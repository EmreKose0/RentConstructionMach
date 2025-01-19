using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string PricingName { get; set; }
        public List<MachinePricing> MachinePricing { get; set; }
    }
}
