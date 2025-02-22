using Microsoft.AspNetCore.Mvc;
using VillaBookingAPI.Data;
using VillaBookingAPI.Models;
using VillaBookingAPI.Models.Dto;

namespace VillaBookingAPI.Controllers
{
    //[Route("api/VillaBookingAPI")]
    [Route("api/[controller]")]
    [ApiController]
    public class VillaBookingAPIController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(v => v.Id == id);
        }
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
    }
}
