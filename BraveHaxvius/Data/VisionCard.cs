//MST_VISION_CARD_NAME_100000601^Guiding the Youth^Guiding the Youth---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class VisionCard
    {
        public String Name { get; set; }
        public String VisionCardID { get; set; }
        public String Description { get; set; }
        public String Rarity { get; set; }
        public String GameId { get; set; }
        public String CountId { get; set; }
        public String UnitMaxLevel { get; set; }
        public String UnitHp { get; set; }
        public String UnitMp { get; set; }
        public String UnitAtk { get; set; }
        public String UnitDef { get; set; }
        public String UnitMag { get; set; }
        public String UnitSpr { get; set; }
        public String ElementResists { get; set; }
        public String StatusResists { get; set; }
        public String PhysicalResist { get; set; }
        public String MagicalResist { get; set; }
        public String UnitXpGain { get; set; }
        public String BitNumber { get; set; }
        public String IsPotUnit { get; set; }
        public String UnitGilSell { get; set; }
        public String JobId { get; set; }

        public static readonly VisionCard MadDash = new VisionCard { Name = "Mad Dash", VisionCardID = "207000101", Description = "", Rarity = "1", GameId = "10007", CountId = "1", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "1", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard KnightswhoSoartheSkies = new VisionCard { Name = "Knights who Soar the Skies", VisionCardID = "100000201", Description = "", Rarity = "1", GameId = "11001", CountId = "2", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "35,50,0,0", UnitDef = "35,50,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "3", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard TheWaterGodandPriestess = new VisionCard { Name = "The Water God and Priestess", VisionCardID = "100000301", Description = "", Rarity = "1", GameId = "11001", CountId = "3", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "20,40,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "4", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard AVengefulBlow = new VisionCard { Name = "A Vengeful Blow", VisionCardID = "100000401", Description = "", Rarity = "1", GameId = "11001", CountId = "4", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "45,60,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "5", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard MetalGigantuarsHere = new VisionCard { Name = "Metal Gigantuar's Here!", VisionCardID = "900020101", Description = "", Rarity = "1", GameId = "11001", CountId = "5", UnitMaxLevel = "1", UnitHp = "10,10,0,0", UnitMp = "10,10,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "6", IsPotUnit = "1", UnitGilSell = "0", JobId = "910"};
        public static readonly VisionCard thAnniversaryCelebration = new VisionCard { Name = "4th Anniversary Celebration", VisionCardID = "401000301", Description = "", Rarity = "1", GameId = "11001", CountId = "9001", UnitMaxLevel = "10", UnitHp = "100,100,0,0", UnitMp = "50,50,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "9001", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard InOrdertoChangetheWorld = new VisionCard { Name = "In Order to Change the World", VisionCardID = "100000501", Description = "", Rarity = "1", GameId = "11001", CountId = "9", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "9", IsPotUnit = "0", UnitGilSell = "400", JobId = "95"};
        public static readonly VisionCard PlanetsWhisper_207000301 = new VisionCard { Name = "Planet's Whisper", VisionCardID = "207000301", Description = "", Rarity = "1", GameId = "10007", CountId = "10", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "40,65,0,0", UnitSpr = "40,65,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "10", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard ScorpionSentinelBattle_207000201 = new VisionCard { Name = "Scorpion Sentinel Battle", VisionCardID = "207000201", Description = "", Rarity = "1", GameId = "10007", CountId = "7", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "20,60,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "7", IsPotUnit = "0", UnitGilSell = "400", JobId = "95"};
        public static readonly VisionCard GuidingtheYouth_100000601 = new VisionCard { Name = "Guiding the Youth", VisionCardID = "100000601", Description = "", Rarity = "1", GameId = "11001", CountId = "11", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "11", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
/*VersionControldefinitions*/
		public static readonly List<VisionCard> VisionCards = new List<VisionCard>
		{
           MadDash,
           KnightswhoSoartheSkies,
           TheWaterGodandPriestess,
           AVengefulBlow,
           MetalGigantuarsHere,
           thAnniversaryCelebration,
           InOrdertoChangetheWorld,
           PlanetsWhisper_207000301,
           ScorpionSentinelBattle_207000201,
           GuidingtheYouth_100000601,
/*VersionControldefinitionsList*/		};
    }
}