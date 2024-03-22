using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }

        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Customer()
        {

        }

   

        public override string ToString()
        {
            return $"Customer Id is {CustomerId} \t Customer Name = {FirstName + LastName}\t Email: {Email}\t  Phone :{Phone} \t RegisteredDate: {RegistrationDate}";
        }

    }
}
