using Microsoft.AspNetCore.Mvc;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;

namespace PromoTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvinceController : ControllerBase
    {
        private readonly ILogger<ProvinceController> _logger;
        private readonly IProvinceService _provinceService;

        public ProvinceController(ILogger<ProvinceController> logger,
            IProvinceService provinceService)
        {
            _logger = logger;
            _provinceService = provinceService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProvinceDto>> Get(int countryId)
        {
            return await _provinceService.GetAsync(countryId);
        }
    }
}
