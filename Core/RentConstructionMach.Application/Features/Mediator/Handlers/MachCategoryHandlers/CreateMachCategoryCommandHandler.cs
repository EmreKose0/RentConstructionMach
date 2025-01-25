using MediatR;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Application.Interfaces.CacheInterfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class CreateMachCategoryCommandHandler : IRequestHandler<CreateMachCategoryCommand>
    {
        private readonly IRepository<MachCategory> _repository;
        private readonly ICacheService _cacheService;


        public CreateMachCategoryCommandHandler(IRepository<MachCategory> repository, ICacheService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;
        }

        public async Task Handle(CreateMachCategoryCommand request, CancellationToken cancellationToken)
        {
            var existingCategory = await _repository.GetByFilterAsync(x => x.Name == request.Name);
            if (existingCategory != null)
            {
                return;
            }

            var newCategory = new MachCategory
            {
                Name = request.Name
            };
            await _repository.CreateAsync(newCategory);

            var cacheKey = "machineCategories";
            //var machineCategories = await _repository.GetAllAsync();
            var existingCategories = await _cacheService.GetSetMembersAsync<GetMachCategoryQueryResult>(cacheKey);


            //var categoryResults = machineCategories.Select(c => new GetMachCategoryQueryResult
            //{
            //    MachCategoryID = c.MachCategoryID,
            //    Name = c.Name
            //}).ToList();
            var newCategoryResult = new GetMachCategoryQueryResult
            {
                MachCategoryID = newCategory.MachCategoryID,
                Name = newCategory.Name
            };

            //await _cacheService.SetAsync(cacheKey, categoryResults, TimeSpan.FromMinutes(30));
            await _cacheService.AddToSetAsync(cacheKey, newCategoryResult);


        }
    }
}
