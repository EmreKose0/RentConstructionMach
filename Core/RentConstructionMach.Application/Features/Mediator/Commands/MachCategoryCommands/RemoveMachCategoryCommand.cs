using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands
{
    public class RemoveMachCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMachCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
