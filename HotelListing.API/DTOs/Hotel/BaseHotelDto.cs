//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Hotel
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;
        public double? Rating { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
