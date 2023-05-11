using FeedbackAPI.DTOs;

namespace FeedbackAPI.Repository
{
	public interface IFeedbackRepo
	{
		IEnumerable<FeedbackDto> GetAll();
		bool Add(FeedbackDto entity);
	}
}
