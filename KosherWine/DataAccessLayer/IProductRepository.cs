using System;
using System.Collections.Generic;
using KosherWine.Models;

namespace KosherWine.DataAccessLayer 
{
	public interface IProductRepository: IRepository<Product>
	{
		IEnumerable<Product> GetAllProducts();
		Product GetProductById(int id);
		void InsertProduct(Product product);
	}
}

