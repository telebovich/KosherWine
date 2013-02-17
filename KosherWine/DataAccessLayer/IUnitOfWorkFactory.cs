using System;

namespace KosherWine.DataAccessLayer
{
	public interface IUnitOfWorkFactory
	{
		IUnitOfWork Create();
	}
}

