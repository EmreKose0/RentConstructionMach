using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.AddServiceQueries;
using RentConstructionMach.Application.Features.Mediator.Results.AddServiceResults;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.AddServiceHandlers
{
    public class GetAddServiceQueryHandler : IRequestHandler<GetAddServiceQuery, List<GetAddServiceQueryResult>>
    {
        private readonly IRepository<AddService> _repository;

        public GetAddServiceQueryHandler(IRepository<AddService> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddServiceQueryResult>> Handle(GetAddServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAddServiceQueryResult
            {
                Name = x.Name,
                AddServiceID = x.AddServiceID

            }).ToList();
        }
    }
}
