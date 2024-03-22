using CarConnect.Services;
using System;

namespace CarConnect
{
    internal class UpdateAdmin
    {
        public void AdminUpdate()
        {
            AdminServices adminServices = new AdminServices();

            while (true)
            {
                Console.WriteLine("Enter the Admin ID you want to update:");
                int adminId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. Update First Name");
                Console.WriteLine("2. Update Last Name");
                Console.WriteLine("3. Update Email");
                Console.WriteLine("4. Update Password");
                Console.WriteLine("5. Update Username");
                Console.WriteLine("6. Update Phone Number");
                Console.WriteLine("7. Update Role");
                Console.WriteLine("Enter your Option:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the new First Name:");
                        string firstName = Console.ReadLine();
                        int firstNameRows = adminServices.UpdateAdminFirstName(firstName, adminId);
                        break;

                    case 2:
                        Console.WriteLine("Enter the new Last Name:");
                        string lastName = Console.ReadLine();
                        int lastNameRows = adminServices.UpdateAdminLastName(lastName, adminId);
                        break;

                    case 3:
                        Console.WriteLine("Enter the new Email:");
                        string email = Console.ReadLine();
                        int emailRows = adminServices.UpdateAdminEmail(email, adminId);
                        break;

                    case 4:
                        Console.WriteLine("Enter the new Password:");
                        string password = Console.ReadLine();
                        int passwordRows = adminServices.UpdateAdminPassword(password, adminId);
                        break;

                    case 5:
                        Console.WriteLine("Enter the new Username:");
                        string username = Console.ReadLine();
                        int usernameRows = adminServices.UpdateAdminUsername(username, adminId);
                        break;

                    case 6:
                        Console.WriteLine("Enter the new Phone Number:");
                        string phoneNumber = Console.ReadLine();
                        int phoneNumberRows = adminServices.UpdateAdminPhoneNumber(phoneNumber, adminId);
                        break;

                    case 7:
                        Console.WriteLine("Enter the new Role:");
                        string role = Console.ReadLine();
                        int roleRows = adminServices.UpdateAdminRole(role, adminId);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 7.");
                        break;
                }
            }
        }
    }
}
