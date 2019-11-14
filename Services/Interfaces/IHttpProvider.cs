using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
