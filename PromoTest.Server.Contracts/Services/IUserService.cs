using PromoTest.Server.Contracts.Dtos;

namespace PromoTest.Server.Contracts.Services
{
    public interface IUserService
    {
        Task AddAsync(UserDto user);
    }
}
