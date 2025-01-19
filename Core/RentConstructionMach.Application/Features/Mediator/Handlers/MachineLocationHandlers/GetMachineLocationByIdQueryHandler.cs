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
    public class GetMachineLocationByIdQueryHandler : IRequestHandler<GetMachineLocationByIdQuery, GetMachineLocationByIdQueryResult>
    {
        private readonly IRepository<MachineLocation> _repository;

        public GetMachineLocationByIdQueryHandler(IRepository<MachineLocation> repository)
        {
            _repository = repository;
        }

        public async Task<GetMachineLocationByIdQueryResult> Handle(GetMachineLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetMachineLocationByIdQueryResult
            {
                MachineLocationID = values.MachineLocationID,
                LocationID = values.LocationID,
                MachineID = values.MachineID,
            };
        }
    }
}
