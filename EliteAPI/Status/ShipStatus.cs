﻿namespace EliteAPI.Status
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ShipStatus
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("Flags")]
        public long Flags { get; set; }

        [JsonProperty("Pips")]
        public List<long> Pips { get; set; }

        [JsonProperty("FireGroup")]
        public long FireGroup { get; set; }

        [JsonProperty("GuiFocus")]
        public long GuiFocus { get; set; }

        [JsonProperty("Fuel")]
        public Fuel Fuel { get; set; }

        [JsonProperty("Cargo")]
        public long Cargo { get; set; }

        public bool Docked { get { return GetFlag(0); } }
        public bool Landed { get { return GetFlag(1); } }
        public bool Gear { get { return GetFlag(2); } }
        public bool Shields { get { return GetFlag(3); } }
        public bool Supercruise { get { return GetFlag(4); } }
        public bool FlightAssist { get { return !GetFlag(5); } }
        public bool Hardpoints { get { return GetFlag(6); } }
        public bool Winging { get { return GetFlag(7); } }
        public bool Lights { get { return GetFlag(8); } }
        public bool CargoScoop { get { return GetFlag(9); } }
        public bool SilentRunning { get { return GetFlag(10); } }
        public bool Scooping { get { return GetFlag(11); } }
        public bool SrvHandbreak { get { return GetFlag(12); } }
        public bool SrvTurrent { get { return GetFlag(13); } }
        public bool SrvNearShip { get { return GetFlag(14); } }
        public bool SrvDriveAssist { get { return GetFlag(15); } }
        public bool MassLocked { get { return GetFlag(16); } }
        public bool FsdCharging { get { return GetFlag(17); } }
        public bool FsdCooldown { get { return GetFlag(18); } }
        public bool LowFuel { get { return GetFlag(19); } }
        public bool Overheating { get { return GetFlag(20); } }
        public bool HasLatlong { get { return GetFlag(21); } }
        public bool InDanger { get { return GetFlag(22); } }
        public bool InInterdiction { get { return GetFlag(23); } }
        public bool InMothership { get { return GetFlag(24); } }
        public bool InFighter { get { return GetFlag(25); } }
        public bool InSRV { get { return GetFlag(26); } }
        public bool AnalysisMode { get { return GetFlag(27); } }
        public bool NightVision { get { return GetFlag(28); } }

        public bool InNoFireZone { get; set; }

        public bool GetFlag(long bit)
        {
            char[] carray = Convert.ToString(Flags, 2).ToCharArray();
            Array.Reverse(carray);
            try { return Equals(carray[bit], '1'); } catch { return false; }
        }
    }

    public partial class Fuel
    {
        [JsonProperty("FuelMain")]
        public long FuelMain { get; set; }

        [JsonProperty("FuelReservoir")]
        public double FuelReservoir { get; set; }
    }

    public partial class ShipStatus
    {
        public static ShipStatus FromJson(string json) => JsonConvert.DeserializeObject<ShipStatus>(json, EliteAPI.Status.ShipStatusConverter.Settings);
        public static ShipStatus FromFile(FileInfo file, EliteDangerousAPI api)
        {
            try
            {
                if (!File.Exists(file.FullName)) { api.Logger.LogError("Could not find Status.json."); return new ShipStatus(); }

                //Create a stream from the log file.
                FileStream fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                //Create a stream from the file stream.
                StreamReader streamReader = new StreamReader(fileStream);

                //Go through the stream.
                while (!streamReader.EndOfStream)
                {
                    //Process this string.
                    string json = streamReader.ReadLine();
                    return FromJson(json);
                }

                return api.Status;

            }
            catch { api.Logger.LogWarning("Could not update status.");}

            return new ShipStatus();
        }
    }

    public static class ShipStatusSerializer
    {
        public static string ToJson(this ShipStatus self) => JsonConvert.SerializeObject(self, EliteAPI.Status.ShipStatusConverter.Settings);
    }

    public static class ShipStatusConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
