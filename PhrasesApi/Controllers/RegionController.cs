using Microsoft.AspNetCore.Mvc;
using Phrases.DAL.Repositories.Intefaces;
using Phrases.Data.Models;

namespace Phrases.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly ILogger<RegionController> _logger;
        private IUnitOfWork _ADOuow;
        public RegionController(ILogger<RegionController> logger,
            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;
            _ADOuow = ado_unitofwork;
        }

        //Get all
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Region>>> GetAll()
        {
            try
            {
                var results = await _ADOuow._regionRepository.GetAllAsync();
                _ADOuow.Commit();
                _logger.LogInformation($"Success (GetAll)");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetAll) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Get by id
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Region>> GetById(Guid id)
        {
            try
            {
                var result = await _ADOuow._regionRepository.GetAsync(id);
                _ADOuow.Commit();
                if (result == null)
                {
                    _logger.LogInformation($"Error (GetById): id {id} not found");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Success (GetById)");
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetById) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Post
        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] Region evnt)
        {
            try
            {
                if (evnt == null)
                {
                    _logger.LogInformation($"Empty json from client (Post)");
                    return BadRequest("Object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"Incorrect json from client (Post)");
                    return BadRequest("Object is incorrect");
                }
                var created_id = await _ADOuow._regionRepository.AddAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (Post) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Update by id
        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult> UpdateById(Guid id, [FromBody] Region evnt)
        {
            try
            {
                if (evnt == null)
                {
                    _logger.LogInformation($"Empty json from client (UpdateById)");
                    return BadRequest("Object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"Incorrect json from client (UpdateById)");
                    return BadRequest("Object is incorrect");
                }

                var event_entity = await _ADOuow._regionRepository.GetAsync(id);

                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (UpdateById)");
                    return NotFound();
                }

                await _ADOuow._regionRepository.ReplaceAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (UpdateById) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Delete by id
        [HttpDelete("DeleteById/{id}")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            try
            {
                var event_entity = await _ADOuow._regionRepository.GetAsync(id);
                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (DeleteById)");
                    return NotFound();
                }

                await _ADOuow._regionRepository.DeleteAsync(id);
                _ADOuow.Commit();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (DeleteById) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }
    }
}
