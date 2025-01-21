using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RentConstructionMach.Application.Features.Mediator.Commands.MachineRequestCommands;
using RentConstructionMach.Application.ViewModels;
using RentConstructionMach.Domain.Entities;
using System.Text;
using System.Text.Json;

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

            //var factory = new ConnectionFactory();
            //factory.Uri = new Uri("amqps://ontluugw:PRQ2YOamVQz3lDH8eUk_hkFn4AC-1fUe@seal.lmq.cloudamqp.com/ontluugw");

            //using (var connection = await factory.CreateConnectionAsync())
            //{

            //    using var channel = await connection.CreateChannelAsync();
            //    await channel.QueueDeclareAsync(queue: "", durable: true, exclusive: false, autoDelete: false, arguments: null);
            //    //durable : rabbitmq restart atıldıgında q nun bozulmaması ıcın true, exclusive: dısarıdan baglanmak ıcın false,  autoDelete: consumer down olursak kuyruk silinmemesi icin false,
            //    string msg = "hello-world";

            //    var msgbody = Encoding.UTF8.GetBytes(msg);
            //    await channel.BasicPublishAsync(exchange: string.Empty,routingKey: "hello-queue", body: msgbody);
            //    //exchange kullanmadık, routingkey ile kuyruk ismi eşleşmeli mutlaka
            //    Console.WriteLine("MEsaj gonderılmıstır");
            //    Console.ReadLine();
            //}
            //var value = 
            //MachineRequestViewModel machineRequestViewModel = new MachineRequestViewModel();
            //machineRequestViewModel.StartDate = command.StartDate;
            //machineRequestViewModel.EndDate = command.EndDate;  
            //machineRequestViewModel.MachineName = command.MachineID.;

            //var factory = new ConnectionFactory
            //{
            //    Uri = new Uri(_hostname),
            //    UserName = _username,
            //    Password = _password
            //};

            //using var connection = factory.CreateConnection();
            //using var channel = connection.CreateModel();

            //channel.QueueDeclare(queue: _queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);

            //var messageBody = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(customer));
            //channel.BasicPublish(exchange: "", routingKey: _queueName, basicProperties: null, body: messageBody);

            return Ok("MachineRequest is added..");
        }
    }
}
