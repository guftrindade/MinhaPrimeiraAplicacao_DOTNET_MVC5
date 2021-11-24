using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(FNStoreDataContext ctx) : base(ctx)
        {}

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            contains = contains.ToUpper();
            return _ctx.Produtos.Where(p => p.Nome.ToUpper().Contains(contains));
            
            //from p in ctx.Produtos
            //where p.Nome.Contains(contains)
            //select p
        }
    }
}
