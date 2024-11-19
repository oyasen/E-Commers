using E_Commers.Dto;
using E_Commers.Dto.Post_Dto;
namespace E_Commers.Repo
{
    public interface IPaymentCardRepo
    {
        IEnumerable<Payment_Dto> Get();
        Payment_Dto? Get(int id);
        void Update(Payment_Dto_Only Payment_dto, int id);
        void UpdateAll(Payment_Dto Payment_dto, int id);
        void Delete(int id);
        void Add(Payment_Dto_Only Payment_dto);
        void AddAll(Payment_Dto Payment_dto);
    }
}
