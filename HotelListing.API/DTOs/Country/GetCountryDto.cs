using HotelListing.API.DTOs.Hotel;

namespace HotelListing.API.DTOs.Country
{
    public class GetCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
    }

    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;

        public List<HotelDto> Hotels { get; set; }
    }

}
