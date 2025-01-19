using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineCommands;
using RentConstructionMach.Application.Features.Mediator.Queries.MachineQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MachinesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> MachineList()
        {
            var values = await _mediator.Send(new GetMachineQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetMachine(int id)
        {
            var value = await _mediator.Send(new GetMachineByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachine(CreateMachineCommand command)
        {
            await _mediator.Send(command);
            return Ok("Machine is added..");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMachine(int id)
        {
            await _mediator.Send(new RemoveMachineCommand(id));
            return Ok("Machine is deleted..");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMachine(UpdateMachineCommand command)
        {
            await _mediator.Send(command);
            return Ok("Machine Updated..");
        }
    }
}
