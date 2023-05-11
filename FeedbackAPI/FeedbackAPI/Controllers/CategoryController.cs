using FeedbackAPI.DTOs;
using FeedbackAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : Controller
	{

		private readonly ICategoryRepo _categoryRepo;

		public CategoryController(ICategoryRepo categoryRepo)
		{
			this._categoryRepo = categoryRepo;
		}

		// GET: CategoryController
		[HttpGet]
		public IEnumerable<CategoryDto> Get()
		{
			return _categoryRepo.GetCategories();
		}

	}
}
