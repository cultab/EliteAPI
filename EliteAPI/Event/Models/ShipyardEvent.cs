using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class ShipyardEvent : EventBase
    {
        internal ShipyardEvent() { }

        public static ShipyardEvent FromJson(string json) => JsonConvert.DeserializeObject<ShipyardEvent>(json);


        [JsonProperty("MarketID")]
        public long MarketId { get; internal set; }

        [JsonProperty("StationName")]
        public string StationName { get; internal set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; internal set; }

        
    }
}