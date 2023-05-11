namespace FeedbackAPI.DTOs
{
	public class FeedbackDto
	{
		public string UserId { get; set; } = null!;

		public string PageUrl { get; set; } = null!;

		public string PageName { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public string FeedbackMessage { get; set; } = null!;

		public decimal Rating { get; set; }

		public int CategoryId { get; set; }
		public string ProjectName { get; set; } = null!;

		public string Image { get; set; } = null!;

	}
}
