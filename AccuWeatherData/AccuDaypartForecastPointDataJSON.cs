using System;

namespace AccuWeatherData
{
    /// <summary>
    /// Base object represents the top of the JSON structure
    /// for AccuWeather Day Part Forecast Point Data
    /// </summary>
    public class DaypartRoot
    {
        /// <summary>
        /// Day part forecast period headline:
        /// the main weather event that will take place
        /// over the next "n" day(s)
        /// </summary>
        public DaypartHeadline Headline { get; set; }

        /// <summary>
        /// An array of day part forecasts
        /// number depends on the forecast range selected
        /// (1 day, 5 days, 10 days, 20 days, 25 days)
        /// </summary>
        public DayPartForecast[] DailyForecasts { get; set; }

    }

    /// <summary>
    /// Headline highlighting big "weather story"
    /// over the forecast time period.
    /// </summary>
    public class DaypartHeadline
    {
        /// <summary>
        /// Datetime that the headline is in effect
        /// displayed in ISO8601 format: yyyy-mm-ddThh:mm:ss±hh:mm 
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Effective datetime of the headline displayed as the number of seconds
        /// that have elapsed since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public long EffectiveEpochDate { get; set; }

        /// <summary>
        /// Severity of the headline displayed as an integer
        /// The lower the number, the greater the severity 
        /// FMI: < http://api.accuweather.com/developers/forecastsAPIParameters >
        /// </summary>
        public int Severity { get; set; }

        /// <summary>
        /// Headline text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Headline category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Datetime that the headline period ends
        /// displayed in ISO8601 format: yyyy-mm-ddThh:mm:ss±hh:mm
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Effective datetime when the headline period ends
        /// displayed as the number of seconds
        /// that have elapsed since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public long? EpochEndDate { get; set; }
    }

    /// <summary>
    /// Represents one day part forecast
    /// A day part forecast covers a 12 hour block of time
    /// and is often used in extended forecasts 
    /// or other graphics that need a condensed view (summary)
    /// of a day's or night's weather.
    /// </summary>
    public class DayPartForecast
    {
        /// <summary>
        /// Date of the forecast displayed in ISO8601 format: 
        /// yyyy-mm-ddThh:mm:ss±hh:mm
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Date of the forecast displayed as the number of seconds
        /// that have elapsed since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public long EpochDate { get; set; }

        /// <summary>
        /// Solar data for the day part forecast
        /// sunset, sunrise, etc
        /// </summary>
        public SunAlmanacData Sun { get; set; }

        /// <summary>
        /// Moon data for the day part forecast
        /// moonset, moonrise, moon phase, etc.
        /// </summary>
        public MoonAlmanacData Moon { get; set; }

        /// <summary>
        /// Maximum and Minimum temperatures for a given day
        /// </summary>
        public DaypartTemperature Temperature { get; set; }

        /// <summary>
        /// AccuWeather's Feels Like temperature max and min
        /// for a given day
        /// </summary>
        public DaypartTemperature RealFeelTemperature { get; set; }

        /// <summary>
        /// AccuWeather's Feels Like temperature max and min
        /// in the shade for a given day
        /// </summary>
        public DaypartTemperature RealFeelTemperatureShade { get; set; }

        /// <summary>
        /// The number of hours the sun is forecast to shine
        /// on a given day
        /// </summary>
        public double HoursOfSun { get; set; }

        /// <summary>
        /// An array of forecast airborne related items
        /// (pollen, air quality, etc) for a given day
        /// </summary>
        public Air[] AirAndPollen { get; set; }

        /// <summary>
        /// Daylight specific forecast elements
        /// </summary>
        public DaypartElements Day { get; set; }

        /// <summary>
        /// Nighttime specific forecast elements
        /// </summary>
        public DaypartElements Night { get; set; }

    }

    /// <summary>
    /// Solar almanac data for a given day
    /// </summary>
    public class SunAlmanacData
    {

        /// <summary>
        /// Datetime of the moon/sunrise displayed in ISO8601 format: 
        /// yyyy-mm-ddThh:mm:ss±hh:mm for a given day
        /// </summary>
        public DateTime Rise { get; set; }

        /// <summary>
        /// Datetime of the moon/sunset displayed in ISO8601 format: 
        /// yyyy-mm-ddThh:mm:ss±hh:mm for a given day
        /// </summary>
        public DateTime Set { get; set; }

        /// <summary>
        /// Datetime of the moon/sunrise displayed as the number of seconds
        /// that have elapsed since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public long EpochRise { get; set; }

        /// <summary>
        /// Datetime of the moon/sunset displayed as the number of seconds
        /// that have elapsed since January 1, 1970 (midnight UTC/GMT)
        /// </summary>
        public long EpochSet { get; set; }

    }


    /// <summary>
    /// Lunar almanac data for a given day
    /// Extends the solar almanac class
    /// Adding two Properties: Moon Phase and "Age"
    /// </summary>
    public class MoonAlmanacData : SunAlmanacData
    {
        // moon data has two additional Properties

        /// <summary>
        /// A description of the moon phase:
        /// Full, New, Waxing Crescent, Waning Gibbous, etc
        /// </summary>
        public string Phase { get; set; }

        /// <summary>
        /// The "age" of the moon's phase represented as an integer.
        /// 0=New Moon; 1= Waxing Crescent; 2=First Quarter;
        /// 3=Waxing Gibbous; 4=Full Moon; 5 = Waning Gibbous;
        /// 6=Last Quarter; 7=Waning Crescent
        /// </summary>
        public int Age { get; set; } // should probably enumerate

    }

