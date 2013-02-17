using System;

namespace KosherWine.DataAccessLayer 
{
	public static class UnitOfWork
	{
		public static IUnitOfWork Current { get; set; }

		public static IUnitOfWork Start ()
		{
			throw new NotImplementedException();
		}
	}
}

