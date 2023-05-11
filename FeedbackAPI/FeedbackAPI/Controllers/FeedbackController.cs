using FeedbackAPI.DTOs;
using FeedbackAPI.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeedbackAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeedbackController : ControllerBase
	{
		private readonly IFeedbackRepo _feedbackRepo;

		public FeedbackController(IFeedbackRepo repository)
		{
			this._feedbackRepo = repository;
		}

		// GET: api/<FeedbackController>
		[HttpGet]
		public IEnumerable<FeedbackDto> Get()
		{
			return _feedbackRepo.GetAll();
		}

		[HttpPost]
		public bool Post(FeedbackDto feedbackDto)
		{
			return _feedbackRepo.Add(feedbackDto);
		}

	}
}
