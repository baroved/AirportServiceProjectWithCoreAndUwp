using System;
using System.Threading.Tasks;

namespace Extend
{
    public interface IHttpService
    {
        Task<R> PostAsync<T, R>(string url, T payload, string token = "");
        Task<R> GetAsync<R>(string url, string token = "");
    }
}
