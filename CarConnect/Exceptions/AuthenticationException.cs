using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Exceptions
{
    internal class AuthenticationException : Exception
    {

        public AuthenticationException(string message):base(message) { }


        public static void CheckIfAuthenticated()
        {


            throw new AuthenticationException("The username or password is incorrect");
        }

    }
}
