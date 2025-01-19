using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class MachineService
    {
        public int MachineServiceID { get; set; }
        public  int MachineID { get; set; }
        public Machine Machine { get; set; }
        public int AddServiceID { get; set; }
        public AddService  AddService { get; set; }
        public bool Available { get; set; }
    }
}
