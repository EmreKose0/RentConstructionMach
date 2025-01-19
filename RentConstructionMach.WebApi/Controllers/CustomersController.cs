using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.CostumerCommands;
using RentConstructionMach.Application.Features.Mediator.Queries.CustomerQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CustomerList()
        {
            var values = await _mediator.Send(new GetCustomerQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCustomer(int id)
        {
            var value = await _mediator.Send(new GetCustomerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Customer is added..");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCustomer(int id)
        {
            await _mediator.Send(new RemoveCustomerCommand(id));
            return Ok("Customer is deleted..");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand command)
        {
            await _mediator.Send(command);
            return Ok("Customer Updated..");
        }
    }
}
