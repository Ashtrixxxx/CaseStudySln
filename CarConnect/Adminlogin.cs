using CarConnect.Model;
using CarConnect.Repository;
using CarConnect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class Adminlogin
    {

        AuthenticationServices auth = new AuthenticationServices();
        CustomerImp customerImp = new CustomerImp();
        AdminImpl adminImpl = new AdminImpl();
        AdminOverallMenu adminOverallMenu = new AdminOverallMenu();
        public void Admin()
        {
            while (true)
            {
                Console.WriteLine("Welcome to CarConnect ");
                Console.WriteLine("1. Login To the application:");
                Console.WriteLine("2. SignUp for the Application");

                Console.WriteLine("Enter your Choice");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Your Username");
                        string user = Console.ReadLine();
                        Console.WriteLine("Enter Your password");
                        string password = Console.ReadLine();

                        bool isAuthenticated = auth.AdminLogin(user, password);
                        if (isAuthenticated)
                        {
                            adminOverallMenu.AdminMenu();
                        }
                        else
                        {
                            Console.WriteLine("The username or password You entered is incorrect");
                            break;
                        }

                        break;

                    case 2:
                        Admin adminClass = new Admin();
                        Console.WriteLine("Create Your New account ");

                        Console.WriteLine("Enter your details:");


                        Console.WriteLine("Enter your first Name:");
                        string frst = Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        string last = Console.ReadLine();
                        Console.WriteLine("Enter your email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter your Phone Number");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Enter your username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string newPassword = Console.ReadLine();
                        Console.WriteLine("Enter Your Role");
                        string role = Console.ReadLine();

                        DateTime date = DateTime.Now;
                        adminClass = new Admin() { FirstName = frst, LastName = last, Email = email, PhoneNumber = phone, Username = username, Password = newPassword,Role= role ,JoinDate = date };
                        adminImpl.CreateAdmin(adminClass);
                        break;



                }

            }
        }
    }
}
