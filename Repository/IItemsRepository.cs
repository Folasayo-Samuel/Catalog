using System;
using Catalog.Models;
using System.Collections.Generic;


namespace Catalog.Repository;

public interface IItemsRepository
{
	Item GetItem(Guid id);

		IEnumerable<Item> GetItems();
}