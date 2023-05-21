﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ShortName { get; set; } = string.Empty;
    }
}
