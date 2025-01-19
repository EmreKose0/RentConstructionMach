using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineHandlers
{
    public class RemoveMachineCommandHandler : IRequestHandler<RemoveMachineCommand>
    {
        private readonly IRepository<Machine> _repository;

        public RemoveMachineCommandHandler(IRepository<Machine> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMachineCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
