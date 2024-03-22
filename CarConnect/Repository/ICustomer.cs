using CarConnect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Repository
{
    internal interface ICustomer
    {



        int CreateCustomer(Customer customer);

        Customer GetCustomerDetailsById(string user);

        Customer GetCustomerDetailsByUsername(string username);

        Vehicle getVehicleDetailsById(int id);

        void DeleteCustomer(string username);

        List<Vehicle> DisplayAvailableVehicles();
    }
}
