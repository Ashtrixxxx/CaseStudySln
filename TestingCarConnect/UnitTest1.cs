using CarConnect.Model;
using CarConnect.Services;
using Microsoft.IdentityModel.Tokens;
namespace TestingCarConnect
{
    //[TestFixture]
    public class Tests
    {


        [Test]

        [TestCase("ann5122", "ann5122", ExpectedResult = true)]
        [TestCase("invalidUsername", "invalidPassword", ExpectedResult = false)]
        public bool TestForCustomerAuth(string user, string password)
        {
            AuthenticationServices authentication = new AuthenticationServices();
            //string user = "Ashwin";
            //string password = "Hey";

            bool result = authentication.Login(user, password);

            return result;
        }


        //TestCases for Customer Updation


        [TestCase("ann5122", "AnnRose", ExpectedResult = 1)]
        [TestCase("ann", "AnnRose", ExpectedResult = 0)]
        public int UpdateCustomerFirstName(string user, string firstName)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updateFirstName(user, firstName);
            return rows;

        }

        [TestCase("ann5122", "RosePaul", ExpectedResult = 1)]
        [TestCase("ann", "RosePaul", ExpectedResult = 0)]
        public int UpdateCustomerLastName(string user, string lastName)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updateLastName(user, lastName);
            return rows;

        }

        [TestCase("ann5122", "ann5122@gmail.com", ExpectedResult = 1)]
        [TestCase("ann", "ann5122@gmail.com", ExpectedResult = 0)]
        public int UpdateCustomerEmail(string user, string email)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updateEmail(user, email);
            return rows;

        }

        [TestCase("ann5122", "9908329873", ExpectedResult = 1)]
        [TestCase("ann5122", "3289379283323", ExpectedResult = 0)]
        public int UpdateCustomerPhone(string user, string phone)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updatePhone(user, phone);
            return rows;

        }


        [TestCase("ann5122", "ann2003", ExpectedResult = 1)]
        [TestCase("ann", "ann5122", ExpectedResult = 0)]
        public int UpdateCustomerUserName(string user, string newUser)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updateUserName(user, newUser);
            return rows;

        }


        [TestCase("ann5122", "ann2003", ExpectedResult = 1)]
        [TestCase("ann", "ann@2003", ExpectedResult = 0)]
        public int UpdateCustomerPassword(string user, string password)
        {

            CustomerServices cs = new CustomerServices();


            int rows = cs.updatePassword(user, password);
            return rows;

        }



        //3. Test adding a new vehicle.

        [Test]
        public void TestToAddvehicle()
        {
            VehicleServices vehicleServices = new VehicleServices();
            Vehicle vehicle = new Vehicle()
            {
                Make = "Mercedes",
                Model = "Amg ONE",
                RegistrationNumber = 157938,
                Availability = 1,
                Year = 2022,
                VehicleColor = "Black",
                DailyRate = 890.00
            };


            int addVehicleTest = vehicleServices.CreateVehicle(vehicle);
            Assert.That(1,Is.EqualTo(addVehicleTest));

        }


        [Test]
        public void TestToGetAvailableVehicles()
        {
            VehicleServices services = new VehicleServices();
            List<Vehicle> availableVehicles = services.AvailableVehicles();

            bool isListEmpty = availableVehicles.IsNullOrEmpty();

            Assert.That(!isListEmpty, Is.True);

        }



        //6. Test getting a list of all vehicles.

        [Test]
        public void TestToGetAllVehicles()
        {
            VehicleServices services = new VehicleServices();
            List<Vehicle> allVehicles = services.GetAllVehicles();

            bool isListEmpty = allVehicles.IsNullOrEmpty();

            Assert.That(isListEmpty, Is.True);

        }


        // Test updating vehicle details.


        [TestCase("m8 COMP",5011 , ExpectedResult = 1)]
        [TestCase("M8 COMP", 5067, ExpectedResult = 0)]
        public int UpdateVehicleModel(string model,int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateModel(model, vehicleId);
            return rows;

        }


        [TestCase("BMW", 5011, ExpectedResult = 1)]
        [TestCase("Bmw", 5067, ExpectedResult = 0)]
        public int UpdateVehicleMake(string make, int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateMake(make, vehicleId);
            return rows;

        }

        [TestCase("white", 5011, ExpectedResult = 1)]
        [TestCase("White", 5067, ExpectedResult = 0)]
        public int UpdateVehicleColor(string color, int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateColor(color, vehicleId);
            return rows;

        }

        [TestCase(938723, 5011, ExpectedResult = 1)]
        [TestCase(3928739, 5067, ExpectedResult = 0)]
        public int UpdateVehicleRegistration(int registration, int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateRegistrationNumber(registration, vehicleId);
            return rows;

        }

        [TestCase(1, 5011, ExpectedResult = 1)]
        [TestCase(1, 5067, ExpectedResult = 0)]
        public int UpdateVehicleAvailability(int avail, int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateAvailability(avail, vehicleId);
            return rows;

        }

        [TestCase(900.00, 5011, ExpectedResult = 1)]
        [TestCase(780.00, 5067, ExpectedResult = 0)]
        public int UpdateVehicleDailyRate(double rate, int vehicleId)
        {

            AdminServices adminServices = new AdminServices();

            int rows = adminServices.UpdateDailyRate(rate, vehicleId);
            return rows;

        }

    }
}