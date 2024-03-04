using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
    public class InvGenerator
    {
        public double claculatefare(double distance, int time)
        {
            double fare = distance * 10 + time * 1;
            return Math.Max(fare, 5);
        }

    }
    public class InvGeneratormultiplerides
    {
        public double calculatetotalfare(List<Ride> rides)
        {
            double totalfare = 0.0;
            foreach(var  ride in rides)
            {
                totalfare += calculatefare(ride.Distance, ride.Time);
                
            }
            return totalfare;
        }

        private double calculatefare(double distance, int time)
        {
            double fare = distance * 10.0 + time * 1;
            return Math.Max(5, fare);
        }
    }

}