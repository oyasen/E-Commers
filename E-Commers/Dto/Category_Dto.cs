using E_Commers.Dto.Get_Dto;
using E_Commers.Model;

namespace E_Commers.Dto
{
    public class Category_Dto
    {
        public string Name { get; set; }
        public ICollection<Product_Dto_Category> Products { get; set; }
    }
}
