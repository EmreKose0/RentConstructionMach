using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class CreateMachCategoryCommandHandler : IRequestHandler<CreateMachCategoryCommand>
    {
        private readonly IRepository<MachCategory> _repository;

        public CreateMachCategoryCommandHandler(IRepository<MachCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMachCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new MachCategory
            {
                Name = request.Name

            }); 

        }
    }
}
