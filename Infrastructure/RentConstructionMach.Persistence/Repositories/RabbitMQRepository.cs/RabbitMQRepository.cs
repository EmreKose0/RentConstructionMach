using RabbitMQ.Client;
using RentConstructionMach.Application.Interfaces.RabbitMQInterfaces;
using RentConstructionMach.Application.ViewModels;
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
        public async Task SendMessageAsync(string queueName, MachineRequestViewModel machineRequest)
        {
            //var factory = new ConnectionFactory() { HostName = "localhost" };
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqps://ontluugw:PRQ2YOamVQz3lDH8eUk_hkFn4AC-1fUe@seal.lmq.cloudamqp.com/ontluugw");
            using (var connection = await factory.CreateConnectionAsync())
            {

                using var channel = await connection.CreateChannelAsync();

                channel.QueueDeclareAsync(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);

                var producerJsonString = JsonSerializer.Serialize(machineRequest);

                //string msg = "hello-world";

                var msgbody = Encoding.UTF8.GetBytes(producerJsonString);
                await channel.BasicPublishAsync(exchange: string.Empty, routingKey: queueName, body: msgbody);

            }

            
        }
    }
}
