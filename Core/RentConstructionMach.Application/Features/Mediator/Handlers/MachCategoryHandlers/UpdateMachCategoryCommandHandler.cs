using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Commands.MachCategoryCommands;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.MachCategorys.Mediator.Handlers.CategoryHandlers
{
    public class UpdateMachCategoryCommandHandler : IRequestHandler<UpdateMachCategoryCommand>
    {
        private readonly IRepository<MachCategory> _repository;

        public UpdateMachCategoryCommandHandler(IRepository<MachCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMachCategoryCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.MachCategoryID);
            values.Name = request.Name;


            await _repository.UpdateAsync(values);
        }
    }
}
