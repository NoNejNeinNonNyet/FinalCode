using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.HttpProvider
{
    public class HttpProvider : IHttpProvider
    {
        private readonly HttpClient _httpClient;

        public HttpProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> Get(string uri)
        {
            return _httpClient.GetAsync(uri);
        }

        public Task<HttpResponseMessage> Post(string uri, HttpContent content)
        {
            return _httpClient.PostAsync(uri, content);
        }

        public Task<HttpResponseMessage> Put(string uri, HttpContent content)
        {
            return _httpClient.PutAsync(uri, content);
        }

        public Task<HttpResponseMessage> Delete(string uri)
        {
            return _httpClient.DeleteAsync(uri);
        }
    }
}
