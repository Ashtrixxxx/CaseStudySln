using CarConnect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class UpdateVehicle
    {

        public void VehicleUpdate()
            
        {

            AdminServices adminServices = new AdminServices();
            while(true)
            {
                Console.WriteLine("Enter the vehicle id you want to update");
                int vehicleId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. Update Vehicle Model");
                Console.WriteLine("2. Update vehicle Make:");
                Console.WriteLine("3. Update Vehicle Year");
                Console.WriteLine("4. Update Vehicle Registration Number");
                Console.WriteLine("5. Update vehicle Daily Rate");
                Console.WriteLine("Enter your Option");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {

                    case 1:
                        Console.WriteLine("Enter the Vehicle Model ");
                        string model = Console.ReadLine();
                        Console.WriteLine("enter the vehicle Id ");
                        int idForModel = Convert.ToInt32(Console.ReadLine());

                        int modelRows = adminServices.UpdateModel(model, idForModel);
                        break;
                    case 2: Console.WriteLine("Enter Your Vehicle make");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter the Vehicle ID");
                        int idForMake = Convert.ToInt32(Console.ReadLine());

                        int makeRows = adminServices.UpdateMake(make, idForMake);
                        break;
                case 3:
                        Console.WriteLine("Enter the vehicle year you want to update");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Vehicle ID");
                        int idForYear = Convert.ToInt32(Console.ReadLine());

                        int yearRows = adminServices.UpdateYear(year, idForYear);
                        break;

                    case 4:
                        Console.WriteLine("Enter the Color you want to change");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the vehicle ID");
                        int idForColor = Convert.ToInt32(Console.ReadLine());
                        
                        int colorRows = adminServices.UpdateColor(color, idForColor);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Registration number you want to change");
                        int regNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Vehicle ID");
                        int idForReg= Convert.ToInt32(Console.ReadLine());
                         int regRows = adminServices.UpdateRegistrationNumber(regNumber, idForReg);
                        break;
                    case 6:
                        Console.WriteLine("Change the Availability to 1 0r 0");
                        int avail = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the vehicle ID");
                        int idForVehicle = Convert.ToInt32(Console.ReadLine());

                        int availRows = adminServices.UpdateAvailability(avail, idForVehicle);
                        break;
                    case 7:
                        Console.WriteLine("Enter the new Daily Rate");
                        double dailyRate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the vehicle ID");
                        int idForRate = Convert.ToInt32(Console.ReadLine());

                        int rateRows = adminServices.UpdateDailyRate(dailyRate, idForRate);
                        break;
                }
            }
        }

    }
}
