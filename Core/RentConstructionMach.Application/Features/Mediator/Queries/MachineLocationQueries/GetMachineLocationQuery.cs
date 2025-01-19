using MediatR;
using RentConstructionMach.Application.Features.Mediator.Results.MachineLocationResults;
using RentConstructionMach.Application.Features.Mediator.Results.MachineResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Queries.MachineLocationQueries
{
    public class GetMachineLocationQuery : IRequest<List<GetMachineLocationQueryResult>>
    {
    }
}
