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
    public class GetAddServiceByIdQueryHandler : IRequestHandler<GetAddServiceByIdQuery, GetAddServiceByIdQueryResult>
    {
        private readonly IRepository<AddService> _repository;

        public GetAddServiceByIdQueryHandler(IRepository<AddService> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddServiceByIdQueryResult> Handle(GetAddServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetAddServiceByIdQueryResult
            {
                Name = value.Name,
                AddServiceID = value.AddServiceID,
            };
        }
    }
}
