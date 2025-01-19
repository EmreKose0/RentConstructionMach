using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class MachineRequest
    {
        public int MachineRequestID { get; set; }
        public int MachineID { get; set; }
        public Machine Machine { get; set; }
        public int Quantity { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public string DistrictName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public decimal? TotalPrice { get; set; }


    }
}
