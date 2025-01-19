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
    public class RemoveAddServiceCommandHandler : IRequestHandler<RemoveAddServiceCommand>
    {
        private readonly IRepository<AddService> _repository;

        public RemoveAddServiceCommandHandler(IRepository<AddService> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
