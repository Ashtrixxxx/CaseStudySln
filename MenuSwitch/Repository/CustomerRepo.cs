using MenuSwitch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch.Repository
{
    internal class CustomerRepo
    {
        List<Customer> customers;

        //public void addCustomer(int ID, string first, string last, string email, string phone, string username, string password, DateOnly registrationDate)
        //{
        //    // customers.Add(new Customer( ID,  first,  last,  email,  phone,  username,  password,  registrationDate));

        //}

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public CustomerRepo() { 
            customers = new List<Customer>() { new Customer() {CustomerId=101,FirstName="Ashwin",LastName="S",Email="ashwin94@gmail.com",Phone="770856739",UserName="Ashtrix",Password="ashwin123",RegistrationDate=DateTime.Now} };

        }

        public void getCustomerDetailsById(int ID)
        {
            Customer customer = getCustomerById(ID);

            Console.WriteLine(customer);
        }

        public Customer getCustomerById(int ID)
        {
            return customers.Find(x => x.CustomerId == ID);
        }

        public void getCustomerDetailsByName(string name)
        {
            Customer customer = customers.Find(x => x.UserName == name);

            Console.WriteLine(customer);
        }

        public void updateDetails(int id)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            
        }

        public void updateFirstName(int id,string frst)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.FirstName = frst;
        }

        public void updateLastName(int id, string last)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.LastName = last;
        }

        public void updateEmail(int id, string email)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.Email = email;
        }

        public void updatePhone(int id, string phone)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.Phone = phone;
        }

        public void updateUserName(int id, string user)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.UserName = user;
        }

        public void updatePassword(int id, string pass)
        {
            Customer customer = customers.Find(x => x.CustomerId == id);
            customer.Password = pass;
        }

        public string DeleteCustomer(int id)
        {
            Customer customer = customers.Find(x=>x.CustomerId == id);
            customers.Remove(customer);

            return $"The id {id} has been successfully deleted";
        }

    }
}
