using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MenuSwitch.Model
{
    internal class Reservation
    {
//        ervation Table:
//• ReservationID(Primary Key) : Unique identifier for each reservation.
//• CustomerID (Foreign Key): Foreign key referencing the Customer table.
//• VehicleID (Foreign Key): Foreign key referencing the Vehicle table.
//• StartDate: Date and time of the reservation start.
//• EndDate: Date and time of the reservation end.
//• TotalCost: Total cost of the reservation.
//• Status: Current status of the reservation (e.g., pending, confirmed, completed).

        public int ReservationId{ get; set; }
        public int CustomerId {  get; set; }
        public int VehicleId { get; set; }

        public DateTime Start {  get; set; }

        public DateTime End { get; set; }

        public double TotalCost { get; set; }

        public string ReservationStatus{ get;set; }

        public Reservation()
        {

        }
    }
}
