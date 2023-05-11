using FeedbackAPI.Models;
using FeedbackAPI.DTOs;

namespace FeedbackAPI.Repository
{
	public class FeedbackRepo : IFeedbackRepo
	{
		private readonly TestContext _context = new();
		public IEnumerable<FeedbackDto> GetAll()
		{
			try
			{
				var feedbacks = _context.Feedbacks.ToList();

				return feedbacks.Select(feedback => new FeedbackDto()
				{
					UserId = feedback.UserId,
					PageUrl = feedback.PageUrl,
					PageName = feedback.PageName,
					FeedbackMessage = feedback.FeedbackMessage,
					Rating = feedback.Rating,
					CreatedOn = feedback.CreatedOn,
					CategoryId = feedback.CategoryId,
					ProjectName = feedback.ProjectName,
					Image = feedback.Image
				})
					.ToList();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
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
					CategoryId = entity.CategoryId,
					ProjectName = entity.ProjectName,
					Image = entity.Image

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
