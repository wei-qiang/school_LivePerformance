using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public interface IProductContext
    {
        List<Product> GetAllProducts();
        void AddProduct(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage);
        void DeleteProduct(int id);
        void UpdateProduct(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage);
    }
}
