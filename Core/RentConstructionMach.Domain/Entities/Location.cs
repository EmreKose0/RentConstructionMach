using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string City { get; set; }
        public List<MachineRequest> MachineRequests { get; set; }
    }
}
