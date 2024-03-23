using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarConnect.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        public int CustomerId { get; set; }
        public string Model {  get; set; }

        public string VehicleColor { get; set; }
        public int RegistrationNumber { get; set; }
        public int Availability { get; set; }
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
