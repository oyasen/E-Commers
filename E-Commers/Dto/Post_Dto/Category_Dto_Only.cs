using E_Commers.Model;

namespace E_Commers.Dto.Post_Dto
{
    public class Category_Dto_Only
    {
        public string Name { get; set; }
        public ICollection<int> ProductsId { get; set; }
    }
}
