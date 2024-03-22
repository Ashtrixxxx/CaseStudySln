using MenuSwitch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch.Repository
{
    internal class VehicleRepo
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        //Add vehicle Object
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void GetVehicleById(int id)
        {
            Vehicle vehicle = vehicles.Find(v=> v.VehicleId== id);

            Console.WriteLine(vehicle);
        }

        public void GetAvailable()
        {
            foreach(Vehicle vehicle1 in vehicles)
            {
                if(vehicle1.Availability == "active")
                {
                    Console.WriteLine(vehicle1);
                }

            }

        }

        public void updateMake(int id,string make)
        {
            Vehicle vehicle = vehicles.Find(v=> v.VehicleId== id);
            vehicle.Make = make;
        }

        public void updateYear(int id, int year)
        {
            Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);
            vehicle.Year = year;
        }

        public void updateColor(int id, string color)
        {
            Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);
            vehicle.VehicleColor = color;
        }


        public void updateRate(int id, double rate)
        {
            Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);
            vehicle.DailyRate = rate;
        }

        public void updateAvail(int id,string avail)
        {
            Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);
            vehicle.Availability= avail;
        }

        public void removeVehicle(int id)
        {
            Vehicle vehicle = vehicles.Find(v => v.VehicleId == id);
            vehicles.Remove(vehicle);   
        }

    }
}
