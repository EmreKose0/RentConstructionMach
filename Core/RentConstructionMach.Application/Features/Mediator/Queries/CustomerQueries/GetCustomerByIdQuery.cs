using MediatR;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Features.Mediator.Results.CustomerResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Queries.CustomerQueries
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
