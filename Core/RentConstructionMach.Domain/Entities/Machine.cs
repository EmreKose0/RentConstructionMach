using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Domain.Entities
{
    public class Machine
    {
        public int MachineID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public int MachCategoryID { get; set; }
        public MachCategory MachCategory { get; set; }
        public string Model { get; set; }
        public int WorkingWeight { get; set; }
        public string   Description { get; set; }
        public bool AvailabilityStatus { get; set; }

        public string BigImgUrl{ get; set; }
        public string StandartImageUrl{ get; set; }
        public DateTime ProductionYear { get; set; }
        public int WorkingHours { get; set; }
        public int TransportCapacity { get; set; }
        public List<MachineService> MachineServices { get; set; }
        public List<MachinePricing> MachinePricing { get; set; }
        public List<MachineRequest> MachineRequest { get; set; }
        public List<MachineLocation> MachineLocations { get; set; }


    }
}
