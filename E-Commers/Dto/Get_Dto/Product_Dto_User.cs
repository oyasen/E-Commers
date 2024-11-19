using E_Commers.Model;

namespace E_Commers.Dto.Get_Dto
{
    public class Product_Dto_User
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
