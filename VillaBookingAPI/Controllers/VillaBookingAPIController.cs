using Microsoft.AspNetCore.Mvc;
using VillaBookingAPI.Models;
using VillaBookingAPI.Models.Dto;

namespace VillaBookingAPI.Controllers
{
    //[Route("api/VillaBookingAPI")]
    [Route("api/[controller]")]
    [ApiController]
    public class VillaBookingAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Pool view" },
                new VillaDTO { Id = 2, Name = "River view" }
            };
        }
    }
}
