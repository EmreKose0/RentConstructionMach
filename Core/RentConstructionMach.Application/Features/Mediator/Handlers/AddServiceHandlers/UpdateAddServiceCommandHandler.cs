using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.AddServiceCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.AddServiceHandlers
{
    public class UpdateAddServiceCommandHandler : IRequestHandler<UpdateAddServiceCommand>
    {
        private readonly IRepository<AddService> _repository;

        public UpdateAddServiceCommandHandler(IRepository<AddService> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AddServiceID);
            values.Name = request.Name;


            await _repository.UpdateAsync(values);
        }
    }
}
