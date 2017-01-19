using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using System.Data.SqlClient;

namespace LivePerformance.Data
{
    public class MssqlIngredientContext : MssqlDatabase, IIngredientContext
    {
        public List<Ingredient> GetAllIngredienten()
        {
            string query = "select ID, Naam, Inkoopprijs, Verkoopprijs, Halal, Veganistisch, Glutenvrij, Bodem from INGREDIENT where Bodem = 0";
            List<Ingredient> ingredienten = new List<Ingredient>();

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredienten.Add(new Ingredient(reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetDecimal(3),
                                reader.GetBoolean(4),
                                reader.GetBoolean(5),
                                reader.GetBoolean(6),
                                reader.GetBoolean(7)));
                        }
                        return ingredienten;
                    }
                }
            }
        }
        public List<Ingredient> GetAllBodem()
        {
            string query = "select ID, Naam, Inkoopprijs, Verkoopprijs, Halal, Veganistisch, Glutenvrij, Bodem from INGREDIENT where Bodem = 1";
            List<Ingredient> ingredienten = new List<Ingredient>();

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredienten.Add(new Ingredient(reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetDecimal(3),
                                reader.GetBoolean(4),
                                reader.GetBoolean(5),
                                reader.GetBoolean(6),
                                reader.GetBoolean(7)));
                        }
                        return ingredienten;
                    }
                }
            }
        }

        public void AddIngredient(string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem)
        {
            string query = @"insert into INGREDIENT(Naam, Inkoopprijs, Verkoopprijs, Halal, Veganistisch, Glutenvrij, Bodem)
                             values (@naam, @inkoopprijs, @verkoopprijs, @halal, @veganistisch, @glutenvrij, @bodem)";

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@halal", halal);
                    cmd.Parameters.AddWithValue("@veganistisch", veganistisch);
                    cmd.Parameters.AddWithValue("@glutenvrij", glutenvrij);
                    cmd.Parameters.AddWithValue("@bodem", bodem);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteIngredient(int id)
        {
            string query = "delete INGREDIENT where ID = @ingredientid";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ingredientid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateIngredient(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem)
        {
            string query = @"update Ingredient 
                           set Naam = @naam, Inkoopprijs = @inkoopprijs, Verkoopprijs = @verkoopprijs, Halal = @halal, Veganistisch = @veganistisch, Glutenvrij = @glutenvrij, Bodem = @bodem
                           where ID = @id";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product", id);
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@inkoopprijs", inkoopprijs);
                    cmd.Parameters.AddWithValue("@verkoopprijs", verkoopprijs);
                    cmd.Parameters.AddWithValue("@halal", halal);
                    cmd.Parameters.AddWithValue("@veganistisch", veganistisch);
                    cmd.Parameters.AddWithValue("@glutenvrij", glutenvrij);
                    cmd.Parameters.AddWithValue("@bodem", bodem);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
