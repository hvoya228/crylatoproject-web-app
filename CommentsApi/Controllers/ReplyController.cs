using Comments.BLL.Repositories.Interfaces;
using Comments.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Comments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService _replyService;

        public ReplyController(IReplyService replyService)
        {
            _replyService = replyService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<ReplyDto>>> GetAll()
        {
            var result = await _replyService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] ReplyDto replyDto)
        {
            var result = await _replyService.UpdateById(id, replyDto);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] ReplyDto replyDto)
        {
            var result = await _replyService.Insert(replyDto);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _replyService.DeleteById(id);
            return Ok(result);
        }
    }
}
