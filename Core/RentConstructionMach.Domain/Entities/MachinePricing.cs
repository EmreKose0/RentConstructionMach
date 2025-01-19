using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class MachinePricing
    {
        public int MachinePricingID { get; set; }
        public int MachineID { get; set; }
        public Machine Machine { get; set; }
        public int PricingID { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; } 

    }
}
