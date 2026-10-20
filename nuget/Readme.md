Weather API
============

Weather is a current weather API that reports conditions for any city name or zip code: real-time temperature and wind speed with compass direction, in both metric and imperial units. Paid plans add a 7-day forecast with daily highs, lows, rain chance and conditions for the week ahead.


[![NuGet version](https://img.shields.io/nuget/v/APIVerve.API.Weather.svg)](https://www.nuget.org/packages/APIVerve.API.Weather)

This is a .NET wrapper for the [Weather API](https://apiverve.com/marketplace/weatherforecast?utm_source=nuget&utm_medium=referral&utm_content=readme)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.Weather
```

Using the Package Manager:
```
nuget install APIVerve.API.Weather
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.Weather
```

From within Visual Studio:

1. Open the Solution Explorer
2. Right-click on a project within your solution
3. Click on Manage NuGet Packages
4. Click on the Browse tab and search for "APIVerve.API.Weather"
5. Click on the APIVerve.API.Weather package, select the appropriate version in the right-tab and click Install

---

## Configuration

Before using the Weather API client, you have to setup your account and obtain your API Key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com?utm_source=nuget&utm_medium=referral&utm_content=readme)

---

## Quick Start

Here's a simple example to get you started quickly:

```csharp
using System;
using APIVerve.API.Weather;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialize the API client
        var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WeatherQueryOptions {
            City = "San Francisco",
            Forecast = true
        };

        // Make the API call
        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
            }
            else
            {
                Console.WriteLine("Success!");
                // Access response data using the strongly-typed ResponseObj properties
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
```

---

## Usage

The Weather API documentation is found here: [https://docs.apiverve.com/ref/weatherforecast](https://docs.apiverve.com/ref/weatherforecast?utm_source=nuget&utm_medium=referral&utm_content=readme).
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Weather API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```csharp
// Create an instance of the API client
var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");
```

---

## Usage Examples

### Basic Usage (Async/Await Pattern - Recommended)

The modern async/await pattern provides the best performance and code readability:

```csharp
using System;
using System.Threading.Tasks;
using APIVerve.API.Weather;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WeatherQueryOptions {
            City = "San Francisco",
            Forecast = true
        };

        var response = await apiClient.ExecuteAsync(queryOptions);

        if (response.Error != null)
        {
            Console.WriteLine($"Error: {response.Error}");
        }
        else
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
```

### Synchronous Usage

If you need to use synchronous code, you can use the `Execute` method:

```csharp
using System;
using APIVerve.API.Weather;

public class Example
{
    public static void Main(string[] args)
    {
        var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WeatherQueryOptions {
            City = "San Francisco",
            Forecast = true
        };

        var response = apiClient.Execute(queryOptions);

        if (response.Error != null)
        {
            Console.WriteLine($"Error: {response.Error}");
        }
        else
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
```

---

## Error Handling

The API client provides comprehensive error handling. Here are some examples:

### Handling API Errors

```csharp
using System;
using System.Threading.Tasks;
using APIVerve.API.Weather;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WeatherQueryOptions {
            City = "San Francisco",
            Forecast = true
        };

        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            // Check for API-level errors
            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
                Console.WriteLine($"Status: {response.Status}");
                return;
            }

            // Success - use the data
            Console.WriteLine("Request successful!");
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
        catch (ArgumentException ex)
        {
            // Invalid API key or parameters
            Console.WriteLine($"Invalid argument: {ex.Message}");
        }
        catch (System.Net.Http.HttpRequestException ex)
        {
            // Network or HTTP errors
            Console.WriteLine($"Network error: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Other errors
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
```

### Comprehensive Error Handling with Retry Logic

```csharp
using System;
using System.Threading.Tasks;
using APIVerve.API.Weather;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

        // Configure retry behavior (max 3 retries)
        apiClient.SetMaxRetries(3);        // Retry up to 3 times (default: 0, max: 3)
        apiClient.SetRetryDelay(2000);     // Wait 2 seconds between retries

        var queryOptions = new WeatherQueryOptions {
            City = "San Francisco",
            Forecast = true
        };

        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
            }
            else
            {
                Console.WriteLine("Success!");
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed after retries: {ex.Message}");
        }
    }
}
```

---

## Advanced Features

### Custom Headers

Add custom headers to your requests:

```csharp
var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

// Add custom headers
apiClient.AddCustomHeader("X-Custom-Header", "custom-value");
apiClient.AddCustomHeader("X-Request-ID", Guid.NewGuid().ToString());

var queryOptions = new WeatherQueryOptions {
    City = "San Francisco",
    Forecast = true
};

var response = await apiClient.ExecuteAsync(queryOptions);

// Remove a header
apiClient.RemoveCustomHeader("X-Custom-Header");

// Clear all custom headers
apiClient.ClearCustomHeaders();
```

### Request Logging

Enable logging for debugging:

```csharp
var apiClient = new WeatherAPIClient("[YOUR_API_KEY]", isDebug: true);

// Or use a custom logger
apiClient.SetLogger(message =>
{
    Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
});

var queryOptions = new WeatherQueryOptions {
    City = "San Francisco",
    Forecast = true
};

var response = await apiClient.ExecuteAsync(queryOptions);
```

### Retry Configuration

Customize retry behavior for failed requests:

```csharp
var apiClient = new WeatherAPIClient("[YOUR_API_KEY]");

// Set retry options
apiClient.SetMaxRetries(3);           // Retry up to 3 times (default: 0, max: 3)
apiClient.SetRetryDelay(1500);        // Wait 1.5 seconds between retries (default: 1000ms)

var queryOptions = new WeatherQueryOptions {
    City = "San Francisco",
    Forecast = true
};

var response = await apiClient.ExecuteAsync(queryOptions);
```

### Dispose Pattern

The API client implements `IDisposable` for proper resource cleanup:

```csharp
var queryOptions = new WeatherQueryOptions {
    City = "San Francisco",
    Forecast = true
};

using (var apiClient = new WeatherAPIClient("[YOUR_API_KEY]"))
{
    var response = await apiClient.ExecuteAsync(queryOptions);
    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
}
// HttpClient is automatically disposed here
```

---

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "tempC": 13.3,
    "tempF": 55.9,
    "windMph": 4.7,
    "windKph": 7.6,
    "windDegree": 273,
    "windDir": "W",
    "pressureMb": 1022,
    "pressureIn": 30.17,
    "precipMm": 0,
    "precipIn": 0,
    "feelslikeC": 13,
    "feelslikeF": 55.3,
    "visKm": 16,
    "visMiles": 9,
    "gustMph": 7.2,
    "gustKph": 11.6,
    "forecast": [
      {
        "date": "2026-09-21",
        "condition": "Sunny",
        "maxtempC": 22.5,
        "maxtempF": 72.5,
        "mintempC": 13.3,
        "mintempF": 56,
        "avgtempC": 17.7,
        "avgtempF": 63.9,
        "maxwindMph": 4.7,
        "maxwindKph": 7.6,
        "avghumidity": 48,
        "uv": 4,
        "willItRain": 0,
        "chanceOfRain": 4,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0,
        "totalprecipIn": 0,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-22",
        "condition": "Sunny",
        "maxtempC": 22.8,
        "maxtempF": 73,
        "mintempC": 16.5,
        "mintempF": 61.7,
        "avgtempC": 19.7,
        "avgtempF": 67.5,
        "maxwindMph": 4.7,
        "maxwindKph": 7.6,
        "avghumidity": 63,
        "uv": 3.9,
        "willItRain": 0,
        "chanceOfRain": 8,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0.02,
        "totalprecipIn": 0,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-23",
        "condition": "Overcast",
        "maxtempC": 22.8,
        "maxtempF": 73.1,
        "mintempC": 14.1,
        "mintempF": 57.4,
        "avgtempC": 18.4,
        "avgtempF": 65.2,
        "maxwindMph": 15.7,
        "maxwindKph": 25.2,
        "avghumidity": 70,
        "uv": 3.1,
        "willItRain": 1,
        "chanceOfRain": 76,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 5.97,
        "totalprecipIn": 0.23,
        "totalsnowCm": 0,
        "avgvisKm": 9.9,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-24",
        "condition": "Partly Cloudy",
        "maxtempC": 18,
        "maxtempF": 64.5,
        "mintempC": 10.5,
        "mintempF": 50.8,
        "avgtempC": 14.3,
        "avgtempF": 57.7,
        "maxwindMph": 11,
        "maxwindKph": 17.6,
        "avghumidity": 64,
        "uv": 3.5,
        "willItRain": 0,
        "chanceOfRain": 11,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0.03,
        "totalprecipIn": 0,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-25",
        "condition": "Sunny",
        "maxtempC": 21.3,
        "maxtempF": 70.3,
        "mintempC": 12,
        "mintempF": 53.6,
        "avgtempC": 16,
        "avgtempF": 60.8,
        "maxwindMph": 6.5,
        "maxwindKph": 10.4,
        "avghumidity": 56,
        "uv": 6,
        "willItRain": 0,
        "chanceOfRain": 4,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0,
        "totalprecipIn": 0,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-26",
        "condition": "Sunny",
        "maxtempC": 22,
        "maxtempF": 71.5,
        "mintempC": 13,
        "mintempF": 55.3,
        "avgtempC": 17.1,
        "avgtempF": 62.8,
        "maxwindMph": 8.9,
        "maxwindKph": 14.4,
        "avghumidity": 62,
        "uv": 6,
        "willItRain": 0,
        "chanceOfRain": 8,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0,
        "totalprecipIn": 0,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      },
      {
        "date": "2026-09-27",
        "condition": "Overcast",
        "maxtempC": 19.3,
        "maxtempF": 66.8,
        "mintempC": 12.8,
        "mintempF": 55.1,
        "avgtempC": 16.3,
        "avgtempF": 61.3,
        "maxwindMph": 6.9,
        "maxwindKph": 11.2,
        "avghumidity": 67,
        "uv": 4,
        "willItRain": 0,
        "chanceOfRain": 36,
        "willItSnow": 0,
        "chanceOfSnow": 0,
        "totalprecipMm": 0.32,
        "totalprecipIn": 0.01,
        "totalsnowCm": 0,
        "avgvisKm": 10,
        "avgvisMiles": 6
      }
    ],
    "forecastSummary": {
      "rainExpectedOn": "2026-09-23",
      "daysWithRain": 1,
      "tempTrend": "cooling",
      "tempTrendC": -2.1,
      "maxChanceOfRain": 76
    }
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact?utm_source=nuget&utm_medium=referral&utm_content=readme).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms?utm_source=nuget&utm_medium=referral&utm_content=readme) and all legal documents and agreements.

---

## License
Licensed under the MIT License (MIT)

Copyright (&copy;) 2026 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
