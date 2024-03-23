using CarConnect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect
{
    internal class AdminUpdateReservation
    {
        AdminImpl admin = new AdminImpl();
        public void AdminReservationUpdate()
        {
            while (true) {
                Console.WriteLine("Enter Your Option");

                int input = Convert.ToInt32(Console.ReadLine());    
                switch(input)
                {
                    case 1:
                        Console.WriteLine("Enter the Reservation Id");
                        int reservationID= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 0 for Inactive and 1 for Active");
                        int status = Convert.ToInt32(Console.ReadLine());
                        admin.UpdateReservationStatus(reservationID, status);
                        break;
                }

            }
        }


    }
}
