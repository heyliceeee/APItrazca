using api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        #region ConfigurationConnection

        public static IConfiguration _configuration;

        SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DBConnection"));

        #endregion


        #region TABLE RESTAURANT

        #region INSERT

        [HttpPost]
        [Route("insertRestaurant")]

        public string AddRestaurant([FromBody] RestaurantViewModel restaurant)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO restaurant (image, name, nStars, allCategories, cheapPriceProduct, distanceUserAddress, description, address)
                                                        VALUES (@image, @name, @nStars, @allCategories, @cheapPriceProduct, @distanceUserAddress, @description, @address)");

                command.Parameters.AddWithValue("@image", ((object)restaurant.image ?? DBNull.Value));
                command.Parameters.AddWithValue("@name", ((object)restaurant.name ?? DBNull.Value));
                command.Parameters.AddWithValue("@nStars", ((object)restaurant.nStars ?? DBNull.Value));
                command.Parameters.AddWithValue("@allCategories", ((object)restaurant.allCategories ?? DBNull.Value));
                command.Parameters.AddWithValue("@cheapPriceProduct", ((object)restaurant.cheapPriceProduct ?? DBNull.Value));
                command.Parameters.AddWithValue("@distanceUserAddress", ((object)restaurant.distanceUserAddress ?? DBNull.Value));
                command.Parameters.AddWithValue("@description", ((object)restaurant.description ?? DBNull.Value));
                command.Parameters.AddWithValue("@address", ((object)restaurant.address ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert restaurant
                {
                    var testTuple = (StatusCode: 200, Message: "Restaurante inserido com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Restaurante inserido sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Restaurante inserido sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }


        #endregion

        #endregion


        #region TABLE PRODUCT

        #region INSERT

        [HttpPost]
        [Route("insertProduct")]

        public string AddProduct([FromBody] ProductViewModel product)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO product (category, name, description, image, price, nStars, idRestaurant, allergens, mainIngredients, nutritionalValue)
                                                        VALUES (@category, @name, @description, @image, @price, @nStars, @idRestaurant, @allergens, @mainIngredients, @nutritionalValue)");

                command.Parameters.AddWithValue("@category", ((object)product.category ?? DBNull.Value));
                command.Parameters.AddWithValue("@name", ((object)product.name ?? DBNull.Value));
                command.Parameters.AddWithValue("@description", ((object)product.description ?? DBNull.Value));
                command.Parameters.AddWithValue("@image", ((object)product.image ?? DBNull.Value));
                command.Parameters.AddWithValue("@price", ((object)product.price ?? DBNull.Value));
                command.Parameters.AddWithValue("@nStars", ((object)product.nStars ?? DBNull.Value));
                command.Parameters.AddWithValue("@idRestaurant", ((object)product.idRestaurant ?? DBNull.Value));
                command.Parameters.AddWithValue("@allergens", ((object)product.allergens ?? DBNull.Value));
                command.Parameters.AddWithValue("@mainIngredients", ((object)product.mainIngredients ?? DBNull.Value));
                command.Parameters.AddWithValue("@nutritionalValue", ((object)product.nutritionalValue ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert product
                {
                    var testTuple = (StatusCode: 200, Message: "Produto inserido com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Restaurante inserido sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }


            var testTuple4 = (StatusCode: 404, Message: "Produto inserido sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE USER

        #region INSERT

        [HttpPost]
        [Route("insertUser")]

        public string AddUser([FromBody] UserViewModel user)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO [user] (role, name, address, email, password, phoneNumber, paypal)
                                                        VALUES (@role, @name, @address, @email, @password, @phoneNumber, @paypal)");

                command.Parameters.AddWithValue("@role", ((object)user.role ?? DBNull.Value));
                command.Parameters.AddWithValue("@name", ((object)user.name ?? DBNull.Value));
                command.Parameters.AddWithValue("@address", ((object)user.address ?? DBNull.Value));
                command.Parameters.AddWithValue("@email", ((object)user.email ?? DBNull.Value));
                command.Parameters.AddWithValue("@password", ((object)user.password ?? DBNull.Value));
                command.Parameters.AddWithValue("@phoneNumber", ((object)user.phoneNumber ?? DBNull.Value));
                command.Parameters.AddWithValue("@paypal", ((object)user.paypal ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert user
                {
                    var testTuple = (StatusCode: 200, Message: "Utilizador inserido com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Utilizador inserido sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Utilizador inserido sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion
    }
}
