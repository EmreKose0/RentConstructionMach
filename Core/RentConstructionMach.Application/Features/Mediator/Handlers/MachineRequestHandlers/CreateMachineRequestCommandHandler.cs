using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineRequestCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachineRequestHandlers
{
    public class CreateMachineRequestCommandHandler : IRequestHandler<CreateMachineRequestCommand>
    {
        private readonly IRepository<MachineRequest> _repository;

        public CreateMachineRequestCommandHandler(IRepository<MachineRequest> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMachineRequestCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new MachineRequest
            {
                MachineID = request.MachineID,
                Quantity = request.Quantity,
                LocationID = request.LocationID,
                DistrictName = request.DistrictName,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Description = request.Description,
                Status = "Talep Alındı",
                CustomerName = request.CustomerName,
                CustomerSurname = request.CustomerSurname,
                Email = request.Email,
                Phone = request.Phone,
                CompanyName = request.CompanyName,

            });
        }
    }
}

