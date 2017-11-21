using Microsoft.Practices.Unity;
using System.Web.Http;
using Telefonica.Business;
using Telefonica.Business.Repositories;
using Telefonica.Business.Services;
using Telefonica.Data;

namespace Telefonica.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            // DI
            var container = new UnityContainer();
                container
                .RegisterType(typeof(IRepository<TelefonicaEntities>), typeof(TelefonicaEntities))
                .RegisterType(typeof(IRepository<Llamada>), typeof(LlamadaRepository))
                .RegisterType(typeof(IRepository<Telefono>), typeof(TelefonoRepository))
                .RegisterType(typeof(IRepository<Usuario>), typeof(UsuarioRepository))
                .RegisterType(typeof(ILlamadaService), typeof(LlamadaService))
                ;

            config.DependencyResolver = new UnityResolver(container);

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
