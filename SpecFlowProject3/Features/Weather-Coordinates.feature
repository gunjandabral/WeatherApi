Feature: WeatherData-Coordinates
Following Scenarios get the weather data based on Latitude-Longitude

Scenario Outline: Weather Data based on Latitudes and Longitudes
Given I am a user who wants to get the weather details based on its <Latitude> and <Longitude>
When  I look up the weather forecast as an authenticated user
Then the Api response code should be '<ExpectedResponse>'
And  I receive the weather forecast with the following parameters
| Comments                                                                                                                                                               | clouds | snow | precip | sunrise | sunset | date_time | temp |
| All parameters are approximations. Values in this table are not utilized but can be used with small change. There is also a bug such that sunrise time is after sunset | 0      | 0    | 0      |         |        | 0         | 0    |  
      
Examples:
| Comments | Latitude | Longitude | ExpectedResponse |
| Sydney   | -33.86   | 151.21    | OK               |
| Tokyo    | 35.65    | 139.74    | OK               |


Scenario Outline: Weather Data based on Latitudes and Longitudes - Negative Scenarios
Given I am a user who wants to get the weather details based on its <Latitude> and <Longitude>
When  I look up the weather forecast as an authenticated user
Then the Api response code should be '<ExpectedResponse>'
      
Examples:
| Comments | Latitude | Longitude | ExpectedResponse |
| Sydney   |          | 151.21    | BadRequest       |
| Sydney   | -33.86   |           | BadRequest       |
| Sydney   |          |           | BadRequest       |
