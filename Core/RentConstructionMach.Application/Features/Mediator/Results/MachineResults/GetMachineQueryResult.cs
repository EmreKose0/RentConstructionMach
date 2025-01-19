using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Results.MachineResults
{
    public class GetMachineQueryResult
    {
        public int MachineID { get; set; }
        public int BrandID { get; set; }
        public int MachCategoryID { get; set; }
        public string Model { get; set; }
        public int WorkingWeight { get; set; }
        public string Description { get; set; }
        public bool AvailabilityStatus { get; set; }
        public string BigImgUrl { get; set; }
        public string StandartImageUrl { get; set; }
        public DateTime ProductionYear { get; set; }
        public int WorkingHours { get; set; }
        public int TransportCapacity { get; set; }
    }
}
