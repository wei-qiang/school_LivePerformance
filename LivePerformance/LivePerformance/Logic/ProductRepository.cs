using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Models;
using LivePerformance.Data;
using LivePerformance.Exceptions;

namespace LivePerformance.Logic
{
    public class ProductRepository
    {
        private readonly IProductContext _productcontext;

        public ProductRepository(IProductContext productcontext)
        {
            this._productcontext = productcontext;
        }

        public List<Product> GetAllProduct()
        {
            return _productcontext.GetAllProducts();
        }

        public void AddProduct(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            try
            {
                _productcontext.CheckProduct(naam, inkoopprijs, verkoopprijs, alcoholpercentage);
            }
            catch (ProductBestaatAlException e)
            {
                MessageBox.Show(e.Message);
            }
            _productcontext.AddProduct(naam, inkoopprijs, verkoopprijs, alcoholpercentage);
        }

        public void DeleteProduct(int id)
        {
            _productcontext.DeleteProduct(id);
        }

        public void UpdateProduct(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
                _productcontext.UpdateProduct(id, naam, inkoopprijs, verkoopprijs, alcoholpercentage);
        }

        /// <summary>
        /// checkt of het product al bestaat
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="inkoopprijs"></param>
        /// <param name="verkoopprijs"></param>
        /// <param name="alcoholpercentage"></param>
        /// <returns></returns>
        public bool CheckProduct(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            try
            {
                _productcontext.CheckProduct(naam, inkoopprijs, verkoopprijs, alcoholpercentage);
                return false;
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// Dit is een methode die gebruikt wordt voor de unit test
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="inkoopprijs"></param>
        /// <param name="verkoopprijs"></param>
        /// <param name="alcoholpercentage"></param>
        /// <returns></returns>
        public int GetProductId(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            try
            {
                return _productcontext.GetProductId(naam, inkoopprijs, verkoopprijs, alcoholpercentage);
            }
            catch(ProductBestaatAlException e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
    }
}
