using System.Collections.Generic;
using Catalog.Models;
using Catalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controller
{
	// GET / items
	
	[ApiController]
	[Route("items")]
	public class ItemsController : ControllerBase
	{
		private readonly IItemsRepository repository;
		
		public ItemsController(IItemsRepository repository)
		{
			this.repository = repository;
		}
		
		[HttpGet]
		public IEnumerable<Item> GetItems()
		{
			var items = repository.GetItems();
			return items;
		}
		
		// GET /item/id
		[HttpGet("{id}")]
		public ActionResult<Item> GetItem(Guid id)
		{
			var item = repository.GetItem(id);
			if(item is null)
			  return NotFound();
			return item;
			// OR return Ok(item); Is still the same.
		}
	}
}