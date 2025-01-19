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
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly IRepository<Customer> _repository;

        public UpdateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CustomerID);
            values.Phone = request.Phone;
            values.Email = request.Email;
            values.CustomerSurname = request.CustomerSurname;
            values.CustomerName = request.CustomerName;
            values.CompanyName = request.CompanyName;


            await _repository.UpdateAsync(values);
        }
    }
}
