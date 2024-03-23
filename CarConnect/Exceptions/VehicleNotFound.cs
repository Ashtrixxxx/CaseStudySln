using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Exceptions
{
    internal class VehicleNotFound : Exception
    {

        public VehicleNotFound(string  message): base(message) { }

        public static void CheckIfVehicleFound(int rows)
        {
            if (rows == 0) throw new ArgumentException("Vehicle You are trying to select is not available");
        }

    }
}
