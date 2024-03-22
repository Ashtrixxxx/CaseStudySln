using MenuSwitch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch.Repository
{
    internal class ReservationRepo
    {

        List<Reservation> reservations;

        public void createReservation(Reservation reservation)

        {

            reservations.Add(reservation);
        }
    }
}
