using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineRequestCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Application.Interfaces.MachineRequestInterfaces;
using RentConstructionMach.Application.Interfaces.RabbitMQInterfaces;
using RentConstructionMach.Application.ViewModels;
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
        private readonly IMachineRequestRepository _machineRequestRepository;
        private readonly IRepository<MachineRequest> _repository;
        private readonly IRabbitMQRepository _rabbitMqRepository;

        public CreateMachineRequestCommandHandler(IRepository<MachineRequest> repository, IRabbitMQRepository rabbitMqRepository, IMachineRequestRepository machineRequestRepository)
        {
            _repository = repository;
            _rabbitMqRepository = rabbitMqRepository;
            _machineRequestRepository = machineRequestRepository;
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
            var (model, brand) = await _machineRequestRepository.GetMachineNameAndBrandAsync(request.MachineID);
            var LocationName = await _machineRequestRepository.GetLocationNameAsync(request.LocationID);


            var viewModel = new MachineRequestViewModel {
                MachineID = request.MachineID,
                Model = model,
                Brand = brand,
                Quantity = request.Quantity,
                LocationID = request.LocationID,
                LocationName = LocationName,
                DistrictName = request.DistrictName,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Description = request.Description,
                CustomerName = request.CustomerName,
                CustomerSurname = request.CustomerSurname,
                Email = request.Email,
                Phone = request.Phone,
                CompanyName = request.CompanyName,

            };

            await _rabbitMqRepository.SendMessageAsync(viewModel);
            //await _rabbitMqRepository.SendMessageAsync("MachineQueue", viewModel);


        }
    }
}


