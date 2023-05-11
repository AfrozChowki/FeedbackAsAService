using FeedbackAPI.DTOs;
namespace FeedbackAPI.Repository
{
	public interface ICategoryRepo
	{
		public IEnumerable<CategoryDto> GetCategories();
	}
}
