using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IncirDesignRevize1.DATA
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        // Constructor - Dependency Injection için gerekli
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }

      
        
    }
}
