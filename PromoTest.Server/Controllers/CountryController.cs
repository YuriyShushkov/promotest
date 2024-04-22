using Microsoft.AspNetCore.Mvc;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;

namespace PromoTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService _countryService;

        public CountryController(ILogger<CountryController> logger,
            ICountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CountryDto>> Get()
        {
            return await _countryService.GetAsync();
        }
    }
}
