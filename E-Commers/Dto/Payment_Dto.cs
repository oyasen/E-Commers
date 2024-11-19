using E_Commers.Dto.Get_Dto;
using E_Commers.Model;

namespace E_Commers.Dto
{
    public class Payment_Dto
    {
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateOnly ExpiryYear { get; set; }
        public User_Dto_Payment User { get; set; }
    }
}
