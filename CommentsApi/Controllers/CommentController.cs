using Comments.DAL.Entities;
using Comments.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Comments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;
        private IUnitOfWork _ADOuow;
        public CommentController(ILogger<CommentController> logger, IUnitOfWork ado_unitofwork)
        {
            _logger = logger;
            _ADOuow = ado_unitofwork;
        }

        //GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAllEventsAsync()
        {
            try
            {
                var results = await _ADOuow.CommentsRepository.GetAsync();
                _logger.LogInformation($"Отримали всі івенти з бази даних!");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Транзакція сфейлилась! Щось пішло не так у методі GetAllEventsAsync() - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "вот так вот!");
            }
        }
    }
}
