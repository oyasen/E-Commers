using E_Commers.Dto.Get_Dto;
using E_Commers.Model;

namespace E_Commers.Dto
{
    public class User_Dto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Product_Dto_User> Products { get; set; }
        public PaymentCard_Dto_Get_Only PaymentCard { get; set; }
    }
}
