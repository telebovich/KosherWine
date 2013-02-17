using System;
using NHibernate;
using KosherWine.Models;
namespace KosherWine
{
	public class ProductRepositoryNH
	{
		private static ISession GetSession ()
		{
			return SessionProvider.GetSession ();
		}

		public Product GetById (int id)
		{
			using (var session = GetSession ()) {
				return session.Get<Product>(id);
			}
		}

		public void Add (Product product)
		{
			using (var session = GetSession ()) {
				session.Save (product);
			}
		}

		public void Remove (Product product)
		{
			using (var session = GetSession ()) {
				session.Delete (product);
			}
		}

		public ProductRepositoryNH ()
		{
		}
	}
}

