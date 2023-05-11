using FeedbackAPI.DTOs;
using FeedbackAPI.Models;

namespace FeedbackAPI.Repository
{
	public class DataRepository : IDataRepository
	{
		private readonly TestContext _context = new();
		public IEnumerable<FeedbackDto> GetAll()
		{

			var feedbacks = _context.Feedbacks.ToList();

			List<FeedbackDto> feedbacksDto = new List<FeedbackDto>();

			foreach (var feedback in feedbacks)
			{
				feedbacksDto.Add(new FeedbackDto()
				{
					UserId = feedback.UserId, 
					PageUrl = feedback.PageUrl, 
					PageName = feedback.PageName, 
					FeedbackMessage = feedback.FeedbackMessage, 
					Rating = feedback.Rating, 
					CreatedOn = feedback.CreatedOn,
					CategoryId = feedback.CategoryId
				});
			}

			return feedbacksDto;
		}
		public bool Add(FeedbackDto entity)
		{
			try
			{
				var feedback = new Feedback()
				{
					UserId = entity.UserId,
					PageUrl = entity.PageUrl,
					PageName = entity.PageName,
					CreatedOn = DateTime.Today,
					FeedbackMessage = entity.FeedbackMessage,
					Rating = entity.Rating,
					CategoryId = entity.CategoryId
				};
				_context.Add(feedback);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		
		}

	}
}
