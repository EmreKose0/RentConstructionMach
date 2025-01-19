using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineLocationCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineLocationHandlers
{
    public class UpdateMachineLocationCommandHandler : IRequestHandler<UpdateMachineLocationCommand>
    {
        private readonly IRepository<MachineLocation> _repository;

        public UpdateMachineLocationCommandHandler(IRepository<MachineLocation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMachineLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.MachineLocationID);
            values.LocationID = request.LocationID;
            values.MachineID = request.MachineID;


            await _repository.UpdateAsync(values);
        }
    }
}
