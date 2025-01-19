using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentConstructionMach.Application.Features.Mediator.Commands.CategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Commands.MachCategoryCommands;
using RentConstructionMach.Application.Features.Mediator.Queries.CategoryQueries;

namespace RentConstructionMach.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MachCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> MachCategoryList()
        {
            var values = await _mediator.Send(new GetMachCategoryQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetMachCategory(int id)
        {
            var value = await _mediator.Send(new GetMachCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachCategory(CreateMachCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("MachCategory is added..");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMachCategory(int id)
        {
            await _mediator.Send(new RemoveMachCategoryCommand(id));
            return Ok("MachCategory is deleted..");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMachCategory(UpdateMachCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("MachCategory Updated..");
        }
    }
}
