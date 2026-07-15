declare module '@apiverve/weatherforecast' {
  export interface weatherforecastOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface weatherforecastResponse {
    status: string;
    error: string | null;
    data: WeatherData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface WeatherData {
      tempC:      number | null;
      tempF:      number | null;
      windMph:    number | null;
      windKph:    number | null;
      windDegree: number | null;
      windDir:    null | string;
      pressureMB: number | null;
      pressureIn: number | null;
      precipMm:   number | null;
      precipIn:   number | null;
      feelslikeC: number | null;
      feelslikeF: number | null;
      visKM:      number | null;
      visMiles:   number | null;
      gustMph:    number | null;
      gustKph:    number | null;
  }

  export default class weatherforecastWrapper {
    constructor(options: weatherforecastOptions);

    execute(callback: (error: any, data: weatherforecastResponse | null) => void): Promise<weatherforecastResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: weatherforecastResponse | null) => void): Promise<weatherforecastResponse>;
    execute(query?: Record<string, any>): Promise<weatherforecastResponse>;
  }
}
