using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using KosherWine.DataAccessLayer;

namespace KosherStore.Linux.Tests
{
	[TestFixture()]
	public class ProductRepositoryTestFake
	{
		private IProductRepository repository;

		[SetUp]
		public void SetupContext ()
		{
			repository = new ProductRepositoryFake();
		}

		[Test]
		public void TestCase ()
		{
		}

		[Test]
		public void CanLoadAProductByItsIdFromTheRepository ()
		{
			var product = repository.GetById (2);

			product.ShouldNotBeNull();
			product.Id.ShouldEqual(2);
		}

		[Test]
		public void CanRemoveAnExistingProductFromRepository ()
		{
			var product = repository.GetById (1);

			repository.Remove (product);

			// This has ambiguous meaning. I would do it another way
			typeof(KeyNotFoundException).ShouldBeThrownBy (() => repository.GetById (1));
		}
	}
}

