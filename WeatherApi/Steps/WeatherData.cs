using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;
using WeatherApi.Helpers;

namespace WeatherApi.Steps
{
    [Binding]
    public sealed class WeatherData
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        readonly IApiClient _apiClient = new ApiClient();
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        HttpResponseMessage apiResult = Base._contextHelper.ApiResult;
        readonly string masterKey = "8c91a77c554f472c860654aec021c944";

        public WeatherData(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am a user who wants to get the weather details based on its (.*) and (.*)")]
        public void GivenIAmAUserWhoWantsToGetTheWeatherDetailsForBasedOnItsAnd(string latitude, string longitude)
        {
            parameters = new Dictionary<string, string>
                {
                        { "lat",latitude },
                        {"lon",longitude }
                };
        }

        [Given(@"I am a user who wants to get the weather details using (.*) and (.*)")]
        public void GivenIAmAUserWhoWantsToGetTheWeatherDetailsUsingAnd(string postalCode, string countryCode)
        {
            parameters = new Dictionary<string, string>
                {
                        { "postal_code",postalCode }
                };

            if(!string.IsNullOrEmpty(countryCode))
                {
                    parameters.Add("country", countryCode);
                }
        }

        [When(@"I look up the weather forecast as a non-authenticated user")]
        public void WhenILookUpTheWeatherForecastAsAnNon_AuthenticatedUser()
        {
            apiResult = _apiClient.Get("/v2.0/current", parameters);
        }

        [Then(@"the Api response code should be '(.*)'")]
        public void ThenTheApiResponseCodeShouldBe(string status)
        {
            var newStatus= Enum.Parse<HttpStatusCode>(status);
            apiResult.StatusCode.Should().Be(newStatus); 
            if(status!="OK")
            {
                Assert.Pass();
            }
        }

        [When(@"I look up the weather forecast as an authenticated user")]
        public void WhenILookUpTheWeatherForecastAsAnAuthenticatedUser()
        {
            //As per the weather forecast api documentation , every user needs to have a valid key to call the api. 
            parameters.Add("key", masterKey);
            apiResult = _apiClient.Get("/v2.0/current", parameters);
        }
        [Then(@"I receive the weather forecast with the following parameters")]
        public void ThenIReceiveTheWeatherForecastWithTheFollowingParameters(Table table)
        {
            var json = apiResult.Content.ReadAsStringAsync()?.Result;
            ApiResponse.RootObject = JsonConvert.DeserializeObject<Root>(json);
            var data = ApiResponse.RootObject.data;
       
            var columns = table.Header;
            foreach (var column in columns.Where(x=>!x.Contains("Comments")))
            {
                switch (column)
                {
                    case "clouds":
                        data[0].clouds.Should().BeGreaterOrEqualTo(0);
                        break;
                    case "snow":
                        data[0].snow.Should().BeGreaterOrEqualTo(0);
                        break;
                    case "precip":
                        data[0].precip.Should().BeGreaterOrEqualTo(0);
                        break;
                    case "sunrise":
                        data[0].sunrise.Should().NotBeNull();
                        break;
                    case "sunset":
                        data[0].sunset.Should().NotBeNull();
                        Assert.That(data[0].sunrise, Is.LessThan(data[0].sunset));
                        break;
                    case "temp":
                        data[0].temp.Should().BeGreaterOrEqualTo(-50);
                        break;
                    case "date_time":
                        data[0].datetime.Should().NotBeNull();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
