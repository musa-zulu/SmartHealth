﻿using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using SmartHealth.DB.Migrations;
using SmartHealth.Web.App_Start;

namespace SmartHealth.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var connectionStringSettings = ConfigurationManager.ConnectionStrings["SmarthHealthWebContext"];
            DBMigrationsRunner runner = new DBMigrationsRunner(connectionStringSettings.ConnectionString);
            runner.MigrateToLatest();
            Bootstrap();
        }

        private IWindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            container.Register(Component.For<IWindsorContainer>()
                .Instance(container));

            container.Register(
               Component
                   .For<IControllerFactory>()
                   .ImplementedBy<WindsorControllerFactory>()
                   .LifeStyle.Singleton
               );

            container.Register(Classes.FromThisAssembly()
              .BasedOn<IController>()
              .LifestyleTransient());

            SetControllerFactory(container);

            return container;
        }

        private static void SetControllerFactory(WindsorContainer container)
        {
            var windsorControllerFactory = container.Resolve<IControllerFactory>();
            ControllerBuilder.Current.SetControllerFactory(windsorControllerFactory);
        }
    }
}
