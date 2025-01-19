using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.MachineCommands
{
    public class RemoveMachineCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMachineCommand(int id)
        {
            Id = id;
        }
    }
}
