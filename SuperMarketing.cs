using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using CRUDwithWeb_API;
namespace CRUDwithWeb_API12
{

    public class Marketing
    {

        SqlConnection connection;
        string connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = SuperMarket;user id =sa;password=Anaiyaan@123;";
        public Marketing()
        {
            connection = new SqlConnection(connectionstring);
        }
        public void SignUp(SuperMarketShope obj)
        {

            try
            {
                var insertsql = $" Insert into SuperMarketShope values('{obj.Name}','{obj.OwnerName}','{obj.NumberOfProduct}','{obj.ContactNumber}','{obj.Emailid}','{obj.Location}')";
                // var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                // SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(insertsql);
                connection.Close();



            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void update(string a, string p)
        {

            try
            {





                var insertsql = $"Update SuperMarketShope set Location='{p}' where Name='{a}';";
                //var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                //SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(insertsql);
                connection.Close();




            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }



        public void delete(int ShopId)
        {

            try
            {


                var deletesql = $"delete From SuperMarketShope where ShopId = '{ShopId}'";
               // var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
                //SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute(deletesql);
                connection.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }



        }


        public IEnumerable<SuperMarketShope> Select()
        {
            try
            {
                var SelectsQuery = $"Select * From SuperMarketShope";
                //var connectionstring = "Data source = DESKTOP-BLBGEHJ\\SQLEXPRESS; Initial catalog = Batch-8;user id =sa;password=Anaiyaan@123;";
               // SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                var result = connection.Query<SuperMarketShope>(SelectsQuery);
                connection.Close();
                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }   }
   
