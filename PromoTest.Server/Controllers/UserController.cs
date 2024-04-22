using Microsoft.AspNetCore.Mvc;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;

namespace PromoTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger,
            IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        public async Task Add(UserDto user)
            => await _userService.AddAsync(user);
    }
}
