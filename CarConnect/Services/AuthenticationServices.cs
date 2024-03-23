using CarConnect.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    public class AuthenticationServices
    {
        AuthenticationImpl authenticationImpl = new AuthenticationImpl();
        public bool Login(string username, string password)
        {
            try
            {
                bool IsAuthenticated = authenticationImpl.Login(username, password);
                return IsAuthenticated;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool AdminLogin(string username, string password)
        {
            Console.WriteLine("hello");
            try
            {
                bool IsAuthenticated = authenticationImpl.MyAdminLogin(username, password);
                return IsAuthenticated;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return false;
        }

    }
}
