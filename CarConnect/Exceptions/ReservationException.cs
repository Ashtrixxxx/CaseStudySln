using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Exceptions
{
    public  class ReservationException: Exception
    {
        public ReservationException(string message):base(message) { }


        public static void CheckIfVehicleInUse(int rows)
        {
            if(rows < 1)
            {
                throw new ReservationException("The Vehicle you are trying to Reserve is currently in use");
            }

        }
    }
}
