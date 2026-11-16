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
        /// The city for which you want to get the current weather (e.g., San Francisco). A name shared by several places resolves to the best-known one (London is London, UK); add a state, province or country after a comma to pick another (e.g., Portland, Maine or London, Ontario)
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Included by default. Set to false to omit the 7-day forecast and return current conditions only.
        /// </summary>
        [JsonProperty("forecast")]
        public bool? Forecast { get; set; }

        /// <summary>
        /// Set to true to add an hourly forecast: every hour from now through the end of the 7-day window.
        /// </summary>
        [JsonProperty("hourly")]
        public bool? Hourly { get; set; }
    }
}
