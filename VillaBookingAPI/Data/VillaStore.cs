using VillaBookingAPI.Models.Dto;

namespace VillaBookingAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Pool view" },
                new VillaDTO { Id = 2, Name = "River view" }
            };
    }
}
