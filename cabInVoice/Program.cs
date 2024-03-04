using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
   
    public class Program
    {
        static void Main()
        {
            InvGenerator invGenerator = new InvGenerator();
            double fare = invGenerator.claculatefare(10, 20);
            Console.WriteLine("Step 1 - calculate fare " + fare);

            InvGeneratormultiplerides invgeneratorformultipleride = new InvGeneratormultiplerides();
            List<Ride> rides = new List<Ride> {
                new Ride { Distance = 5, Time = 10 },
                new Ride { Distance = 20, Time = 30 },
                new Ride { Distance = 7, Time = 15 }
            };
            double totalfare = invgeneratorformultipleride.calculatetotalfare(rides);
            Console.WriteLine("Step 2 - calculate fare " + totalfare);

            EnhancedInvoicegenerator enhancedinvoicegenerator = new EnhancedInvoicegenerator();
            EnhancedInvoice enhancedinvoice = enhancedinvoicegenerator.GenerateEnhancedInvoice(rides);
            Console.WriteLine("Step 3 - Enhanced invoice - total rides: " + enhancedinvoice.totalrides);
            Console.WriteLine("Step 3 - Enhanced invoice - total fare: " + enhancedinvoice.totalfare);

        }
    }
   
}
