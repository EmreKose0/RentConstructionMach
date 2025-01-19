using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class MachCategory
    {
        public int MachCategoryID { get; set; }
        public string Name { get; set; }
        public List<Machine> Machines { get; set; }
    }
}
