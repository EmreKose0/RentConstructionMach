using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries;
using RentConstructionMach.Application.Features.Mediator.Queries.MachineLocationQueries;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Features.Mediator.Results.MachineLocationResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineLocationHandlers
{
    public class GetMachineLocationQueryHandler : IRequestHandler<GetMachineLocationQuery, List<GetMachineLocationQueryResult>>
    {
        private readonly IRepository<MachineLocation> _repository;

        public GetMachineLocationQueryHandler(IRepository<MachineLocation> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMachineLocationQueryResult>> Handle(GetMachineLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetMachineLocationQueryResult
            {
                MachineLocationID = x.MachineLocationID,
                LocationID = x.LocationID,
                MachineID = x.MachineID,

            }).ToList();

        }
    }
}
