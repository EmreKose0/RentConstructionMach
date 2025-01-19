using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.AddServiceCommands;
using RentConstructionMach.Application.Features.Mediator.Queries.AddServiceQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AddServiceList()
        {
            var values = await _mediator.Send(new GetAddServiceQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAddService(int id)
        {
            var value = await _mediator.Send(new GetAddServiceByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddService(CreateAddServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("AddService is added..");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddService(int id)
        {
            await _mediator.Send(new RemoveAddServiceCommand(id));
            return Ok("AddService is deleted..");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddService(UpdateAddServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("AddService Updated..");
        }
    }
}
