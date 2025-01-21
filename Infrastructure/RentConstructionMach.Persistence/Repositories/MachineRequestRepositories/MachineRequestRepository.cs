using Microsoft.EntityFrameworkCore;
using RentConstructionMach.Application.Interfaces.MachineRequestInterfaces;
using RentConstructionMach.Application.ViewModels;
using RentConstructionMach.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Repositories.MachineRequestRepositories
{
    public class MachineRequestRepository : IMachineRequestRepository
    {
        private readonly RentConstructionMachContext _context;

        public MachineRequestRepository(RentConstructionMachContext context)
        {
            _context = context;
        }

        public async Task<string> GetLocationNameAsync(int LocationId)
        {
            var data =await _context.Locations.FindAsync(LocationId);
            return data.City.ToString();
        }

        public async Task<(string, string)> GetMachineNameAndBrandAsync(int MachineId)
        {
            var data = await _context.Machines
                    .Where(x => x.MachineID == MachineId)
                    .Select(x => new { x.Model, BrandName = x.Brand.BrandName })
                    .FirstOrDefaultAsync();

            if (data == null) throw new Exception("Machine not found.");
            return (data.Model, data.BrandName);
        }

        
    }
}
