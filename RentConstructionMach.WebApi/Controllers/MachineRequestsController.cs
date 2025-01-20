using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineRequestCommands;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MachineRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachineRequest(CreateMachineRequestCommand command)
        {
            await _mediator.Send(command);
            return Ok("MachineRequest is added..");
        }
    }
}
