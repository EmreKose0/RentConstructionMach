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
    public class GetMachineByIdQueryHandler : IRequestHandler<GetMachineByIdQuery, GetMachineByIdQueryResult>
    {
        private readonly IRepository<Machine> _repository;

        public GetMachineByIdQueryHandler(IRepository<Machine> repository)
        {
            _repository = repository;
        }

        public async Task<GetMachineByIdQueryResult> Handle(GetMachineByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetMachineByIdQueryResult
            {
                MachineID = values.MachineID,
                BrandId = values.BrandID,
                MachCategoryID = values.MachCategoryID,
                Model = values.Model,
                WorkingWeight = values.WorkingWeight,
                Description = values.Description,
                AvailabilityStatus = values.AvailabilityStatus,
                BigImgUrl = values.BigImgUrl,
                StandartImageUrl = values.StandartImageUrl,
                ProductionYear = values.ProductionYear,
                WorkingHours = values.WorkingHours,
                TransportCapacity = values.TransportCapacity,
            };
        }
    }
}

