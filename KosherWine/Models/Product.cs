﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NHibernate;

namespace KosherWine.Models
{
	public enum Color { black, white }

    public class Product: Repository
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

		public virtual string Description { get; set; }

        public virtual Producer Producer { get; set; }

        public virtual Type Type { get; set; }

        public virtual Sort Sort { get; set; }

        private decimal _unitPrice;
        public virtual decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }

		public virtual int Alcohol { get; set; }

		public virtual int Volume { get; set; }

		public virtual Color Color { get; set; }

        private string _urlsOfPhotoesRaw;
        public virtual string UrlsToPhotoesRaw
        {
            get
            {	
                return _urlsOfPhotoesRaw;
            }
            set
            {
                _urlsOfPhotoesRaw = value;
            }
        }

        private Uri[] _urlsOfPhotoes;
        public virtual Uri[] UrlsOfPhotoes
        {
            get
            {
                return _urlsOfPhotoes;
            }
            set
            {
                string[] urls = _urlsOfPhotoesRaw.Split(';');
                for (int i = 0; i < urls.Length; i++)
                {
                    _urlsOfPhotoes[i] = new Uri(urls[i]);
                }
            }
        }

        public virtual Category Category { get; set; }

        private DateTime _saleStartDate;
        public virtual DateTime SaleStartDate
        {
            get
            {
                return _saleStartDate;
            }
            set
            {
                _saleStartDate = value;
            }
        }

        private DateTime _saleEndDate;
        public virtual DateTime SaleEndDate
        {
            get
            {
                return _saleEndDate;
            }
            set
            {
                _saleEndDate = value;
            }
        }

        private decimal _discount;
        public virtual decimal Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }

        private int _stockQuantity;
        public virtual int StockQuantity
        {
            get
            {
                return _stockQuantity;
            }
            set
            {
                _stockQuantity = value;
            }
        }
    }
}