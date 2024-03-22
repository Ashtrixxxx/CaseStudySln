using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1.Models
{
    internal class Bike {
        //    

        //        As a member of a team that is developing toys for JoyToys, Inc., you have
        //been assigned the task of creating a bike module that accepts and displays
        //bike details.Declare the Bike class and its member functions.The member
        //function that accepts bike details should display the message “Accepting Bike
        //Details”. Similarly, the member function to display bike details on the screen
        //should display the message “Displaying Bike Details

        int bikeId;
        string bikeName;
        int bikeyear;
        string bikeModel;

        public int BikeId
        {
            get { return bikeId; } set {  bikeId = value; }
        }

        public string BikeName
        {
            get { return bikeName; }
            set { bikeName = value; }
        }
        public int BikeYear
        {
            get { return bikeyear; }
            set { bikeyear = value; }
        }

        public string BikeModel
        {
            get { return bikeModel; }
            set { bikeModel = value; }
        }
        public void getBike()
        {

        }

        public void display()
        {
            Console.WriteLine("Displaying details");
            Console.WriteLine(BikeId + " " + BikeName+" "+BikeYear+" "+ BikeModel);
        }
    }
}
