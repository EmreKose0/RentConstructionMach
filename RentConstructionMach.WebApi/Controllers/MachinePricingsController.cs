using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Queries.MachinePricingQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinePricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MachinePricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetMachinePricingWithMachineList()
        {
            var values = await _mediator.Send(new GetMachinePricingWithMachineQuery());  
            return Ok(values);
        }

      
    }
}
