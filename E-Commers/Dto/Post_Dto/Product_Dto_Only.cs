using E_Commers.Dto.Get_Dto;

namespace E_Commers.Dto.Post_Dto
{
    public class Product_Dto_Only
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public ICollection<int> UsersId { get; set; }
    }
}
