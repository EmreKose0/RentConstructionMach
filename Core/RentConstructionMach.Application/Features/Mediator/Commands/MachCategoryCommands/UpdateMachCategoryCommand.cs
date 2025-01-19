using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.MachCategoryCommands
{
    public class UpdateMachCategoryCommand : IRequest
    {
        public int MachCategoryID { get; set; }
        public string Name { get; set; }
    }
}
