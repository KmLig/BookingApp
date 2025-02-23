using System.ComponentModel.DataAnnotations;

namespace VillaBookingAPI.Models.Dto
{
    public class VillaDTO : IVillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
