using E_Commers.Dto;
using E_Commers.Dto.Post_Dto;

namespace E_Commers.Repo
{
    public interface IUserRepo
    {
        IEnumerable<User_Dto> Get();
        User_Dto? Get(int id);
        void Update(User_Dto_Only User_dto, int id);
        void UpdateAll(User_Dto User_dto, int id);
        void Delete(int id);
        void Add(User_Dto_Only User_dto);
        void AddAll(User_Dto User_dto);
    }
}
