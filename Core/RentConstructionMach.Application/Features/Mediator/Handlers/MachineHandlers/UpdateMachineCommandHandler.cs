using MediatR;
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
    public class UpdateMachineCommandHandler : IRequestHandler<UpdateMachineCommand>
    {
        private readonly IRepository<Machine> _repository;

        public UpdateMachineCommandHandler(IRepository<Machine> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMachineCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.MachineID);
            values.BrandID = request.BrandID;
            values.MachCategoryID = request.MachCategoryID;
            values.Model = request.Model;
            values.WorkingWeight = request.WorkingWeight;
            values.Description = request.Description;
            values.AvailabilityStatus = request.AvailabilityStatus;
            values.BigImgUrl = request.BigImgUrl;
            values.StandartImageUrl = request.StandartImageUrl;
            values.ProductionYear = request.ProductionYear;
            values.WorkingHours = request.WorkingHours;
            values.TransportCapacity = request.TransportCapacity;


            await _repository.UpdateAsync(values);
        }
    }
}
