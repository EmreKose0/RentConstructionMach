using MediatR;
using RentConstructionMach.Application.Features.Mediator.Queries.MachinePricingQueries;
using RentConstructionMach.Application.Features.Mediator.Results.MachinePricingResults;
using RentConstructionMach.Application.Interfaces.MachineInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Features.Mediator.Handlers.MachinePricingHandlers
{
    public class GetMachinePricingWithMachineQueryHandler : IRequestHandler<GetMachinePricingWithMachineQuery, List<GetMachinePricingWithMachineQueryResult>>
    {
        private readonly IMachinePricingRepository _repository;

        public GetMachinePricingWithMachineQueryHandler(IMachinePricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMachinePricingWithMachineQueryResult>> Handle(GetMachinePricingWithMachineQuery request, CancellationToken cancellationToken)
        {
            //var values = await _repository.GetMachinePricingWithMachine();
            //return values.Select(x => new GetMachinePricingWithMachineQueryResult
            //{
            //    //MachinePricingID = x.MachinePricingID,
            //    MachineID = x.MachineID,
            //    BrandName = x.Machine.Brand.BrandName,
            //    Model = x.Machine.Model,
            //    ImgUrl = x.Machine.StandartImageUrl,
            //    DailyAmount = x.Pricing.PricingID == 1 ? x.Amount:0, // PricingId günlük ise Amount'u ata
            //    MonthlyAmount = x.Pricing.PricingID == 2 ? x.Amount : 0 // PricingId aylık ise Amount'u ata

            //}).ToList();
            var values = await _repository.GetMachinePricingWithMachine();

            var groupedValues = values
                .GroupBy(x => x.MachineID) // MachineID'ye göre gruplandır
                .Select(g => new GetMachinePricingWithMachineQueryResult
                {
                    MachineID = g.Key,
                    BrandName = g.First().Machine.Brand.BrandName,
                    Model = g.First().Machine.Model,
                    ImgUrl = g.First().Machine.StandartImageUrl,
                    DailyAmount = g.FirstOrDefault(x => x.Pricing.PricingID == 1)?.Amount ?? 0, // Günlük fiyat
                    MonthlyAmount = g.FirstOrDefault(x => x.Pricing.PricingID == 2)?.Amount ?? 0 // Aylık fiyat
                })
                .ToList();

            return groupedValues;

        }
    }
}


