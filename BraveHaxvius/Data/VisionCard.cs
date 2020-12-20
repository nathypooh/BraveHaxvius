//MST_VISION_CARD_NAME_206000201^Separation and Restoration^Separation and Restoration---VersionControl
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
        public static readonly VisionCard VirtualTraining_401000101 = new VisionCard { Name = "Virtual Training", VisionCardID = "401000101", Description = "", Rarity = "1", GameId = "11001", CountId = "9003", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "50,100,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "9003", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard AzureSuccessor_401000401 = new VisionCard { Name = "Azure Successor", VisionCardID = "401000401", Description = "", Rarity = "1", GameId = "11001", CountId = "9002", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "35,60,0,0", UnitDef = "0,0,0,0", UnitMag = "35,60,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "9002", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard JudgeMagister_212000101 = new VisionCard { Name = "Judge Magister", VisionCardID = "212000101", Description = "", Rarity = "1", GameId = "10012", CountId = "14", UnitMaxLevel = "10", UnitHp = "400,800,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "40,80,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "14", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard ANewJourney_100000101 = new VisionCard { Name = "A New Journey", VisionCardID = "100000101", Description = "", Rarity = "1", GameId = "11001", CountId = "6", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "50,80,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "2", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard BattlewiththeBlackKnights_202000101 = new VisionCard { Name = "Battle with the Black Knights", VisionCardID = "202000101", Description = "", Rarity = "1", GameId = "10002", CountId = "15", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "50,90,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "15", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard MadamandtheGiantBirdBennu_100001101 = new VisionCard { Name = "Madam and the Giant Bird, Bennu", VisionCardID = "100001101", Description = "", Rarity = "1", GameId = "11001", CountId = "18", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "18", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard DemonWhoLearnedHumanity_401000201 = new VisionCard { Name = "Demon Who Learned Humanity", VisionCardID = "401000201", Description = "", Rarity = "1", GameId = "11001", CountId = "9004", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "35,110,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "9004", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard TheHeartlessSage_100000701 = new VisionCard { Name = "The Heartless Sage", VisionCardID = "100000701", Description = "", Rarity = "1", GameId = "11001", CountId = "12", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "40,100,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "12", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard WakeUpCoeurl_100000801 = new VisionCard { Name = "Wake-Up Coeurl", VisionCardID = "100000801", Description = "", Rarity = "1", GameId = "11001", CountId = "13", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "50,80,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "13", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard TooCoolfortheSummer_100001501 = new VisionCard { Name = "Too Cool for the Summer", VisionCardID = "100001501", Description = "", Rarity = "1", GameId = "11001", CountId = "17", UnitMaxLevel = "10", UnitHp = "400,800,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "40,80,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "17", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard CrystalsRevelation_203000101 = new VisionCard { Name = "Crystal's Revelation", VisionCardID = "203000101", Description = "", Rarity = "1", GameId = "10003", CountId = "25", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,80,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "25", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard ThePaopuFruitsBond_335000301 = new VisionCard { Name = "The Paopu Fruit's Bond", VisionCardID = "335000301", Description = "", Rarity = "1", GameId = "20033", CountId = "21", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "36,72,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "44,88,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "21", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard FacingtheDemonTower_335000201 = new VisionCard { Name = "Facing the Demon Tower", VisionCardID = "335000201", Description = "", Rarity = "1", GameId = "20033", CountId = "20", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "35,110,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "20", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard TheKeybladeGraveyardBattle_335000101 = new VisionCard { Name = "The Keyblade Graveyard Battle", VisionCardID = "335000101", Description = "", Rarity = "1", GameId = "20033", CountId = "19", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "50,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "19", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard ADayintheLifeofPhysalis_100000901 = new VisionCard { Name = "A Day in the Life of Physalis", VisionCardID = "100000901", Description = "", Rarity = "1", GameId = "11001", CountId = "23", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "40,65,0,0", UnitDef = "0,0,0,0", UnitMag = "40,65,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "23", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard BeachBeauties_1000010010 = new VisionCard { Name = "Beach Beauties", VisionCardID = "100001001", Description = "", Rarity = "1", GameId = "11001", CountId = "16", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "50,80,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "16", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard SearchfortheEsper_2060001011 = new VisionCard { Name = "Search for the Esper", VisionCardID = "206000101", Description = "", Rarity = "1", GameId = "10006", CountId = "26", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "0,0,0,0", UnitDef = "0,0,0,0", UnitMag = "50,100,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "26", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
        public static readonly VisionCard SeparationandRestoration_2060002012 = new VisionCard { Name = "Separation and Restoration", VisionCardID = "206000201", Description = "", Rarity = "1", GameId = "10006", CountId = "29", UnitMaxLevel = "10", UnitHp = "0,0,0,0", UnitMp = "0,0,0,0", UnitAtk = "50,100,0,0", UnitDef = "0,0,0,0", UnitMag = "0,0,0,0", UnitSpr = "0,0,0,0", ElementResists = "0,0,0,0,0,0,0,0", StatusResists = "0,0,0,0,0,0,0,0", PhysicalResist = "0", MagicalResist = "0", UnitXpGain = "6000", BitNumber = "29", IsPotUnit = "0", UnitGilSell = "400", JobId = "909"};
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
           VirtualTraining_401000101,
           AzureSuccessor_401000401,
           JudgeMagister_212000101,
           ANewJourney_100000101,
           BattlewiththeBlackKnights_202000101,
           MadamandtheGiantBirdBennu_100001101,
           DemonWhoLearnedHumanity_401000201,
           TheHeartlessSage_100000701,
           WakeUpCoeurl_100000801,
           TooCoolfortheSummer_100001501,
           CrystalsRevelation_203000101,
           ThePaopuFruitsBond_335000301,
           FacingtheDemonTower_335000201,
           TheKeybladeGraveyardBattle_335000101,
           ADayintheLifeofPhysalis_100000901,
           BeachBeauties_1000010010,
           SearchfortheEsper_2060001011,
           SeparationandRestoration_2060002012,
/*VersionControldefinitionsList*/
		};
    }
}