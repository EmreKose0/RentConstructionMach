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
    public class GetMachCategoryByIdQueryHandler : IRequestHandler<GetMachCategoryByIdQuery, GetMachCategoryByIdQueryResult>
    {
        private readonly IRepository<MachCategory> _repository;

        public GetMachCategoryByIdQueryHandler(IRepository<MachCategory> repository)
        {
            _repository = repository;
        }

        public async Task<GetMachCategoryByIdQueryResult> Handle(GetMachCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetMachCategoryByIdQueryResult
            {
                MachCategoryID = values.MachCategoryID,
                Name = values.Name
            };
        }
    }
}
