using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries;
using RentConstructionMach.Application.Features.Mediator.Queries.MachineQueries;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Features.Mediator.Results.MachineResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineHandlers
{
    public class GetMachineQueryHandler : IRequestHandler<GetMachineQuery, List<GetMachineQueryResult>>
    {
        private readonly IRepository<Machine> _repository;

        public GetMachineQueryHandler(IRepository<Machine> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMachineQueryResult>> Handle(GetMachineQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetMachineQueryResult
            {
                MachineID = x.MachineID,
                BrandID = x.BrandID,
                MachCategoryID = x.MachCategoryID,
                Model = x.Model,
                WorkingWeight = x.WorkingWeight,
                Description = x.Description,
                AvailabilityStatus = x.AvailabilityStatus,
                BigImgUrl = x.BigImgUrl,
                StandartImageUrl = x.StandartImageUrl,
                ProductionYear = x.ProductionYear,
                WorkingHours = x.WorkingHours,
                TransportCapacity = x.TransportCapacity,

            }).ToList();

        }
    }
}
