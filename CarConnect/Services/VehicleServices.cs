using CarConnect.Model;
using CarConnect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    internal class VehicleServices
    {
        AdminImpl adminImpl = new AdminImpl();
        CustomerImp customerImp = new CustomerImp();
        public Vehicle getVehicleDetailsById(int id)
        {
            return customerImp.getVehicleDetailsById(id);
        }

        public List<Vehicle> AvailableVehicles()
        {
            return customerImp.DisplayAvailableVehicles();
        }

        public int CreateVehicle(Vehicle vehicle)
        {
            return adminImpl.CreateVehicle(vehicle);
        }

    }
}


