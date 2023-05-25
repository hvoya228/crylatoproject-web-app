using Comments.BLL.Repositories.Interfaces;
using Comments.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Comments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetAll()
        {
            var result = await _feedbackService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] FeedbackDto feedbackDto)
        {
            var result = await _feedbackService.UpdateById(id, feedbackDto);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] FeedbackDto feedbackDto)
        {
            var result = await _feedbackService.Insert(feedbackDto);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _feedbackService.DeleteById(id);
            return Ok(result);
        }
    }
}
