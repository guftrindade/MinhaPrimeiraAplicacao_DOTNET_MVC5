using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.ADO.Repositories
{
    public class UsuarioRepositoryADO : IUsuarioRepository
    {
        private readonly FNStoreDataContextADO _ctx;
        public UsuarioRepositoryADO(FNStoreDataContextADO ctx)
        {
            _ctx = ctx;
        }


        public Usuario Get(string email)
        {
            var query = $@"SELECT Usuario.id, Usuario.Nome, Usuario.Email, Usuario.Senha, Usuario.DataCadastro
                           FROM Usuario
                           WHERE Email = '{email}'";
            var dR = _ctx.ExecuteCommandWithData(query);

            //Verifica se existe o usuário
            if (dR.HasRows)
            {
                var usuarios = new List<Usuario>();
                while (dR.Read())
                {
                    usuarios.Add(new Usuario()
                    {
                        id = (int)dR["id"],
                        Nome = dR["Nome"].ToString(),
                        Email = dR["Email"].ToString(),
                        Senha = dR["Senha"].ToString(),
                        DataCadastro = (DateTime)dR["DataCadastro"]
                    });
                }
                dR.Close();
                return usuarios.First();
            }
            return null;
        }


        public void Dispose()
        { }


        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }


        public void Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Usuario> Get()
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
