using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Context;
using NHibernate.Engine;

namespace KosherWine.Models
{
    [Serializable]
    public abstract class MyCurrentSessionContext: CurrentSessionContext 
    {
        public MyCurrentSessionContext(ISessionFactoryImplementor implementor)
        {

        }
        public override ISession CurrentSession()
        {
            if (Session == null)
            {
                throw new HibernateException("No session bound to the current context");
            }
            return Session;
        }
    }
}