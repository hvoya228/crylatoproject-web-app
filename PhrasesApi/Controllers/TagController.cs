using Microsoft.AspNetCore.Mvc;
using PhrasesDAL.Entities;
using PhrasesDAL.Repositories.Contracts;

namespace PhrasesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ILogger<TagController> _logger;
        private IUnitOfWork _ADOuow;
        public TagController(ILogger<TagController> logger,
            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;
            _ADOuow = ado_unitofwork;
        }

        //Get all
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Tag>>> GetAll()
        {
            try
            {
                var results = await _ADOuow._tagRepository.GetAllAsync();
                _ADOuow.Commit();
                _logger.LogInformation($"Success (GetAllEventsAsync)");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetAllEventsAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Get by id
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Tag>> GetById(int id)
        {
            try
            {
                var result = await _ADOuow._tagRepository.GetAsync(id);
                _ADOuow.Commit();
                if (result == null)
                {
                    _logger.LogInformation($"Error (GetByIdAsync): id {id} not found");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Success (GetByIdAsync)");
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetByIdAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Post
        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] Tag evnt)
        {
            try
            {
                if (evnt == null)
                {
                    _logger.LogInformation($"Empty json from client (PostEventAsync)");
                    return BadRequest("Object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"Incorrect json from client (PostEventAsync)");
                    return BadRequest("Object is incorrect");
                }
                var created_id = await _ADOuow._tagRepository.AddAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (PostEventAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Update by id
        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult> UpdateById(int id, [FromBody] Tag evnt)
        {
            try
            {
                if (evnt == null)
                {
                    _logger.LogInformation($"Empty json from client (UpdateEventAsync)");
                    return BadRequest("Object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"Incorrect json from client (UpdateEventAsync)");
                    return BadRequest("Object is incorrect");
                }

                var event_entity = await _ADOuow._tagRepository.GetAsync(id);
                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (UpdateEventAsync)");
                    return NotFound();
                }

                await _ADOuow._tagRepository.ReplaceAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (PostEventAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Delete by id
        [HttpDelete("DeleteById/{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            try
            {
                var event_entity = await _ADOuow._tagRepository.GetAsync(id);
                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (DeleteByIdAsync)");
                    return NotFound();
                }

                await _ADOuow._tagRepository.DeleteAsync(id);
                _ADOuow.Commit();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (DeleteByIdAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }
    }
}
