using System;

namespace KosherWine.DataAccessLayer 
{
	public interface IRepository<T>
	{
		T GetById(int id);
		void Add(T entity);
		void Remove(T entity);
		// void Save();
	}
}

