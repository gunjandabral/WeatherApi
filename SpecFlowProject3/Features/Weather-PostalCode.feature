Feature: WeatherData-PostalCode
Following Scenarios get the weather data based on Postal Code 

Scenario Outline: Weather Data based on PostalCode
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
   
Scenario Outline: Weather Data based on PostalCode - Negative Scenario
Given I am a user who wants to get the weather details using < PostalCode > and < CountryCode >
When  I look up the weather forecast as an authenticated user
Then the Api response code should be '<ExpectedResponse>'

Examples:
| Comments                                                          | PostalCode | CountryCode | ExpectedResponse |
| Postal Code and wrong Country Code. There is a potential bug here | 2000       | JP          | NoContent        |
   

