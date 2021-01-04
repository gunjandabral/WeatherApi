using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace WeatherApi.Helpers
{
    public static class Extensions
    {
        public static Uri AppendParameters(this Uri uri, IDictionary<string, string> parameters)
        {
            var concatenatedParameters = parameters.Select(pair =>
                $"{pair.Key}={pair.Value}");

            var query = string.Join("&", concatenatedParameters);
            var uriString = string.IsNullOrEmpty(uri.Query) ?
                uri.OriginalString + $"?{query}" :
                uri.OriginalString + $"&{query}";

            return new Uri(uriString);
        }
    }
}
