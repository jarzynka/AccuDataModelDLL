using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherData
{
    /// <summary>
    /// Object representation of AccuWeather Location JSON object
    /// API Docs: http://api.accuweather.com/developers/locations
    /// Since root object is an array of returned locations
    /// Instantiate using JSON.NET's JsonConvert.DeserializeString<List<Location>>(jsonString)
    /// and use parsing techniques on the List to return information on each Location
    /// </summary>

    public class Location
    {
        /// <summary>
        /// API version used to retrieve location data
        /// </summary>
        public int Version { get; set; } 
        
        /// <summary>
        /// AccuWeather's Unique ID for a specific location
        /// </summary>
        public string Key { get; set; } // AccuWeather Unique ID Key for location
        
        /// <summary>
        /// Text representation of what this location is:
        /// City, Road, Park, etc
        /// </summary>
        public string Type { get; set; } // enumeration?
        
        /// <summary>
        /// Number appiled to locations set by factors such as population, 
        /// political importance, and geographic size (lower number is higher rank)
        /// Used to sort multiple locations with the same name
        /// Ex. Berlin, Germany has lower number than Berlin, NH, US or Berlin, MA, US
        /// </summary>
        public int Rank { get; set; } 
        
        /// <summary>
        /// Display name text in local dialect set with language code in REST URI. Default is US English (us-en)
        /// </summary>
        public string LocalizedName { get; set; } 
        
        /// <summary>
        /// Location name text as displayed in English
        /// </summary>
        public string EnglishName { get; set; } // Name of location in English
        
        /// <summary>
        /// Official postal (zip) code provided by 
        /// our main location data provider for the requested location
        /// </summary>
        public string PrimaryPostalCode { get; set; } // Main zip code or postal code for location
        
        /// <summary>
        /// Defines the AccuWeather Region (i.e., North America, Asia, etc) of the location
        /// </summary>
        public Region Region { get; set; } 
        
        /// <summary>
        /// The location's country
        /// </summary>
        public Country Country { get; set; } // Object that defined the country of the location (i.e., "US", "United States")
        
        /// <summary>
        /// Primary political administration area of location
        /// Ex. state, province, republik
        /// </summary>
        public AdministrativeArea AdministrativeArea { get; set; } // object defining what major political area the location belongs to (state, province)
        
        /// <summary>
        /// Time zone that the location falls under
        /// </summary>
        public Timezone TimeZone { get; set; }  // object defining time zone information
        
        /// <summary>
        /// Geographic position of the location on the Earth (lat, lon, elevation)
        /// </summary>
        public Geoposition GeoPosition { get; set; } // object defining the geographic positioning of the location (lat, lon, elevation)
        
        /// <summary>
        /// Verification of whether a location is an “alias” or an alternative name or spelling for a requested location
        /// (i.e., St. Louis for Saint Louis)
        /// </summary>
        public bool IsAlias { get; set; } 
        
        /// <summary>
        /// A collection of administration areas other than the primary
        /// ex. county, parish, oblast, city administration district
        /// </summary>
        public SupplementalAdminArea[] SupplementalAdminAreas { get; set; } // location's local political administration area (a county)
        
        /// <summary>
        /// Related details about the location
        /// </summary>
        public Details Details { get; set; } // additional data returned when details=true
    }

    /// <summary>
    /// Class that represents an AccuWeather Region - a continent, basically
    /// http://api.accuweather.com/developers/regions
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Unique region code for location
        /// (i.e., NAM=North America; SAM=South America; EUR=Europe; MEA = Middle East)
        /// </summary>
        public string ID { get; set; } 
        
        /// <summary>
        /// Region name text displayed in the local dialect set with the language code in the URI REST call. 
        /// If no language code is selected, the default is US English (us-en)
        /// </summary>
        public string LocalizedName { get; set; } 
        
        /// <summary>
        /// Region name text displayed in English
        /// </summary>
        public string EnglishName { get; set; } 
    }
    /// <summary>
    /// Class that represents a Country
    /// http://api.accuweather.com/developers/countries
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Unique ISO or Microsoft Localization Code for the country
        /// </summary>
        public string ID { get; set; } 
        
        /// <summary>
        /// Country name text as displayed in the local dialect set with language code in the URI REST call. 
        /// If no language code is selected, the default is US English (us-en)
        /// </summary>
        public string LocalizedName { get; set; } 
        
        /// <summary>
        /// Country name text displayed in English
        /// </summary>
        public string EnglishName { get; set; } 
    }

    /// <summary>
    /// A primary political region of a country such as a state, province or republic
    /// http://api.accuweather.com/developers/administrativeareas
    /// </summary>
    public class AdministrativeArea
    {
        /// <summary>
        /// Unique administrative area ID
        /// (ex. state/province postal abbreviation)
        /// </summary>
        public string ID { get; set; } 
        
        /// <summary>
        /// Administrative area name as displayed in local dialect set with language code in the URI REST call.
        /// If no language code is selected, the default is English
        /// </summary>
        public string LocalizedName { get; set; } // "state's" localized full name 
        
        /// <summary>
        /// Administrative area name displayed in English
        /// </summary>
        public string EnglishName { get; set; } // "state's" full name in English
        
        /// <summary>
        /// An assigned index number to describe the scale of the administrative subdivisions for countries. 
        /// As the Level number increases, the scale of the subdivision will decrease. 
        /// Numbers of 10 or greater are reserved for non-political boundaries and should be used independently
        /// </summary>
        public int Level { get; set; } // Administrative Area's Region Level (should usually be 1)
        
        /// <summary>
        /// The type of this administrative area as displayed in local dialect set with language code in the URI REST call.
        /// If no language code is selected, the default is English
        /// </summary>
        public string LocalizedType { get; set; } // what is this area (native language)?  state, province, respublik
        
        /// <summary>
        /// The type of this administrative area displayed in English
        /// </summary>
        public string EnglishType { get; set; } // what is this area (English)? state, province, republic
        
        /// <summary>
        /// The Country ID that this administrative area belongs to.
        /// See: Country Class
        /// </summary>
        public string CountryID { get; set; } // what country ID does this area belong to?
    }

    /// <summary>
    /// This class represents a secondary or more local political administrative district
    /// In the US this is usually a County or Parish
    /// http://api.accuweather.com/developers/administrativeareas
    /// </summary>
    public class SupplementalAdminArea
    {
        /// <summary>
        /// An assigned index number to describe the scale of the administrative subdivisions for countries. 
        /// As the Level number increases, the scale of the subdivision will decrease. 
        /// Numbers of 10 or greater are reserved for non-political boundaries and should be used independently
        /// </summary>
        public int Level { get; set; } 

        /// <summary>
        /// Administrative area name as displayed in local dialect set with language code in the URI REST call.
        /// If no language code is selected, the default is English
        /// </summary>
        public string LocalizedName { get; set; } 

        /// <summary>
        /// Country name text displayed in English
        /// </summary>
        public string EnglishName { get; set; } 
    }

    /// <summary>
    /// Timezone information for the location
    /// </summary>
    public class Timezone
    {
        /// <summary>
        /// Official abbreviation code text for designated Time Zone
        /// ex. EST, CST, PDT
        /// </summary>
        public string Code { get; set; }  
        
        /// <summary>
        /// Official name text of designated Time Zone
        /// ex. "America/New_York"
        /// </summary>
        public string Name { get; set; } 
        
        /// <summary>
        /// Number of hours offset from local GMT/UTC time
        /// </summary>
        public float GmtOffset { get; set; } 
        
        /// <summary>
        /// Verification of whether a location is currently observing Day Light Saving time
        /// </summary>
        public bool IsDaylightSaving { get; set; } 
        
        /// <summary>
        /// Next time if and when daylight saving time changes 
        /// (is Nullable type!  Check for Exceptions!)
        /// </summary>
        public DateTime? NextOffsetChange { get; set; } // if location uses daylight savings when does the next clock change hapen?
    }

    /// <summary>
    /// Represents the location's position on the Earth
    /// </summary>
    public class Geoposition
    {
        
        /// <summary>
        /// Geographical coordinate that specifies the north-south position of a point on the Earth’s surface
        /// expressed in degrees and decimal portions of degrees
        /// </summary>
        public float Latitude { get; set; } // location's latitude
        
        /// <summary>
        /// Geographical coordinate that specifies the east-west position of a point on the Earth’s surface
        /// expressed in degrees and decimal portions of degrees
        /// </summary>
        public float Longitude { get; set; } // location's longitude
        
        /// <summary>
        /// Representation of locations elevation in relation to mean sea level
        /// </summary>
        public Elevation Elevation { get; set; } // Object that represents location's elevation
    }

    /// <summary>
    /// Representation of a position relative to mean sea level
    /// </summary>
    public class Elevation
    {
        /// <summary>
        /// Location's elevation in Metric (SI) units
        /// includes measurement units and unit type
        /// </summary>
        public AccuValUnitType Metric { get; set; } 

        /// <summary>
        /// Location's elevation in Imperial units
        /// includes measurement units and unit type
        /// </summary>
        public AccuValUnitType Imperial { get; set; } 
    }

    

    /// <summary>
    /// AccuWeather related details about the specific location
    /// Data only returned when URI variable details = true
    /// </summary>
    public class Details
    {
        
        /// <summary>
        /// AccuWeather Unique ID for location
        /// </summary>
        public string Key { get; set; } // the AccuWeather unique ID for the location
       
        /// <summary>
        /// Closest Weather observation station to the location
        /// text code  (ICAO)
        /// </summary>
        public string StationCode { get; set; } 
        
        /// <summary>
        /// Hours offset between the closest weather observation station and GMT/UTC
        /// </summary>
        public float StationGmtOffset { get; set; } 
        
        /// <summary>
        /// Temperature and precipitation band map code for location
        /// used to retrieve image contour tile from AccuWeather
        /// </summary>
        public string BandMap { get; set; } 
        
        /// <summary>
        /// Source of climatology data for the location
        /// </summary>
        public string Climo { get; set; } 
        
        /// <summary>
        /// Local radar code associated with the location 
        /// (closest radar site to the location)
        /// </summary>
        public string LocalRadar { get; set; } 
        
        /// <summary>
        /// Media region associated with the location
        /// ex. NE, SE, SW, etc
        /// </summary>
        public string MediaRegion { get; set; } 
        
        /// <summary>
        /// Closest METAR reporting station to this location
        /// </summary>
        public string Metar { get; set; } 
        
        /// <summary>
        /// City level radar code
        /// </summary>
        public string NXMetro { get; set; }         
        
        /// <summary>
        /// State level radar code 
        /// </summary>
        public string NXState { get; set; }
        
        /// <summary>
        /// Location population
        /// (is Nullable type!  Check for Exceptions!)
        /// </summary>
        public int? Population { get; set; } 

        /// <summary>
        /// Location's NWS primary warning county ID
        /// </summary>
        public string PrimaryWarningCountyCode { get; set; }  

        /// <summary>
        /// Location's NWS primary warning zone ID - often county or sub-county
        /// </summary>
        public string PrimaryWarningZoneCode { get; set; } 

        /// <summary>
        /// Satellite map code for location
        /// used to retrieve image contour tile from AccuWeather
        /// </summary>
        public string Satellite { get; set; }
        
        /// <summary>
        /// Closest METAR station's international synoptic ID?
        /// </summary>
        public string Synoptic { get; set; }
        
        /// <summary>
        /// Closest MARINE reporting station's code
        /// </summary>
        public string MarineStation { get; set; } 

        /// <summary>
        /// Time difference, in hours, between closest MARINE reporting station's code and GMT/UTC
        /// </summary>
        public float? MarineStationGMTOffset { get; set; } 
        
        /// <summary>
        /// Code that identifies city or region for video
        /// </summary>
        public string VideoCode { get; set; } 
        
        /// <summary>
        /// Represents location's local television market (DMA)
        /// </summary>
        public DMA DMA { get; set; } 
        
        /// <summary>
        /// Collection of data sources available for this location
        /// ex. Alerts, Daily Forecast, Hourly Forecast, Current Conditions
        /// </summary>
        public Source[] Sources { get; set; } 
        
        /// <summary>
        /// Main postal code for location
        /// </summary>
        public string CanonicalPostalCode { get; set; } 
        
        /// <summary>
        /// AccuWeather Unique ID for the location
        /// </summary>
        public string CanonicalLocationKey { get; set; } 
    }

    /// <summary>
    /// Class that represents local television market information for a Location
    /// Desginated Market Area (DMA)
    /// </summary>
    public class DMA
    {
        
        /// <summary>
        /// Television Broadcast Desginated Market Area (DMA)
        /// Identification text
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Television Broadcast Desginated Market Area (DMA)
        /// full text description in English
        /// </summary>
        public string EnglishName { get; set; } 
    }

    /// <summary>
    /// Represents an AccuWeather data source: Alert, Daily Forecast, Hourly Forecast
    /// </summary>
    public class Source
    {
        
        /// <summary>
        /// Data source type: "Alerts", "DailyForecast", "HourlyForecast", "Climo", etc
        /// </summary>
        public string DataType { get; set; } // the infomration type available for location: "Alerts", "DailyForecast", etc
        
        /// <summary>
        /// The original source of the Data Type
        /// ex. AccuWeather, US National Weather Service, etc.
        /// </summary>
        public string DataSource { get; set; } // where does the infomration come from? (AccuWeather, US National Weather Service, etc)
    }
}
