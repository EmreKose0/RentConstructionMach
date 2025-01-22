using RentConstructionMach.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Interfaces.RabbitMQInterfaces
{
    public interface IRabbitMQRepository
    {
        Task SendMessageAsync(MachineRequestViewModel machineRequest);
    }
}
