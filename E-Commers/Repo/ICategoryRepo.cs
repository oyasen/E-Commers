using E_Commers.Dto;
using E_Commers.Dto.Post_Dto;
namespace E_Commers.Repo
{
    public interface ICategoryRepo
    {
        IEnumerable<Category_Dto> Get();
        Category_Dto? Get(int id);
        void Update(Category_Dto_Only Category_dto, int id);
        void UpdateAll(Category_Dto Category_dto, int id);
        void Delete(int id);
        void Add(Category_Dto_Only Category_dto);
        void AddAll(Category_Dto Category_dto);
    }
}
