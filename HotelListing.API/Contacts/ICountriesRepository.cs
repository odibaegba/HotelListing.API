﻿using HotelListing.API.Models;

namespace HotelListing.API.Contacts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
