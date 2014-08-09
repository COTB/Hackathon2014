using System.Data.Entity.Infrastructure;
using System.Web.Mvc;
using K9s.WarriorPortal.Models;
using K9s.WarriorPortal.Services;
using K9s.WarriorPortal.Services.Contracts;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace K9s.WarriorPortal.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDbContextFactory<WarriorPortalDbContext>, WarriorPortalDbContextFactory>();

            container.RegisterType<IWarriorApplicationQueryService, WarriorApplicationQueryService>();
            container.RegisterType<IWarriorApplicationCommandService, WarriorApplicationCommandService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}