using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.AddServiceCommands
{
    public class RemoveAddServiceCommand : IRequest
    {
        public  int Id { get; set; }

        public RemoveAddServiceCommand(int id)
        {
            Id = id;
        }
    }
}
