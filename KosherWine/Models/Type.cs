using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KosherWine.Models
{
    public class Type: Repository
    {
        private int _id;
        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name;
        public virtual string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _description;
        public virtual string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public virtual IList<Product> Products { get; set; }
    }
}