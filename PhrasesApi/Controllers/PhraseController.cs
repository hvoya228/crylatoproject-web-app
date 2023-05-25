using Microsoft.AspNetCore.Mvc;
using Phrases.BLL.Repositories.Interfaces;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Dtos;
using Phrases.Data.Models;

namespace Phrases.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhraseController : ControllerBase
    {
        private readonly IPhraseService _phraseService;

        public PhraseController(IPhraseService phraseService)
        {
            _phraseService = phraseService;
        }

        [HttpGet("GetAllComplete")]
        public async Task<ActionResult<IEnumerable<CompletePhraseDto>>> GetAllComplete()
        {
            var result = await _phraseService.GetAllComplete();
            return Ok(result);
        }

        [HttpGet("GetAllCompleteOrderedByLikes")]
        public async Task<ActionResult<IEnumerable<CompletePhraseDto>>> GetAllCompleteOrderedByLikes()
        {
            var result = await _phraseService.GetAllCompleteOrderedByLikes();
            return Ok(result);
        }

        [HttpGet("GetAllCompleteByTagId/{tagId}")]
        public async Task<ActionResult<IEnumerable<CompletePhraseDto>>> GetAllCompleteByTagId(Guid tagId)
        {
            var result = await _phraseService.GetAllCompleteByTagId(tagId);
            return Ok(result);
        }

        [HttpGet("GetAllCompleteByRegionId/{regionId}")]
        public async Task<ActionResult<IEnumerable<CompletePhraseDto>>> GetAllCompleteByRegionId(Guid regionId)
        {
            var result = await _phraseService.GetAllCompleteByRegionId(regionId);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<PhraseDto>>> GetAll()
        {
            var result = await _phraseService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] Phrase phrase)
        {
            var result = await _phraseService.UpdateById(id, phrase);
            return Ok(result);
        }

        [HttpPut("UpdateLikesById/{id}/{likes}")]
        public async Task<ActionResult<string>> UpdateLikesById(Guid id, int likes)
        {
            var result = await _phraseService.UpdateLikesById(id, likes);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] Phrase phrase)
        {
            var result = await _phraseService.Insert(phrase);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _phraseService.DeleteById(id);
            return Ok(result);
        }
    }
}
