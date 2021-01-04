using System.Collections.Generic;
using System.Net.Http;

namespace WeatherApi.Helpers
{

    public interface IApiClient
    {
        HttpResponseMessage Get(string endPoint,Dictionary<string, string> urlParameters = null);
    }

}
