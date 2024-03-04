using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
    public class EnhancedInvoice
    {
        public int totalrides {  get; set; }
        public double totalfare { get; set; }
        public double averagefare {  get; set; }
    }
    public class EnhancedInvoicegenerator
    {
        public EnhancedInvoice GenerateEnhancedInvoice(List<Ride> rides)
        {
            var invoice = new EnhancedInvoice();
            invoice.totalrides = rides.Count;
            invoice.totalfare = rides.Sum(ride => calculatefare(ride.Distance, ride.Time));
            invoice.averagefare = invoice.totalfare / invoice.totalrides;
            return invoice;
        }
        private double calculatefare(double distance, int time)
        {
            double fare = distance * 10.0 + time * 1;
            return Math.Max(5, fare);
        }
    }
}
