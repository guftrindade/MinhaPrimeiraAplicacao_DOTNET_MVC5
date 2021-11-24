using FN.Store.Data.ADO.Repositories;
using FN.Store.Data.EF;
using FN.Store.Data.EF.Repositories;
using FN.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace FN.Store.UI2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<FNStoreDataContext>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryADO>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}