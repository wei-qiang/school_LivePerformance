using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public class MssqlPizzaContext : MssqlDatabase, IPizzaContext
    {
        /// <summary>
        /// dit haalt alle standaard pizzas op
        /// </summary>
        /// <returns></returns>
        public List<Pizza> GetAllPizzas()
        {
            string query = @"select p.ID, p.Naam, Oppervlakte, Standaardpizza, Korting, v.Naam 
                             from PIZZA p, VORM v 
                             where p.Standaardpizza = 1 and v.ID = p.Vorm_ID";
            List<Pizza> pizzas = new List<Pizza>();

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pizzas.Add(new Pizza(reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt32(2),
                                reader.GetBoolean(3),
                                reader.GetInt16(4),
                                (Vorm)Enum.Parse(typeof(Vorm), reader.GetString(5))));
                        }
                        return pizzas;
                    }
                }
            }
        }

        public void AddPizza(int vormid, string naam, int oppervlakte, bool standaardpizza, int korting, int formaat1, int formaat2 = 0, int formaat3 = 0)
        {
            string query = @"insert into PIZZA(Vorm_ID, Naam, Oppervlakte, Standaardpizza, Korting, Formaat1)
                             values (@vormid, @naam, @oppervlakte, @standaardpizza, @korting, @formaat1)";
            if (formaat3 > 0)
            {
                query = @"insert into PIZZA(Vorm_ID, Naam, Oppervlakte, Standaardpizza, Korting, Formaat1, Formaat2, Formaat3)
                             values (@vormid, @naam, @oppervlakte, @standaardpizza, @korting, @formaat1, @formaat2, @formaat3)";
            }
            else if (formaat2 > 0)
            {
                query = @"insert into PIZZA(Vorm_ID, Naam, Oppervlakte, Standaardpizza, Korting, Formaat1, Formaat2)
                             values (@vormid, @naam, @oppervlakte, @standaardpizza, @korting, @formaat1, @formaat2)";
            }

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vormid", vormid);
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@oppervlakte", oppervlakte);
                    cmd.Parameters.AddWithValue("@standaardpizza", standaardpizza);
                    cmd.Parameters.AddWithValue("@korting", korting);
                    cmd.Parameters.AddWithValue("@formaat1", formaat1);
                    cmd.Parameters.AddWithValue("@formaat2", formaat2);
                    cmd.Parameters.AddWithValue("@formaat3", formaat3);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InactivateStandaardPizza(int id)
        {
            string query = @"update Pizza 
                           set Standaardpizza = 0
                           where ID = @pizzaid";
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pizzaid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddIngredientPizza(int pizzaid, int ingredientid)
        {
            string query = @"insert into PIZZA_INGREDIENT(Pizza_ID, Ingredient_ID)
                             values (@pizzaid, @ingredientid);";

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pizzaid", pizzaid);
                    cmd.Parameters.AddWithValue("@ingredientid", ingredientid);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int GetPizzaId(int vormid, string naam, int oppervlakte, bool standaardpizza)
        {
            string query = @"select p.ID
                             from PIZZA p
                             where p.Standaardpizza = @standaardpizza and p.Vorm_ID = @vormid and p.Naam = @naam and p.Oppervlakte = @oppervlakte";

            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vormid", vormid);
                    cmd.Parameters.AddWithValue("@naam", naam);
                    cmd.Parameters.AddWithValue("@oppervlakte", oppervlakte);
                    cmd.Parameters.AddWithValue("@standaardpizza", standaardpizza);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        throw new Exception("Pizza is niet gevonden");
                    }
                }
            }
        }
    }
}
