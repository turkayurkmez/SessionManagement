using SessionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManagement.Services
{
   public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
