using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class FakeProductService : IProductService
    {
        private List<Product> products;
        public FakeProductService()
        {
            products = new List<Product>
            {
                new Product{Id=1,Name="Apple Macbook Air",Price=20000,Discount=0.15,CategoryId=1,Description="16 gb ram",
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=2,Name="Apple Macbook Air",Price=20000,Discount=0.15,CategoryId=1,Description="16 gb ram",
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=3,Name="Apple Macbook Air",Price=20000,Discount=0.15,CategoryId=1,Description="16 gb ram",
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=4,Name="A",Price=20000,Discount=0.15,Description="16 gb ram",CategoryId=2,
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=5,Name="B",Price=20000,Discount=0.15,Description="16 gb ram",CategoryId=2,
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=6,Name="C",Price=20000,Discount=0.15,Description="16 gb ram",CategoryId=1,
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"},
                new Product{Id=7,Name="D",Price=20000,Discount=0.15,Description="16 gb ram",CategoryId=3,
                    ImageUrl="https://cdn.dsmcdn.com//ty209/product/media/images/20211025/14/155912969/117794442/1/1_org.jpg"}
            };
        }
        public ICollection<Product> GetProducts()
        {
            return products;
        }
    }
}
