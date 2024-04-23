using PromoTest.Server.Contracts.Dtos;

namespace PromoTest.Server.Contracts.Services
{
    public interface IProvinceService
    {
        Task<IEnumerable<ProvinceDto>> GetAsync(int countryId);
    }
}
