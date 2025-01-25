using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Application.Interfaces.CacheInterfaces
{
    public interface ICacheService
    {
        //Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
        //Task<T?> GetAsync<T>(string key);
        //Task RemoveAsync(string key);
        Task AddToSetAsync<T>(string key, T value);

        Task RemoveFromSetAsync<T>(string key, T value);

        Task<List<T>> GetSetMembersAsync<T>(string key);

        Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);

        Task RemoveAsync(string key);
    }
}
