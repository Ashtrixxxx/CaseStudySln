using CarConnect.Model;
using CarConnect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    internal class AdminServices
    {
        AdminImpl adminImpl = new AdminImpl();
        public List<Customer> GetCustomers()
        {
            return adminImpl.GetCustomers();
        }

        public int UpdateModel(string model, int id)
        {
            return adminImpl.updateModel(model, id);
        }

        public int UpdateMake(string model, int id)
        {
            return adminImpl.updateMake(model, id);
        }

        public int UpdateYear(int year, int id) {
        return adminImpl.updateYear(year, id);


        }

        public int UpdateColor(string color,int id)
        {
            return adminImpl.updateColor(color, id);
        }

        public int UpdateRegistrationNumber(int registrationNumber,int id)
        {
            return adminImpl.UpdateRegistrationNum(registrationNumber, id);
        }

        public int UpdateAvailability(int availability,int id)
        {
            return adminImpl.updateAvailability(availability, id);
        }

        public int UpdateDailyRate(double dailyRate,int id)
        {
            return adminImpl.updateDailyRate(dailyRate, id);
        }


        //Updating admin Data

        public int UpdateAdminFirstName(string firstName,int id)
        {
           return adminImpl.UpdateAdminFirstName(firstName, id);
        }

        public int UpdateAdminLastName(string lastName,int id)
        {
            return adminImpl.UpdateAdminLastName(lastName, id);
        }

        public int UpdateAdminEmail(string email,int id)
        {
            return adminImpl.UpdateAdminEmail(email, id);
        }

        public int UpdateAdminPassword(string password,int id)
        {
            return adminImpl.UpdateAdminPassword(password,id);
        }

        public int UpdateAdminUsername(string username,int id)
        {
            return adminImpl.UpdateAdminUsername(username,id);
        }

        public int UpdateAdminPhoneNumber(string phoneNumber,int id)
        {
            return adminImpl.UpdateAdminPhoneNumber(phoneNumber,id);
        }

        public int UpdateAdminRole(string role,int id)
        {
            return adminImpl.UpdateAdminRole(role,id);
        }
    }
}
