using E_Commers.Dto.Get_Dto;

namespace E_Commers.Dto.Post_Dto
{
    public class Payment_Dto_Only
    {
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateOnly ExpiryYear { get; set; }
        public int UserId { get; set; }
    }
}
