using Microsoft.EntityFrameworkCore;
using RentConstructionMach.Application.Interfaces.MachineInterfaces;
using RentConstructionMach.Domain.Entities;
using RentConstructionMach.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Repositories.MachinePricingRepositories
{
    public class MachinePricingRepository : IMachinePricingRepository
    {
        private readonly RentConstructionMachContext _context;

        public MachinePricingRepository(RentConstructionMachContext context)
        {
            _context = context;
        }

        public async Task<List<MachinePricing>> GetMachinePricingWithMachine()
        {
            var values = await _context.MachinePricings.Include(z=>z.Pricing).Include(p => p.Machine).ThenInclude(y=>y.Brand).ToListAsync();
            return values;
        }
    }
}
