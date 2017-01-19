using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using LivePerformance.Exceptions;

namespace LivePerformance.Data
{
    public class MssqlProductContext: MssqlDatabase, IProductContext
    {
        public List<Product> GetAllProducts()
        {
            string query = "select p.ID, p.Naam, p.Inkoopprijs, p.Verkoopprijs, p.Alcoholpercentage from PRODUCT p";
            List<Product> producten = new List<Product>();

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            producten.Add(new Product(reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetDecimal(3),
                                reader.GetInt16(4)));
                        }
                        return producten;
                    }
                }
            }
        }

        public void AddProduct(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            string query = @"insert into PRODUCT(Naam, Inkoopprijs, Verkoopprijs, Alcoholpercentage)
                             values(@naam, @inkoopprijs, @verkoopprijs, @alcoholpercentage); ";

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@alcoholpercentage", alcoholpercentage);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int id)
        {
            string query = "delete PRODUCT where ID = @productid";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            string query = @"update PRODUCT 
                           set Naam = @naam, Inkoopprijs = @inkoopprijs, Verkoopprijs = @verkoopprijs, Alcoholpercentage = @alcoholpercentage
                           where ID = @id";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@alcoholpercentage", alcoholpercentage);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CheckProduct(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            string query = @"select * 
                             from PRODUCT 
                             where Naam = @naam and Inkoopprijs = @inkoopprijs and Verkoopprijs = verkoopprijs and Alcoholpercentage = @alcoholpercentage";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@alcoholpercentage", alcoholpercentage);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Product product = null;
                        while (reader.Read())
                        {
                            try
                            {
                                product = new Product(reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetDecimal(2),
                                    reader.GetDecimal(3),
                                    reader.GetInt16(4));
                            }
                            catch
                            {
                            }
                        }
                        if (product != null)
                        {
                            throw new ProductBestaatAlException("Het product bestaat al");
                        }
                    }
                }
            }
        }

        public int GetProductId(string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
        {
            string query = @"select ID
                             from PRODUCT 
                             where Naam = @naam and Inkoopprijs = @inkoopprijs and Verkoopprijs = verkoopprijs and Alcoholpercentage = @alcoholpercentage";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@alcoholpercentage", alcoholpercentage);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        throw new ProductBestaatNietException("Dit product bestaat niet");
                    }
                }
            }
        }
    }
}
