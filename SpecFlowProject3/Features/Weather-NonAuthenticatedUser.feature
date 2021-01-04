Feature: WeatherData - NonAuthenticatedUser
Following Scenarios tries to fetch the weather data for a Non Authenticated User

Scenario Outline: Weather Data based for a non-authenticated user
Given I am a user who wants to get the weather details using < PostalCode > and < CountryCode >
When  I look up the weather forecast as a non-authenticated user
Then the Api response code should be 'Forbidden'
Examples:
| Comments | Latitude | Longitude |
| Sydney   | -33.86   | 151.21    |

