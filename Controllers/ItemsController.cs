using Catalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controller
{
	// GET / items
	
	[ApiController]
	[Route("items")]
	public class ItemsController : ControllerBase
	{
		private readonly InMemItemsRepository repository;
		
		public ItemsController()
		{
			repository = new InMemItemsRepository();
		}
		
		
	}
}