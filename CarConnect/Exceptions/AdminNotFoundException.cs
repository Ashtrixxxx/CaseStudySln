using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Exceptions
{
    internal class AdminNotFoundException : Exception
    {

        public AdminNotFoundException(string message):base(message) { }


        public static void AdminNotFound()
        {
            throw new AdminNotFoundException("The Admin credentials you've entered not found");
        }

    }
}
