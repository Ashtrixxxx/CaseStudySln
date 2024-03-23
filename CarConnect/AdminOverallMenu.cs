using CarConnect.Exceptions;
using CarConnect.Model;
using CarConnect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class AdminOverallMenu
    {

        public enum Option
        {
            Active = 0,
            Inactive = 1
        }

        public void AdminMenu()
        {
            Option option1 = Option.Active;
            Option option2 = Option.Inactive;
            CustomerServices customerServices = new CustomerServices();
            VehicleServices vehicleServices = new VehicleServices();
            ReservationServices reservationServices = new ReservationServices();
            AdminServices adminServices = new AdminServices();
            UpdateVehicle updateVehicle = new UpdateVehicle();
            UpdateAdmin updateAdmin = new UpdateAdmin();
            AdminUpdateReservation updateReservation = new AdminUpdateReservation();
            while (true)

            {
                Console.WriteLine("Welcome, Admin");
                Console.WriteLine("1 .Get All the Customers");
                Console.WriteLine("2. Add a New Vehicle");
                Console.WriteLine("3. Update Vehicle");
                Console.WriteLine("4. Update Admin Details");
                Console.WriteLine("5. Update Reservation status");
                Console.WriteLine("Enter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                

                switch(option)
                {
                    case 1:
                        List<Customer> customers = new List<Customer>();
                        customers = adminServices.GetCustomers();
                        foreach (Customer customer in customers)
                        {
                            Console.WriteLine(customer);
                        }

                        break;
                    case 2:
                        Vehicle vehicle = new Vehicle();
                        Console.WriteLine("Enter the details to create a vehicle");
                        Console.WriteLine("Enter The make of the vehicle");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter the model name");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter the year ");
                        string refyear = Console.ReadLine();
                        int year = 0;
                        InvalidInputException.CheckIfInteger(refyear, ref year);

                        Console.WriteLine("Enter the color of the vehicle");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter your registration Number");
                        string refRegistrationNumber = Console.ReadLine();
                        int registrationNumber = 0;
                        InvalidInputException.CheckIfInteger(refRegistrationNumber, ref registrationNumber );

                        Console.WriteLine("Set Availability ...");
                        Console.WriteLine("Press 1 for Active . 0 for Inactive");
                        int avail = Convert.ToInt32(Console.ReadLine());
                        int availability = 0;
                        switch (avail)
                        {
                            case 1:
                                availability = 1;
                                break;
                            case 2:
                                availability = 0;

                                break;
                            default:
                                Console.WriteLine("Enter Correct Option");
                                break;
                        }
                        Console.WriteLine("Enter Daily Rate for the vehicle");
                        double dailyRate = Convert.ToDouble(Console.ReadLine());

                        vehicle = new Vehicle() {Make = make , Model = model, Year = year, VehicleColor= color, Availability = availability, RegistrationNumber = registrationNumber, DailyRate = dailyRate };
                        int rows = vehicleServices.CreateVehicle(vehicle);
                        break;
                    case 3:
                        updateVehicle.VehicleUpdate();
                        break;
                    case 4:
                        updateAdmin.AdminUpdate();
                        break;
                    case 5:
                        updateReservation.AdminReservationUpdate();
                        break;
                    default:
                        break;

                }

            }
        }
    }
}
