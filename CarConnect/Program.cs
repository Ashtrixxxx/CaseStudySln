﻿namespace CarConnect
{
    internal class Program
    {

        static void Main(string[] args)
        {

            CustomerOverallMenu customerOverallMenu = new CustomerOverallMenu();
            MailService mailService = new MailService();
            customerOverallMenu.ReservationCreated += mailService.OnReservationCreated;

            CustomerLogin customer = new CustomerLogin();
            Adminlogin adminlogin = new Adminlogin();
            while (true)
            {
                Console.WriteLine("Welcome to CarConnect");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Admin");
                Console.WriteLine("Enter Your Option");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        //call Customer Class
                        customer.Customer();
                        break;
                    case 2:
                        //Call admin Loginclass
                        adminlogin.Admin();
                        break;
                    default:
                        break;

                }
                
            }


        }
    }
}
