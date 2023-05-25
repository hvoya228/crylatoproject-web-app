using Comments.BLL.Repositories.Interfaces;
using Comments.Data.Dtos;
using Comments.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("GetAllComplete")]
        public async Task<ActionResult<IEnumerable<CompleteCommentDto>>> GetAllComplete()
        {
            var result = await _commentService.GetAllComplete();
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetAll()
        {
            var result = await _commentService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] CommentDto commentDto)
        {
            var result = await _commentService.UpdateById(id, commentDto);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] CommentDto commentDto)
        {
            var result = await _commentService.Insert(commentDto);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _commentService.DeleteById(id);
            return Ok(result);
        }
    }
}
