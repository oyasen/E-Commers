namespace E_Commers.Dto.Get_Dto
{
    public class Product_Dto_Category
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ICollection<User_Dto_Product> Users { get; set; }
    }
}
