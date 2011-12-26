using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

using NHibernate;

namespace KosherWine.Models
{
    public class Email
    {
        private int id;
        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }



        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "*")]
        public virtual string Address { get; set; }
        
        public Email()
        {

        }

        public Email(string email)
        {
            Address = email;
        }

        public static void Add(Email email)
        {
            ISession session = MvcApplication.SessionFactory.OpenSession();
            using (ITransaction tx = session.BeginTransaction())
            {
                session.Save(email);
                tx.Commit();
            }
        }
    }
}