using CarConnect.Model;
using CarConnect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConnect.Services
{
    internal class ReservationServices
    {
        CustomerImp customerImp = new CustomerImp();
        public int CreateReservation(Reservation reserve)
        {
            int rows = 0;
            try
            {
               rows = customerImp.CreateReservation(reserve);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return rows;
        }

        public List<Reservation> GetReservationList(string user)
        {
            
            return customerImp.GetReservations(user); 

        }

        public Reservation GetReservation(int id)
        {
            return GetReservation(id);
        }
        
        public int DeleteReservation(string user,int customerId) { 
            
            return customerImp.DeleteReservation(user,customerId);
        }

    }
}
