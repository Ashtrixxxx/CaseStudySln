using CarConnect.Model;
using CarConnect.Repository;
using CarConnect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class CustomerLogin
    {


        AuthenticationServices auth = new AuthenticationServices();
        CustomerImp customerImp = new CustomerImp();
        CustomerServices customerServices = new CustomerServices();
        CustomerOverallMenu customerMenu   = new CustomerOverallMenu();

        public bool IsPhoneNumberValid(string phoneNumber)
        {
            if(phoneNumber.Length == 10) {
                return true;
            }

            return false;
        }

        public bool IsEmailValid(string email)
        {

            if(!email.Contains("@"))
            {
                return true;
            }

            return false;
        }

        public void Customer()
        {
            while(true)
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

                        bool isAuthenticated = auth.Login(user, password);
                        if(isAuthenticated)
                        {
                            customerMenu.OverallMenu(user);
                        }
                        else
                        {
                            //Console.WriteLine("The username or password You entered is incorrect");
                            break;
                        }

                        break;

                    case 2:
                        Customer customer = new Customer();
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
                        Console.WriteLine("Enter your address");
                        string address = Console.ReadLine();

                        Console.WriteLine("Enter your username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        string newPassword = Console.ReadLine();
                        Console.WriteLine("Confirm Your Password");
                        string cnfmPassword = Console.ReadLine();

                        

                        DateTime date = DateTime.Now;

                        if (!IsPhoneNumberValid(phone))
                        {
                            break;
                        }

                        if(!IsEmailValid(email))
                        {
                            break;
                        }

                        if (newPassword.Equals(cnfmPassword) )
                        {
                            customer = new Customer() { FirstName = frst, LastName = last, Email = email, Phone = phone, UserName = username, Password = newPassword, RegistrationDate = date, Address = address };
                            int rows = customerServices.CreateCustomerService(customer);
                            if(rows == 1) {
                                customerMenu.OverallMenu(username);

                            }
                            break;
                        }

                        Console.WriteLine("Password doesn't match");
                        break;



                }

            }
        }

    }
}
