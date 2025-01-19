using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CostumerCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.CustomerHandlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly IRepository<Customer> _repository;

        public RemoveCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
