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
    public class GetCustomerQueryHandler :IRequestHandler<GetCustomerQuery, List<GetCustomerQueryResult>>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomerQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCustomerQueryResult>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCustomerQueryResult
            {
                Email = x.Email,
                CustomerID = x.CustomerID,
                Phone = x.Phone,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname,
                CompanyName = x.CompanyName

            }).ToList();
        }
    }
}
