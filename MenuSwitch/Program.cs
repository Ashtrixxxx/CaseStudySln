
using MenuSwitch.Exceptions;
using MenuSwitch.Model;
using MenuSwitch.Repository;
using System;

namespace MenuSwitch
{
    internal class MenuSwitch
    {
        static void Main(string[] args)
        {
            CustomerRepo c = new CustomerRepo();
            Random random = new Random();
            VehicleRepo v = new VehicleRepo();
            ReservationRepo reservationRepo = new ReservationRepo();    

        MainMenu: while (true)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("Customer Services");
                Console.WriteLine("Vehicle Services");
                Console.WriteLine("Reservation Services");
                Console.WriteLine("Admin Services");

                Console.WriteLine("Enter youor option:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            //Console.Clear();
                            Console.WriteLine("1. Get my customer details by ID");
                            Console.WriteLine("2. Get Cutsomer by Username:");
                            Console.WriteLine("3. Register a new Customer:");
                            Console.WriteLine("4. Update my customer details:");
                            Console.WriteLine("5. Delete a customer:");
                            Console.WriteLine("6. Go back to Main menu");

                            Console.WriteLine("Enter your choice:");
                            int ch = Convert.ToInt32(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    //Console.Clear();
                                    try
                                    {


                                        Console.WriteLine("Enter the customer Id");
                                        string id = Console.ReadLine();
                                        int id2 = 0;
                                        InvalidInputException.CheckIfInteger(id, ref id2);
                                        //Console.WriteLine(id2);
                                        c.getCustomerById(id2);

                                    }catch(Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 2:
                                    //Console.Clear();
                                    Console.WriteLine("Enter Customer username:");
                                    String user = Console.ReadLine();
                                    c.getCustomerDetailsByName(user);
                                    break;
                                case 3:
                                    Customer customer = new Customer();

                                    Console.Clear();
                                    Console.WriteLine("Enter your details:");
                                    Console.WriteLine("Enter your Id");
                                    int customerId = Convert.ToInt32(Console.ReadLine());
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
                                    string password = Console.ReadLine();
                                    DateTime date = DateTime.Now;
                                    customer = new Customer() { CustomerId = customerId, FirstName = frst, LastName = last, Email = email, Phone = phone, UserName = username, Password = password, RegistrationDate = date };
                                    c.AddCustomer(customer);
                                    break;
                                case 4:
                                    Console.Clear();
                                    try
                                    {
                                        Console.WriteLine("Enter your id to update:");
                                        string updateId = Console.ReadLine();
                                        if (!int.TryParse(updateId, out int i))
                                        {
                                            throw new InvalidInputException("Invalid Input Please try again");
                                        }
                                        else { 
                                        //c.updateDetails(updateId);

                                        Console.WriteLine("1. Update First Name");
                                        Console.WriteLine("2. Update Last Name");
                                        Console.WriteLine("3. Update emai");
                                        Console.WriteLine("4. Update phone number");
                                        Console.WriteLine("5. Update username");
                                        Console.WriteLine("6. Update password");

                                        Console.WriteLine("Enter your choice");
                                        int updateChoice = Convert.ToInt32(Console.ReadLine());

                                            switch (updateChoice)
                                            {
                                                case 1:
                                                    Console.WriteLine("Enter your new First Name");
                                                    string NewFirst = Console.ReadLine();
                                                    c.updateFirstName(i, NewFirst);
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Enter your last Name to Update");
                                                    string NewLast = Console.ReadLine();
                                                    c.updateLastName(i, NewLast);
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Enter your Email to Update:");
                                                    string NewEmail = Console.ReadLine();
                                                    c.updateEmail(i, NewEmail);
                                                    break;
                                                case 4:
                                                    Console.WriteLine("Enter your Phone to update:");
                                                    string NewPhone = Console.ReadLine();
                                                    c.updatePhone(i, NewPhone);
                                                    break;
                                                case 5:
                                                    Console.WriteLine("Enter your Username to Update");
                                                    string NewUser = Console.ReadLine();
                                                    c.updateUserName(i, NewUser);
                                                    break;
                                                case 6:
                                                    Console.WriteLine("Enter your New Password:");
                                                    string NewPassword = Console.ReadLine();
                                                    Console.WriteLine("Confirm Your new Password:");
                                                    string p1 = Console.ReadLine();
                                                    if (p1 == NewPassword)
                                                    {
                                                        c.updatePassword(i, NewPassword);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }catch(Exception ex) { Console.WriteLine(ex.Message); }


                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("Enter your id to delete the customer:");
                                    int deleteId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(c.DeleteCustomer(deleteId));
                                    break;
                                case 6:
                                    Console.Clear();
                                    goto MainMenu;
                                    break;

                            }
                        }
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("1. GetVehicleById");
                            Console.WriteLine("2. GetAvailableVehicles");

                            Console.WriteLine("3. AddVehicle");

                            Console.WriteLine("4. UpdateVehicle");
                            Console.WriteLine("5. RemoveVehicle");
                            Console.WriteLine("6. Go to main menu");



                            int vch = Convert.ToInt32(Console.ReadLine());
                            switch (vch)
                            {
                                case 1:
                                    try
                                    {


                                        Console.WriteLine("Enter your id");
                                        string input = Console.ReadLine();
                                        if(!int.TryParse(input, out int Vid))
                                        {
                                            throw new InvalidInputException("Invalid input . Please check your id again");
                                        }
                                        v.GetVehicleById(Vid);
                                    }catch(Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Available vehicles");
                                    v.GetAvailable();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Vehicle vehicle = new Vehicle();
                                    Console.WriteLine("Add a vehicle:");
                                    Console.WriteLine("Enter your details:");
                                    Console.WriteLine("Enter your Id");
                                    int vehicleId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter your Vehicle Make:");
                                    string vehicleMake = Console.ReadLine();
                                    Console.WriteLine("Enter your Vehicle Year");
                                    int yearVehicle = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter your Color:");
                                    string vehicleColor = Console.ReadLine();
                                    Console.WriteLine("Enter your DailyRate");
                                    double dailyRate = Convert.ToDouble(Console.ReadLine());


                                    string registrationNumber = random.Next(10000).ToString();


                                    Console.WriteLine("Enter your Availability Status:");
                                    string availabilityVehicle = Console.ReadLine();
                                    vehicle = new Vehicle() {VehicleId=vehicleId,Make=vehicleMake,Year=yearVehicle,VehicleColor= vehicleColor,DailyRate=dailyRate,RegistrationNumber=registrationNumber,Availability=availabilityVehicle };

                                    break;
                                case 4:

                                    try
                                    {


                                        Console.Clear();
                                        Console.WriteLine("Enter your car id to update");
                                        int carId = Convert.ToInt32(Console.ReadLine());


                                        Console.WriteLine("1. Update Make");
                                        Console.WriteLine("2. Update Last Name");
                                        Console.WriteLine("3. Update emai");
                                        Console.WriteLine("4. Update phone number");
                                        Console.WriteLine("5. Update username");
                                        Console.WriteLine("6. Update password");

                                        Console.WriteLine("Enter your choice");
                                        int updateChoice = Convert.ToInt32(Console.ReadLine());
                                        switch (updateChoice)
                                        {
                                            case 1:
                                                Console.WriteLine("Enter your new Make Name");
                                                string NewMake = Console.ReadLine();
                                                v.updateMake(carId, NewMake);
                                                break;

                                            case 2:
                                                Console.WriteLine("Enter your Year ");
                                                int NewYear = Convert.ToInt32(Console.ReadLine());
                                                v.updateYear(carId, NewYear);
                                                break;

                                            case 3:
                                                Console.WriteLine("Enter your Color to Update:");
                                                string NewColor = Console.ReadLine();
                                                v.updateColor(carId, NewColor);
                                                break;
                                            case 4:
                                                Console.WriteLine("Enter your new DailyRate:");
                                                double NewDailyRate = Convert.ToDouble(Console.ReadLine());
                                                v.updateRate(carId, NewDailyRate);
                                                break;
                                            case 5:
                                                Console.WriteLine("Update your Availability status");
                                                string Avail = Console.ReadLine();
                                                v.updateAvail(carId, Avail);
                                                break;

                                            default:
                                                break;
                                        }
                                    }
                                    catch(Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("Enter the vehicle id to remove the vehicle:");
                                    int CarRemoveId = Convert.ToInt32(Console.ReadLine());
                                    v.removeVehicle(CarRemoveId);
                                    break;
                                case 6:
                                    goto MainMenu;
                            }

                        }
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("Reservation Services");
                            Console.WriteLine("1. Get reservation details by Id");
                            Console.WriteLine("2. Get reservation details by customer id");
                            Console.WriteLine("3. Create a reservation");
                            Console.WriteLine("4. Update a reservation");
                            Console.WriteLine("5. Cancel a reservation");

                            Console.WriteLine("Enter Your option");
                            int reservationChoice = Convert.ToInt32(Console.ReadLine());

                            switch(reservationChoice) {


                                case 1:
                                    
                                    


                                        Reservation r = new Reservation();


                                        Console.WriteLine("Enter Your Customer Id:");
                                        int customerId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter your vehicle Id:");
                                        int vehicleId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("enter your reservation Id:");
                                        int reservationId = Convert.ToInt32(Console.ReadLine());
                                        DateTime start = DateTime.Now;
                                        Console.WriteLine("Enter your expiry Date");
                                        DateTime end = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Enter your cost ");
                                        double cost = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter your reservation status"); //pending, confirmed,completed
                                        string status = Console.ReadLine();
                                        r = new Reservation() { CustomerId = customerId, VehicleId = vehicleId, ReservationId = reservationId, Start = start, End = end, TotalCost = cost, ReservationStatus = status };
                                        reservationRepo.createReservation(r);
                                        break;
                                    
                            }

                        }

                }

            }
        }
    }
}

