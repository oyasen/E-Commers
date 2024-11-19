using E_Commers.Dto.Get_Dto;
using E_Commers.Model;

namespace E_Commers.Dto
{
    public class Product_Dto
    { 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category_Dto_Only Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<User_Dto_Product> Users { get; set; }
    }
}
