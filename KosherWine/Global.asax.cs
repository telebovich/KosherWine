using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using NHibernate.Context;
using NHibernate.Dialect;
using KosherWine.Logging;
using KosherWine.Models;

namespace KosherWine
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static ISessionFactory SessionFactory { get; private set; }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index_Production", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            // SQLite Configuration

            // NHibernate configuration
            NHibernate.Cfg.Configuration nhConfig = new NHibernate.Cfg.Configuration()
                .DataBaseIntegration(db =>
                    {
                        db.Dialect<SQLiteDialect>();
                        db.ConnectionStringName = "KosherWineSQLite";
                        db.BatchSize = 100;
                    })
                    .CurrentSessionContext<WebSessionContext>()
                    .AddAssembly("KosherWine");
            SessionFactory = nhConfig.BuildSessionFactory();

            // log4net
            log4net.Config.XmlConfigurator.Configure();
        }

        public MvcApplication()
        {
            this.BeginRequest += Application_BeginRequest;
            this.EndRequest += Application_EndRequest;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            CurrentSessionContext.Bind(SessionFactory.OpenSession());
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            CurrentSessionContext.Unbind(SessionFactory);
        }
    }
}