# Weather API

Weather is a current weather API that reports conditions for any city name or zip code: real-time temperature and wind speed with compass direction, in both metric and imperial units. Paid plans add a 7-day forecast with daily highs, lows, rain chance and conditions for the week ahead.

[![npm version](https://img.shields.io/npm/v/@apiverve/weatherforecast.svg)](https://www.npmjs.com/package/@apiverve/weatherforecast)

This is a JavaScript wrapper for the [Weather API](https://apiverve.com/marketplace/weatherforecast?utm_source=npm&utm_medium=referral&utm_content=readme)

---

## Installation

Using npm:
```shell
npm install @apiverve/weatherforecast
```

Using yarn:
```shell
yarn add @apiverve/weatherforecast
```

---

## Configuration

Before using the Weather API client, you have to setup your account and obtain your API Key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com?utm_source=npm&utm_medium=referral&utm_content=readme)

---

## Quick Start

[Get started with the Quick Start Guide](https://docs.apiverve.com/quickstart?utm_source=npm&utm_medium=referral&utm_content=readme)

The Weather API documentation is found here: [https://docs.apiverve.com/ref/weatherforecast](https://docs.apiverve.com/ref/weatherforecast?utm_source=npm&utm_medium=referral&utm_content=readme).
You can find parameters, example responses, and status codes documented here.

### Setup

```javascript
const weatherforecastAPI = require('@apiverve/weatherforecast');
const api = new weatherforecastAPI({
    api_key: '[YOUR_API_KEY]'
});
```

---

## Usage

---

### Perform Request

Using the API is simple. All you have to do is make a request. The API will return a response with the data you requested.

```javascript
var query = {
  city: "San Francisco",
  forecast: true
};

api.execute(query, function (error, data) {
    if (error) {
        return console.error(error);
    } else {
        console.log(data);
    }
});
```

---

### Using Promises

You can also use promises to make requests. The API returns a promise that you can use to handle the response.

```javascript
var query = {
  city: "San Francisco",
  forecast: true
};

api.execute(query)
    .then(data => {
        console.log(data);
    })
    .catch(error => {
        console.error(error);
    });
```

---

### Using Async/Await

You can also use async/await to make requests. The API returns a promise that you can use to handle the response.

```javascript
async function makeRequest() {
    var query = {
  city: "San Francisco",
  forecast: true
};

    try {
        const data = await api.execute(query);
        console.log(data);
    } catch (error) {
        console.error(error);
    }
}
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

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact?utm_source=npm&utm_medium=referral&utm_content=readme).

---

## Updates

Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms?utm_source=npm&utm_medium=referral&utm_content=readme) and [Privacy Policy](https://apiverve.com/privacy?utm_source=npm&utm_medium=referral&utm_content=readme).

---

## License
Licensed under the MIT License (MIT)

Copyright (&copy;) 2026 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
