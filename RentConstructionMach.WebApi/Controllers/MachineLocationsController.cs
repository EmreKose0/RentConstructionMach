using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineLocationCommands;
using RentConstructionMach.Application.Features.Mediator.Queries.MachineLocationQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineLocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MachineLocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> MachineLocationList()
        {
            var values = await _mediator.Send(new GetMachineLocationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetMachineLocation(int id)
        {
            var value = await _mediator.Send(new GetMachineLocationByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachineLocation(CreateMachineLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("MachineLocation is added..");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMachineLocation(int id)
        {
            await _mediator.Send(new RemoveMachineLocationCommand(id));
            return Ok("MachineLocation is deleted..");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMachineLocation(UpdateMachineLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("MachineLocation Updated..");
        }
    }
}
