using System.Net.Http;

namespace WeatherApi.Helpers
{
    public interface IContextHelper
    {
        HttpResponseMessage ApiResult { get; set; }
        ApiResponse ApiResponse { get; set; }
    }
}
