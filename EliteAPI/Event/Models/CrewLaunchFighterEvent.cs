using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class CrewLaunchFighterEvent : EventBase
    {
        internal CrewLaunchFighterEvent() { }

        public static CrewLaunchFighterEvent FromJson(string json) => JsonConvert.DeserializeObject<CrewLaunchFighterEvent>(json);


        [JsonProperty("Crew")]
        public string Crew { get; internal set; }

        
    }
}