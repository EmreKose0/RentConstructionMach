using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Application.Interfaces.CacheInterfaces;
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
        private readonly ICacheService _cacheService;

        public RemoveMachCategoryCommandHandler(IRepository<MachCategory> repository, ICacheService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;
        }

        public async Task Handle(RemoveMachCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);

            var cacheKey = "machineCategories";

            var categoryToRemove = new GetMachCategoryQueryResult
            {
                MachCategoryID = value.MachCategoryID,
                Name = value.Name
            };

            await _cacheService.RemoveFromSetAsync(cacheKey, categoryToRemove);

        }
    }
}
