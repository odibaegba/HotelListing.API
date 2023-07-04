namespace HotelListing.API.Exceptions
{
    //custom exception handling
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} ({key}) was not found")
        {

        }
    }
}
