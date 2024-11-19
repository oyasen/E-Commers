using E_Commers.Dto.Get_Dto;

namespace E_Commers.Dto.Get_Dto
{
    public class User_Dto_Payment
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Product_Dto_User> Products { get; set; }
    }
}
