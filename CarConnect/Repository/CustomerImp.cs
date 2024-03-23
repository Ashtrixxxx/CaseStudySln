using CarConnect.Exceptions;
using CarConnect.Model;
using CarConnect.Utils;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Repository
{
    internal class CustomerImp : ICustomer
    {

        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        public CustomerImp()
        {
            sqlConnection = new SqlConnection(DbUtils.GetConnection());
            sqlCommand = new SqlCommand();
        }



        public  int CreateCustomer(Customer customer)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO Customer ( FirstName, LastName, Email, PhoneNumber, [Address], Username, [Password], RegistrationDate) values (@first,@last,@email,@phone,@address,@username,@password,@registrationDate)";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@first", customer.FirstName);
                sqlCommand.Parameters.AddWithValue("@last", customer.LastName);
                sqlCommand.Parameters.AddWithValue("@email", customer.Email);
                sqlCommand.Parameters.AddWithValue("@phone", customer.Phone);
                sqlCommand.Parameters.AddWithValue("@username", customer.UserName);
                sqlCommand.Parameters.AddWithValue("@password", customer.Password);
                sqlCommand.Parameters.AddWithValue("@registrationDate", customer.RegistrationDate);
                sqlCommand.Parameters.AddWithValue("@address", customer.Address);
                rows = sqlCommand.ExecuteNonQuery();

                Console.WriteLine(rows);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return rows;
        }

        public Customer GetCustomerDetailsByUsername(string username)
        {
            Customer customer = new Customer();
            // List<Customer> customerDetails = new List<Customer>();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from Customer where Username = @username";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    customer.CustomerId = (int)reader["CustomerID"];
                    customer.FirstName = (string)reader["FirstName"];
                    customer.LastName = (string)reader["LastName"];
                    customer.Address = (string)reader["Address"];
                    customer.Phone = (string)reader["PhoneNumber"];
                    customer.Email = (string)reader["Email"];
                    customer.UserName = (string)reader["Username"];
                    customer.RegistrationDate = (DateTime)reader["RegistrationDate"];

                }
                //customerDetails.Add(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customer;
        }

        public Customer GetCustomerDetailsById(string user)
        {
            Customer customer = new Customer();
            //List<Customer> customerDetailsId = new List<Customer>();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from Customer where Username = @user";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@user", user);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    customer.CustomerId = (int)reader["CustomerID"];
                    customer.FirstName = (string)reader["FirstName"];
                    customer.LastName = (string)reader["LastName"];
                    customer.Address = (string)reader["Address"];
                    customer.Phone = (string)reader["PhoneNumber"];
                    customer.Email = (string)reader["Email"];
                    customer.UserName = (string)reader["Username"];
                    customer.RegistrationDate = (DateTime)reader["RegistrationDate"];

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customer;
        }

        public void DeleteCustomer(string username) { }

        // Update Implementations

        public int updateFirstName(string username, string name)
        {

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set FirstName = @name where Username = @username";
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@username", username);
            int rows = sqlCommand.ExecuteNonQuery();

            return rows;

        }

        public int updateLastName(string username, string lastName)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set LastName = @lastName where Username = @username";
            sqlConnection.Open();

            int rows = sqlCommand.ExecuteNonQuery();
            return rows;
        }

        public int updateEmail(string username, string email)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Email = @email where Username = @username";
            sqlConnection.Open();

            int rows = sqlCommand.ExecuteNonQuery();
            return rows;
        }

        public int updatePhone(string username, string phone)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set PhoneNumber = @phone where Username = @username";
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@username", username);
            int rows = sqlCommand.ExecuteNonQuery();

            return rows;

        }


        public int updateUsername(string username, string newUser)
        {

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Username = @newUser where Username = @username";
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@newUser", newUser);
            sqlCommand.Parameters.AddWithValue("@username", username);
            int rows = sqlCommand.ExecuteNonQuery();

            return rows;
        }

        public int updatePassword(string username, string password)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Password = @name where Username = @username";
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@name", password);
            sqlCommand.Parameters.AddWithValue("@username", username);
            int rows = sqlCommand.ExecuteNonQuery();

            return rows;

        }

        //Vehicle Operations Done by the customer

        public Vehicle getVehicleDetailsById(int vehicleId)
        {

            Vehicle vehicle = new Vehicle();
            try
            {
                int rows = 0;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from VEHICLE where VehicleId = @id";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", vehicleId);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vehicle.VehicleId = (int)reader["VehicleID"];
                    vehicle.Make = (string)reader["Make"];
                    vehicle.Model = (string)reader["Model"];
                    vehicle.Year = (int)reader["Year"];
                    vehicle.VehicleColor = (string)reader["Color"];
                    vehicle.RegistrationNumber = (int)(reader["RegistrationNumber"]);
                    vehicle.Availability = (int)(reader["Availability"]);
                    vehicle.DailyRate = (double)((decimal)reader["DailyRate"]);
                    rows = 1;
                }
                VehicleNotFound.CheckIfVehicleFound(rows);
                //customerDetails.Add(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return vehicle;
        }

        public List<Vehicle> DisplayAvailableVehicles()
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from VEHICLE where Availability = 1";
                sqlConnection.Open();


                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vehicle.VehicleId = (int)reader["VehicleID"];
                    vehicle.Make = (string)reader["Make"];
                    vehicle.Model = (string)reader["Model"];
                    vehicle.Year = (int)reader["Year"];
                    vehicle.VehicleColor = (string)reader["Color"];
                    vehicle.RegistrationNumber = (int)reader["RegistrationNumber"];
                    vehicle.Availability = Convert.ToInt32(reader["Availability"]);
                    vehicle.DailyRate = (double)((decimal)reader["DailyRate"]);

                    vehicles.Add(vehicle);

                }

                if(vehicles.IsNullOrEmpty())
                {
                    throw new VehicleNotFound("The vehicles are not available");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return vehicles;
        }

        public List<Vehicle> DisplayAllVehicles()
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from VEHICLE";
                sqlConnection.Open();


                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    vehicle.VehicleId = (int)reader["VehicleID"];
                    vehicle.Make = (string)reader["Make"];
                    vehicle.Model = (string)reader["Model"];
                    vehicle.Year = (int)reader["Year"];
                    vehicle.VehicleColor = (string)reader["Color"];
                    vehicle.RegistrationNumber = (int)reader["RegistrationNumber"];
                    vehicle.Availability = Convert.ToInt32(reader["Availability"]);
                    vehicle.DailyRate = (double)((decimal)reader["DailyRate"]);

                    vehicles.Add(vehicle);

                }

                if (vehicles.IsNullOrEmpty())
                {
                    throw new VehicleNotFound("The vehicles are not available");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return vehicles;
        }

        //Reservation Services made by Customer

        public int CreateReservation(Reservation reservation)
        {
            int rows = 0;
            try
            {

                sqlCommand.CommandText = @"
                IF NOT EXISTS (SELECT 1 FROM ReservationTable WHERE VehicleId = @VehicleId)
                BEGIN
                INSERT INTO ReservationTable (CustomerId, VehicleId, StartDate, EndDate) VALUES (@customerId, @vehicleId, @start, @end)
                END";



                sqlCommand.Connection = sqlConnection;
                //sqlCommand.CommandText = "INSERT INTO ReservationTable ( CustomerId, VehicleId, StartDate, EndDate) values (@customerId,@vehicleId,@start,@end)";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@customerId", reservation.CustomerId);
                sqlCommand.Parameters.AddWithValue("@vehicleId", reservation.VehicleId);
                sqlCommand.Parameters.AddWithValue("@start", reservation.Start);
                sqlCommand.Parameters.AddWithValue("@end", reservation.End);

                rows = sqlCommand.ExecuteNonQuery();

                Console.WriteLine(rows);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return rows;
        }

        public List<Reservation> GetReservations(string user)
        {
            List<Reservation> reservations = new List<Reservation>();
            int id = 0;

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Select CustomerID  from Customer where Username = @user";
                sqlCommand.Parameters.AddWithValue("@user", user);
                sqlConnection.Open();
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    id = Convert.ToInt32(r["CustomerID"]);
                }

            }
            catch (SqlException sqlexx)
            {
                Console.WriteLine(sqlexx.StackTrace);
            }


            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Select * from ReservationTable where CustomerID = @id";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Reservation reservation = new Reservation();
                    reservation.CustomerId = (int)reader["CustomerID"];
                    reservation.VehicleId = (int)reader["VehicleID"];
                    reservation.ReservationId = (int)reader["ReservationId"];
                    reservation.Start = (DateTime)reader["StartDate"];
                    reservation.End = (DateTime)reader["EndDate"];
                    reservation.ReservationStatus = Convert.ToInt32(reader["TotalCost"]);
                    reservation.TotalCost = (double)((decimal)reader["TotalCost"]);
                    reservations.Add(reservation);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reservations;
        }

        public Reservation GetReservation(int id)
        {
            Reservation reservation = new Reservation();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Select * from ReservationTable where ReservationID = @id";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    reservation.CustomerId = (int)reader["CustomerID"];
                    reservation.VehicleId = (int)reader["VehicleID"];
                    reservation.ReservationId = (int)reader["ReservationId"];
                    reservation.Start = (DateTime)reader["StartDate"];
                    reservation.End = (DateTime)reader["EndDate"];
                    reservation.ReservationStatus = Convert.ToInt32(reader["TotalCost"]);
                    reservation.TotalCost = (double)((decimal)reader["TotalCost"]);

                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sqlConnection.Close();

            return reservation;

        }

        public int DeleteReservation(string user, int customerId)
        {
            int id = 0;
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Select CustomerID  from Customer where Username = @user";
                sqlCommand.Parameters.AddWithValue("@user", user);
                sqlConnection.Open();
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    id = Convert.ToInt32(r["CustomerID"]);
                }

            }
            catch (SqlException sqlexx)
            {
                Console.WriteLine(sqlexx.StackTrace);
            }

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "delete from ReservationTable where ReservationID = @reservationID and CustomerID = @customerId";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@customerId", id);
                rows = sqlCommand.ExecuteNonQuery();



            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rows;
        }

    }



}
