using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Results.MachineLocationResults
{
   public class GetMachineLocationByIdQueryResult
    {
        public int MachineLocationID { get; set; }
        public int MachineID { get; set; }
        public int LocationID { get; set; }
    }
}
