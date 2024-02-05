using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Context
{
    public class _Context: DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TECHNOSHOPE;Integrated Security=True;Encrypt=False");
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TECHNOSHOPE;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }
       
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCartItem> ProductCartItems { get; set; }
        public virtual DbSet<ProductInOrder> ProductInOrders { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
     
    }
}
