
namespace EliteAPI.Event.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Abstractions;


    public partial class StatisticsEvent : EventBase
    {
        internal StatisticsEvent() { }

        [JsonProperty("Bank_Account")]
        public BankAccountInfo BankAccount { get; private set; }

        [JsonProperty("CombatInfo")]
        public CombatInfo Combat { get; private set; }

        [JsonProperty("CrimeInfo")]
        public CrimeInfo Crime { get; private set; }

        [JsonProperty("SmugglingInfo")]
        public SmugglingInfo Smuggling { get; private set; }

        [JsonProperty("TradingInfo")]
        public TradingInfo Trading { get; private set; }

        [JsonProperty("MiningInfo")]
        public MiningInfo Mining { get; private set; }

        [JsonProperty("ExplorationInfo")]
        public ExplorationInfo Exploration { get; private set; }

        [JsonProperty("PassengersInfo")]
        public PassengersInfo Passengers { get; private set; }

        [JsonProperty("Search_And_Rescue")]
        public SearchAndRescueInfo SearchAndRescue { get; private set; }

        [JsonProperty("TG_ENCOUNTERS")]
        public TgEncountersInfo TgEncounters { get; private set; }

        [JsonProperty("CraftingInfo")]
        public CraftingInfo Crafting { get; private set; }

        [JsonProperty("CrewInfo")]
        public CrewInfo Crew { get; private set; }

        [JsonProperty("MulticrewInfo")]
        public MulticrewInfo Multicrew { get; private set; }

        [JsonProperty("Material_Trader_Stats")]
        public MaterialTraderStatsInfo MaterialTraderStats { get; private set; }
    

    public partial class BankAccountInfo
    {
        internal BankAccountInfo() { }

        [JsonProperty("Current_Wealth")]
        public long CurrentWealth { get; private set; }

        [JsonProperty("Spent_On_Ships")]
        public long SpentOnShips { get; private set; }

        [JsonProperty("Spent_On_Outfitting")]
        public long SpentOnOutfitting { get; private set; }

        [JsonProperty("Spent_On_Repairs")]
        public long SpentOnRepairs { get; private set; }

        [JsonProperty("Spent_On_Fuel")]
        public long SpentOnFuel { get; private set; }

        [JsonProperty("Spent_On_Ammo_Consumables")]
        public long SpentOnAmmoConsumables { get; private set; }

        [JsonProperty("Insurance_Claims")]
        public long InsuranceClaims { get; private set; }

        [JsonProperty("Spent_On_Insurance")]
        public long SpentOnInsurance { get; private set; }

        [JsonProperty("Owned_Ship_Count")]
        public long OwnedShipCount { get; private set; }
    }

    public partial class CombatInfo
    {
        internal CombatInfo() { }

        [JsonProperty("Bounties_Claimed")]
        public long BountiesClaimed { get; private set; }

        [JsonProperty("Bounty_Hunting_Profit")]
        public long BountyHuntingProfit { get; private set; }

        [JsonProperty("CombatInfo_Bonds")]
        public long CombatInfoBonds { get; private set; }

        [JsonProperty("CombatInfo_Bond_Profits")]
        public long CombatInfoBondProfits { get; private set; }

        [JsonProperty("Assassinations")]
        public long Assassinations { get; private set; }

        [JsonProperty("Assassination_Profits")]
        public long AssassinationProfits { get; private set; }

        [JsonProperty("Highest_Single_Reward")]
        public long HighestSingleReward { get; private set; }

        [JsonProperty("Skimmers_Killed")]
        public long SkimmersKilled { get; private set; }
    }

    public partial class CraftingInfo
    {
        internal CraftingInfo() { }

        [JsonProperty("Count_Of_Used_Engineers")]
        public long CountOfUsedEngineers { get; private set; }

        [JsonProperty("Recipes_Generated")]
        public long RecipesGenerated { get; private set; }

        [JsonProperty("Recipes_Generated_Rank_1")]
        public long RecipesGeneratedRank1 { get; private set; }

        [JsonProperty("Recipes_Generated_Rank_2")]
        public long RecipesGeneratedRank2 { get; private set; }

        [JsonProperty("Recipes_Generated_Rank_3")]
        public long RecipesGeneratedRank3 { get; private set; }

        [JsonProperty("Recipes_Generated_Rank_4")]
        public long RecipesGeneratedRank4 { get; private set; }

        [JsonProperty("Recipes_Generated_Rank_5")]
        public long RecipesGeneratedRank5 { get; private set; }
    }

    public partial class CrewInfo
    {
        internal CrewInfo() { }

        [JsonProperty("NpcCrewInfo_TotalWages")]
        public long NpcCrewInfoTotalWages { get; private set; }

        [JsonProperty("NpcCrewInfo_Hired")]
        public long NpcCrewInfoHired { get; private set; }

        [JsonProperty("NpcCrewInfo_Fired")]
        public long NpcCrewInfoFired { get; private set; }

        [JsonProperty("NpcCrewInfo_Died")]
        public long NpcCrewInfoDied { get; private set; }
    }

    public partial class CrimeInfo
    {
        internal CrimeInfo() { }

        [JsonProperty("Notoriety")]
        public long Notoriety { get; private set; }

        [JsonProperty("Fines")]
        public long Fines { get; private set; }

        [JsonProperty("Total_Fines")]
        public long TotalFines { get; private set; }

        [JsonProperty("Bounties_Received")]
        public long BountiesReceived { get; private set; }

        [JsonProperty("Total_Bounties")]
        public long TotalBounties { get; private set; }

        [JsonProperty("Highest_Bounty")]
        public long HighestBounty { get; private set; }
    }

    public partial class ExplorationInfo
    {
        internal ExplorationInfo() { }

        [JsonProperty("Systems_Visited")]
        public long SystemsVisited { get; private set; }

        [JsonProperty("ExplorationInfo_Profits")]
        public long ExplorationInfoProfits { get; private set; }

        [JsonProperty("Planets_Scanned_To_Level_2")]
        public long PlanetsScannedToLevel2 { get; private set; }

        [JsonProperty("Planets_Scanned_To_Level_3")]
        public long PlanetsScannedToLevel3 { get; private set; }

        [JsonProperty("Efficient_Scans")]
        public long EfficientScans { get; private set; }

        [JsonProperty("Highest_Payout")]
        public long HighestPayout { get; private set; }

        [JsonProperty("Total_Hyperspace_Distance")]
        public long TotalHyperspaceDistance { get; private set; }

        [JsonProperty("Total_Hyperspace_Jumps")]
        public long TotalHyperspaceJumps { get; private set; }

        [JsonProperty("Greatest_Distance_From_Start")]
        public double GreatestDistanceFromStart { get; private set; }

        [JsonProperty("Time_Played")]
        public long TimePlayed { get; private set; }
    }

    public partial class MaterialTraderStatsInfo
    {
        internal MaterialTraderStatsInfo() { }

        [JsonProperty("Trades_Completed")]
        public long TradesCompleted { get; private set; }

        [JsonProperty("Materials_Traded")]
        public long MaterialsTraded { get; private set; }

        [JsonProperty("Encoded_Materials_Traded")]
        public long EncodedMaterialsTraded { get; private set; }

        [JsonProperty("Raw_Materials_Traded")]
        public long RawMaterialsTraded { get; private set; }

        [JsonProperty("Grade_2_Materials_Traded")]
        public long Grade2_MaterialsTraded { get; private set; }

        [JsonProperty("Grade_3_Materials_Traded")]
        public long Grade3_MaterialsTraded { get; private set; }

        [JsonProperty("Grade_4_Materials_Traded")]
        public long Grade4_MaterialsTraded { get; private set; }

        [JsonProperty("Grade_5_Materials_Traded")]
        public long Grade5_MaterialsTraded { get; private set; }
    }

    public partial class MiningInfo
    {
        internal MiningInfo() { }

        [JsonProperty("MiningInfo_Profits")]
        public long MiningInfoProfits { get; private set; }

        [JsonProperty("Quantity_Mined")]
        public long QuantityMined { get; private set; }

        [JsonProperty("Materials_Collected")]
        public long MaterialsCollected { get; private set; }
    }

    public partial class MulticrewInfo
    {
        internal MulticrewInfo() { }

        [JsonProperty("MulticrewInfo_Time_Total")]
        public long MulticrewInfoTimeTotal { get; private set; }

        [JsonProperty("MulticrewInfo_Gunner_Time_Total")]
        public long MulticrewInfoGunnerTimeTotal { get; private set; }

        [JsonProperty("MulticrewInfo_Fighter_Time_Total")]
        public long MulticrewInfoFighterTimeTotal { get; private set; }

        [JsonProperty("MulticrewInfo_Credits_Total")]
        public long MulticrewInfoCreditsTotal { get; private set; }

        [JsonProperty("MulticrewInfo_Fines_Total")]
        public long MulticrewInfoFinesTotal { get; private set; }
    }

    public partial class PassengersInfo
    {
        internal PassengersInfo() { }

        [JsonProperty("PassengersInfo_Missions_Accepted")]
        public long PassengersInfoMissionsAccepted { get; private set; }

        [JsonProperty("PassengersInfo_Missions_Disgruntled")]
        public long PassengersInfoMissionsDisgruntled { get; private set; }

        [JsonProperty("PassengersInfo_Missions_Bulk")]
        public long PassengersInfoMissionsBulk { get; private set; }

        [JsonProperty("PassengersInfo_Missions_VIP")]
        public long PassengersInfoMissionsVip { get; private set; }

        [JsonProperty("PassengersInfo_Missions_Delivered")]
        public long PassengersInfoMissionsDelivered { get; private set; }

        [JsonProperty("PassengersInfo_Missions_Ejected")]
        public long PassengersInfoMissionsEjected { get; private set; }
    }

    public partial class SearchAndRescueInfo
    {
        internal SearchAndRescueInfo() { }

        [JsonProperty("SearchRescue_Traded")]
        public long SearchRescueTraded { get; private set; }

        [JsonProperty("SearchRescue_Profit")]
        public long SearchRescueProfit { get; private set; }

        [JsonProperty("SearchRescue_Count")]
        public long SearchRescueCount { get; private set; }
    }

    public partial class SmugglingInfo
    {
        internal SmugglingInfo() { }

        [JsonProperty("Black_Markets_Traded_With")]
        public long BlackMarketsTradedWith { get; private set; }

        [JsonProperty("Black_Markets_Profits")]
        public long BlackMarketsProfits { get; private set; }

        [JsonProperty("Resources_Smuggled")]
        public long ResourcesSmuggled { get; private set; }

        [JsonProperty("Average_Profit")]
        public long AverageProfit { get; private set; }

        [JsonProperty("Highest_Single_Transaction")]
        public long HighestSingleTransaction { get; private set; }
    }

    public partial class TgEncountersInfo
    {
        internal TgEncountersInfo() { }

        [JsonProperty("TG_ENCOUNTER_TOTAL")]
        public long TgEncounterTotal { get; private set; }

        [JsonProperty("TG_ENCOUNTER_TOTAL_LAST_SYSTEM")]
        public string TgEncounterTotalLastSystem { get; private set; }

        [JsonProperty("TG_ENCOUNTER_TOTAL_LAST_TIMESTAMP")]
        public string TgEncounterTotalLastTimestamp { get; private set; }

        [JsonProperty("TG_ENCOUNTER_TOTAL_LAST_SHIP")]
        public string TgEncounterTotalLastShip { get; private set; }

        [JsonProperty("TG_SCOUT_COUNT")]
        public long TgScoutCount { get; private set; }
    }

    public partial class TradingInfo
    {
        internal TradingInfo() { }

        [JsonProperty("Markets_Traded_With")]
        public long MarketsTradedWith { get; private set; }

        [JsonProperty("Market_Profits")]
        public long MarketProfits { get; private set; }

        [JsonProperty("Resources_Traded")]
        public long ResourcesTraded { get; private set; }

        [JsonProperty("Average_Profit")]
        public double AverageProfit { get; private set; }

        [JsonProperty("Highest_Single_Transaction")]
        public long HighestSingleTransaction { get; private set; }
    }

}

    public partial class StatisticsEvent
    {
        public static StatisticsEvent FromJson(string json) => JsonConvert.DeserializeObject<StatisticsEvent>(json);
    }

    
}

namespace EliteAPI.Event.Handler
{
    using System;
    using Models;

    public partial class EventHandler
    {
        public event EventHandler<StatisticsEvent> StatisticsEvent;
        internal void InvokeStatisticsEvent(StatisticsEvent arg) => StatisticsEvent?.Invoke(this, arg);
    }
}