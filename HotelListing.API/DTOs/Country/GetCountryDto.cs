using HotelListing.API.DTOs.Hotel;

namespace HotelListing.API.DTOs.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }

    }

    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }

}
