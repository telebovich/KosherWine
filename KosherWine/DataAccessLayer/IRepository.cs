using System;

namespace KosherWine.DataAccessLayer 
{
	public interface IRepository<T>
	{
		T Get(int id);
		void Add(T entity);
		void Delete(T entity);
		void Save();
	}
}

