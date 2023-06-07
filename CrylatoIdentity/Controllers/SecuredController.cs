using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CrylatoIdentity.Constants.Authorization;
using System.Threading.Tasks;

namespace CrylatoIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecuredController : ControllerBase
    {
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PostSecuredData()
        {
            return Ok("This Secured Data is available only for Authenticated Users.");
        }
    }
}
