using RentConstructionMach.Application.ViewModels;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Interfaces.MachineRequestInterfaces
{
    public interface IMachineRequestRepository
    {
        Task<(string,string)> GetMachineNameAndBrandAsync(int MachineId);
        Task<string> GetLocationNameAsync(int LocationId);

    }
}
