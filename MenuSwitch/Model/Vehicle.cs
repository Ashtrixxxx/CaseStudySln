using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MenuSwitch.Model
{
    internal class Vehicle
    {
//        • VehicleID(Primary Key) : Unique identifier for each vehicle.
//• Model: Model of the vehicle.
//• Make: Manufacturer or brand of the vehicle.
//• Year: Manufacturing year of the vehicle.
//• Color: Color of the vehicle.
//• RegistrationNumber: Unique registration number for each vehicle.
//• Availability: Boolean indicating whether the vehicle is available for rent.
//• DailyRate: Daily rental rate for the vehicle.

        public int VehicleId { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string VehicleColor { get; set; }
        public string RegistrationNumber { get; set; }
        public string Availability { get; set; }
        public double DailyRate { get; set; }

        public Vehicle()
        {

        }

        public override string ToString()
        {
            return $"Vehicle Id : {VehicleId} \t Vehicle Make : {Make}\t Year : {Year} \t Color of Vehicle: {VehicleColor}\t Registration Number : {RegistrationNumber}\t Availability : {Availability}\t Daily Rate : {DailyRate}";
        }

    }
}
