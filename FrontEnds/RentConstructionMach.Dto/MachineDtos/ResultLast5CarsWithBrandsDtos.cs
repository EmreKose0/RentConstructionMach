using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Dto.MachineDtos
{
    public class ResultLast5CarsWithBrandsDtos
    {
        public int MachineID { get; set; }
        //public int MachinePricingID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string ImgUrl { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal MonthlyAmount { get; set; }
    }
}
