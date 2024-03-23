using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class SmsService
    {

        public void OnReservationCreated(Object source, EventArgs e)
        {
            Console.WriteLine("Sms service: Your reservation has been created");
        }
    }
}
