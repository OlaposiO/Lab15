using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15._2.Services
{
    public class DALSqlServer : IDAL
    {
        private readonly string connectionString;
        public DALSqlServer(IConfiguration config)
        {
            connectionString = config.GetConnectionString("movieAPI");
        }
        public IEnumerable<Movie> GetMovieAll()
        {
            SqlConnection connection = null;
            string queryString = "SELECT * FROM MovieTitle";
            IEnumerable<Movie> Movies = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Movies = connection.Query<Movie>(queryString);
            }
            catch (Exception e)
            {

               
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
            return Movies;

        }

        public IEnumerable<Movie> GetMovieByCategory(string category)
        {
            SqlConnection connection = null;
            string queryString = "SELECT * FROM Products WHERE Category = @category";
            IEnumerable<Movie> Movies = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Movies = connection.Query<Movie>(queryString, new { cat = category });
            }
            catch (Exception e)
            {
                //log the error--get details from e
            }
            finally //cleanup!
            {
                if (connection != null)
                {
                    connection.Close(); //explicitly closing the connection
                }
            }

            return Movies;
        }

        public string[] GetMovieCategories()
        {

            SqlConnection connection = null;
            string queryString = "SELECT DISTINCT Category FROM MovieTitle";
            string[] categories = null;

            try
            {
                connection = new SqlConnection(connectionString);
                categories = connection.Query<string>(queryString).ToArray();
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (connection != null)
                {

                    connection.Close(); //explicitly closing the connection
                }
            }

            return categories;

        }
    }
}
