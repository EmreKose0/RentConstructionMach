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
    public class RemoveMachineLocationCommandHandler : IRequestHandler<RemoveMachineLocationCommand>
    {
        private readonly IRepository<MachineLocation> _repository;

        public RemoveMachineLocationCommandHandler(IRepository<MachineLocation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMachineLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
