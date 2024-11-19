namespace E_Commers.Model
{
    public class PaymentCard
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateOnly ExpiryYear { get; set; }
        public User User { get; set; }
    }
}
