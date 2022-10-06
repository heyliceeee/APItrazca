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



        #region TABLE CART

        #region INSERT

        [HttpPost]
        [Route("insertCart")]

        public string AddCart([FromBody] CartViewModel cart)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO cart (idUser, subtotal, deliveryFee, discount, total, status)
                                                        VALUES (@idUser, @subtotal, @deliveryFee, @discount, @total, 'inserted')");

                command.Parameters.AddWithValue("@idUser", ((object)cart.idUser ?? DBNull.Value));
                command.Parameters.AddWithValue("@subtotal", ((object)cart.subtotal ?? DBNull.Value));
                command.Parameters.AddWithValue("@deliveryFee", ((object)cart.deliveryFee ?? DBNull.Value));
                command.Parameters.AddWithValue("@discount", ((object)cart.discount ?? DBNull.Value));
                command.Parameters.AddWithValue("@total", ((object)cart.total ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Carrinho criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Carrinho criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Carrinho criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #region EDIT

        [HttpPut]
        [Route("editCart/{id}")]

        public string EditCart(int id, [FromBody] CartViewModel cart)
        {
            try
            {
                var query = @"  UPDATE cart SET idUser = @idUser, subtotal = @subtotal, deliveryFee = @deliveryFee, discount = @discount, total = @total, status = 'edited'
                                WHERE idCart = " + id + "";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@idUser", ((object)cart.idUser ?? DBNull.Value));
                command.Parameters.AddWithValue("@subtotal", ((object)cart.subtotal ?? DBNull.Value));
                command.Parameters.AddWithValue("@deliveryFee", ((object)cart.deliveryFee ?? DBNull.Value));
                command.Parameters.AddWithValue("@discount", ((object)cart.discount ?? DBNull.Value));
                command.Parameters.AddWithValue("@total", ((object)cart.total ?? DBNull.Value));

                conn.Open();

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Dados do carrinho atualizados com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Dados do carrinho não atualizados. Tente novamente.");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Dados do carrinho não atualizados. Tente novamente.");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE CART ITEM

        #region INSERT

        [HttpPost]
        [Route("insertCartItem")]

        public string AddCartItem([FromBody] CartItemViewModel cartItem)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO cartItem (idCart, idProduct, quantity, noteProduct, status)
                                                        VALUES (@idCart, @idProduct, @quantity, @noteProduct, 'inserted')");

                command.Parameters.AddWithValue("@idCart", ((object)cartItem.idCart ?? DBNull.Value));
                command.Parameters.AddWithValue("@idProduct", ((object)cartItem.idProduct ?? DBNull.Value));
                command.Parameters.AddWithValue("@quantity", ((object)cartItem.quantity ?? DBNull.Value));
                command.Parameters.AddWithValue("@noteProduct", ((object)cartItem.noteProduct ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Item do carrinho criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Item do carrinho criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Item do carrinho criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #region EDIT

        [HttpPut]
        [Route("editCart/{id}")]

        public string EditCart(int id, [FromBody] CartViewModel cart)
        {
            try
            {
                var query = @"  UPDATE cart SET idUser = @idUser, subtotal = @subtotal, deliveryFee = @deliveryFee, discount = @discount, total = @total, status = 'edited'
                                WHERE idCart = " + id + "";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@idUser", ((object)cart.idUser ?? DBNull.Value));
                command.Parameters.AddWithValue("@subtotal", ((object)cart.subtotal ?? DBNull.Value));
                command.Parameters.AddWithValue("@deliveryFee", ((object)cart.deliveryFee ?? DBNull.Value));
                command.Parameters.AddWithValue("@discount", ((object)cart.discount ?? DBNull.Value));
                command.Parameters.AddWithValue("@total", ((object)cart.total ?? DBNull.Value));

                conn.Open();

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Dados do carrinho atualizados com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Dados do carrinho não atualizados. Tente novamente.");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Dados do carrinho não atualizados. Tente novamente.");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE COMMENT PRODUCT

        #region INSERT

        [HttpPost]
        [Route("insertCommentProduct")]

        public string AddCommentProduct([FromBody] CommentProductViewModel comment)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO commentProduct (image, nameClient, nStars, idProduct, text, status)
                                                        VALUES (@image, @nameClient, @nStars, @idProduct, @text, 'inserted')");

                command.Parameters.AddWithValue("@image", ((object)comment.image ?? DBNull.Value));
                command.Parameters.AddWithValue("@nameClient", ((object)comment.nameClient ?? DBNull.Value));
                command.Parameters.AddWithValue("@nStars", ((object)comment.nStars ?? DBNull.Value));
                command.Parameters.AddWithValue("@idProduct", ((object)comment.idProduct ?? DBNull.Value));
                command.Parameters.AddWithValue("@text", ((object)comment.text ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Comentário criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Comentário criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Comentário criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE COMMENT WORKER

        #region INSERT

        [HttpPost]
        [Route("insertCommentWorker")]

        public string AddCommentWorker([FromBody] CommentWorkerViewModel comment)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO commentWorker (image, nameClient, nStars, idWorker, text, status)
                                                        VALUES (@image, @nameClient, @nStars, @idWorker, @text, 'inserted')");

                command.Parameters.AddWithValue("@image", ((object)comment.image ?? DBNull.Value));
                command.Parameters.AddWithValue("@nameClient", ((object)comment.nameClient ?? DBNull.Value));
                command.Parameters.AddWithValue("@nStars", ((object)comment.nStars ?? DBNull.Value));
                command.Parameters.AddWithValue("@idWorker", ((object)comment.idWorker ?? DBNull.Value));
                command.Parameters.AddWithValue("@text", ((object)comment.text ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Comentário criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Comentário criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Comentário criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE LOG

        #region INSERT

        [HttpPost]
        [Route("insertLog")]

        public string AddLog([FromBody] LogViewModel log)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO log (dateTime, idUser, type, titleLog, resume, status)
                                                        VALUES (@dateTime, @idUser, @type, @titleLog, @resume, 'inserted')");

                command.Parameters.AddWithValue("@dateTime", ((object)log.dateTime ?? DBNull.Value));
                command.Parameters.AddWithValue("@idUser", ((object)log.idUser ?? DBNull.Value));
                command.Parameters.AddWithValue("@type", ((object)log.type ?? DBNull.Value));
                command.Parameters.AddWithValue("@titleLog", ((object)log.titleLog ?? DBNull.Value));
                command.Parameters.AddWithValue("@resume", ((object)log.resume ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Log criada com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Log criada sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Log criada sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion


        #region TABLE ORDER

        #region INSERT

        [HttpPost]
        [Route("insertOrder")]

        public string AddOrder([FromBody] OrderViewModel order)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = string.Format(@"  INSERT INTO [order] (idCart, status, timeUserAddress)
                                                        VALUES (@idCart, 'inserted', @timeUserAddress)");

                command.Parameters.AddWithValue("@idCart", ((object)order.idCart ?? DBNull.Value));
                command.Parameters.AddWithValue("@timeUserAddress", ((object)order.timeUserAddress ?? DBNull.Value));

                int i = command.ExecuteNonQuery();

                conn.Close();

                if (i == 1) //if insert log
                {
                    var testTuple = (StatusCode: 200, Message: "Pedido criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Pedido criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Pedido criado sem sucesso");

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
                command.CommandText = string.Format(@"  INSERT INTO product (category, name, description, image, price, nStars, idRestaurant, allergens, mainIngredients, nutritionalValue, status)
                                                        VALUES (@category, @name, @description, @image, @price, @nStars, @idRestaurant, @allergens, @mainIngredients, @nutritionalValue, 'inserted')");

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
                    var testTuple = (StatusCode: 200, Message: "Produto criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Restaurante criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }


            var testTuple4 = (StatusCode: 404, Message: "Produto criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

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
                command.CommandText = string.Format(@"  INSERT INTO restaurant (image, name, nStars, allCategories, cheapPriceProduct, distanceUserAddress, description, address, status)
                                                        VALUES (@image, @name, @nStars, @allCategories, @cheapPriceProduct, @distanceUserAddress, @description, @address, 'inserted')");

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
                    var testTuple = (StatusCode: 200, Message: "Restaurante criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Restaurante criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Restaurante criado sem sucesso");

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
                command.CommandText = string.Format(@"  INSERT INTO [user] (role, name, address, email, password, phoneNumber, paypal, status)
                                                        VALUES (@role, @name, @address, @email, @password, @phoneNumber, @paypal, 'inserted')");

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
                    var testTuple = (StatusCode: 200, Message: "Utilizador criado com sucesso");

                    return JsonConvert.SerializeObject(new { testTuple.StatusCode, testTuple.Message });
                }
                else
                {
                    var testTuple2 = (StatusCode: 404, Message: "Utilizador criado sem sucesso");

                    return JsonConvert.SerializeObject(new { testTuple2.StatusCode, testTuple2.Message });
                }
            }
            catch (Exception ex)
            {
                var testTuple3 = (StatusCode: 404, Message: ex.Message);

                return JsonConvert.SerializeObject(new { testTuple3.StatusCode, testTuple3.Message });
            }

            var testTuple4 = (StatusCode: 404, Message: "Utilizador criado sem sucesso");

            return JsonConvert.SerializeObject(new { testTuple4.StatusCode, testTuple4.Message });
        }

        #endregion

        #endregion
    }
}
