# [Weather API](https://apiverve.com/marketplace/weatherforecast?utm_source&#x3D;github&amp;utm_medium&#x3D;referral&amp;utm_content&#x3D;readme)

Weather is a current weather API that reports conditions for any city name or zip code: real-time temperature and wind speed with compass direction, in both metric and imperial units. Paid plans add a 7-day forecast with daily highs, lows, rain chance and conditions for the week ahead.

The Weather API provides a simple, reliable way to integrate weather functionality into your applications. Built for developers who need production-ready weather capabilities without the complexity of building from scratch.

**[View API Details →](https://apiverve.com/marketplace/weatherforecast?utm_source&#x3D;github&amp;utm_medium&#x3D;referral&amp;utm_content&#x3D;readme)**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![API Status](https://img.shields.io/badge/Status-Active-green.svg)](https://apiverve.com/marketplace/weatherforecast?utm_source&#x3D;github&amp;utm_medium&#x3D;referral&amp;utm_content&#x3D;readme)
[![Method](https://img.shields.io/badge/Method-GET-blue.svg)](#)
[![Platform](https://img.shields.io/badge/Platform-Multi--Platform-orange.svg)](#installation)

**Available on:**
[![npm](https://img.shields.io/badge/npm-CB3837?style=flat&logo=npm&logoColor=white)](https://www.npmjs.com/package/@apiverve/weatherforecast)
[![NuGet](https://img.shields.io/badge/NuGet-004880?style=flat&logo=nuget&logoColor=white)](https://www.nuget.org/packages/APIVerve.API.Weather)
[![PyPI](https://img.shields.io/badge/PyPI-3776AB?style=flat&logo=python&logoColor=white)](https://pypi.org/project/apiverve-weatherforecast/)
[![RubyGems](https://img.shields.io/badge/RubyGems-E9573F?style=flat&logo=rubygems&logoColor=white)](https://rubygems.org/gems/apiverve_weatherforecast)
[![Packagist](https://img.shields.io/badge/Packagist-F28D1A?style=flat&logo=packagist&logoColor=white)](https://packagist.org/packages/apiverve/weatherforecast)
[![Go](https://img.shields.io/badge/Go-00ADD8?style=flat&logo=go&logoColor=white)](#-go)
[![Dart](https://img.shields.io/badge/Dart-0175C2?style=flat&logo=dart&logoColor=white)](https://pub.dev/packages/apiverve_weatherforecast)
[![JitPack](https://img.shields.io/badge/JitPack-2E7D32?style=flat&logo=android&logoColor=white)](#-android-jitpack)

---

## Quick Start

### Using JavaScript

```javascript
async function callWeatherAPI() {
    try {
        const params = new URLSearchParams({
            city: 'San Francisco',
            forecast: true
        });

        const response = await fetch(`https://api.apiverve.com/v1/weatherforecast?${params}`, {
            method: 'GET',
            headers: {
                'x-api-key': 'YOUR_API_KEY_HERE'
            }
        });

        const data = await response.json();
        console.log(data);
    } catch (error) {
        console.error('Error:', error);
    }
}

callWeatherAPI();
```

### Using cURL

```bash
curl -X GET "https://api.apiverve.com/v1/weatherforecast?city=San%20Francisco&forecast=true" \
  -H "x-api-key: YOUR_API_KEY_HERE"
```

**Get your API key:** [https://apiverve.com](https://apiverve.com)

**📁 For more examples, see the [examples folder](./examples/)**

---

## Installation

Choose your preferred programming language:

### 📦 NPM (JavaScript/Node.js)

```bash
npm install @apiverve/weatherforecast
```

[**View NPM Package →**](https://www.npmjs.com/package/@apiverve/weatherforecast) | [**Package Code →**](./npm/)

---

### 🔷 NuGet (.NET/C#)

```bash
dotnet add package APIVerve.API.Weather
```

[**View NuGet Package →**](https://www.nuget.org/packages/APIVerve.API.Weather) | [**Package Code →**](./nuget/)

---

### 🐍 Python (PyPI)

```bash
pip install apiverve-weatherforecast
```

[**View PyPI Package →**](https://pypi.org/project/apiverve-weatherforecast/) | [**Package Code →**](./python/)

---

### 💎 Ruby (RubyGems)

```bash
gem install apiverve_weatherforecast
```

[**View RubyGems Package →**](https://rubygems.org/gems/apiverve_weatherforecast) | [**Package Code →**](./ruby/)

---

### 🐘 PHP (Packagist)

```bash
composer require apiverve/weatherforecast
```

[**View Packagist Package →**](https://packagist.org/packages/apiverve/weatherforecast) | [**Package Code →**](./php/)

---

### 🎯 Dart (pub.dev)

```bash
dart pub add apiverve_weatherforecast
```

[**View pub.dev Package →**](https://pub.dev/packages/apiverve_weatherforecast) | [**Package Code →**](./dart/)

---

### 🤖 Android (JitPack)

```gradle
implementation 'com.github.apiverve:weatherforecast-api:1.0.0'
```

[**Package Code →**](./android/)

---

### 🐹 Go

```bash
go get github.com/apiverve/weatherforecast-api/go
```

[**Package Code →**](./go/)

---

## Why Use This API?

| Feature | Benefit |
|---------|---------|
| **Multi-language SDKs** | Native packages for JavaScript, Python, C#, Go, and Android |
| **Simple Integration** | Single API key authentication, consistent response format |
| **Production Ready** | 99.9% uptime SLA, served from 24 global regions |
| **Comprehensive Docs** | Full examples, OpenAPI spec, and dedicated support |

---

## Documentation

- 🏠 **API Home:** [Weather API](https://apiverve.com/marketplace/weatherforecast?utm_source&#x3D;github&amp;utm_medium&#x3D;referral&amp;utm_content&#x3D;readme)
- 📚 **API Reference:** [docs.apiverve.com/ref/weatherforecast](https://docs.apiverve.com/ref/weatherforecast)
- 📖 **OpenAPI Spec:** [openapi.yaml](./openapi.yaml)
- 💡 **Examples:** [examples/](./examples/)

---

## What Can You Build?

The Weather API is commonly used for:

- **Web Applications** - Add weather features to your frontend or backend
- **Mobile Apps** - Native SDKs for Android development
- **Automation** - Integrate with n8n, Zapier, or custom workflows
- **SaaS Products** - Enhance your product with weather capabilities
- **Data Pipelines** - Process and analyze data at scale

---

## API Reference

### Authentication
All requests require an API key in the header:
```
x-api-key: YOUR_API_KEY_HERE
```

Get your API key: [https://apiverve.com](https://apiverve.com)

### Response Format

Every APIVerve endpoint returns the same envelope — check `status`, then read `data`:

```json
{
  "status": "ok",
  "error": null,
  "data": { ... }
}
```

### Example Response

A real response from the Weather API:

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

## Support & Community

- 🏠 **API Home**: [Weather API](https://apiverve.com/marketplace/weatherforecast?utm_source&#x3D;github&amp;utm_medium&#x3D;referral&amp;utm_content&#x3D;readme)
- 💬 **Support**: [https://apiverve.com/contact](https://apiverve.com/contact)
- 🐛 **Issues**: [GitHub Issues](../../issues)
- 📖 **Documentation**: [https://docs.apiverve.com](https://docs.apiverve.com)
- 🌐 **Website**: [https://apiverve.com](https://apiverve.com)

---

## Contributing

We welcome contributions! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

---

## Security

For security concerns, please review our [Security Policy](SECURITY.md).

---

## License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

---

## Acknowledgments

Built with ❤️ by [APIVerve](https://apiverve.com)

Copyright © 2026 APIVerve. All rights reserved.
