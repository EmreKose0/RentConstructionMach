using Microsoft.EntityFrameworkCore.Storage;
using RentConstructionMach.Application.Interfaces.CacheInterfaces;
using RentConstructionMach.Persistence.Context;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using IDatabase = StackExchange.Redis.IDatabase;

namespace RentConstructionMach.Persistence.Repositories.CacheRepositories
{
    public class CacheService : ICacheService
    {
        private readonly IDatabase _database;

        public CacheService(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();
        }

      

        public async Task<T?> GetAsync<T>(string key)
        {
            var jsonData = await _database.StringGetAsync(key);
            if (jsonData.IsNullOrEmpty) return default;
            
            return JsonSerializer.Deserialize<T>(jsonData);
             
        }

        public async Task RemoveAsync(string key)
        {
            await _database.KeyDeleteAsync(key);

        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            var jsonData = JsonSerializer.Serialize(value);
            await _database.StringSetAsync(key,jsonData,expiry);
        }
    }
}
