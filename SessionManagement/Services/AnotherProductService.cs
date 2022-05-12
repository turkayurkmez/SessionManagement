using SessionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManagement.Services
{
    public class AnotherProductService : IProductService
    {
        private List<Product> products;
        public AnotherProductService()
        {
            products = new List<Product>
            {
                new Product{ Id=1, Name="X", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=2, Name="A", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=3, Name="B", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=4, Name="C", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=5, Name="D", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=6, Name="E", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000},

                new Product{ Id=7, Name="F", Description="Güzel bir makine", Discount=0.15, ImageUrl="https://cdn.dsmcdn.com//ty292/product/media/images/20220111/14/24965825/356386402/1/1_org.jpg", Price=35000}

            };
        }
        public IList<Product> GetProducts()
        {
            return products;
        }
    }
}
