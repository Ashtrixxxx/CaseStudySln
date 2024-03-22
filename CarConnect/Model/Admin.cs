using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Model
{
    internal class Admin
    {

        public Admin() { }

        //        AdminID(Primary Key) : Unique identifier for each admin.
        //• FirstName: First name of the admin.
        //• LastName: Last name of the admin.
        //• Email: Email address of the admin for communication.
        //• PhoneNumber: Contact number of the admin.
        //• Username: Unique username for admin login.
        //• Password: Securely hashed password for admin authentication.
        //• Role: Role of the admin within the system (e.g., super admin, fleet manager).
        //• JoinDate: Date when the admin joined the system.


        public int AdminId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public string PhoneNumber { get; set; }
        public string Role { get;set; }

        public DateTime JoinDate { get; set; }

        public override string ToString()
        {
            return $"Admin Id is {AdminId} \t Name : {FirstName} \t Email : {Email} \t UserName : {Username} \t Phone Number : {PhoneNumber} \t Role {Role}";
        }

    }
}
