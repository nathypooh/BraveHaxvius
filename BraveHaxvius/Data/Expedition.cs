using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Expedition
    {
                public String Id { get; set; }
                public String Name { get; set; }
                public Int32 Expira { get; set; }
                public Int32 MaxUnits { get; set; }
                public String HardCoredUnit { get; set; }

                public string UnitsList { get; set; }
                public int MaxPorDias { get; internal set; }
                public int Corridas { get; internal set; }
                
//
        public static readonly Expedition Expedition_1 = new Expedition { Id = "1", Name = "Relic Hunting Craze I", MaxUnits = 1, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_2 = new Expedition { Id = "2", Name = "Relic Hunting Craze II", MaxUnits = 2, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_3 = new Expedition { Id = "3", Name = "Relic Hunting Craze III", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_4 = new Expedition { Id = "4", Name = "Strange Encounters", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_5 = new Expedition { Id = "5", Name = "Shirts and Skins", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_6 = new Expedition { Id = "6", Name = "Put to the Test", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_7 = new Expedition { Id = "7", Name = "Needle in a Haystack", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_8 = new Expedition { Id = "8", Name = "Merchant Guard", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_9 = new Expedition { Id = "9", Name = "Guard Duty", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_10 = new Expedition { Id = "10", Name = "Mouse Trapped", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_11 = new Expedition { Id = "11", Name = "Farmers Dismay", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_12 = new Expedition { Id = "12", Name = "Cause for Celebration", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_13 = new Expedition { Id = "13", Name = "What Might Happen?", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_14 = new Expedition { Id = "14", Name = "Flame Fighters", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_15 = new Expedition { Id = "15", Name = "Devilish Arms", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_16 = new Expedition { Id = "16", Name = "Cant Beat Free", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_17 = new Expedition { Id = "17", Name = "To the Rescue", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_18 = new Expedition { Id = "18", Name = "Heavy Objects Collide", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_19 = new Expedition { Id = "19", Name = "Lightning Rod", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_20 = new Expedition { Id = "20", Name = "Dream Job", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_21 = new Expedition { Id = "21", Name = "No Sheep to Count", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_22 = new Expedition { Id = "22", Name = "Poker Tournament", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_23 = new Expedition { Id = "23", Name = "Winter Retreat", MaxUnits = 3, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_24 = new Expedition { Id = "24", Name = "Buzzkill", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_25 = new Expedition { Id = "25", Name = "Just Cause", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_26 = new Expedition { Id = "26", Name = "Bad to the Bone", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_27 = new Expedition { Id = "27", Name = "Volcano on Ice", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_28 = new Expedition { Id = "28", Name = "Leave No Stones Unturned", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_29 = new Expedition { Id = "29", Name = "Precious Lumber", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_30 = new Expedition { Id = "30", Name = "Test Your Strength", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_31 = new Expedition { Id = "31", Name = "Targeted", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_32 = new Expedition { Id = "32", Name = "Call to Arms", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_33 = new Expedition { Id = "33", Name = "Grand Theft Carriage", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_34 = new Expedition { Id = "34", Name = "Paging All White Mages", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_35 = new Expedition { Id = "35", Name = "The Mage-Off", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_36 = new Expedition { Id = "36", Name = "Crab Battle", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_37 = new Expedition { Id = "37", Name = "None Shall Starve", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_38 = new Expedition { Id = "38", Name = "Stop the Horde!", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_39 = new Expedition { Id = "39", Name = "Arms on Fire!", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_40 = new Expedition { Id = "40", Name = "Lost in Fantasy", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_41 = new Expedition { Id = "41", Name = "Time to Relax", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_42 = new Expedition { Id = "42", Name = "Parley?", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_43 = new Expedition { Id = "43", Name = "Lightning Returns?", MaxUnits = 4, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_44 = new Expedition { Id = "44", Name = "Plumbers Paradise", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_45 = new Expedition { Id = "45", Name = "Spelunking Splendor", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_46 = new Expedition { Id = "46", Name = "Will to Survive", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_47 = new Expedition { Id = "47", Name = "Unpleasant Dreams", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_48 = new Expedition { Id = "48", Name = "Egg Hunt", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_49 = new Expedition { Id = "49", Name = "Back to the Sands", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_50 = new Expedition { Id = "50", Name = "Weathering the Weather", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_51 = new Expedition { Id = "51", Name = "Quarry Quickness", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_52 = new Expedition { Id = "52", Name = "Cat Lost", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_53 = new Expedition { Id = "53", Name = "Monster Tamer", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_54 = new Expedition { Id = "54", Name = "Run, Cactuar, Run", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_55 = new Expedition { Id = "55", Name = "A Certain Set of Skills", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_56 = new Expedition { Id = "56", Name = "Bashers Brawl", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_57 = new Expedition { Id = "57", Name = "Undead Rising", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_58 = new Expedition { Id = "58", Name = "Will It Hold?", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_59 = new Expedition { Id = "59", Name = "Crying Over Spilt Milk", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_60 = new Expedition { Id = "60", Name = "Sword in the Stone", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_61 = new Expedition { Id = "61", Name = "Join the Circus", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_62 = new Expedition { Id = "62", Name = "Hot Topic", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_63 = new Expedition { Id = "63", Name = "Impact from Above", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_64 = new Expedition { Id = "64", Name = "General Hospitality", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_65 = new Expedition { Id = "65", Name = "Stranger Stuff", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_66 = new Expedition { Id = "66", Name = "He Who Smelt It", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_67 = new Expedition { Id = "67", Name = "Full House", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_68 = new Expedition { Id = "68", Name = "A Beasts Bounty", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_69 = new Expedition { Id = "69", Name = "Childs Play", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_70 = new Expedition { Id = "70", Name = "A Priest, a Monk, and a Paladin", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_71 = new Expedition { Id = "71", Name = "Shopping for Medicine", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_72 = new Expedition { Id = "72", Name = "The Missing Key", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_73 = new Expedition { Id = "73", Name = "Across the Desert", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_74 = new Expedition { Id = "74", Name = "Cook Off", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_75 = new Expedition { Id = "75", Name = "Tavern Cleanup", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_76 = new Expedition { Id = "76", Name = "Too Many Coeurls", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_77 = new Expedition { Id = "77", Name = "Lost in the Dark", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_78 = new Expedition { Id = "78", Name = "Anger Management", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_79 = new Expedition { Id = "79", Name = "Wrath in the Wreckage", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_80 = new Expedition { Id = "80", Name = "Seven Years Bad Luck", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_81 = new Expedition { Id = "81", Name = "Ghost Busted", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_82 = new Expedition { Id = "82", Name = "Whats Her Secret?", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_83 = new Expedition { Id = "83", Name = "Braving the Elements", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_84 = new Expedition { Id = "84", Name = "Lost in the World", MaxUnits = 5, HardCoredUnit = "100000102"};
        public static readonly Expedition Expedition_85 = new Expedition { Id = "85", Name = "Hotline Grandshelt", MaxUnits = 5, HardCoredUnit = "100000202"};
        public static readonly Expedition Expedition_86 = new Expedition { Id = "86", Name = "Break Time", MaxUnits = 5, HardCoredUnit = "100000302"};
        public static readonly Expedition Expedition_87 = new Expedition { Id = "87", Name = "Reinventing the Wheel", MaxUnits = 5, HardCoredUnit = "100000503"};
        public static readonly Expedition Expedition_88 = new Expedition { Id = "88", Name = "Winter is Coming", MaxUnits = 5, HardCoredUnit = "100000403"};
        public static readonly Expedition Expedition_89 = new Expedition { Id = "89", Name = "Hide Your Kids, Hide Your Wife", MaxUnits = 5, HardCoredUnit = "100000703"};
        public static readonly Expedition Expedition_90 = new Expedition { Id = "90", Name = "Paper, Please!", MaxUnits = 5, HardCoredUnit = "100000603"};
        public static readonly Expedition Expedition_91 = new Expedition { Id = "91", Name = "Wherefore Art Thou, Father", MaxUnits = 5, HardCoredUnit = "100000102"};
        public static readonly Expedition Expedition_92 = new Expedition { Id = "92", Name = "A Legendary Challenge", MaxUnits = 5, HardCoredUnit = "100000202"};
        public static readonly Expedition Expedition_93 = new Expedition { Id = "93", Name = "Wheres My Mommy?", MaxUnits = 5, HardCoredUnit = "100000302"};
        public static readonly Expedition Expedition_94 = new Expedition { Id = "94", Name = "Be the Best", MaxUnits = 5, HardCoredUnit = "100000503"};
        public static readonly Expedition Expedition_95 = new Expedition { Id = "95", Name = "Hot Ice", MaxUnits = 5, HardCoredUnit = "100000403"};
        public static readonly Expedition Expedition_96 = new Expedition { Id = "96", Name = "Save the Children", MaxUnits = 5, HardCoredUnit = "100000703"};
        public static readonly Expedition Expedition_97 = new Expedition { Id = "97", Name = "Magi in Danger", MaxUnits = 5, HardCoredUnit = "100000603"};
        public static readonly Expedition Expedition_98 = new Expedition { Id = "98", Name = "Red and Blue Supercite", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_99 = new Expedition { Id = "99", Name = "Violet and Yellow Supercite", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_100 = new Expedition { Id = "100", Name = "Orange and White Supercite", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_101 = new Expedition { Id = "101", Name = "Green and Black Supercite", MaxUnits = 5, HardCoredUnit = "0"};
        public static readonly Expedition Expedition_102 = new Expedition { Id = "102", Name = "TM Expedition", MaxUnits = 5, HardCoredUnit = "0"};
//definitions-102

		public static readonly List<Expedition> Expeditions = new List<Expedition>
		{
           Expedition_1,
           Expedition_2,
           Expedition_3,
           Expedition_4,
           Expedition_5,
           Expedition_6,
           Expedition_7,
           Expedition_8,
           Expedition_9,
           Expedition_10,
           Expedition_11,
           Expedition_12,
           Expedition_13,
           Expedition_14,
           Expedition_15,
           Expedition_16,
           Expedition_17,
           Expedition_18,
           Expedition_19,
           Expedition_20,
           Expedition_21,
           Expedition_22,
           Expedition_23,
           Expedition_24,
           Expedition_25,
           Expedition_26,
           Expedition_27,
           Expedition_28,
           Expedition_29,
           Expedition_30,
           Expedition_31,
           Expedition_32,
           Expedition_33,
           Expedition_34,
           Expedition_35,
           Expedition_36,
           Expedition_37,
           Expedition_38,
           Expedition_39,
           Expedition_40,
           Expedition_41,
           Expedition_42,
           Expedition_43,
           Expedition_44,
           Expedition_45,
           Expedition_46,
           Expedition_47,
           Expedition_48,
           Expedition_49,
           Expedition_50,
           Expedition_51,
           Expedition_52,
           Expedition_53,
           Expedition_54,
           Expedition_55,
           Expedition_56,
           Expedition_57,
           Expedition_58,
           Expedition_59,
           Expedition_60,
           Expedition_61,
           Expedition_62,
           Expedition_63,
           Expedition_64,
           Expedition_65,
           Expedition_66,
           Expedition_67,
           Expedition_68,
           Expedition_69,
           Expedition_70,
           Expedition_71,
           Expedition_72,
           Expedition_73,
           Expedition_74,
           Expedition_75,
           Expedition_76,
           Expedition_77,
           Expedition_78,
           Expedition_79,
           Expedition_80,
           Expedition_81,
           Expedition_82,
           Expedition_83,
           Expedition_84,
           Expedition_85,
           Expedition_86,
           Expedition_87,
           Expedition_88,
           Expedition_89,
           Expedition_90,
           Expedition_91,
           Expedition_92,
           Expedition_93,
           Expedition_94,
           Expedition_95,
           Expedition_96,
           Expedition_97,
           Expedition_98,
           Expedition_99,
           Expedition_100,
           Expedition_101,
           Expedition_102,
//definitionslist-102
		};
    }
}