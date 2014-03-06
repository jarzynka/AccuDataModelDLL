using System;

namespace AccuWeatherData
{
    public class LocationPointHourlyForecastData
    {
        /// <summary>
        /// Date and time for the hour this forecast is valid
        /// displayed in ISO8601 format: yyyy-mm-ddThh:mm:ss±hh:mm
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Date and time for the hour this forecast is valid
        /// displayed as the number of seconds that have elapsed 
        /// since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public int EpochDateTime { get; set; }
        
        /// <summary>
        /// Sensible weather text describing the icon displayed
        /// ex. Mostly Sunny, Heavy Rain, etc.
        /// this text is localized to the native language
        /// localization determined by REST call to AccuWeather server
        /// </summary>
        public string IconPhrase { get; set; }
        
        /// <summary>
        /// Numeric index indicating a specific weather icon map
        /// in the AccuWeather library
        /// Enumeration available in this namespace
        /// under WeatherIcons
        /// </summary>
        public int WeatherIcon { get; set; }
        
        /// <summary>
        /// Hourly forecast temperature and units
        /// </summary>
        public AccuValUnitType Temperature { get; set; }
        
        /// <summary>
        /// Hourly forecast AccuWeather RealFeel (feels like)
        /// temperature and units
        /// </summary>
        public AccuValUnitType RealFeelTemperature { get; set; }
        
        /// <summary>
        /// Hourly forecast wet bulb temperature and units
        /// Very useful in determining how far the 
        /// air temperature will drop when precipitation starts
        /// </summary>
        public AccuValUnitType WetBulbTemperature { get; set; }
        
        /// <summary>
        /// Hourly forecast dew point temperature and units
        /// Dew point is the measure of how much humidity
        /// is in the air
        /// </summary>
        public AccuValUnitType DewPoint { get; set; }
        
        /// <summary>
        /// Hourly wind direction and speed forecast
        /// </summary>
        public WindForecast Wind { get; set; }
        
        /// <summary>
        /// Hourly wind gust speed forecast
        /// Wind direction object will be null or empty
        /// make sure you check against it (Exceptions)
        /// </summary>
        public WindForecast WindGust { get; set; }
        
        /// <summary>
        /// Hourly forecast of humidity in the air relative
        /// to how much it can hold before the air is saturated
        /// expressed as a percentage
        /// </summary>
        public double RelativeHumidity { get; set; }
        
        /// <summary>
        /// Horizontal visibility around the location
        /// forecast for the specific hour
        /// also includes units of measurement
        /// </summary>
        public AccuValUnitType Visibility { get; set; }
        
        /// <summary>
        /// Vertical height of the lowest cloud deck above
        /// the forecast location for the specific hour
        /// also includes units of measurement
        /// </summary>
        public AccuValUnitType Ceiling { get; set; }
        
        /// <summary>
        /// Hourly Ultraviolet sun rays index forecast:
        /// 0-12 with 12 the highest strength
        /// </summary>
        public double UVIndex { get; set; }
        
        /// <summary>
        /// Text description of the 
        /// hourly forecast ultraviolet sun rays index 
        /// </summary>
        public string UVIndexText { get; set; }
        
        /// <summary>
        /// Hourly forecast for the chance of any precipitation
        /// Also known as POP (probability of precipitation)
        /// expressed as a percentage
        /// </summary>
        public double PrecipitationProbability { get; set; }

        /// <summary>
        /// Hourly forecast for the chance of rain
        /// expressed as a percentage
        /// (Does not include frozen precipitation)
        /// </summary>
        public double RainProbability { get; set; }

        /// <summary>
        /// Hourly forecast for the chance of snow
        /// expressed as a percentage
        /// (Does not include rain, sleet or freezing rain)
        /// </summary>
        public double SnowProbability { get; set; }

        /// <summary>
        /// Hourly forecast for the chance of sleet or freezing rain
        /// expressed as a percentage
        /// (Does not include rain or snow)
        /// </summary>
        public double IceProbability { get; set; }
        
        /// <summary>
        /// Total liquid equivalent accumulation
        /// for the forecast hour
        /// and unit of measurement
        /// (includes rain and melted frozen precipitation) 
        /// </summary>
        public AccuValUnitType TotalLiquid { get; set; }
        
        /// <summary>
        /// Total rainfall accumulation
        /// for the forecast hour
        /// and unit of measurement
        /// (does not include frozen precipitation) 
        /// </summary>
        public AccuValUnitType Rain { get; set; }

        /// <summary>
        /// Total snowfall accumulation
        /// for the forecast hour
        /// and unit of measurement
        /// (does not include rain, freezing rain or sleet) 
        /// </summary>
        public AccuValUnitType Snow { get; set; }

        /// <summary>
        /// Total sleet and freezing rain accumulation
        /// for the forecast hour
        /// and unit of measurement
        /// (does not include rain or snow) 
        /// </summary>
        public AccuValUnitType Ice { get; set; }
        
        /// <summary>
        /// Percentage of hour forecast to be cloudy
        /// </summary>
        public double CloudCover { get; set; }


    }
}
