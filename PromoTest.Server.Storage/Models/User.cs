
namespace PromoTest.Server.Storage.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool AgreeWorkForFood { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public Country Country { get; set; }
        public Province Province { get; set; }
    }
}
