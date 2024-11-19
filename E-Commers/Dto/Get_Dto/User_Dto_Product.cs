using E_Commers.Dto.Get_Dto;

namespace E_Commers.Dto.Get_Dto
{
    public class User_Dto_Product
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public PaymentCard_Dto_Only PaymentCard { get; set; }
    }
}
