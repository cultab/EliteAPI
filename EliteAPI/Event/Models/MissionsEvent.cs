
namespace EliteAPI.Event.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Abstractions;


    public partial class MissionsEvent : EventBase
    {
        internal MissionsEvent() { }

        [JsonProperty("Active")]
        public IReadOnlyList<object> Active { get; private set; }

        [JsonProperty("Failed")]
        public IReadOnlyList<object> Failed { get; private set; }

        [JsonProperty("Complete")]
        public IReadOnlyList<object> Complete { get; private set; }
    }

    public partial class MissionsEvent
    {
        public static MissionsEvent FromJson(string json) => JsonConvert.DeserializeObject<MissionsEvent>(json);
    }

    
}

namespace EliteAPI.Event.Handler
{
    using System;
    using Models;

    public partial class EventHandler
    {
        public event EventHandler<MissionsEvent> MissionsEvent;
        internal void InvokeMissionsEvent(MissionsEvent arg) => MissionsEvent?.Invoke(this, arg);
    }
}