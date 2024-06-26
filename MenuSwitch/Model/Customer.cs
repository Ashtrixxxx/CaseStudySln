﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }   
        public string Phone { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Customer()
        {

        }

        //public Customer(int ID, string first, string last, string email, string phone, string username,string password,DateTime registrationDate)
        //{

        //    CustomerId = ID;
        //    FirstName = first;
        //    LastName = last;
        //    Email = email;
        //    Phone = phone;
        //    UserName = username;
        //    Password = password;
        //    RegistrationDate = registrationDate;

        //}

        public override string ToString()
        {
            return $"Customer Id is {CustomerId} \t Customer Name = {FirstName + LastName}\t Email: {Email}\t  Phone :{Phone} \t RegisteredDate: {RegistrationDate}";
        }

    }
}
