using System.Net.Http;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IHttpProvider
    {
        Task<HttpResponseMessage> Get(string uri);
        Task<HttpResponseMessage> Post(string uri, HttpContent content);
        Task<HttpResponseMessage> Put(string uri, HttpContent content);
        Task<HttpResponseMessage> Delete(string uri);
    }
}
