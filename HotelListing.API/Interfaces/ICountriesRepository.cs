using HotelListing.API.Data;

namespace HotelListing.API.Interfaces
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
