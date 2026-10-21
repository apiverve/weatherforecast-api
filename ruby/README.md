# Weather API - Ruby Gem

Weather is a current weather API that reports conditions for any city name or zip code: real-time temperature and wind speed with compass direction, in both metric and imperial units. Paid plans add a 7-day forecast with daily highs, lows, rain chance and conditions for the week ahead.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_weatherforecast'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_weatherforecast
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_weatherforecast'

# Initialize the client
client = APIVerve::Weatherforecast::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute({
  city: "San Francisco",
  forecast: true
})

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ city: "San Francisco", forecast: true })
  puts response["data"]
rescue APIVerve::Weatherforecast::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Weatherforecast::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Weatherforecast::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
```

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

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/weatherforecast?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/weatherforecast?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/weatherforecast?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).
