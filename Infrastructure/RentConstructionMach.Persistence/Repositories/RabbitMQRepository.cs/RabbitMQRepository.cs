using RabbitMQ.Client;
using RentConstructionMach.Application.Interfaces.RabbitMQInterfaces;
using RentConstructionMach.Application.ViewModels;
using RentConstructionMach.Persistence.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Repositories.RabbitMQRepository.cs
{
    public class RabbitMQRepository : IRabbitMQRepository
    {
        private readonly RabbitMQClientService _rabbitMQClientService;

        public RabbitMQRepository(RabbitMQClientService rabbitMQClientService)
        {
            _rabbitMQClientService = rabbitMQClientService;
        }

        public async Task SendMessageAsync( MachineRequestViewModel machineRequest)
        {
            var channel = await _rabbitMQClientService.ConnectAsync();
            
            var bodyString = JsonSerializer.Serialize(machineRequest);

            var msgbody = Encoding.UTF8.GetBytes(bodyString);

            await channel.BasicPublishAsync(
            exchange: RabbitMQClientService.ExchangeName, // Exchange name
            routingKey: RabbitMQClientService.Routing,   // Routing key
            mandatory: false,                            // Mandatory flag
            body: msgbody                                // Message body
        );

        }

        //public async Task SendMessageAsync(string queueName, MachineRequestViewModel machineRequest)
        //{
        //    //var factory = new ConnectionFactory() { HostName = "localhost" };
        //    var factory = new ConnectionFactory();
        //    factory.Uri = new Uri("amqps://ontluugw:PRQ2YOamVQz3lDH8eUk_hkFn4AC-1fUe@seal.lmq.cloudamqp.com/ontluugw");
        //    using (var connection = await factory.CreateConnectionAsync())
        //    {

        //        using var channel = await connection.CreateChannelAsync();

        //        channel.QueueDeclareAsync(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);

        //        var producerJsonString = JsonSerializer.Serialize(machineRequest);

        //        //string msg = "hello-world";

        //        var msgbody = Encoding.UTF8.GetBytes(producerJsonString);
        //        await channel.BasicPublishAsync(exchange: string.Empty, routingKey: queueName, body: msgbody);

        //    }


        //}
    }
}
