using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Services
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _connectionMultiplexer;
        public IDatabase Database => _connectionMultiplexer.GetDatabase();

        public RedisService(string configuration)
        {
            _connectionMultiplexer = ConnectionMultiplexer.Connect(configuration);
        }
    }
}
