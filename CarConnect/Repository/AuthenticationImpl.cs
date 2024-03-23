    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarConnect.Exceptions;
using CarConnect.Utils;
using Microsoft.Data.SqlClient;

namespace CarConnect.Repository
{
    public class AuthenticationImpl
    {

        SqlConnection _connection;
        SqlCommand _command;
         public AuthenticationImpl() { 
               _command = new SqlCommand();
            _connection = new SqlConnection(DbUtils.GetConnection());
        }


        public bool Login(string username, string password)
        {
            try
            {
                _command.Connection = _connection;
                _command.CommandText = "select * from Customer where Username = @username and Password = @password";
                _connection.Open();

                _command.Parameters.AddWithValue("@username", username);
                _command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    AuthenticationException.CheckIfAuthenticated();
                }


            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connection.Close();
                _command.Parameters.Clear();

            }

            return false;

        }

        public bool MyAdminLogin(string username, string password)
        {
            try
            {
                _command.Connection = _connection;
                _command.CommandText = "select * from AdminTable where Username = @username and Password = @password";
                _connection.Open();
                _command.Parameters.AddWithValue("@username", username);
                _command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = _command.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                _connection.Close();
                _command.Parameters.Clear();

            }

            return false;

        }

    }
}
