using Microsoft.AspNetCore.Mvc;
using Phrases.BLL.Repositories.Interfaces;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Dtos;
using Phrases.Data.Models;

namespace Phrases.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<RegionDto>>> GetAll()
        {
            var result = await _regionService.GetAll();
            return Ok(result);
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult<string>> UpdateById(Guid id, [FromBody] Region region)
        {
            var result = await _regionService.UpdateById(id, region);
            return Ok(result);
        }

        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] Region region)
        {
            var result = await _regionService.Insert(region);
            return Ok(result);
        }

        [HttpDelete("DelereById")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var result = await _regionService.DeleteById(id);
            return Ok(result);
        }
    }
}
