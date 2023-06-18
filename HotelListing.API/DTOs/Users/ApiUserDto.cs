using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;


    }
}
