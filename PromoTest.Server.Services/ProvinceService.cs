using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;
using PromoTest.Server.Storage;

namespace PromoTest.Server.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly ApplicationContext _db;
        private readonly IMapper _mapper;

        public ProvinceService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProvinceDto>> GetAsync(int countryId)
        {
            var countries = await _db.Provinces
                .Where(x => x.CountryId == countryId)
                .ToListAsync()
                .ConfigureAwait(false);

            return countries
                    .Select(_mapper.Map<ProvinceDto>)
                    .ToList();
        }
    }
}
