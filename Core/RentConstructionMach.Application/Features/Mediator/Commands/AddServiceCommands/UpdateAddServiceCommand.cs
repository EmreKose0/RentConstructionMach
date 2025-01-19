using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.AddServiceCommands
{
    public class UpdateAddServiceCommand :IRequest
    {
        public int AddServiceID { get; set; }
        public string Name { get; set; }
    }
}
