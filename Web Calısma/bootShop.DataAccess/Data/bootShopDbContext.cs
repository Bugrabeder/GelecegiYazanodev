using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Data
{
    public class bootShopDbContext : DbContext
    {
        public bootShopDbContext( DbContextOptions<bootShopDbContext> options ):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(s => s.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Telefon",
                    

                },
                new Category
                {
                    Id=2,
                    Name="Bilgisayar",
                    
                },
                new Category
                {
                    Id=3,
                    Name="Tablet"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Apple Macbook Air",
                    Price = 20000,
                    Discount = 0.15,
                    CategoryId = 2,
                    Description = "16 gb ram",
                    ImageUrl = "https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"
                },
                          new Product
                          {
                              Id = 2,
                              Name = "Apple Macbook Air",
                              Price = 20000,
                              Discount = 0.15,
                              CategoryId = 2,
                              Description = "16 gb ram",
                              ImageUrl = "https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"
                          },
                        new Product
                        {
                            Id = 3,
                            Name = "Iphone",
                            Price = 15000,
                            Discount = 0.15,
                            CategoryId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg"
                        },
                        new Product
                        {
                            Id = 4,
                            Name = "Iphone",
                            Price = 15000,
                            Discount = 0.15,
                            CategoryId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg"
                        },
                        new Product
                        {
                            Id = 5,
                            Name = "Iphone",
                            Price = 15000,
                            Discount = 0.15,
                            CategoryId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71ZiSXOdnhL._AC_SL1500_.jpg"
                        }

                );
                 
                         
                        
            

            
        }
    }
}
