Feature: WeatherData
Following Scenarios get the weather data based on Latitude-Longitude and PostCode

Scenario Outline: Weather Data based for a non-authenticated user
Given I am a user who wants to get the weather details using < PostalCode > and < CountryCode >
When  I look up the weather forecast as a non-authenticated user
Then the Api response code should be 'Forbidden'
Examples:
| Comments | Latitude | Longitude |
| Sydney   | -33.86   | 151.21    |


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
| Sydney   |          | 151.21    | BadRequest       |
| Sydney   | -33.86   |           | BadRequest       |
| Sydney   |          |           | BadRequest       |


Scenario Outline: Weather Data based on PostCode
Given I am a user who wants to get the weather details using < PostalCode > and < CountryCode >
When  I look up the weather forecast as an authenticated user
Then the Api response code should be '<ExpectedResponse>'
And  I receive the weather forecast with the following parameters
| Comments                                                                                                  | clouds | snow | 
| All parameters are approximations. Values in this tble are not utilized but can be used with small change | 0      | 0    |   

Examples:
| Comments                                                          | PostalCode | CountryCode | ExpectedResponse |
| Only Postal Code                                                  | 2000       |             | OK               |
| Postal Code and correct Country Code                              | 2000       | AU          | OK               |
| Postal Code and wrong Country Code. There is a potential bug here | 2000       | JP          | NoContent        |
| Neither a Post Code nor a Country Code                            |            |             | BadRequest       |
   

