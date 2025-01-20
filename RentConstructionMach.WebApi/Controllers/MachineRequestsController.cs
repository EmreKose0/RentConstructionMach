using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineRequestCommands;
using System.Text;

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

            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqps://ontluugw:PRQ2YOamVQz3lDH8eUk_hkFn4AC-1fUe@seal.lmq.cloudamqp.com/ontluugw");

            using (var connection = await factory.CreateConnectionAsync())
            {

                using var channel = await connection.CreateChannelAsync();
                await channel.QueueDeclareAsync(queue: "", durable: true, exclusive: false, autoDelete: false, arguments: null);
                //durable : rabbitmq restart atıldıgında q nun bozulmaması ıcın true, exclusive: dısarıdan baglanmak ıcın false,  autoDelete: consumer down olursak kuyruk silinmemesi icin false,
                string msg = "hello-world";

                var msgbody = Encoding.UTF8.GetBytes(msg);
                await channel.BasicPublishAsync(exchange: string.Empty,routingKey: "hello-queue", body: msgbody);
                //exchange kullanmadık, routingkey ile kuyruk ismi eşleşmeli mutlaka
                Console.WriteLine("MEsaj gonderılmıstır");
                Console.ReadLine();
            }
            

                return Ok("MachineRequest is added..");
        }
    }
}
