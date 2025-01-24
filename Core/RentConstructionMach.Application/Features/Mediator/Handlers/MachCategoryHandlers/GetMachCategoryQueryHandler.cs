using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries;
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
    public class GetMachCategoryQueryHandler : IRequestHandler<GetMachCategoryQuery, List<GetMachCategoryQueryResult>>    
    {
        private readonly IRepository<MachCategory> _repository;
        private readonly ICacheService _cacheService;

        public GetMachCategoryQueryHandler(IRepository<MachCategory> repository, ICacheService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;
        }

        public async Task<List<GetMachCategoryQueryResult>> Handle(GetMachCategoryQuery request, CancellationToken cancellationToken)
        {
            var cacheKey = "machineCategories";
            var cachedData = await _cacheService.GetAsync<List<GetMachCategoryQueryResult>>(cacheKey);

            if (cachedData != null)
            {
                return cachedData;
            }


            var values = await _repository.GetAllAsync();

            var machineCategories = values.Select(x => new GetMachCategoryQueryResult
            {
                MachCategoryID = x.MachCategoryID,
                Name = x.Name

            }).ToList();

            await _cacheService.SetAsync(cacheKey, machineCategories, TimeSpan.FromMinutes(30));

            return machineCategories;
        }
    }
}
