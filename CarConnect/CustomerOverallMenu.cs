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
    public class CustomerOverallMenu
    {

        CustomerServices customerServices = new CustomerServices();
        VehicleServices vehicleServices = new VehicleServices();
        ReservationServices reservationServices = new ReservationServices();
        
        public void OverallMenu(string user)
        {
        MainMenu: while (true)
            {
                Console.WriteLine("1. Customer Services");
                Console.WriteLine("2. Vehicle Services");
                Console.WriteLine("3. Reservation Services");

                Console.WriteLine("Enter Your Choice");

                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                        while (true)
                        {
                            Console.WriteLine("1. Get Customer Details By ID");
                            Console.WriteLine("2. Get Customer Details by Username");
                            Console.WriteLine("3. Update My Customer Details");

                            Console.WriteLine("Enter Your Option:");
                            int option = Convert.ToInt32(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                    
                                    Customer customerDetailsbyId = customerServices.GetDetailsByIdService(user);
                                    Console.WriteLine(customerDetailsbyId);
                                    break;
                                case 2:
                                    //Console.WriteLine("Enter your username");
                                    //string user = Console.ReadLine();
                                    Customer customerDetailsByUser = customerServices.GetDetailsByNameService(user);
                                    Console.WriteLine(customerDetailsByUser);
                                    break;
                                case 3:
                                    Console.Clear();
                                    try
                                    {
                                        //Console.WriteLine("Enter your Username to update:");
                                        //string username = Console.ReadLine();
                                        //c.updateDetails(updateId);

                                        Console.WriteLine("1. Update First Name");
                                        Console.WriteLine("2. Update Last Name");
                                        Console.WriteLine("3. Update email");
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
                                                customerServices.updateFirstName(user, NewFirst);
                                                break;

                                            case 2:
                                                Console.WriteLine("Enter your last Name to Update");
                                                string NewLast = Console.ReadLine();
                                                customerServices.updateLastName(user, NewLast);
                                                break;

                                            case 3:
                                                Console.WriteLine("Enter your Email to Update:");
                                                string NewEmail = Console.ReadLine();
                                                customerServices.updateEmail(user, NewEmail);
                                                break;
                                            case 4:
                                                Console.WriteLine("Enter your Phone to update:");
                                                string NewPhone = Console.ReadLine();
                                                customerServices.updatePhone(user, NewPhone);
                                                break;
                                            case 5:
                                                Console.WriteLine("Enter your Username to Update");
                                                string NewUser = Console.ReadLine();
                                                customerServices.updateUserName(user, NewUser);
                                                break;
                                            case 6:
                                                Console.WriteLine("Enter your New Password:");
                                                string NewPassword = Console.ReadLine();
                                                Console.WriteLine("Confirm Your new Password:");
                                                string p1 = Console.ReadLine();
                                                if (p1 == NewPassword)
                                                {
                                                    customerServices.updatePassword(user, NewPassword);
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
                                    catch (Exception ex) { Console.WriteLine(ex.Message); }


                                    break;

                                    break;
                                default:
                                    goto MainMenu;
                                    break;
                            }

                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("1. Get Vehicle Details by Id");
                            Console.WriteLine("2. Get All the available vehicles ");

                            Console.WriteLine("Enter Your option");
                            int vehicleOption = Convert.ToInt32(Console.ReadLine());
                            switch (vehicleOption)
                            {
                                case 1:
                                    Console.WriteLine("Enter The vehicle ID");
                                    string refVehicleId = Console.ReadLine();
                                    int vehicleID = 0;
                                    InvalidInputException.CheckIfInteger(refVehicleId, ref vehicleID);


                                    Vehicle vehicle = vehicleServices.getVehicleDetailsById(vehicleID);
                                    Console.WriteLine(vehicle);
                                    break;
                                case 2:
                                    Console.WriteLine("Displayin all the Available vehicles");
                                    List<Vehicle> vehicleList = new List<Vehicle>();
                                    vehicleList = vehicleServices.AvailableVehicles();
                                    foreach(Vehicle v in vehicleList)
                                    {
                                        Console.WriteLine(v);
                                    }

                                    break;
                                default:
                                    goto MainMenu;
                                    break;
                            }
                        }
                        break;
                    case 3:

                        while (true)
                        {
                            Console.WriteLine("1. Create a Reservation");
                            Console.WriteLine("2. Display all Reservations of a Customer");
                            Console.WriteLine("3. Display Reservation ");
                            Console.WriteLine("4.Cancel a reservation");

                            Console.WriteLine("Enter your Option");
                            int reservationOption = Convert.ToInt32(Console.ReadLine());
                            switch (reservationOption)
                            {
                                case 1:

                                   

                                    Reservation reserve = new Reservation();
                                    Console.WriteLine("Create Your New Reservation ");

                                    Console.WriteLine("Enter your details:");


                                    Console.WriteLine("Enter your Id:");
                                    string refCustomerId =Console.ReadLine();
                                    int customerID = 0;
                                    InvalidInputException.CheckIfInteger(refCustomerId, ref customerID);


                                    Console.WriteLine("Enter The vehicle Id you want to rent");
                                    string refVehicleId = Console.ReadLine();
                                    int vehicleID = 0;
                                    //int vehicleId = Convert.ToInt32(Console.ReadLine());
                                    InvalidInputException.CheckIfInteger(refVehicleId, ref vehicleID);


                                    Console.WriteLine("Enter Expiry Date");
                                    DateTime expiry = Convert.ToDateTime(Console.ReadLine());
                                    
                                    DateTime start = DateTime.Now;
                                    reserve = new Reservation() { CustomerId= customerID, VehicleId = vehicleID, Start = start, End = expiry };
                                   int createReservationRows=  reservationServices.CreateReservation(reserve);


                                    //if (createReservationRows == 1)
                                    //OnReservationCreated();


                                    break;
                                case 2:

                                    //Console.WriteLine("Enter your customer id :");
                                    //int id = Convert.ToInt32(Console.ReadLine());

                                    List<Reservation> reservations = new List<Reservation>();
                                    reservations = reservationServices.GetReservationList(user);
                                    foreach(Reservation reservation in reservations)
                                    {
                                        Console.WriteLine(reservation);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Your resevation Id");
                                    string refReservationId = Console.ReadLine();
                                    int reservationID = 0;
                                    InvalidInputException.CheckIfInteger(refReservationId, ref reservationID);

                                    Reservation reserveDetails = new Reservation();
                                    reserveDetails = reservationServices.GetReservation(reservationID);
                                    Console.WriteLine(reserveDetails);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Your reservation ID to Remove");
                                    int removeReservationId = Convert.ToInt32(Console.ReadLine());
                                    
                                    int deleteRows = reservationServices.DeleteReservation(user, removeReservationId);

                                   

                                    break;
                                default:
                                    goto MainMenu;
                            }
                        }
                        break;


                }
            }
        }

    }
}
