using E_Commers.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commers.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
    }
}
