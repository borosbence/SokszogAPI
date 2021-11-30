using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sokszogek.Models;

namespace Sokszogek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegyzetController : ControllerBase
    {
        [HttpGet]
        [Route("Kerulet")]
        public double Kerulet(double oldalA)
        {
            var negyzet = new Negyzet(oldalA);
            return negyzet.Kerulet();
        }

        [HttpGet]
        [Route("Terulet")]
        public double Terulet(double oldalA)
        {
            return 0;
        }
    }
}
