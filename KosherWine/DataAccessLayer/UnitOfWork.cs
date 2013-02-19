using System;

namespace KosherWine.DataAccessLayer 
{
	public static class UnitOfWork
	{
		private static IUnitOfWorkFactory _unitOfWorkFactory;
		private static IUnitOfWork _innerUnitOfWork;

		public static IUnitOfWork Current { get; private set; }

		public static IUnitOfWork Start ()
		{
			_innerUnitOfWork = _unitOfWorkFactory.Create ();
			return _innerUnitOfWork;
		}
	}
}

