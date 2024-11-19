using E_Commers.Dto.Get_Dto;

namespace E_Commers.Dto.Post_Dto
{
    public class User_Dto_Only
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<int> Products { get; set; }
        public int PaymentCard { get; set; }
    }
}
