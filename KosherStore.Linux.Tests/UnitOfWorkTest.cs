using System;
using System.Reflection;
using NUnit.Framework;
using Rhino.Mocks;
using KosherWine.DataAccessLayer;

namespace KosherStore.Linux.Tests
{
	[TestFixture]
	public class UnitOfWorkTest
	{
		private readonly MockRepository _mocks = new MockRepository();

		[Test]
		public void CanStartUnitOfWork ()
		{
			var factory = _mocks.DynamicMock<IUnitOfWorkFactory>();
			var unitOfWork = _mocks.DynamicMock<IUnitOfWork>();

			var fieldInfo = typeof(UnitOfWork).GetField ("_unitOfWorkFactory", 
			                                             BindingFlags.Static | 
			                                             BindingFlags.SetField | 
			                                             BindingFlags.NonPublic);
			fieldInfo.SetValue (null, factory);

			IUnitOfWork uow = UnitOfWork.Start();
		}

		public UnitOfWorkTest ()
		{
		}
	}
}

