using System;
using System.Collections.Generic;
using KosherWine.Models;

namespace KosherWine.DataAccessLayer 
{
	public class ProductRepositoryFake: IProductRepository 
	{
		private readonly Dictionary<int, Product> dictionary;

		public Dictionary<int, Product> Dictionary {
			get {
				return dictionary;
			}
		}

		public ProductRepositoryFake ()
		{
			dictionary = new Dictionary<int, Product>();

			dictionary.Add (1, new Product { Id = 1, Name = "Vodka", Description = "Fire" });
			dictionary.Add (2, new Product { Id = 2, Name = "Wine", Description = "Red" });
			dictionary.Add (3, new Product { Id = 3, Name = "Brandy", Description = "Orange" });
			dictionary.Add (4, new Product { Id = 4, Name = "Coca", Description = "Dark"});
			dictionary.Add (5, new Product { Id = 5, Name = "Cola", Description = "Light" });
			dictionary.Add (6, new Product { Id = 6, Name = "Sprite", Description = "White" });
		}

		public Product GetById(int id)
		{
			return dictionary[id];
		}

		public void Add(Product product)
		{
			dictionary.Add (product.Id, product);
		}

		public void Remove(Product product)
		{
			dictionary.Remove (product.Id);
		}
	}
}

