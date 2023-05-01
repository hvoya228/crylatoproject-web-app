using Microsoft.AspNetCore.Mvc;
using PhrasesDAL.Entities;
using PhrasesDAL.Repositories.Contracts;

namespace PhrasesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhraseController : ControllerBase
    {
        private readonly ILogger<PhraseController> _logger;
        private IUnitOfWork _ADOuow;
        public PhraseController(ILogger<PhraseController> logger,
            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;
            _ADOuow = ado_unitofwork;
        }

        //Get all
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Phrase>>> GetAll()
        {
            try
            {
                var results = await _ADOuow._phraseRepository.GetAllAsync();
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

        //Get all by tagId ordered by newest
        [HttpGet("GetAllByTagIdOrderById/{tagId}")]
        public async Task<ActionResult<Phrase>> GetAllByTagIdOrderById(int tagId)
        {
            try
            {
                var result = await _ADOuow._phraseRepository.GetAllByTagIdOrderByIdAsync(tagId);
                _ADOuow.Commit();
                if (result == null)
                {
                    _logger.LogInformation($"Error (GetAllByTagIdOrderById): tagId {tagId} not found");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Success (GetAllByTagIdOrderById)");
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetAllByTagIdOrderById) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Get all by tagId ordered by newest
        [HttpGet("GetAllByTagIdOrderByLikes/{tagId}")]
        public async Task<ActionResult<Phrase>> GetAllByTagIdOrderByLikes(int tagId)
        {
            try
            {
                var result = await _ADOuow._phraseRepository.GetAllByTagIdOrderByLikesAsync(tagId);
                _ADOuow.Commit();
                if (result == null)
                {
                    _logger.LogInformation($"Error (GetAllByTagIdOrderByLikes): tagId {tagId} not found");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Success (GetAllByTagIdOrderByLikes)");
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (GetAllByTagIdOrderByLikes) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Get by id
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Phrase>> GetById(int id)
        {
            try
            {
                var result = await _ADOuow._phraseRepository.GetAsync(id);
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
                _logger.LogError($"Error (GetByIdAsync) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Post
        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] Phrase evnt)
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
                var created_id = await _ADOuow._phraseRepository.AddAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (Post) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Update likes by id
        [HttpPut("UpdateLikesById/{id}/{likes}")]
        public async Task<IActionResult> UpdateLikes(int id, int likes)
        {
            try
            {
                await _ADOuow._phraseRepository.UpdateLikesAsync(id, likes);
                _ADOuow.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (UpdateLikes) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Update by id
        [HttpPut("UpdateById/{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Phrase evnt)
        {
            try
            {
                if (evnt == null)
                {
                    _logger.LogInformation($"Empty json from client (Update)");
                    return BadRequest("Object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"Incorrect json from client (Update)");
                    return BadRequest("Object is incorrect");
                }

                var event_entity = await _ADOuow._phraseRepository.GetAsync(id);
                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (Update)");
                    return NotFound();
                }

                await _ADOuow._phraseRepository.ReplaceAsync(evnt);
                _ADOuow.Commit();
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error (Update) - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "error");
            }
        }

        //Delete by id
        [HttpDelete("DeleteById/{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            try
            {
                var event_entity = await _ADOuow._phraseRepository.GetAsync(id);
                if (event_entity == null)
                {
                    _logger.LogInformation($"There is no object with id {id} in database (DeleteById)");
                    return NotFound();
                }

                await _ADOuow._phraseRepository.DeleteAsync(id);
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
