namespace E_Commers.Dto.Get_Dto
{
    public class PaymentCard_Dto_Only
    {
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateOnly ExpiryYear { get; set; }
    }
}
