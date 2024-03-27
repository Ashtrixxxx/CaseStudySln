using CarConnect.Model;
using CarConnect.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    public class CustomerServices
    {
        CustomerImp customerImp = new CustomerImp();
        public Customer GetDetailsByIdService(string user)
        {
            
            return customerImp.GetCustomerDetailsById(user);

        }


        public Customer GetDetailsByNameService(string name)
        {
            return customerImp.GetCustomerDetailsByUsername(name);
        }

        public void DeleteCustomerService(string name) { }

        public int CreateCustomerService(Customer customer)
        {
            int rows = 0;
            try
            {
              rows =  customerImp.CreateCustomer(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rows;
        }

        //Update Functions 
        //
        public int updateFirstName(string username, string firstName)
        {
            int rows = 0;
            try
            {


               rows = customerImp.updateFirstName(username, firstName);
            }catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rows;
        }

        public int updateLastName(string username, string lastName)
        {
            int rows = 0;
            try
            {
              rows=  customerImp.updateLastName(username, lastName);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);

            
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return rows;
        }

        public int updateEmail(string username, string email)
        {
            int rows = 0;
            try
            {
               rows= customerImp.updateEmail(username, email);
            }
            
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rows;
        }

        public int updatePhone(string username, string phone)
        {
            int rows = 0;
            try
            {
             rows=    customerImp.updatePhone(username, phone);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rows;
        }

        public int updateUserName(string username, string userName)
        {

            int rows = 0;
            try
            {
                customerImp.updateUsername(username, userName);
            }
            catch(SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rows;
        }

        public int updatePassword(string username, string password)
        {

            int rows = 0;
            try
            {
               rows =  customerImp.updatePassword(username, password);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }

            return rows;
        }


       
    }
}
