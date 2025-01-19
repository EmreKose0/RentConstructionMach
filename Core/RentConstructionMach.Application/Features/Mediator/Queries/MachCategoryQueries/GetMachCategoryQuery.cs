using MediatR;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetMachCategoryQuery  :IRequest<List<GetMachCategoryQueryResult>>
    {
    }
}
