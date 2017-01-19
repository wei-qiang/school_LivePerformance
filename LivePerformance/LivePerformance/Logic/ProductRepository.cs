using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using LivePerformance.Data;

namespace LivePerformance.Logic
{
    public class ProductRepository
    {
        private readonly IProductContext productcontext;

        public ProductRepository(IProductContext productcontext)
        {
            this.productcontext = productcontext;
        }

        public List<Product> GetAllPizza()
        {
            return productcontext.GetAllProducts();
        }
    }
}
