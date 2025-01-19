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
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly IRepository<Customer> _repository;

        public CreateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Customer
            {
                CompanyName = request.CompanyName,
                CustomerName = request.CustomerName,
                CustomerSurname = request.CustomerSurname,
                Email = request.Email,
                Phone = request.Phone                
            });

        }
    }
}
