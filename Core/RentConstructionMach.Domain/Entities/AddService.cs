using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class AddService
    {
        public int AddServiceID { get; set; }
        public string Name { get; set; }
        public List<MachineService> MachineServices { get; set; }
    }
}
