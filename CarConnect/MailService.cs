using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class MailService
    {

        public void OnReservationCreated(Object source, EventArgs e)
        {
            Console.WriteLine("Mail service: Your reservation has been created");
        }

    }
}
