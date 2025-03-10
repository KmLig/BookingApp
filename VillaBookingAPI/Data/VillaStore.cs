using VillaBookingAPI.Models.Dto;

namespace VillaBookingAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Pool view", Sqrt = 100, Occupancy = 4 },
            new VillaDTO { Id = 2, Name = "River view", Sqrt = 300, Occupancy = 3 }
        };
    }
}
