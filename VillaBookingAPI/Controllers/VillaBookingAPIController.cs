using Microsoft.AspNetCore.Mvc;
using VillaBookingAPI.Models;

namespace VillaBookingAPI.Controllers
{
    [Route("api/VillaBookingAPI")]
    [ApiController]
    public class VillaBookingAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id = 1, Name="Pool view"},
                new Villa{Id = 2, Name = "River view"}
            };
        }
    }
}
