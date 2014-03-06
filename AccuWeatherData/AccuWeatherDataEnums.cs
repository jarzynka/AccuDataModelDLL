using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherData
{

    /// <summary>
    /// This enumeration defines basic unit types that AccuWeather uses for all data unit representation
    /// </summary>
    public enum UnitTypes
    {
        Feet = 0,
        Inches = 1,
        Miles = 2,
        Millimeter = 3,
        Centimeter = 4,
        Meter = 5,
        Kilometer = 6,
        KilometersPerHour = 7,
        Knots = 8,
        MilesPerHour = 9,
        MetersPerSecond = 10,
        HectoPascals = 11,
        InchesOfMercury = 12,
        KiloPascals = 13,
        Millibars = 14,
        MillimetersOfMercury = 15,
        PoundsPerSquareInch = 16,
        Celsius = 17,
        Fahrenheit = 18,
        Kelvin = 19,
        Percent = 20,
        Float = 21,
        Integer = 22
    }

    /// <summary>
    /// This enumeration defines weather icon mapping that AccuWeather uses for all weather icon representation
    /// </summary>
    public enum WeatherIcons
    {
        Sunny = 1,
        MostlySunny = 2,
        PartlySunny = 3,
        IntermittentClouds = 4,
        HazySunshine = 5,
        MostlyCloudy = 6,
        Cloudy = 7,
        DrearyOvercast = 8,
        Fog = 11,
        Showers = 12,
        MostlyCloudyShowers = 13,
        PartlySunnyShowers = 14,
        Tstorms = 15,
        MostlyCloudyTstorms = 16,
        PartlySunnyTstorms = 17,
        Rain = 18,
        Flurries = 19,
        MostlyCloudyFlurries = 20,
        PartlySunnyFlurries = 21,
        Snow = 22,
        MostlyCloudySnow = 23,
        Ice = 24,
        Sleet = 25,
        FreezingRain = 26,
        RainSnow = 29,
        Hot = 30,
        Cold = 31,
        ClearNight = 33,
        MostlyClearNight = 34,
        PartlyCloudyNight = 35,
        IntermittentCloudsNight = 36,
        HazyMoonlight = 37,
        MostlyCloudyNight = 38,
        PartlyCloudyShowersNight = 39,
        MostlyCloudyShowersNight = 40,
        PartlyCloudyTstormsNight = 41,
        MostlyCloudyTstormsNight = 42,
        MostlyCloudyFlurriesNight = 43,
        MostlyCloudySnowNight = 44
    }

    /// <summary>
    /// This enumeration represents the pressure tendency
    /// based on a the pressure difference betweeen an observation
    /// and a previous observation (usually 1 hour, 3 hours or 6 hours prior)
    /// The enumeration can be used as a Comparator
    /// to map to an icon representing this trend
    /// </summary>
    public enum PressureTendencyStatus
    {
        F = -1,
        R = 1,
        S = 0
    }
    
}
