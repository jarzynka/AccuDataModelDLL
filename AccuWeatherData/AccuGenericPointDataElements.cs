using System;

namespace AccuWeatherData
{
    /// <summary>
    /// A small construct used
    /// in several AccuWeather Point Data Forecasts
    /// Consists of value (number), unit (string)
    /// and UnitType 
    /// (number that represents AccuWeather Unit enumeration)
    /// </summary>
    public class AccuValUnitType
    {
        /// <summary>
        /// value of the data
        /// could be temperature, feels like, dew point
        /// wind speed, etc.
        /// </summary>
        public double Value { get; set; }
        
        /// <summary>
        /// the units of the data
        /// represented as text
        /// ex. mph, m/s, °F, °C
        /// </summary>
        public string Unit { get; set; }
        
        /// <summary>
        /// the units of the data
        /// represented as an index
        /// useful for conversions
        /// enumeration in this namespace as UnitType
        /// </summary>
        public int UnitType { get; set; }

    }

    /// <summary>
    /// AccuWeather class that represents
    /// both Metric (SI) and Imperial
    /// units, unit types and enumeration index
    /// </summary>
    public class AccuMetricImperialData
    {
        public AccuValUnitType Metric { get; set; }
        public AccuValUnitType Imperial { get; set; }

    }

    
    /// <summary>
    /// Class that represents wind data
    /// used in several AccuWeather Point Data Forecasts
    /// </summary>
    public class WindForecast
    {
        /// <summary>
        /// The wind speed value, units and UnitType index
        /// </summary>
        public AccuValUnitType Speed { get; set; }
        
        /// <summary>
        /// The wind direction in compass degrees,
        /// cardinal text (localized to native language)
        /// cardinal text (in English)
        /// </summary>
        public WindDirection Direction { get; set; }
    }

    /// <summary>
    /// Class that represents wind data
    /// used in several AccuWeather Point Data Observations
    /// </summary>
    public class WindObservation
    {
        public WindDirection Direction { get; set; }
        public AccuMetricImperialData Speed { get; set; }
    }


    /// <summary>
    /// Class that represents wind direction data 
    /// </summary>
    public class WindDirection
    {
        /// <summary>
        /// The wind represented in compass degrees
        /// 0°=North; 90°=East; 180°=South; 270°=West
        /// </summary>
        public int Degrees { get; set; }
        
        /// <summary>
        /// The cardinal wind as text expressed
        /// in the native language (localized)
        /// Ex. French: N (nord); E (est); S (sud); O (ouest)
        /// Language is determined by the REST call 
        /// to the AccuWeather data server
        /// </summary>
        public string Localized { get; set; }
        
        /// <summary>
        /// The cardinal wind as text expressed
        /// in English
        /// Ex. N (north); E (east); S (south); W (west)
        /// </summary>
        public string English { get; set; }
    }
}
