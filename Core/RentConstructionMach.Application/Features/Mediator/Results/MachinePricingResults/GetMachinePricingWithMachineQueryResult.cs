using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Results.MachinePricingResults
{
    public class GetMachinePricingWithMachineQueryResult
    {
        public int MachineID { get; set; }
        //public int MachinePricingID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string ImgUrl { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal MonthlyAmount { get; set; }
        //public string PricingName { get; set; }

    }
}
