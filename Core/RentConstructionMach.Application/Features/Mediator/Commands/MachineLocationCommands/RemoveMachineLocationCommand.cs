using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.MachineLocationCommands
{
    public class RemoveMachineLocationCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMachineLocationCommand(int id)
        {
            Id = id;
        }
    }
}
