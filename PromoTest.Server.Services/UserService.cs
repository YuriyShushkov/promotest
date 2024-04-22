using AutoMapper;
using PromoTest.Server.Contracts.Dtos;
using PromoTest.Server.Contracts.Services;
using PromoTest.Server.Storage;
using PromoTest.Server.Storage.Models;

namespace PromoTest.Server.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _db;
        private readonly IMapper _mapper;

        public UserService(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task AddAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
        }
    }
}
