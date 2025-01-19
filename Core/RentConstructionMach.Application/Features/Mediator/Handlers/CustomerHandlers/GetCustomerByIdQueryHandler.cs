using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.CustomerQueries;
using RentConstructionMach.Application.Features.Mediator.Results.CustomerResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.CustomerHandlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomerByIdQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCustomerByIdQueryResult
            {
                Email = value.Email,
                CustomerID = value.CustomerID,
                Phone = value.Phone,
                CompanyName = value.CompanyName,
                CustomerSurname = value.CustomerSurname,
                CustomerName = value.CustomerName
               
            };
        }
    }
}
