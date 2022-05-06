using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class FakeCategoryService : ICategoryService
    {
        private List<Category> categories;
        
        public FakeCategoryService()
        {
            categories = new List<Category>()
            {
                new Category{ Id=1,Name="Bilgisayar"},
                new Category{ Id=2,Name="Telefon"},
                new Category{ Id=3,Name="Tablet"}
            };
        }
        public IList<Category> GetCategories()
        {
            return categories;
        }
    }
}
