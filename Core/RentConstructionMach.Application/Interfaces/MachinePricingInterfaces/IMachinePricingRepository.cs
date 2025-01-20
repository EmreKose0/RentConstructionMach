using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Interfaces.MachineInterfaces
{
    public interface IMachinePricingRepository
    {
        Task<List<MachinePricing>> GetMachinePricingWithMachine();
    }
}
