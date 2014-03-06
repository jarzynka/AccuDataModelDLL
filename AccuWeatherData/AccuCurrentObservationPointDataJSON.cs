using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherData
{
    public class LocationPointCurrentData
    {
        /// <summary>
        /// Date and time for this observation
        /// displayed in ISO8601 format: yyyy-mm-ddThh:mm:ss±hh:mm
        /// </summary>
        public DateTime LocalObservationDateTime { get; set; }

        /// <summary>
        /// Date and time for this observation
        /// displayed as the number of seconds that have elapsed 
        /// since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public int EpochTime { get; set; }
        
        /// <summary>
        /// Sensible weather text description of the observed weather
        /// Ex. Mostly Sunny, Cloudy, Heavy Rain, Snow, Sleet, etc
        /// Displayed in native language (localized)
        /// Determined by the language value sent to AccuWeather REST server
        /// </summary>
        public string WeatherText { get; set; }
        
        /// <summary>
        /// Sensible weather index number that represents a weather icon
        /// This is mapped in the WeatherIcons enumeration
        /// available within this namespace
        /// </summary>
        public int WeatherIcon { get; set; }
        
        /// <summary>
        /// Is there daylight at the time of this observation?
        /// </summary>
        public bool IsDayTime { get; set; }
        
        /// <summary>
        /// Observed temperature, units and unit type
        /// </summary>
        public AccuMetricImperialData Temperature { get; set; }

        /// <summary>
        /// Observed AccuWeather RealFeel (feels like) temperature,
        /// units and unit type
        /// </summary>
        public AccuMetricImperialData RealFeelTemperature { get; set; }

        /// <summary>
        /// Observed AccuWeather RealFeel (feels like) temperature in the shade,
        /// units and unit type
        /// </summary>
        public AccuMetricImperialData RealFeelTemperatureShade { get; set; }

        /// <summary>
        /// Observed humidity in the air relative
        /// to how much it can hold before the air is saturated
        /// expressed as a percentage
        /// </summary>
        public int RelativeHumidity { get; set; }

        /// <summary>
        /// Observed dew point temperature and units
        /// Dew point is the measure of how much humidity
        /// is in the air
        /// </summary>
        public AccuMetricImperialData DewPoint { get; set; }
        
        /// <summary>
        /// Observed wind direction and speed
        /// Speed expressed in Imperial and Metric units
        /// </summary>
        public WindObservation Wind { get; set; }
        
        /// <summary>
        /// Observed wind gust speed
        /// Speed expresssed in Imperial and Metric units
        /// Wind Direction will be null or empty - check against Exceptions!
        /// </summary>
        public WindObservation WindGust { get; set; }

        /// <summary>
        /// "Observed" Ultraviolet sun rays index forecast:
        /// 0-12 with 12 the highest strength
        /// Derived value from strength and angle of sun and cloud cover
        /// </summary>
        public int UVIndex { get; set; }

        /// <summary>
        /// Text description of the 
        /// "observed" ultraviolet sun rays index 
        /// Derived value from strength and angle of sun and cloud cover
        /// </summary>
        public string UVIndexText { get; set; }

        /// <summary>
        /// Observed horizontal visibility around the location
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Visibility { get; set; }

        /// <summary>
        /// Text description of any obstruction
        /// to horizontal visibility 
        /// (smoke, fog, dust, sand, heavy precip, etc)
        /// </summary>
        public string ObstructionsToVisibility { get; set; }
        
        /// <summary>
        /// Observed percentage of sky covered by clouds
        /// </summary>
        public double CloudCover { get; set; }
        
        /// <summary>
        /// Observation of vertical distance to lowest, continuous
        /// cloud deck in relation to the observation location
        /// </summary>
        public AccuMetricImperialData Ceiling { get; set; }
        
        /// <summary>
        /// Atmospheric (barometric) pressure
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Pressure { get; set; }
        
        /// <summary>
        /// Difference in pressure compared to 1, 3 or 6 hours prior
        /// Ex. Rising, Falling, Steady
        /// </summary>
        public PressureTendency PressureTendency { get; set; }
        
        /// <summary>
        /// Difference in temperaure between current observation
        /// and the observation 24 hours prior
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past24HourTemperatureDeparture { get; set; }
        
        /// <summary>
        /// Observed, perceived outdoor temperature 
        /// caused by the combination of air temperature, relative humidity, and wind speed
        /// expressed in Imperial and Metric units
        /// This value may be different than AccuWeather RealFeel value
        /// </summary>
        public AccuMetricImperialData ApparentTemperature { get; set; }
        
        /// <summary>
        /// Observed, perceived air temperature on exposed skin due to wind
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData WindChillTemperature { get; set; }
        
        /// <summary>
        /// Observed (liquid equivalent) precipitation accumulated over the previous hour
        /// expressed in Imperial and Metric units
        /// (this includes melted snow, freezing rain and sleet)
        /// </summary>
        public AccuMetricImperialData Precip1hr { get; set; }
        
        /// <summary>
        /// Observed precipitaiton from the
        /// Past Hour, Past 3 Hours, Past 6 Hours, Past 9 Hours,
        /// Past 12 Hours, Past 18 Hours and Past 24 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public PrecipitationSummary PrecipitationSummary { get; set; }
        
        /// <summary>
        /// Observed maximum and minimum temperature from the
        /// Past 6 Hours, Past 12 Hours and Past 24 Hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public TemperatureSummary TemperatureSummary { get; set; }
        
        /// <summary>
        /// Text representing a URI link to the 
        /// AccuWeather Mobile web site displaying this report
        /// </summary>
        public string MobileLink { get; set; }

        /// <summary>
        /// Text representing a URI link to the 
        /// AccuWeather full web site displaying this report
        /// </summary>
        public string Link { get; set; }

       
    }

    /// <summary>
    /// Class that represents Pressure Tendency values
    /// based on current observation vs. an prior observation
    /// (usually 1, 3 or 6 hours prior to the current)
    /// </summary>
    public class PressureTendency
    {
        /// <summary>
        /// Pressure tendency represented as localized text
        /// in the native language 
        /// (based on language setting sent to AccuWeather REST server)
        /// </summary>
        public string LocalizedText { get; set; }
        
        /// <summary>
        /// Pressure tendency code letters: F; R; S
        /// F = Falling; R = Rising; S = Steady
        /// </summary>
        public string Code { get; set; }

    }

    /// <summary>
    /// A larger collection of observed liquid equivalent precipitation
    /// (includes melted snow, sleet and freezing rain)
    /// </summary>
    public class PrecipitationSummary
    {
        /// <summary>
        /// Instananeous observed precipitation or precip rate?
        /// Expressed in Imperial and Metric Units
        /// </summary>
        public AccuMetricImperialData Precipitation { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous hour
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData PastHour { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous 3 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past3Hours { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous 6 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past6Hours { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous 9 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past9Hours { get; set; }
        
        /// <summary>
        /// Observed precipitation accumulated over the previous 12 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past12Hours { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous 18 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past18Hours { get; set; }

        /// <summary>
        /// Observed precipitation accumulated over the previous 24 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Past24Hours { get; set; }

    }

    
    /// <summary>
    /// Observed temperature maximums and minimums (highs and lows)
    /// over multiple previous time lengths
    /// </summary>
    public class TemperatureSummary
    {

        /// <summary>
        /// Observed maximum and minumum temperaure over the previous 6 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public TemperatureMaxMinObserved Past6HourRange { get; set; }

        /// <summary>
        /// Observed maximum and minumum temperaure over the previous 12 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public TemperatureMaxMinObserved Past12HourRange { get; set; }

        /// <summary>
        /// Observed maximum and minumum temperaure over the previous 24 hours
        /// expressed in Imperial and Metric units
        /// </summary>
        public TemperatureMaxMinObserved Past24HourRange { get; set; }

    }

    
    /// <summary>
    /// A small class that combined Maximum and Minimum temperature data
    /// in both Imperial and Metric units
    /// </summary>
    public class TemperatureMaxMinObserved
    {
        /// <summary>
        /// Observed maximum (high) temperature for a specific time period
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Maximum { get; set; }

        /// <summary>
        /// Observed minimum (low) temperature for a specific time period
        /// expressed in Imperial and Metric units
        /// </summary>
        public AccuMetricImperialData Minimum { get; set; }

    }
}
