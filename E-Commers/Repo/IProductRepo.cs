using E_Commers.Dto;
using E_Commers.Dto.Post_Dto;
namespace E_Commers.Repo
{
    public interface IProductRepo
    {
        IEnumerable<Product_Dto> Get();
        Product_Dto? Get(int id);
        void Update(Product_Dto_Only Product_dto, int id);
        void UpdateAll(Product_Dto Product_dto, int id);
        void Delete(int id);
        void Add(Product_Dto_Only Product_dto);
        void AddAll(Product_Dto Product_dto);
    }
}
