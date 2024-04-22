using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;
using PromoTest.Server.Storage;

namespace PromoTest.Server.Services
{
    public class CountryService : ICountryService
    {
        private readonly ApplicationContext _db;
        private readonly IMapper _mapper;

        public CountryService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryDto>> GetAsync()
        {
            var countries = await _db.Countries
                .ToListAsync()
                .ConfigureAwait(false);

            return countries
                    .Select(_mapper.Map<CountryDto>)
                    .ToList();
        }
    }
}
