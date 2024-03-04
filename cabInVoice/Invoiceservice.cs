using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
    public class Invoiceservice
    {
        private RideRepository riderepository;
        public Invoiceservice(RideRepository riderepository)
        {
            this.riderepository = riderepository;
        }   

        public Invoice GenerateInvoice(int userid)
        {
            List<Ride> rides = riderepository.GetRides(userid);
            double totalfare = new InvGeneratormultiplerides().calculatetotalfare(rides);
            return new Invoice { Userid = userid, Rides = rides, Totalfare = totalfare };

        }
    }
}
