using HotelListing.API.Data;

namespace HotelListing.API.Interfaces
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetDetails(int id);
    }
}
