using Microsoft.AspNetCore.Mvc;
using Phrases.BLL.Repositories;
using Phrases.BLL.Repositories.Interfaces;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Dtos;
using Phrases.Data.Models;

namespace Phrases.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<TagDto>>> GetAll()
        {
            var result = await _tagService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] Tag tag)
        {
            var result = await _tagService.UpdateById(id, tag);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] Tag tag)
        {
            var result = await _tagService.Insert(tag);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _tagService.DeleteById(id);
            return Ok(result);
        }
    }
}
