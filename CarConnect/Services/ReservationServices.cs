using CarConnect.Exceptions;
using CarConnect.Model;
using CarConnect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    public class ReservationServices
    {
        //public delegate void ReservationHandler(Object source, EventArgs e);
        //public event ReservationHandler ReservationCreated;
        //public event EventHandler<> ReservationCreated;

       
        AdminImpl admin = new AdminImpl();
        CustomerImp customerImp = new CustomerImp();
        public int CreateReservation(Reservation reserve,string user)
        {
            int rows = 0;
            try
            {
               rows = customerImp.CreateReservation(reserve,user);
                ReservationException.CheckIfVehicleInUse(rows);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            //catch(Exception ex1)
            //{
            //    Console.WriteLine(ex1.Message);
            //}

            return rows;
        }

        public List<Reservation> GetReservationList(string user)
        {
            
            return customerImp.GetReservations(user); 

        }

        public Reservation GetReservation(int id)
        {
            return customerImp.GetReservation(id);
        }
        
        public int DeleteReservation(string user,int customerId) { 
            
            return customerImp.DeleteReservation(user,customerId);
        }

        public int UpdateReservationStatus(int status, int id)
        {


            return admin.UpdateReservationStatus(status, id); 
                }

    }
}
