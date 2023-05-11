using FeedbackAPI.Models;
using FeedbackAPI.DTOs;

namespace FeedbackAPI.Repository
{
	public class CategoryRepo : ICategoryRepo
	{
		TestContext _context;

		public CategoryRepo()
		{
			_context = new TestContext();
		}
		public IEnumerable<CategoryDto> GetCategories()
		{
			var categories = _context.Categories.ToList();

			return categories.Select(category => new CategoryDto()
			{
				CategoryId = category.CategoryId,
				CategoryName = category.CategoryName
			}).ToList();
		}
	}
}
