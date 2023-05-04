using Microsoft.Build.Framework;

namespace HotelListing.API.DTOs.Country
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ShortName { get; set; } = string.Empty;
    }
}
