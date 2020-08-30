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

        public static readonly Ticket Crest = new Ticket { Name = "Crest"};
        public static readonly Ticket EXPKey = new Ticket { Name = "EXP Key"};
        public static readonly Ticket JeweledKey = new Ticket { Name = "Jeweled Key"};
        public static readonly Ticket RareSummonTicket = new Ticket { Name = "Rare Summon Ticket", GachaCost_zJ1A6HXm = "17", ImportantId = "50", GatheringStageId = "10020", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket ArenaSummonTicket = new Ticket { Name = "Arena Summon Ticket"};
        public static readonly Ticket GuaranteedTicket = new Ticket { Name = "4★+ Guaranteed Ticket", GachaCost_zJ1A6HXm = "18", ImportantId = "70", GatheringStageId = "10020", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket NRGRestore_100 = new Ticket { Name = "NRG Restore 10"};
        public static readonly Ticket NRGRestore_110 = new Ticket { Name = "NRG Restore 30"};
        public static readonly Ticket NRGRestore_120 = new Ticket { Name = "NRG Restore 50"};
        public static readonly Ticket EXSummonTicket = new Ticket { Name = "EX Summon Ticket", GachaCost_zJ1A6HXm = "10", ImportantId = "160", GatheringStageId = "10010", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedEXTicket_170 = new Ticket { Name = "4★+ Guaranteed EX Ticket", GachaCost_zJ1A6HXm = "11", ImportantId = "170", GatheringStageId = "10010", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket GuaranteedEXTicket_180 = new Ticket { Name = "5★ Guaranteed EX Ticket", GachaCost_zJ1A6HXm = "12", ImportantId = "180", GatheringStageId = "10010", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket SpecialPass = new Ticket { Name = "Special Pass"};
        public static readonly Ticket ArenaRestore = new Ticket { Name = "Arena Restore"};
        public static readonly Ticket RaidRestore = new Ticket { Name = "Raid Restore"};
        public static readonly Ticket ExpansionVoucher = new Ticket { Name = "Expansion Voucher"};
        public static readonly Ticket AncientCoin = new Ticket { Name = "Ancient Coin"};
        public static readonly Ticket AdvanceToken = new Ticket { Name = "Advance Token"};
        public static readonly Ticket SummonTicket_210 = new Ticket { Name = "30% 4★ Summon Ticket", GachaCost_zJ1A6HXm = "20", ImportantId = "210", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:67000000,4:30000000,5:3000000@3:69000000,4:30500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_220 = new Ticket { Name = "50% 4★ Summon Ticket", GachaCost_zJ1A6HXm = "21", ImportantId = "220", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:47000000,4:50000000,5:3000000@3:49000000,4:50500000,5:500000", GachaId = ""};
        public static readonly Ticket SummonTicket_230 = new Ticket { Name = "10% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "22", ImportantId = "230", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:71000000,4:19000000,5:10000000@3:89000000,4:500000,5:10500000", GachaId = ""};
        public static readonly Ticket SummonTicket_240 = new Ticket { Name = "30% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "23", ImportantId = "240", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:51000000,4:19000000,5:30000000@3:69000000,4:500000,5:30500000", GachaId = ""};
        public static readonly Ticket SummonTicket_250 = new Ticket { Name = "50% 5★ Summon Ticket", GachaCost_zJ1A6HXm = "24", ImportantId = "250", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:31000000,4:19000000,5:50000000@3:49000000,4:500000,5:50500000", GachaId = ""};
        public static readonly Ticket SelectSummonTicket_260 = new Ticket { Name = "5★ Select Summon Ticket", GachaCost_zJ1A6HXm = "27", ImportantId = "260", GatheringStageId = "10040", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket GreenClover = new Ticket { Name = "Green Clover"};
        public static readonly Ticket NagasBlood = new Ticket { Name = "Naga's Blood"};
        public static readonly Ticket NRGLightSphere = new Ticket { Name = "NRG Light Sphere"};
        public static readonly Ticket PremiumSummonTicket = new Ticket { Name = "Premium 10+1 Summon Ticket"};
        public static readonly Ticket GuaranteedSummonTicket = new Ticket { Name = "5★ Guaranteed 10+1 Summon Ticket"};
        public static readonly Ticket SpecialReturnSummonTicket_910 = new Ticket { Name = "Special Return 3★+ Summon Ticket"};
        public static readonly Ticket SpecialReturnSummonTicket_911 = new Ticket { Name = "Special Return 4★+ Summon Ticket"};
        public static readonly Ticket EquipmentEnhancementOrbRestore = new Ticket { Name = "Equipment Enhancement Orb Restore"};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_280 = new Ticket { Name = "2 Year Anniversary Special Summon Ticket", GachaCost_zJ1A6HXm = "25", ImportantId = "280", GatheringStageId = "10030", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket YearAnniversarySpecialSummonTicket_290 = new Ticket { Name = "2 Year Anniversary 4★+ Special Summon Ticket", GachaCost_zJ1A6HXm = "26", ImportantId = "290", GatheringStageId = "10030", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket SummonTicket_912 = new Ticket { Name = "5+1 Summon Ticket"};
        public static readonly Ticket TrustCoin = new Ticket { Name = "Trust Coin"};
        public static readonly Ticket FMABROTHERHOODSummonTicket = new Ticket { Name = "FMA BROTHERHOOD Summon Ticket", GachaCost_zJ1A6HXm = "1016", ImportantId = "10008", GatheringStageId = "50221", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket RaidRestore_310 = new Ticket { Name = "Raid Restore"};
        public static readonly Ticket FFVIIIFeaturedSummonTicket_10010 = new Ticket { Name = "FFVIII Featured Summon Ticket", GachaCost_zJ1A6HXm = "1048", ImportantId = "10010", GatheringStageId = "50229", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFBEthAnniversaryNextEraTicket_110000 = new Ticket { Name = "FFBE 4th Anniversary: Next Era Ticket"};
        public static readonly Ticket FFBEthAnniversaryNextEraIITicket_110001 = new Ticket { Name = "FFBE 4th Anniversary: Next Era II Ticket"};
        public static readonly Ticket FFBEthAnniversaryNextEraIIITicket_110002 = new Ticket { Name = "FFBE 4th Anniversary: Next Era III Ticket"};
        public static readonly Ticket FFTYPEFeaturedSummonTicket_10012 = new Ticket { Name = "FF TYPE-0 Featured Summon Ticket", GachaCost_zJ1A6HXm = "1101", ImportantId = "10012", GatheringStageId = "50235", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFXIIFeaturedSummonTicket_10014 = new Ticket { Name = "FFXII Featured Summon Ticket", GachaCost_zJ1A6HXm = "1201", ImportantId = "10014", GatheringStageId = "50239", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket FFIXFeaturedSummonTicket_100160 = new Ticket { Name = "FFIX Featured Summon Ticket", ImportantId = "10016", GachaCost_zJ1A6HXm = "1301", GatheringStageId = "50243", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedTicketNV_801 = new Ticket { Name = "Guaranteed Ticket (5★/NV)", ImportantId = "80", GachaCost_zJ1A6HXm = "19", GatheringStageId = "10020", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_1101602 = new Ticket { Name = "NV EX Ticket (3★/4★/5★/NV)", ImportantId = "110160", GachaCost_zJ1A6HXm = "90001", GatheringStageId = "100101", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_1101703 = new Ticket { Name = "NV EX Ticket (4★/5★/NV)", ImportantId = "110170", GachaCost_zJ1A6HXm = "90002", GatheringStageId = "100101", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket NVEXTicketNV_1101804 = new Ticket { Name = "NV EX Ticket (5★/NV)", ImportantId = "110180", GachaCost_zJ1A6HXm = "90003", GatheringStageId = "100101", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket NVSummonTicket_1102605 = new Ticket { Name = "1/10 NV Summon Ticket", ImportantId = "110260"};
        public static readonly Ticket VIPCoin_1100036 = new Ticket { Name = "VIP Coin", ImportantId = "110003"};
        public static readonly Ticket RareSummonTicketNV_507 = new Ticket { Name = "Rare Summon Ticket (3★/4★/5★/NV)", ImportantId = "50", GachaCost_zJ1A6HXm = "17", GatheringStageId = "10020", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket GuaranteedTicketNV_708 = new Ticket { Name = "Guaranteed Ticket (4★/5★/NV)", ImportantId = "70", GachaCost_zJ1A6HXm = "18", GatheringStageId = "10020", ItemCount = "1", Rarity = "4:95000000,5:5000000@4:50000000,5:50000000", GachaId = ""};
        public static readonly Ticket SummonTicketNV_2309 = new Ticket { Name = "10% Summon Ticket (5★/NV)", ImportantId = "230", GachaCost_zJ1A6HXm = "22", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:71000000,4:19000000,5:10000000@3:89000000,4:500000,5:10500000", GachaId = ""};
        public static readonly Ticket SummonTicketNV_24010 = new Ticket { Name = "30% Summon Ticket (5★/NV)", ImportantId = "240", GachaCost_zJ1A6HXm = "23", GatheringStageId = "10020", ItemCount = "1", Rarity = "3:51000000,4:19000000,5:30000000@3:69000000,4:500000,5:30500000", GachaId = ""};
        public static readonly Ticket EXTicket_16011 = new Ticket { Name = "EX Ticket (3★/4★/5★)", ImportantId = "160", GachaCost_zJ1A6HXm = "10", GatheringStageId = "10010", ItemCount = "1", Rarity = "3", GachaId = ""};
        public static readonly Ticket EXTicket_17012 = new Ticket { Name = "EX Ticket (4★/5★)", ImportantId = "170", GachaCost_zJ1A6HXm = "11", GatheringStageId = "10010", ItemCount = "1", Rarity = "4", GachaId = ""};
        public static readonly Ticket EXTicket_18013 = new Ticket { Name = "EX Ticket (5★)", ImportantId = "180", GachaCost_zJ1A6HXm = "12", GatheringStageId = "10010", ItemCount = "1", Rarity = "5", GachaId = ""};
        public static readonly Ticket SummonTicket_91214 = new Ticket { Name = "5+1 Summon Ticket (3★/4★/5★)", ImportantId = "912"};
        public static readonly Ticket GuaranteedSummonTicket_90915 = new Ticket { Name = "5★ Guaranteed 10+1 Summon Ticket (3★/4★/5★)", ImportantId = "909"};
        public static readonly Ticket FFVIIREMAKEFeaturedSummonTicket_1001816 = new Ticket { Name = "FFVII REMAKE Featured Summon Ticket", ImportantId = "10018", GachaCost_zJ1A6HXm = "1401", GatheringStageId = "50247", ItemCount = "1", Rarity = "3", GachaId = ""};
/*VersionControldefinitions*/








		public static readonly List<Ticket> Tickets = new List<Ticket>
		{
           Crest,
           EXPKey,
           JeweledKey,
           RareSummonTicket,
           ArenaSummonTicket,
           GuaranteedTicket,
           NRGRestore_100,
           NRGRestore_110,
           NRGRestore_120,
           EXSummonTicket,
           GuaranteedEXTicket_170,
           GuaranteedEXTicket_180,
           SpecialPass,
           ArenaRestore,
           RaidRestore,
           ExpansionVoucher,
           AncientCoin,
           AdvanceToken,
           SummonTicket_210,
           SummonTicket_220,
           SummonTicket_230,
           SummonTicket_240,
           SummonTicket_250,
           SelectSummonTicket_260,
           GreenClover,
           NagasBlood,
           NRGLightSphere,
           PremiumSummonTicket,
           GuaranteedSummonTicket,
           SpecialReturnSummonTicket_910,
           SpecialReturnSummonTicket_911,
           EquipmentEnhancementOrbRestore,
           YearAnniversarySpecialSummonTicket_280,
           YearAnniversarySpecialSummonTicket_290,
           SummonTicket_912,
           TrustCoin,
           FMABROTHERHOODSummonTicket,
           RaidRestore_310,
           FFVIIIFeaturedSummonTicket_10010,
           FFBEthAnniversaryNextEraTicket_110000,
           FFBEthAnniversaryNextEraIITicket_110001,
           FFBEthAnniversaryNextEraIIITicket_110002,
           FFTYPEFeaturedSummonTicket_10012,
           FFXIIFeaturedSummonTicket_10014,
           FFIXFeaturedSummonTicket_100160,
           GuaranteedTicketNV_801,
           NVEXTicketNV_1101602,
           NVEXTicketNV_1101703,
           NVEXTicketNV_1101804,
           NVSummonTicket_1102605,
           VIPCoin_1100036,
           RareSummonTicketNV_507,
           GuaranteedTicketNV_708,
           SummonTicketNV_2309,
           SummonTicketNV_24010,
           EXTicket_16011,
           EXTicket_17012,
           EXTicket_18013,
           SummonTicket_91214,
           GuaranteedSummonTicket_90915,
           FFVIIREMAKEFeaturedSummonTicket_1001816,
/*VersionControldefinitionsList*/







		};
    }
}