using System;
using NHibernate;
using NHibernate.Cfg;
using KosherWine.Models;

namespace KosherWine
{
	public class SessionProvider
	{
		private static NHibernate.Cfg.Configuration configuration;

		private static ISessionFactory sessionFactory;

		public static NHibernate.Cfg.Configuration Configuration {
			get {
				if (configuration == null)
				{
					configuration = new NHibernate.Cfg.Configuration();
					configuration.Configure ();
					configuration.AddAssembly (typeof(Product).Assembly);
				}
				return configuration;
			} 
		}

		public static ISessionFactory SessionFactory {
			get {
				if (sessionFactory == null)
				{
					sessionFactory = configuration.BuildSessionFactory ();
				}
				return sessionFactory;
			}
		}

		private SessionProvider ()
		{
		}

		public static ISession GetSession ()
		{
			return SessionFactory.OpenSession ();
		}
	}
}

