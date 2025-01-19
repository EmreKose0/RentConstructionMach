using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries;
using RentConstructionMach.Application.Features.Mediator.Results.CategoryResults;
using RentConstructionMach.Application.Interfaces;
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

        public GetMachCategoryQueryHandler(IRepository<MachCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMachCategoryQueryResult>> Handle(GetMachCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetMachCategoryQueryResult
            {
                MachCategoryID = x.MachCategoryID,
                Name = x.Name

            }).ToList();

        }
    }
}
