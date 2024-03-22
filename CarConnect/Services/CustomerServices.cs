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
    internal class CustomerServices
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
        public void updateFirstName(string username, string firstName)
        {
            try
            {


                customerImp.updateFirstName(username, firstName);
            }catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateLastName(string username, string lastName)
        {

            try
            {
                customerImp.updateLastName(username, lastName);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);

            
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateEmail(string username, string email)
        {
            try
            {
                customerImp.updateEmail(username, email);
            }
            
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updatePhone(string username, string phone)
        {
            try
            {
                customerImp.updatePhone(username, phone);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateUserName(string username, string userName)
        {
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
        }

        public void updatePassword(string username, string password)
        {
            try
            {
                customerImp.updatePassword(username, password);
            }
            catch(SqlException sqlexp)
            {
                Console.WriteLine(sqlexp.Message);
            }
        }


       
    }
}
