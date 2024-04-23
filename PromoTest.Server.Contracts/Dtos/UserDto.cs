using System;
namespace PromoTest.Server.Contracts.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool AgreeWorkForFood { get; set; }
    }
}
