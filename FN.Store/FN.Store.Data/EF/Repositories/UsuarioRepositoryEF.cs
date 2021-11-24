using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(FNStoreDataContext ctx) : base(ctx)
        {}

        public Usuario Get(string email)
        {
            email = email.ToLower();

            //var tt = _ctx.Usuarios.FirstOrDefault(u => EF.Functions.Collate(u.Email, "SQL_Latin1_General_CP1_CS_AS") == email);
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email);
        }
    }
}
