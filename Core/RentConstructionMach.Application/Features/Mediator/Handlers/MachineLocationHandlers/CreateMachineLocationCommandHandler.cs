using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineLocationCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineLocationHandlers
{
    public class CreateMachineLocationCommandHandler : IRequestHandler<CreateMachineLocationCommand>
    {
        private readonly IRepository<MachineLocation> _repository;

        public CreateMachineLocationCommandHandler(IRepository<MachineLocation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMachineLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new MachineLocation
            {
                LocationID = request.LocationID,
                MachineID = request.MachineID,

            });

        }
    }
}
