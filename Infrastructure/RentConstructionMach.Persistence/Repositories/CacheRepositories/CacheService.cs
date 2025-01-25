using Microsoft.EntityFrameworkCore.Storage;
using RentConstructionMach.Application.Interfaces.CacheInterfaces;
using RentConstructionMach.Persistence.Context;
using RentConstructionMach.Persistence.Services;
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
        //private readonly IDatabase _database;
        private readonly RedisService _redisService;

        public CacheService( RedisService redisService) //IConnectionMultiplexer redis,
        {
            //_database = redis.GetDatabase();
            _redisService = redisService;
        }



        //public async Task<T?> GetAsync<T>(string key)
        //{
        //    var jsonData = await _redisService.Database.StringGetAsync(key);
        //    if (jsonData.IsNullOrEmpty) return default;

        //    return JsonSerializer.Deserialize<T>(jsonData);

        //}

        //public async Task RemoveAsync(string key)
        //{
        //    await _redisService.Database.KeyDeleteAsync(key);

        //}

        //public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        //{
        //    var jsonData = JsonSerializer.Serialize(value);
        //    await _redisService.Database.StringSetAsync(key,jsonData,expiry);
        //}


        public async Task AddToSetAsync<T>(string key, T value)
        {
            var jsonData = JsonSerializer.Serialize(value);
            var added = await _redisService.Database.SetAddAsync(key, jsonData);

            if (added)
            {
                Console.WriteLine($"'{value}' set'e eklendi.");
            }
            else
            {
                Console.WriteLine($"'{value}' zaten set'te var.");
            }
        }

        public async Task RemoveFromSetAsync<T>(string key, T value)
        {
            var jsonData = JsonSerializer.Serialize(value);
            var removed = await _redisService.Database.SetRemoveAsync(key, jsonData);

            if (removed)
            {
                Console.WriteLine($"'{value}' set'ten silindi.");
            }
            else
            {
                Console.WriteLine($"'{value}' set'te bulunamadı.");
            }
        }

        public async Task<List<T>> GetSetMembersAsync<T>(string key)
        {
            var members = await _redisService.Database.SetMembersAsync(key);
            var result = new List<T>();

            foreach (var member in members)
            {
                var item = JsonSerializer.Deserialize<T>(member);
                if (item != null)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            var jsonData = JsonSerializer.Serialize(value);
            await _redisService.Database.SetAddAsync(key, jsonData);  
        }

        public async Task RemoveAsync(string key)
        {
            await _redisService.Database.KeyDeleteAsync(key); 
        }
    }
}
