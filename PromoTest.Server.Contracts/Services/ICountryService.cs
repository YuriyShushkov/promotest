using PromoTest.Server.Contracts.Dtos;

namespace PromoTest.Server.Contracts.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAsync();
    }
}
