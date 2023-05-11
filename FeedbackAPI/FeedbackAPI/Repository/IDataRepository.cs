using FeedbackAPI.DTOs;
using FeedbackAPI.Models;

namespace FeedbackAPI.Repository
{
	public interface IDataRepository
	{
		IEnumerable<FeedbackDto> GetAll();
		bool Add(FeedbackDto entity);
	}
}
