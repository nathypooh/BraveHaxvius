//MST_IMPORTANT_ITEM_NAME_10018^FFVII REMAKE Featured Summon Ticket^FFVII REMAKE Featured Summon Ticket---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Ticket
    {
        public String Name { get; set; }
        public String GachaCost_zJ1A6HXm { get; set; }
        public String ImportantId { get; set; }
        public String GatheringStageId { get; set; }
        public String ItemCount { get; set; }
        public String Rarity { get; set; }
        public String GachaId { get; set; }

        public static readonly Ticket Crest = new Ticket { Name = "Crest", ImportantId = "20"};
        public static readonly Ticket EXPKey = new Ticket { Name = "EXP Key", ImportantId = "30"};
        public static readonly Ticket JeweledKey = new Ticket { Name = "Jeweled Key", ImportantId = "40"};
        public static readonly Ticket ArenaSummonTicket = new Ticket { Name = "Arena Summon Ticket", ImportantId = "60"};
        public static readonly Ticket NRGRestore_100 = new Ticket { Name = "NRG Restore 10", ImportantId = "100"};
        public static readonly Ticket NRGRestore_110 = new Ticket { Name = "NRG Restore 30", ImportantId = "110"};
        public static readonly Ticket NRGRestore_120 = new Ticket { Name = "NRG Restore 50", ImportantId = "120"};
        public static readonly Ticket SpecialPass = new Ticket { Name = "Special Pass", ImportantId = "890"};
        public static readonly Ticket ArenaRestore = new Ticket { Name = "Arena Restore", ImportantId = "902"};
        public static readonly Ticket RaidRestore_903 = new Ticket { Name = "Raid Restore", ImportantId = "903"};
        public static readonly Ticket ExpansionVoucher = new Ticket { Name = "Expansion Voucher", ImportantId = "904"};
        public static readonly Ticket AncientCoin = new Ticket { Name = "Ancient Coin", ImportantId = "900"};
        public static readonly Ticket AdvanceToken = new Ticket { Name = "Advance Token", ImportantId = "901"};
        public static readonly Ticket SummonTicket_210 = new Ticket { Name = "30% 4★ Summon Ticket", ImportantId = "210", GachaCost_zJ1A6HXm = "20", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:67000000,4:30000000,5:3000000@3:69000000,4:30500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_220 = new Ticket { Name = "50% 4★ Summon Ticket", ImportantId = "220", GachaCost_zJ1A6HXm = "21", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:47000000,4:50000000,5:3000000@3:49000000,4:50500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_250 = new Ticket { Name = "50% 5★ Summon Ticket", ImportantId = "250", GachaCost_zJ1A6HXm = "24", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:31000000,4:19000000,5:50000000@3:49000000,4:500000,5:50500000", GachaId = ""};
        public static readonly Ticket SelectSummonTicket = new Ticket { Name = "5★ Select Summon Ticket", ImportantId = "260", GachaCost_zJ1A6HXm = "27", GatheringStageId = "10040", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket GreenClover = new Ticket { Name = "Green Clover", ImportantId = "905"};
        public static readonly Ticket NagasBlood = new Ticket { Name = "Naga's Blood", ImportantId = "906"};
        public static readonly Ticket NRGLightSphere = new Ticket { Name = "NRG Light Sphere", ImportantId = "907"};
        public static readonly Ticket PremiumSummonTicket = new Ticket { Name = "Premium 10+1 Summon Ticket", ImportantId = "908"};
        public static readonly Ticket SpecialReturnSummonTicket_910 = new Ticket { Name = "Special Return 3★+ Summon Ticket", ImportantId = "910"};
        public static readonly Ticket SpecialReturnSummonTicket_911 = new Ticket { Name = "Special Return 4★+ Summon Ticket", ImportantId = "911"};
        public static readonly Ticket EquipmentEnhancementOrbRestore = new Ticket { Name = "Equipment Enhancement Orb Restore", ImportantId = "270"};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_280 = new Ticket { Name = "2 Year Anniversary Special Summon Ticket", ImportantId = "280", GachaCost_zJ1A6HXm = "25", GatheringStageId = "10030", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_290 = new Ticket { Name = "2 Year Anniversary 4★+ Special Summon Ticket", ImportantId = "290", GachaCost_zJ1A6HXm = "26", GatheringStageId = "10030", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket TrustCoin = new Ticket { Name = "Trust Coin", ImportantId = "300"};
        public static readonly Ticket FMABROTHERHOODSummonTicket = new Ticket { Name = "FMA BROTHERHOOD Summon Ticket", ImportantId = "10008", GachaCost_zJ1A6HXm = "1016", GatheringStageId = "50221", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket RaidRestore_310 = new Ticket { Name = "Raid Restore", ImportantId = "310"};
        public static readonly Ticket FFVIIIFeaturedSummonTicket = new Ticket { Name = "FFVIII Featured Summon Ticket", ImportantId = "10010", GachaCost_zJ1A6HXm = "1048", GatheringStageId = "50229", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFBEthAnniversaryNextEraTicket = new Ticket { Name = "FFBE 4th Anniversary: Next Era Ticket", ImportantId = "110000"};
        public static readonly Ticket FFBEthAnniversaryNextEraIITicket = new Ticket { Name = "FFBE 4th Anniversary: Next Era II Ticket", ImportantId = "110001"};
        public static readonly Ticket FFBEthAnniversaryNextEraIIITicket = new Ticket { Name = "FFBE 4th Anniversary: Next Era III Ticket", ImportantId = "110002"};
        public static readonly Ticket FFTYPEFeaturedSummonTicket = new Ticket { Name = "FF TYPE-0 Featured Summon Ticket", ImportantId = "10012", GachaCost_zJ1A6HXm = "1101", GatheringStageId = "50235", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFXIIFeaturedSummonTicket = new Ticket { Name = "FFXII Featured Summon Ticket", ImportantId = "10014", GachaCost_zJ1A6HXm = "1201", GatheringStageId = "50239", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFIXFeaturedSummonTicket = new Ticket { Name = "FFIX Featured Summon Ticket", ImportantId = "10016", GachaCost_zJ1A6HXm = "1301", GatheringStageId = "50243", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedTicketNV_80 = new Ticket { Name = "Guaranteed Ticket (5★/NV)", ImportantId = "80", GachaCost_zJ1A6HXm = "19", GatheringStageId = "10020", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_110160 = new Ticket { Name = "NV EX Ticket (3★/4★/5★/NV)", ImportantId = "110160", GachaCost_zJ1A6HXm = "90001", GatheringStageId = "100101", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_110170 = new Ticket { Name = "NV EX Ticket (4★/5★/NV)", ImportantId = "110170", GachaCost_zJ1A6HXm = "90002", GatheringStageId = "100101", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_110180 = new Ticket { Name = "NV EX Ticket (5★/NV)", ImportantId = "110180", GachaCost_zJ1A6HXm = "90003", GatheringStageId = "100101", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket NVSummonTicket = new Ticket { Name = "1/10 NV Summon Ticket", ImportantId = "110260"};
        public static readonly Ticket VIPCoin = new Ticket { Name = "VIP Coin", ImportantId = "110003"};
        public static readonly Ticket RareSummonTicketNV = new Ticket { Name = "Rare Summon Ticket (3★/4★/5★/NV)", ImportantId = "50", GachaCost_zJ1A6HXm = "17", GatheringStageId = "10020", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedTicketNV_70 = new Ticket { Name = "Guaranteed Ticket (4★/5★/NV)", ImportantId = "70", GachaCost_zJ1A6HXm = "18", GatheringStageId = "10020", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket SummonTicketNV_230 = new Ticket { Name = "10% Summon Ticket (5★/NV)", ImportantId = "230", GachaCost_zJ1A6HXm = "22", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:71000000,4:19000000,5:10000000@3:89000000,4:500000,5:10500000", GachaId = ""};
        public static readonly Ticket SummonTicketNV_240 = new Ticket { Name = "30% Summon Ticket (5★/NV)", ImportantId = "240", GachaCost_zJ1A6HXm = "23", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:51000000,4:19000000,5:30000000@3:69000000,4:500000,5:30500000", GachaId = ""};
        public static readonly Ticket EXTicket_160 = new Ticket { Name = "EX Ticket (3★/4★/5★)", ImportantId = "160", GachaCost_zJ1A6HXm = "10", GatheringStageId = "10010", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket EXTicket_170 = new Ticket { Name = "EX Ticket (4★/5★)", ImportantId = "170", GachaCost_zJ1A6HXm = "11", GatheringStageId = "10010", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket EXTicket_180 = new Ticket { Name = "EX Ticket (5★)", ImportantId = "180", GachaCost_zJ1A6HXm = "12", GatheringStageId = "10010", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket SummonTicket_912 = new Ticket { Name = "5+1 Summon Ticket (3★/4★/5★)", ImportantId = "912"};
        public static readonly Ticket GuaranteedSummonTicket = new Ticket { Name = "5★ Guaranteed 10+1 Summon Ticket (3★/4★/5★)", ImportantId = "909"};
        public static readonly Ticket FFVIIREMAKEFeaturedSummonTicket = new Ticket { Name = "FFVII REMAKE Featured Summon Ticket", ImportantId = "10018", GachaCost_zJ1A6HXm = "1401", GatheringStageId = "50247", ItemCount = "1", Rarity = "3", GachaId = ""};
/*VersionControldefinitions*/
		public static readonly List<Ticket> Tickets = new List<Ticket>
		{
           Crest,
           EXPKey,
           JeweledKey,
           ArenaSummonTicket,
           NRGRestore_100,
           NRGRestore_110,
           NRGRestore_120,
           SpecialPass,
           ArenaRestore,
           RaidRestore_903,
           ExpansionVoucher,
           AncientCoin,
           AdvanceToken,
           SummonTicket_210,
           SummonTicket_220,
           SummonTicket_250,
           SelectSummonTicket,
           GreenClover,
           NagasBlood,
           NRGLightSphere,
           PremiumSummonTicket,
           SpecialReturnSummonTicket_910,
           SpecialReturnSummonTicket_911,
           EquipmentEnhancementOrbRestore,
           YearAnniversarySpecialSummonTicket_280,
           YearAnniversarySpecialSummonTicket_290,
           TrustCoin,
           FMABROTHERHOODSummonTicket,
           RaidRestore_310,
           FFVIIIFeaturedSummonTicket,
           FFBEthAnniversaryNextEraTicket,
           FFBEthAnniversaryNextEraIITicket,
           FFBEthAnniversaryNextEraIIITicket,
           FFTYPEFeaturedSummonTicket,
           FFXIIFeaturedSummonTicket,
           FFIXFeaturedSummonTicket,
           GuaranteedTicketNV_80,
           NVEXTicketNV_110160,
           NVEXTicketNV_110170,
           NVEXTicketNV_110180,
           NVSummonTicket,
           VIPCoin,
           RareSummonTicketNV,
           GuaranteedTicketNV_70,
           SummonTicketNV_230,
           SummonTicketNV_240,
           EXTicket_160,
           EXTicket_170,
           EXTicket_180,
           SummonTicket_912,
           GuaranteedSummonTicket,
           FFVIIREMAKEFeaturedSummonTicket,
/*VersionControldefinitionsList*/		};
    }
}