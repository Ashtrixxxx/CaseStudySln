using CarConnect.Exceptions;
using CarConnect.Model;
using CarConnect.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Repository
{
    internal class AdminImpl
    {

        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        public AdminImpl()
        {
            sqlConnection = new SqlConnection(DbUtils.GetConnection());
            sqlCommand = new SqlCommand();
        }

        public void CreateAdmin(Admin admin)
        {

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO Admin ( FirstName, LastName, Email, PhoneNumber, Username, [Password], RegistrationDate) values (@first,@last,@email,@phone,@address,@username,@password,@registrationDate)";
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@first", admin.FirstName);
                sqlCommand.Parameters.AddWithValue("@last", admin.LastName);
                sqlCommand.Parameters.AddWithValue("@email", admin.Email);
                sqlCommand.Parameters.AddWithValue("@phone", admin.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@username", admin.Username);
                sqlCommand.Parameters.AddWithValue("@password", admin.Password);
                sqlCommand.Parameters.AddWithValue("@registrationDate", admin.JoinDate);
                sqlCommand.Parameters.AddWithValue("@address", admin.Role);
                int rows = sqlCommand.ExecuteNonQuery();

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

        }



        public int CreateVehicle(Vehicle vehicle)
        {
            int rows = 0;

            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO VEHICLE ( Model, Make, [Year], Color, RegistrationNumber, [Availability], DailyRate) VALUES (@model, @make, @year, @color, @registrationNumber, @avail, @rate)";
                sqlCommand.Parameters.AddWithValue("@model", vehicle.Model);
                sqlCommand.Parameters.AddWithValue("@make", vehicle.Make);
                sqlCommand.Parameters.AddWithValue("@year", vehicle.Year);
                sqlCommand.Parameters.AddWithValue("@color", vehicle.VehicleColor);
                sqlCommand.Parameters.AddWithValue("@registrationNumber", vehicle.RegistrationNumber);
                sqlCommand.Parameters.AddWithValue("@avail", vehicle.Availability);
                sqlCommand.Parameters.AddWithValue("@rate", vehicle.DailyRate);
                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rows;

        }
        public int updateMake(string Make, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Vehicle set Make = @make where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("@make", Make);
            sqlCommand.Parameters.AddWithValue("@id", id);


            sqlConnection.Open();
            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows;

        }
        public int updateModel(string Model, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Model = @Model where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("@Model", Model);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();

            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows ;

        }
        public int updateYear(int year, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Year = @Year where VehicleId = @id";
            sqlCommand.Parameters.AddWithValue("@Year", year);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();

            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows ;

        }
        public int updateColor(string color, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Color = @color where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("@color", color);
            sqlCommand.Parameters.AddWithValue("@VehicleID", id);
            sqlConnection.Open();

            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows;

        }
        public int updateAvailability(int avail, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set Availability = @avail where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("avail", avail);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();

            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows;

        }
        public int updateDailyRate(double dailyRate, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set DailyRate = @dailyRate where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("@dailyRate", dailyRate);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();

            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows;

        }

        public int UpdateRegistrationNum(int registrationNum, int id)
        {
            int rows = 0;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Update Customer set RegistrationNumber = @Num where VehicleID = @id";
            sqlCommand.Parameters.AddWithValue("@Num", registrationNum);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();


            rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlCommand.Parameters.Clear();

            VehicleNotFound.CheckIfVehicleFound(rows);

            return rows;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                Customer customer = new Customer();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from Customers";

                sqlConnection.Open();
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
                    customers.Add(customer);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return customers;
        }

        public int UpdateAdminFirstName(string firstName, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set FirstName = @firstName where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();
                
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return rows;
        }

        public int UpdateAdminLastName(string lastName, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set LastName = @lastName where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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
        public int UpdateAdminEmail(string email, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set Email = @email where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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
        public int UpdateAdminPassword(string password, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set Password = @password where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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
        public int UpdateAdminUsername(string userName, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set Username = @username where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@username", userName);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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
        public int UpdateAdminPhoneNumber(string phoneNumber, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set PhoneNumber = @phoneNumber where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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

        public int UpdateAdminRole(string role, int id)
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update AdminTable set Role = @role where AdminID = @id";
                sqlCommand.Parameters.AddWithValue("@Role", role);
                sqlCommand.Parameters.AddWithValue("@id", id);


                sqlConnection.Open();
                rows = sqlCommand.ExecuteNonQuery();

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
        public int UpdateReservationStatus(int reservationStatus, int id    )
        {
            int rows = 0;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "update ReservationTable set Status = @status where ReservationID = @id";
                sqlCommand.Parameters.AddWithValue("@status", reservationStatus);
                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlConnection.Open();
                 rows = sqlCommand.ExecuteNonQuery();



            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return rows;
        }
    }
}
