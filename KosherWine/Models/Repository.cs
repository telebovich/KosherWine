using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NHibernate;
using NHibernate.Context;

// В следующей версии надо изменить код, чтобы сессия создавалась раз в запрос или раз в приложение
namespace KosherWine.Models
{
    public class Repository
    {
        public static void Add<T>(T entity)
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Save(entity);
                tx.Commit();                
            }
            session.Close();
        }

        public virtual void Update<T>(T entity)
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Update(entity);
                tx.Commit();
            }
            session.Close();
        }

        public static void Delete<T>(T entity)
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Delete(entity);
                tx.Commit();
            }
            session.Close();
        }

        public static IEnumerable<T> GetAllItems<T>() where T : class
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                IList<T> items = session.QueryOver<T>()
                    .List<T>();
                return items;
            }
        }

        public static T GetItemById<T>(int id) where T : class
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                var query = from c in session.QueryOver<Category>()
                            where c.Id == id
                            select c;
                return query.SingleOrDefault<T>();
            }
        }
    }
}