using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.Weather
{
    /// <summary>
    /// Query options for the Weather API
    /// </summary>
    public class WeatherQueryOptions
    {
        /// <summary>
        /// The city for which you want to get the current weather (e.g., San Francisco)
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Included by default. Set to false to omit the 7-day forecast and return current conditions only.
        /// </summary>
        [JsonProperty("forecast")]
        public bool? Forecast { get; set; }
    }
}
