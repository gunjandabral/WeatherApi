using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace WeatherApi.Helpers
{

    public class ApiClient : IApiClient
    {
        private IContextHelper _context=new ContextHelper();

        private HttpClient _httpClient = Base._apiClient;

        public HttpResponseMessage Get(string endPoint, Dictionary<string,string> urlParameters=null)
        {
            var urlWithEndPoint = CombineUriToString(_httpClient.BaseAddress.ToString(), endPoint);
            var finalUrl=Extensions.AppendParameters(urlWithEndPoint, urlParameters);
            var request = new HttpRequestMessage(new HttpMethod("GET"), finalUrl);
            return SendRequest(request);
        }

        public HttpResponseMessage Post(string url, object payload)
        {
            var json = JsonConvert.SerializeObject(payload);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(new HttpMethod("POST"), url) { Content = content };

            return SendRequest(request);
        }

        public static Uri CombineUriToString(string baseUri, string relativeOrAbsoluteUri)
        {
            return new Uri(new Uri(baseUri), relativeOrAbsoluteUri);
        }
        private HttpResponseMessage SendRequest(HttpRequestMessage request)
        {

            _context.ApiResult = _httpClient.SendAsync(request)?.Result;
            return _context.ApiResult;
        }     

    }
}

