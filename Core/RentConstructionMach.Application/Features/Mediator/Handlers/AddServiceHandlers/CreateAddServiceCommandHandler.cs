using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.AddServiceCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.AddServiceHandlers
{
    public class CreateAddServiceCommandHandler : IRequestHandler<CreateAddServiceCommand>
    {
        private readonly IRepository<AddService> _repository;

        public CreateAddServiceCommandHandler(IRepository<AddService> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAddServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AddService
            {
                Name = request.Name
               
            });

        }
    }
}
