using System.Net.Http;

namespace WeatherApi.Helpers
{
    public class ContextHelper:IContextHelper
    {
        public HttpResponseMessage ApiResult { get; set; }
        public ApiResponse ApiResponse { get; set; }
        
    }
}
