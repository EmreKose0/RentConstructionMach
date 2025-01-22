using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using System;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Managers
{
    public class RabbitMQClientService : IDisposable
    {
        private readonly ConnectionFactory _connectionFactory;
        private IConnection _connection;
        private IChannel _channel;
        public static string ExchangeName = "MachineExchange";
        public static string Routing = "Machine-Route";
        public static string QueueName = "Machine-Queue";

        private readonly ILogger<RabbitMQClientService> _logger;

        public RabbitMQClientService(ConnectionFactory connectionFactory, ILogger<RabbitMQClientService> logger)
        {
            _connectionFactory = connectionFactory;
            _logger = logger;
        }

        public async Task<IChannel> ConnectAsync()
        {
            _connection = await _connectionFactory.CreateConnectionAsync();
            _channel = await _connection.CreateChannelAsync();

            await _channel.QueueDeclareAsync(queue: QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            await _channel.ExchangeDeclareAsync(exchange: ExchangeName, type: "direct", durable: true, autoDelete: false);
            await _channel.QueueBindAsync(queue: QueueName, exchange: ExchangeName, routingKey: Routing);

            _logger.LogInformation("RabbitMQ Connected.");

            return _channel;
        }

        public void Dispose()
        {
            _channel?.Dispose();
            _connection?.Dispose();

            _logger.LogInformation("RabbitMQ Disconnected.");
        }
    }
}
