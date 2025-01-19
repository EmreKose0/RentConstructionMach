using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineHandlers
{
    public class CreateMachineCommandHandler : IRequestHandler<CreateMachineCommand>
    {
        private readonly IRepository<Machine> _repository;

        public CreateMachineCommandHandler(IRepository<Machine> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMachineCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Machine
            {
                BrandID = request.BrandID,
                BigImgUrl = request.BigImgUrl,
                AvailabilityStatus = request.AvailabilityStatus,
                Description = request.Description,
                MachCategoryID = request.MachCategoryID,
                Model = request.Model,
                WorkingWeight = request.WorkingWeight,
                WorkingHours = request.WorkingHours,
                StandartImageUrl = request.StandartImageUrl,
                ProductionYear = request.ProductionYear,
                TransportCapacity = request.TransportCapacity

            });

        }
    }
}



