using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EliteAPI.Event.Models
{
    public static class JsonSettings
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            MetadataPropertyHandling = MetadataPropertyHandling.Default,
            DateParseHandling = DateParseHandling.DateTime,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
            CheckAdditionalContent = true
        };
    }
}