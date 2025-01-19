using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands
{
    public class CreateMachCategoryCommand :IRequest
    {
        public string Name { get; set; }
    }
}
