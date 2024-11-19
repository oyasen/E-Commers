using E_Commers.Model;

namespace E_Commers.Dto
{
    public class Category_Dto
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
