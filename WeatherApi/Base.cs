
namespace WeatherApi
{
    using TechTalk.SpecFlow;
    using System.Net.Http;
    using System;
    using System.Net.Http.Headers;
    using System.Configuration;
    using WeatherApi.Helpers;

    [Binding]
    public class Base
    {
        public static HttpClient _apiClient;
        public static IContextHelper _contextHelper = new ContextHelper();


        [BeforeScenario]
        public void TestSetUp()
        {
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri("https://api.weatherbit.io/v2.0/");
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            //In this case the response header was xml, as observed manually on Postman.
            _apiClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/xml"));
        }

        [AfterScenario]
        public static void TearDown()
        {
            _apiClient.Dispose();
        }


    }
}
