using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dolgozat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpPost]
        [Authorize]

        [HttpGet]
        [Authorize]

        [HttpGet("{id}")]
        [Authorize]

        [HttpPut("{id}")]
        [Authorize]

        [HttpDelete("{id}")]
        [Authorize]
    }
}
