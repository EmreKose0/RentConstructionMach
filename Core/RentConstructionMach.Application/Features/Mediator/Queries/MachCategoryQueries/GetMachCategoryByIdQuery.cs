using MediatR;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Features.Mediator.Results.FooterAddressResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetMachCategoryByIdQuery : IRequest<GetMachCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMachCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
