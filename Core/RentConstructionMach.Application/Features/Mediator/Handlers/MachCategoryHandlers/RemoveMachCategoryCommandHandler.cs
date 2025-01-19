using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.MachCategorys.Mediator.Handlers.CategoryHandlers
{
    public class RemoveMachCategoryCommandHandler : IRequestHandler<RemoveMachCategoryCommand>
    {
        private readonly IRepository<MachCategory> _repository;

        public RemoveMachCategoryCommandHandler(IRepository<MachCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMachCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
