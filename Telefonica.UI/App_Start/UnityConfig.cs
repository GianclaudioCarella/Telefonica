using Microsoft.Practices.Unity;
using System.Web.Http;
//using Telefonica.Business;
using Unity.WebApi;

namespace Telefonica.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container
            //    //CONTEXTO Y UOW
            //    .RegisterType<IDataContextAsync, TelefonicaEntities>(new PerResolveLifetimeManager())
            //    //.RegisterType<IUnitOfWorkAsync, Repository.Pattern.Ef6.UnitOfWork>(new PerResolveLifetimeManager())
            //    ;


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}