using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
    public class PremiumInvoice
    {

        public double claculatefare(double distance,int time, bool ispremium)
        {
            double cost_per_km = ispremium ? 15 : 10;
            double cost_per_minute = ispremium ? 2 : 1;
            double min_fare = ispremium ? 20 : 5;

            double fare = distance * cost_per_km + time * cost_per_minute;
            return Math.Max(fare, min_fare);
        }
    }

    public class Ride
    {
        public double Distance { get; set; }
        public int Time { get; set; }
    }

    public class Invoice
    {
        public int Userid { get; set; }
        public List<Ride> Rides { get; set; }
        public double Totalfare { get; set; }
    }
    public interface RideRepository
    {
        List<Ride> GetRides(int Userid);

    }
    public class ExampleRideRepository : RideRepository
    {
        public List<Ride> GetRides(int Userid)
        {
            return new List<Ride>
            {
                new Ride { Distance = 5, Time = 10 },
                new Ride { Distance = 20, Time = 30 },
                new Ride { Distance = 7, Time = 15 }
            };
        }
    }
}
