/// <summary>
/// Unity Configurtion For Dependency Injection
/// </summary>

namespace WebApp.Host
{
    #region

    using System.Web.Mvc;
    using Unity;
    using Unity.Mvc5;
    using WebApp.DataAccess.Repositories;
    using WebApp.DataAccess.Repositories.Interfaces;

    #endregion

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all dependencies
            container.RegisterType<IContactUsRepository, ContactUsRepository>();
            container.RegisterType<IMessageTypeRepository, MessageTypeRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}