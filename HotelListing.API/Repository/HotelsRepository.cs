using HotelListing.API.Contacts;
using HotelListing.API.Data;
using HotelListing.API.Models;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