    /// <summary>
    /// Day part temperatures
    /// maximum and minimum
    /// </summary>
    public class DaypartTemperature
    {
        /// <summary>
        /// Minimum (low) temperature object for given day part
        /// contains forecast temperature,
        /// the unit the temperature is represented in
        /// and the UnitType which is an integer
        /// that represents an AccuWeather enumerated unit
        /// </summary>        
        public AccuValUnitType Minimum { get; set; }

        /// <summary>
        /// Maximum (high) temperature object for given day part
        /// contains forecast temperature,
        /// the unit the temperature is represented in
        /// and the UnitType which is an integer
        /// that represents an AccuWeather enumerated unit
        /// </summary>
        public AccuValUnitType Maximum { get; set; }
    }


    /// <summary>
    /// Class that represents day part forecast information
    /// for airborne items (pollen, air quality, etc)
    /// </summary>
    public class Air
    {
        /// <summary>
        /// Name of the pollen or pollution. 
        /// For example: grass, mold, weed, 
        /// air quality, tree and UVindex
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the given type above. 
        /// Values associated with mold, grass, weed and tree 
        /// are in units of parts per cubic meter. 
        /// Both air quality and UV are indices, 
        /// so they are unitless
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Category of the air quality or pollution type.
        /// For example: low, high, good, moderate, unhealthy, hazardous
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Value associated with the category
        /// of the air quality or pollution type. 
        /// These values range from 1 to 5. 
        /// 1 implying good conditions, 
        /// 5 implying bad conditions
        /// </summary>
        public int CategoryValue { get; set; } // should enumerate?

        /// <summary>
        /// Only exists for air quality.
        /// Examples include ozone and particle pollution
        /// check for null value against other types
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Items that are specific to a "12 hour" 
    /// day part vs. the entire day
    /// Instantiated as "Day" and "Night" Properties
    /// </summary>
    public class DaypartElements
    {

        /// <summary>
        /// Forecast weather icon index (wx_code)
        /// for the day part period.
        /// AccuWeather icon values available as enumeration
        /// </summary>
        public int Icon { get; set; } // enumeration available

        /// <summary>
        /// Sensible weather text describing the icon
        /// Mostly Sunny, Partly Cloudy, Heavy Rain, etc.
        /// </summary>
        public string IconPhrase { get; set; } // sensible weather text

        /// <summary>
        /// Sensible weather text describing the forecast day part
        /// Short form but more descriptive than IconPhrase
        /// Maximum: 30 characters
        /// </summary>
        public string ShortPhrase { get; set; } // sensible weather text short form

        /// <summary>
        /// Sensible weather text describing the forecast day part
        /// Long form: more descriptive than ShortPhrase
        /// Maximum: 100 characters
        /// </summary>
        public string LongPhrase { get; set; } // sensible weather text long form

        /// <summary>
        /// Forecast percentage chance of any precipitation (POP) 
        /// in the day part time period.
        /// </summary>
        public double PrecipitationProbability { get; set; }

        /// <summary>
        /// Forecast percentage chance of a thunderstorm 
        /// in the day part time period.
        /// </summary>
        public double ThunderstormProbability { get; set; }

        /// <summary>
        /// Forecast percentage chance of a rain (not snow or ice) 
        /// in the day part time period.
        /// </summary>
        public double RainProbability { get; set; }

        /// <summary>
        /// Forecast percentage chance of a snow (not ice or rain) 
        /// in the day part time period.
        /// </summary>
        public double SnowProbability { get; set; }

        /// <summary>
        /// Forecast percentage chance of a sleet or freezing rain (not snow or rain) 
        /// in the day part time period.
        /// </summary>
        public double IceProbability { get; set; }

        /// <summary>
        /// Average wind speed and direction forecast 
        /// for the day part time period
        /// </summary>
        public WindForecast Wind { get; set; }

        /// <summary>
        /// Maximum wind gust speed and the direction of the gust
        /// forecast for the day part time period
        /// </summary>
        public WindForecast WindGust { get; set; }

        /// <summary>
        /// Total liquid equivalent precipitation forecast
        /// for the day part time period (aka QPF)
        /// </summary>
        public AccuValUnitType TotalLiquid { get; set; }

        /// <summary>
        /// Total rainfall accumulation forecast
        /// for the day part time period
        /// (does not include frozen precip accumulation)
        /// </summary>
        public AccuValUnitType Rain { get; set; }

        /// <summary>
        /// Total snowfall accumulation forecast
        /// for the day part time period
        /// (does not include rain or ice accumulation)
        /// </summary>
        public AccuValUnitType Snow { get; set; }

        /// <summary>
        /// Total sleet and freezing rain accumulation 
        /// forecast for the day part time period
        /// (does not include rain or snow accumulation)
        /// </summary>
        public AccuValUnitType Ice { get; set; }

        /// <summary>
        /// How many hours or portions of an hour
        /// that precipitation is forecast to fall
        /// during the day part time period
        /// </summary>
        public double HoursOfPrecipitation { get; set; }

        /// <summary>
        /// How many hours or portions of an hour
        /// that rain is forecast to fall
        /// during the day part time period
        /// (does not include frozen precipitation)
        /// </summary>
        public double HoursOfRain { get; set; }

        /// <summary>
        /// The percentage of the day part time period
        /// forecast to have cloud cover
        /// </summary>
        public double CloudCover { get; set; }
    }
}
