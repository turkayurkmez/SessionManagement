using SessionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManagement.Services
{
    public class FakeProductService : IProductService
    {
        private List<Product> products = new List<Product>();
        public FakeProductService()
        {
            products = new List<Product>
            {
                new Product{ Id=1, Name="Mac Book Pro", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=2, Name="Dell", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=3, Name="Lenovo", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=4, Name="Asus", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=5, Name="X", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=6, Name="Y", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=7, Name="Z", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000}

            };
        }
        public IList<Product> GetProducts()
        {
            return products;
        }
    }
}
