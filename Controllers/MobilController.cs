using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using netcore_id_jwt.Model;

namespace netcore_id_jwt.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Roles = "Administrator,Regular")]
    public class MobilController : ControllerBase
    {
        public IActionResult List()
        {
            // ini adalah ilustrasi method Read operation, semua user yang terautentikasi bisa mengaksesnya.
            return Ok("ini mobil");
        }

        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public IActionResult Add(Mobil mobil)
        {
            // Sebagai ilustrasi method ini adalah Create operation, hanya user dengan role administrator yang mempunyai akses.
            return Ok(mobil);
        }
    }
}