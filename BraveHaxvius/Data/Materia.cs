//MST_MATERIA_NAME_504236549^Snowstorm Katana^Snowstorm Katana---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Materia
    {
        public String Name { get; set; }
        public String MateriaId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String EquipmentActiveAbility { get; set; }
        public String EquipmentPassiveAbility { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Materia Libra = new Materia { Name = "Libra", MateriaId = "504010010", Description = "ライブラ", CountId = "1150010", EquipmentActiveAbility = "10010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000002", BitNumber = "1"};
        public static readonly Materia Cure = new Materia { Name = "Cure", MateriaId = "504010020", Description = "ケアル", CountId = "1150020", EquipmentActiveAbility = "10020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000004", BitNumber = "2"};
        public static readonly Materia Blindna = new Materia { Name = "Blindna", MateriaId = "504010030", Description = "ブラナ", CountId = "1150110", EquipmentActiveAbility = "10030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000003", BitNumber = "3"};
        public static readonly Materia Vox = new Materia { Name = "Vox", MateriaId = "504010040", Description = "ボキャル", CountId = "1150120", EquipmentActiveAbility = "10040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000003", BitNumber = "4"};
        public static readonly Materia Poisona = new Materia { Name = "Poisona", MateriaId = "504010050", Description = "ポイゾナ", CountId = "1150130", EquipmentActiveAbility = "10050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000003", BitNumber = "5"};
        public static readonly Materia Banish = new Materia { Name = "Banish", MateriaId = "504010060", Description = "バニシュ", CountId = "1155010", EquipmentActiveAbility = "10060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000005", BitNumber = "6"};
        public static readonly Materia Paralyna = new Materia { Name = "Paralyna", MateriaId = "504010080", Description = "パラナ", CountId = "1150140", EquipmentActiveAbility = "10080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000003", BitNumber = "8"};
        public static readonly Materia Stona = new Materia { Name = "Stona", MateriaId = "504010090", Description = "ストナ", CountId = "1150150", EquipmentActiveAbility = "10090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000003", BitNumber = "9"};
        public static readonly Materia Esuna = new Materia { Name = "Esuna", MateriaId = "504010110", Description = "エスナ", CountId = "1150170", EquipmentActiveAbility = "10110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000003", BitNumber = "11"};
        public static readonly Materia Regen = new Materia { Name = "Regen", MateriaId = "504010120", Description = "リジェネ", CountId = "1150190", EquipmentActiveAbility = "10120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000004", BitNumber = "12"};
        public static readonly Materia Cleanse = new Materia { Name = "Cleanse", MateriaId = "504010140", Description = "リブート", CountId = "1150160", EquipmentActiveAbility = "10140", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000003", BitNumber = "14"};
        public static readonly Materia Holy = new Materia { Name = "Holy", MateriaId = "504010210", Description = "ホーリー", CountId = "1155510", EquipmentActiveAbility = "10210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000005", BitNumber = "21"};
        public static readonly Materia Fire = new Materia { Name = "Fire", MateriaId = "504020010", Description = "ファイア", CountId = "1250010", EquipmentActiveAbility = "20010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000021", BitNumber = "23"};
        public static readonly Materia Blizzard = new Materia { Name = "Blizzard", MateriaId = "504020020", Description = "ブリザド", CountId = "1250110", EquipmentActiveAbility = "20020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000022", BitNumber = "24"};
        public static readonly Materia Thunder = new Materia { Name = "Thunder", MateriaId = "504020030", Description = "サンダー", CountId = "1250210", EquipmentActiveAbility = "20030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000020", BitNumber = "25"};
        public static readonly Materia Water = new Materia { Name = "Water", MateriaId = "504020040", Description = "ウォータ", CountId = "1250310", EquipmentActiveAbility = "20040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000023", BitNumber = "26"};
        public static readonly Materia Aero = new Materia { Name = "Aero", MateriaId = "504020050", Description = "エアロ", CountId = "1250410", EquipmentActiveAbility = "20050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000025", BitNumber = "27"};
        public static readonly Materia Stone = new Materia { Name = "Stone", MateriaId = "504020060", Description = "ストーン", CountId = "1250510", EquipmentActiveAbility = "20060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000028", BitNumber = "28"};
        public static readonly Materia Bio = new Materia { Name = "Bio", MateriaId = "504020070", Description = "バイオ", CountId = "1250610", EquipmentActiveAbility = "20070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000024", BitNumber = "29"};
        public static readonly Materia Fira = new Materia { Name = "Fira", MateriaId = "504020080", Description = "ファイラ", CountId = "1250020", EquipmentActiveAbility = "20080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000021", BitNumber = "30"};
        public static readonly Materia Blizzara = new Materia { Name = "Blizzara", MateriaId = "504020090", Description = "ブリザラ", CountId = "1250120", EquipmentActiveAbility = "20090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000022", BitNumber = "31"};
        public static readonly Materia Thundara = new Materia { Name = "Thundara", MateriaId = "504020100", Description = "サンダラ", CountId = "1250220", EquipmentActiveAbility = "20100", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000020", BitNumber = "32"};
        public static readonly Materia Watera = new Materia { Name = "Watera", MateriaId = "504020110", Description = "ウォタラ", CountId = "1250320", EquipmentActiveAbility = "20110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000023", BitNumber = "33"};
        public static readonly Materia Aerora = new Materia { Name = "Aerora", MateriaId = "504020120", Description = "エアロラ", CountId = "1250420", EquipmentActiveAbility = "20120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000025", BitNumber = "34"};
        public static readonly Materia Stonra = new Materia { Name = "Stonra", MateriaId = "504020130", Description = "ストンラ", CountId = "1250520", EquipmentActiveAbility = "20130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000028", BitNumber = "35"};
        public static readonly Materia Gravity = new Materia { Name = "Gravity", MateriaId = "504020150", Description = "グラビデ", CountId = "1251010", EquipmentActiveAbility = "20150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000026", BitNumber = "37"};
        public static readonly Materia Drain = new Materia { Name = "Drain", MateriaId = "504020160", Description = "ドレイン", CountId = "1252010", EquipmentActiveAbility = "20160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000015", BitNumber = "38"};
        public static readonly Materia Biora = new Materia { Name = "Biora", MateriaId = "504020180", Description = "バイオラ", CountId = "1250620", EquipmentActiveAbility = "20180", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000024", BitNumber = "40"};
        public static readonly Materia Firaga = new Materia { Name = "Firaga", MateriaId = "504020200", Description = "ファイガ", CountId = "1250030", EquipmentActiveAbility = "20200", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000021", BitNumber = "42"};
        public static readonly Materia Blizzaga = new Materia { Name = "Blizzaga", MateriaId = "504020210", Description = "ブリザガ", CountId = "1250130", EquipmentActiveAbility = "20210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000022", BitNumber = "43"};
        public static readonly Materia Thundaga = new Materia { Name = "Thundaga", MateriaId = "504020220", Description = "サンダガ", CountId = "1250230", EquipmentActiveAbility = "20220", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000020", BitNumber = "44"};
        public static readonly Materia Flare = new Materia { Name = "Flare", MateriaId = "504020350", Description = "フレア", CountId = "1255020", EquipmentActiveAbility = "20350", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000030", BitNumber = "57"};
        public static readonly Materia Ultima = new Materia { Name = "Ultima", MateriaId = "504020440", Description = "アルテマ", CountId = "1255110", EquipmentActiveAbility = "20440", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000037", BitNumber = "66"};
        public static readonly Materia Sleep_504030010 = new Materia { Name = "Sleep", MateriaId = "504030010", Description = "スリプル", CountId = "1358010", EquipmentActiveAbility = "30010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "67"};
        public static readonly Materia Blind = new Materia { Name = "Blind", MateriaId = "504030020", Description = "ブライン", CountId = "1358020", EquipmentActiveAbility = "30020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "68"};
        public static readonly Materia Barfire = new Materia { Name = "Barfire", MateriaId = "504030030", Description = "バファイ", CountId = "1351010", EquipmentActiveAbility = "30030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000006", BitNumber = "69"};
        public static readonly Materia Barblizzard = new Materia { Name = "Barblizzard", MateriaId = "504030040", Description = "バブリザ", CountId = "1351110", EquipmentActiveAbility = "30040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000010", BitNumber = "70"};
        public static readonly Materia Barthunder = new Materia { Name = "Barthunder", MateriaId = "504030050", Description = "バサンダ", CountId = "1351210", EquipmentActiveAbility = "30050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000008", BitNumber = "71"};
        public static readonly Materia Barwater = new Materia { Name = "Barwater", MateriaId = "504030060", Description = "バウォタ", CountId = "1351310", EquipmentActiveAbility = "30060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000013", BitNumber = "72"};
        public static readonly Materia Baraero = new Materia { Name = "Baraero", MateriaId = "504030070", Description = "バエアロ", CountId = "1351410", EquipmentActiveAbility = "30070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000007", BitNumber = "73"};
        public static readonly Materia Barstone = new Materia { Name = "Barstone", MateriaId = "504030080", Description = "バストン", CountId = "1351510", EquipmentActiveAbility = "30080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000012", BitNumber = "74"};
        public static readonly Materia Silence = new Materia { Name = "Silence", MateriaId = "504030100", Description = "サイレス", CountId = "1358030", EquipmentActiveAbility = "30100", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000009", BitNumber = "76"};
        public static readonly Materia Barfira = new Materia { Name = "Barfira", MateriaId = "504030110", Description = "バファイラ", CountId = "1351020", EquipmentActiveAbility = "30110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000006", BitNumber = "77"};
        public static readonly Materia Barblizzara = new Materia { Name = "Barblizzara", MateriaId = "504030120", Description = "バブリザラ", CountId = "1351120", EquipmentActiveAbility = "30120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000010", BitNumber = "78"};
        public static readonly Materia Barthundara = new Materia { Name = "Barthundara", MateriaId = "504030130", Description = "バサンダラ", CountId = "1351220", EquipmentActiveAbility = "30130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000008", BitNumber = "79"};
        public static readonly Materia Shell = new Materia { Name = "Shell", MateriaId = "504030140", Description = "シェル", CountId = "1350310", EquipmentActiveAbility = "30140", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "80"};
        public static readonly Materia Deprotect = new Materia { Name = "Deprotect", MateriaId = "504030150", Description = "デプロテ", CountId = "1355110", EquipmentActiveAbility = "30150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000039", BitNumber = "81"};
        public static readonly Materia Deshell = new Materia { Name = "Deshell", MateriaId = "504030160", Description = "デシェル", CountId = "1355310", EquipmentActiveAbility = "30160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000039", BitNumber = "82"};
        public static readonly Materia Barwatera = new Materia { Name = "Barwatera", MateriaId = "504030170", Description = "バウォタラ", CountId = "1351320", EquipmentActiveAbility = "30170", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000013", BitNumber = "83"};
        public static readonly Materia Baraerora = new Materia { Name = "Baraerora", MateriaId = "504030180", Description = "バエアロラ", CountId = "1351420", EquipmentActiveAbility = "30180", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000007", BitNumber = "84"};
        public static readonly Materia Barstonra = new Materia { Name = "Barstonra", MateriaId = "504030190", Description = "バストンラ", CountId = "1351520", EquipmentActiveAbility = "30190", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000012", BitNumber = "85"};
        public static readonly Materia HP_504100010 = new Materia { Name = "HP +10%", MateriaId = "504100010", Description = "HP+10%", CountId = "2111010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100010", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "145"};
        public static readonly Materia MP_504100040 = new Materia { Name = "MP +10%", MateriaId = "504100040", Description = "MP+10%", CountId = "2112010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100040", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "148"};
        public static readonly Materia MP_504100050 = new Materia { Name = "MP +20%", MateriaId = "504100050", Description = "MP+20%", CountId = "2112030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100050", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "149"};
        public static readonly Materia ATK_504100070 = new Materia { Name = "ATK +10%", MateriaId = "504100070", Description = "攻撃+10%", CountId = "2113010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100070", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "151"};
        public static readonly Materia ATK_504100080 = new Materia { Name = "ATK +20%", MateriaId = "504100080", Description = "攻撃+20%", CountId = "998", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100080", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "152"};
        public static readonly Materia MAG_504100120 = new Materia { Name = "MAG +30%", MateriaId = "504100120", Description = "魔力+30%", CountId = "2115050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100120", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "156"};
        public static readonly Materia AutoLimit = new Materia { Name = "Auto-Limit", MateriaId = "504100750", Description = "オートリミット", CountId = "2173010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100750", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "219"};
        public static readonly Materia EquipSSword = new Materia { Name = "Equip S Sword", MateriaId = "504100760", Description = "短剣装備", CountId = "2155010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100760", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "220"};
        public static readonly Materia EquipLSword = new Materia { Name = "Equip L Sword", MateriaId = "504100780", Description = "大剣装備", CountId = "2155030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100780", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "222"};
        public static readonly Materia EquipStaff = new Materia { Name = "Equip Staff", MateriaId = "504100800", Description = "杖装備", CountId = "2155050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100800", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "224"};
        public static readonly Materia EquipHArmor = new Materia { Name = "Equip H Armor", MateriaId = "504100940", Description = "重鎧装備", CountId = "2155570", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100940", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "238"};
        public static readonly Materia StoneKiller = new Materia { Name = "Stone Killer", MateriaId = "504101010", Description = "ストーンキラー", CountId = "2152020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101010", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "245"};
        public static readonly Materia MachineKiller = new Materia { Name = "Machine Killer", MateriaId = "504101030", Description = "マシーンキラー", CountId = "2152040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101030", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "247"};
        public static readonly Materia DragonKiller_504101050 = new Materia { Name = "Dragon Killer", MateriaId = "504101050", Description = "ドラゴンキラー", CountId = "2152060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101050", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "249"};
        public static readonly Materia AquanKiller = new Materia { Name = "Aquan Killer", MateriaId = "504101110", Description = "アクアンキラー", CountId = "2152120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101110", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "255"};
        public static readonly Materia Cover = new Materia { Name = "Cover", MateriaId = "504101170", Description = "かばう", CountId = "2178010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000069", BitNumber = "261"};
        public static readonly Materia Counter = new Materia { Name = "Counter", MateriaId = "504101200", Description = "カウンター", CountId = "2175010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101200", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000068", BitNumber = "264"};
        public static readonly Materia Evade = new Materia { Name = "Evade", MateriaId = "504101230", Description = "しらはどり", CountId = "2177010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101230", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000075", BitNumber = "267"};
        public static readonly Materia Camouflage = new Materia { Name = "Camouflage", MateriaId = "504101350", Description = "カモフラージュ", CountId = "2176010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101350", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000084", BitNumber = "279"};
        public static readonly Materia Doublehand = new Materia { Name = "Doublehand", MateriaId = "504101360", Description = "りょうてもち", CountId = "2171010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "280"};
        public static readonly Materia DualWield_504101370 = new Materia { Name = "Dual Wield", MateriaId = "504101370", Description = "にとうりゅう", CountId = "2171020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "281"};
        public static readonly Materia Steal = new Materia { Name = "Steal", MateriaId = "504200010", Description = "ぬすむ", CountId = "2290010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200010", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000082", BitNumber = "294"};
        public static readonly Materia Pilfer = new Materia { Name = "Pilfer", MateriaId = "504200030", Description = "くすねる", CountId = "2290020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200030", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000082", BitNumber = "296"};
        public static readonly Materia Drink = new Materia { Name = "Drink", MateriaId = "504200090", Description = "のむ", CountId = "2290210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200090", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000058", BitNumber = "302"};
        public static readonly Materia Brace = new Materia { Name = "Brace", MateriaId = "504200120", Description = "がまん", CountId = "2290310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200120", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "305"};
        public static readonly Materia Throw = new Materia { Name = "Throw", MateriaId = "504200180", Description = "なげる", CountId = "2290220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200180", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000047", BitNumber = "311"};
        public static readonly Materia Store = new Materia { Name = "Store", MateriaId = "504200210", Description = "ためる", CountId = "2290320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200210", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000087", BitNumber = "314"};
        public static readonly Materia RagingFist = new Materia { Name = "Raging Fist", MateriaId = "504200230", Description = "爆裂拳", CountId = "2212110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200230", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000051", BitNumber = "316"};
        public static readonly Materia Escape = new Materia { Name = "Escape", MateriaId = "504200250", Description = "とんずら", CountId = "2290110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200250", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000057", BitNumber = "318"};
        public static readonly Materia Barrage = new Materia { Name = "Barrage", MateriaId = "504200310", Description = "みだれうち", CountId = "2212210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200310", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000053", BitNumber = "324"};
        public static readonly Materia MirrorofEquity = new Materia { Name = "Mirror of Equity", MateriaId = "504200320", Description = "明鏡", CountId = "2212010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200320", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000053", BitNumber = "325"};
        public static readonly Materia Aim = new Materia { Name = "Aim", MateriaId = "504200390", Description = "ねらう", CountId = "2212020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200390", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000040", BitNumber = "332"};
        public static readonly Materia Bladeblitz = new Materia { Name = "Bladeblitz", MateriaId = "504200440", Description = "ぜんぎり", CountId = "2212310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200440", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000053", BitNumber = "337"};
        public static readonly Materia FireBlade = new Materia { Name = "Fire Blade", MateriaId = "504200510", Description = "ファイア剣", CountId = "2240010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200510", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000021", BitNumber = "344"};
        public static readonly Materia BlizzardBlade = new Materia { Name = "Blizzard Blade", MateriaId = "504200520", Description = "ブリザド剣", CountId = "2240110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200520", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000022", BitNumber = "345"};
        public static readonly Materia SilenceBlade = new Materia { Name = "Silence Blade", MateriaId = "504200550", Description = "サイレス剣", CountId = "2241020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200550", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "348"};
        public static readonly Materia WaterBlade = new Materia { Name = "Water Blade", MateriaId = "504200560", Description = "ウォータ剣", CountId = "2240310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200560", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000023", BitNumber = "349"};
        public static readonly Materia StoneBlade = new Materia { Name = "Stone Blade", MateriaId = "504200580", Description = "ストーン剣", CountId = "2240510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200580", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000028", BitNumber = "351"};
        public static readonly Materia BlindBlade = new Materia { Name = "Blind Blade", MateriaId = "504200590", Description = "ブライン剣", CountId = "2241030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200590", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000009", BitNumber = "352"};
        public static readonly Materia BioBlade = new Materia { Name = "Bio Blade", MateriaId = "504200600", Description = "バイオ剣", CountId = "2240610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200600", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000024", BitNumber = "353"};
        public static readonly Materia DrainBlade = new Materia { Name = "Drain Blade", MateriaId = "504200670", Description = "ドレイン剣", CountId = "2242010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200670", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000015", BitNumber = "360"};
        public static readonly Materia ThundagaBlade = new Materia { Name = "Thundaga Blade", MateriaId = "504200720", Description = "サンダガ剣", CountId = "2240230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200720", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000020", BitNumber = "365"};
        public static readonly Materia BiogaBlade = new Materia { Name = "Bioga Blade", MateriaId = "504200760", Description = "バイオガ剣", CountId = "2240630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200760", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000024", BitNumber = "369"};
        public static readonly Materia MagicInfuse = new Materia { Name = "Magic Infuse", MateriaId = "504200800", Description = "まれんけい", CountId = "2212640", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200800", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000026", BitNumber = "373"};
        public static readonly Materia Lullaby = new Materia { Name = "Lullaby", MateriaId = "504200810", Description = "こもりうた", CountId = "2280010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200810", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000100", BitNumber = "374"};
        public static readonly Materia Paean = new Materia { Name = "Paean", MateriaId = "504200850", Description = "いやしのうた", CountId = "2280020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200850", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000100", BitNumber = "378"};
        public static readonly Materia MentalBreak = new Materia { Name = "Mental Break", MateriaId = "504201160", Description = "メンタルブレイク", CountId = "2219310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201160", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "409"};
        public static readonly Materia SilenceDance = new Materia { Name = "Silence Dance", MateriaId = "504201190", Description = "ちんもくダンス", CountId = "2285010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201190", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000050", BitNumber = "412"};
        public static readonly Materia FireBeam = new Materia { Name = "Fire Beam", MateriaId = "504201260", Description = "ファイアビーム", CountId = "2212610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201260", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000021", BitNumber = "419"};
        public static readonly Materia BlizzardBeam = new Materia { Name = "Blizzard Beam", MateriaId = "504201280", Description = "ブリザービーム", CountId = "2212620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201280", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000022", BitNumber = "421"};
        public static readonly Materia BioBlaster = new Materia { Name = "Bio Blaster", MateriaId = "504201320", Description = "バイオブラスター", CountId = "2212630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201320", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000024", BitNumber = "425"};
        public static readonly Materia PowerShot = new Materia { Name = "Power Shot", MateriaId = "504201340", Description = "パワーショット", CountId = "2212030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201340", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000040", BitNumber = "427"};
        public static readonly Materia Sunbeam = new Materia { Name = "Sunbeam", MateriaId = "504201430", Description = "サンビーム", CountId = "2212550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201430", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000052", BitNumber = "436"};
        public static readonly Materia Meteor = new Materia { Name = "Meteor", MateriaId = "504020430", Description = "メテオ", CountId = "1255030", EquipmentActiveAbility = "20430", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000029", BitNumber = "65"};
        public static readonly Materia Comet = new Materia { Name = "Comet", MateriaId = "504020170", Description = "コメット", CountId = "1255010", EquipmentActiveAbility = "20170", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000029", BitNumber = "39"};
        public static readonly Materia Protect = new Materia { Name = "Protect", MateriaId = "504030090", Description = "プロテス", CountId = "1350110", EquipmentActiveAbility = "30090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "439"};
        public static readonly Materia SPR_504100160 = new Materia { Name = "SPR +10%", MateriaId = "504100160", Description = "精神+10%", CountId = "2116010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100160", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "437"};
        public static readonly Materia BugKiller_504101020 = new Materia { Name = "Bug Killer", MateriaId = "504101020", Description = "ムシキラー", CountId = "2152030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101020", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "438"};
        public static readonly Materia Cura = new Materia { Name = "Cura", MateriaId = "504010070", Description = "ケアルラ", CountId = "1150030", EquipmentActiveAbility = "10070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000004", BitNumber = "7"};
        public static readonly Materia DEF_504100130 = new Materia { Name = "DEF +10%", MateriaId = "504100130", Description = "防御+10%", CountId = "2114010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100130", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "157"};
        public static readonly Materia EquipBow = new Materia { Name = "Equip Bow", MateriaId = "504100820", Description = "弓装備", CountId = "2155070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100820", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000096", BitNumber = "440"};
        public static readonly Materia Bravery = new Materia { Name = "Bravery", MateriaId = "504030210", Description = "ブレイブ", CountId = "1350010", EquipmentActiveAbility = "30210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000077", BitNumber = "442"};
        public static readonly Materia ATK_504100090 = new Materia { Name = "ATK +30%", MateriaId = "504100090", Description = "攻撃+30%", CountId = "2113050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100090", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "443"};
        public static readonly Materia MAG_504100100 = new Materia { Name = "MAG +10%", MateriaId = "504100100", Description = "魔力+10%", CountId = "2115010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100100", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "444"};
        public static readonly Materia MP_504100060 = new Materia { Name = "MP +30%", MateriaId = "504100060", Description = "MP+30%", CountId = "2112050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100060", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "445"};
        public static readonly Materia HolyBlade = new Materia { Name = "Holy Blade", MateriaId = "504200770", Description = "ホーリー剣", CountId = "2245010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200770", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000005", BitNumber = "446"};
        public static readonly Materia KatanaMastery = new Materia { Name = "Katana Mastery", MateriaId = "504201670", Description = "刀の極意", CountId = "2151310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201670", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000053", BitNumber = "447"};
        public static readonly Materia LightsBlessing = new Materia { Name = "Light's Blessing", MateriaId = "504201680", Description = "光の加護", CountId = "2174010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201680", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000091", BitNumber = "448"};
        public static readonly Materia Dispel = new Materia { Name = "Dispel", MateriaId = "504010130", Description = "デスペル", CountId = "1150180", EquipmentActiveAbility = "10130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000003", BitNumber = "454"};
        public static readonly Materia Faith = new Materia { Name = "Faith", MateriaId = "504030220", Description = "フェイス", CountId = "1350210", EquipmentActiveAbility = "30220", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000077", BitNumber = "455"};
        public static readonly Materia HP_504100030 = new Materia { Name = "HP +30%", MateriaId = "504100030", Description = "HP+30%", CountId = "2111050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100030", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "452"};
        public static readonly Materia EquipAxe = new Materia { Name = "Equip Axe", MateriaId = "504100830", Description = "斧装備", CountId = "2155080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100830", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "453"};
        public static readonly Materia EquipHat = new Materia { Name = "Equip Hat", MateriaId = "504100960", Description = "帽子装備", CountId = "2155530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100960", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "456"};
        public static readonly Materia SpiritSlayer = new Materia { Name = "Spirit Slayer", MateriaId = "504101100", Description = "スピリットキラー", CountId = "2152110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101100", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "457"};
        public static readonly Materia HP_504101500 = new Materia { Name = "HP +15%", MateriaId = "504101500", Description = "HP+15%", CountId = "2111020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101500", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "449"};
        public static readonly Materia SleepBlade = new Materia { Name = "Sleep Blade", MateriaId = "504200540", Description = "スリプル剣", CountId = "2241010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200540", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "458"};
        public static readonly Materia AeroBlade = new Materia { Name = "Aero Blade", MateriaId = "504200570", Description = "エアロ剣", CountId = "2240410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200570", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000025", BitNumber = "459"};
        public static readonly Materia StonraBlade = new Materia { Name = "Stonra Blade", MateriaId = "504200660", Description = "ストンラ剣", CountId = "2240520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200660", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000028", BitNumber = "450"};
        public static readonly Materia MelodyofLife = new Materia { Name = "Melody of Life", MateriaId = "504201750", Description = "生命のメロディ", CountId = "2153930", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201750", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000018", BitNumber = "451"};
        public static readonly Materia SealofDestruction_504201950 = new Materia { Name = "Seal of Destruction", MateriaId = "504201950", Description = "破壊の刻印", CountId = "2131150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201950", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "460"};
        public static readonly Materia SealofProtection = new Materia { Name = "Seal of Protection", MateriaId = "504201960", Description = "守護の刻印", CountId = "2131180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201960", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "461"};
        public static readonly Materia GoddesssProtection = new Materia { Name = "Goddess's Protection", MateriaId = "504201970", Description = "聖女神の守護", CountId = "2154991", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201970", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000097", BitNumber = "462"};
        public static readonly Materia EquipHShield = new Materia { Name = "Equip H Shield", MateriaId = "504100990", Description = "重盾装備", CountId = "2155520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100990", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "463"};
        public static readonly Materia Dualcast = new Materia { Name = "Dualcast", MateriaId = "504200150", Description = "れんぞくま", CountId = "2295010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200150", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000026", BitNumber = "464"};
        public static readonly Materia Curada = new Materia { Name = "Curada", MateriaId = "504010150", Description = "ケアルダ", CountId = "1150040", EquipmentActiveAbility = "10150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000004", BitNumber = "465"};
        public static readonly Materia EVOMAG_504100190 = new Materia { Name = "EVO MAG +10%", MateriaId = "504100190", Description = "召喚魔法+10%", CountId = "2117010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100190", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "466"};
        public static readonly Materia PlantKiller_504101000 = new Materia { Name = "Plant Killer", MateriaId = "504101000", Description = "プラントキラー", CountId = "2152010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101000", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "467"};
        public static readonly Materia WateraBlade = new Materia { Name = "Watera Blade", MateriaId = "504200640", Description = "ウォタラ剣", CountId = "2240320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200640", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000023", BitNumber = "468"};
        public static readonly Materia SecondWind = new Materia { Name = "Second Wind", MateriaId = "504202350", Description = "エール", CountId = "8000010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "469"};
        public static readonly Materia CrushArmor = new Materia { Name = "Crush Armor", MateriaId = "504202360", Description = "強甲破点突き", CountId = "8000020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000054", BitNumber = "470"};
        public static readonly Materia Medicate = new Materia { Name = "Medicate", MateriaId = "504202370", Description = "手当て", CountId = "8000030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000003", BitNumber = "471"};
        public static readonly Materia StoneThrow = new Materia { Name = "Stone Throw", MateriaId = "504202380", Description = "投石", CountId = "2211010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000047", BitNumber = "472"};
        public static readonly Materia EquipSpear = new Materia { Name = "Equip Spear", MateriaId = "504100850", Description = "槍装備", CountId = "2155100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100850", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "473"};
        public static readonly Materia Thunderfall = new Materia { Name = "Thunderfall", MateriaId = "504202470", Description = "天鳴万雷", CountId = "8000040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202470", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000020", BitNumber = "474"};
        public static readonly Materia HereWeGo = new Materia { Name = "Here We Go", MateriaId = "504202480", Description = "テンションあげあげ", CountId = "8000050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202480", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "475"};
        public static readonly Materia Attacker = new Materia { Name = "Attacker", MateriaId = "504202490", Description = "アタッカー", CountId = "8000060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "476"};
        public static readonly Materia Defender = new Materia { Name = "Defender", MateriaId = "504202500", Description = "ディフェンダー", CountId = "8000070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202500", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "477"};
        public static readonly Materia StickyFingers = new Materia { Name = "Sticky Fingers", MateriaId = "504202760", Description = "キャッチ", CountId = "2132120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202760", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "478"};
        public static readonly Materia CoinSteal = new Materia { Name = "Coin Steal", MateriaId = "504202770", Description = "コインを盗む", CountId = "2290040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202770", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000082", BitNumber = "479"};
        public static readonly Materia LungeCombo = new Materia { Name = "Lunge Combo", MateriaId = "504202780", Description = "突貫コンボ", CountId = "2132060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202780", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "480"};
        public static readonly Materia BurstShot = new Materia { Name = "Burst Shot", MateriaId = "1500000000", Description = "バーストショット", CountId = "90000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "700000040", BitNumber = "90000"};
        public static readonly Materia AutoProtect = new Materia { Name = "Auto-Protect", MateriaId = "504100710", Description = "オートプロテス", CountId = "2174110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100710", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "481"};
        public static readonly Materia EquipRod = new Materia { Name = "Equip Rod", MateriaId = "504100810", Description = "ロッド装備", CountId = "2155060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100810", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "482"};
        public static readonly Materia BioraBlade = new Materia { Name = "Biora Blade", MateriaId = "504200680", Description = "バイオラ剣", CountId = "2240620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200680", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000024", BitNumber = "483"};
        public static readonly Materia Acceptance = new Materia { Name = "Acceptance", MateriaId = "504203150", Description = "受け取る力", CountId = "2132150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203150", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "484"};
        public static readonly Materia Knowledge = new Materia { Name = "Knowledge", MateriaId = "504203160", Description = "知の力", CountId = "2135310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203160", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "485"};
        public static readonly Materia Ignorance = new Materia { Name = "Ignorance", MateriaId = "504203170", Description = "無知なる力", CountId = "2173020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203170", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000091", BitNumber = "486"};
        public static readonly Materia Discernment = new Materia { Name = "Discernment", MateriaId = "504203180", Description = "認識する力", CountId = "2154992", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203180", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000014", BitNumber = "487"};
        public static readonly Materia Accelerate = new Materia { Name = "Accelerate", MateriaId = "504203190", Description = "スピードアップ", CountId = "2177020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203190", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000097", BitNumber = "488"};
        public static readonly Materia Twinspell = new Materia { Name = "Twinspell", MateriaId = "504203200", Description = "ツインマジック", CountId = "2132020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203200", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "489"};
        public static readonly Materia InsulttoInjury = new Materia { Name = "Insult to Injury", MateriaId = "504203210", Description = "スタンフィニッシュ", CountId = "8000080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203210", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000054", BitNumber = "490"};
        public static readonly Materia CutCards = new Materia { Name = "Cut Cards", MateriaId = "504203220", Description = "デッキオープン", CountId = "8000090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203220", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000083", BitNumber = "491"};
        public static readonly Materia Mentality = new Materia { Name = "Mentality", MateriaId = "504203370", Description = "メンタリティ", CountId = "2132160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "492"};
        public static readonly Materia LettersandArms = new Materia { Name = "Letters and Arms", MateriaId = "504203380", Description = "文武両道", CountId = "2151510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203380", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "493"};
        public static readonly Materia ManasProtection = new Materia { Name = "Mana's Protection", MateriaId = "504203810", Description = "マナの加護", CountId = "2132010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203810", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "494"};
        public static readonly Materia ManasBlessing = new Materia { Name = "Mana's Blessing", MateriaId = "504203820", Description = "マナの祝福", CountId = "2131010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203820", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "495"};
        public static readonly Materia DeepThoughts = new Materia { Name = "Deep Thoughts", MateriaId = "504203830", Description = "一途な想い", CountId = "2132190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203830", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "496"};
        public static readonly Materia FairyWisdom = new Materia { Name = "Fairy Wisdom", MateriaId = "504203840", Description = "妖精族の知恵", CountId = "2132030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203840", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "497"};
        public static readonly Materia Mana = new Materia { Name = "Mana", MateriaId = "504203800", Description = "マナ", CountId = "8000110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203800", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000063", BitNumber = "498"};
        public static readonly Materia FullMoonSlash = new Materia { Name = "Full Moon Slash", MateriaId = "504203460", Description = "満月斬り", CountId = "8000100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203460", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "499"};
        public static readonly Materia AutoShell = new Materia { Name = "Auto-Shell", MateriaId = "504100720", Description = "オートシェル", CountId = "2174210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100720", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "500"};
        public static readonly Materia OsmoseBlade = new Materia { Name = "Osmose Blade", MateriaId = "504200690", Description = "アスピル剣", CountId = "2242110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000015", BitNumber = "501"};
        public static readonly Materia SyldrasProtection = new Materia { Name = "Syldra's Protection", MateriaId = "504204030", Description = "海竜の加護", CountId = "2152510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204030", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "502"};
        public static readonly Materia Wisdom = new Materia { Name = "Wisdom", MateriaId = "504204250", Description = "賢き力", CountId = "2131520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204250", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "503"};
        public static readonly Materia Action = new Materia { Name = "Action", MateriaId = "504204260", Description = "行動する力", CountId = "2179210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000081", BitNumber = "504"};
        public static readonly Materia Innocence = new Materia { Name = "Innocence", MateriaId = "504204270", Description = "純真なる力", CountId = "2133310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204270", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "505"};
        public static readonly Materia Tranquility = new Materia { Name = "Tranquility", MateriaId = "504204280", Description = "冷静なる力", CountId = "2131410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204280", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "506"};
        public static readonly Materia GateofDestiny = new Materia { Name = "Gate of Destiny", MateriaId = "504204290", Description = "エナジーボム", CountId = "8000120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204290", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000026", BitNumber = "507"};
        public static readonly Materia WhiteKnight = new Materia { Name = "White Knight", MateriaId = "504204300", Description = "セーフティガード", CountId = "8000130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204300", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000091", BitNumber = "508"};
        public static readonly Materia TemperedShield = new Materia { Name = "Tempered Shield", MateriaId = "504204310", Description = "硬化シールド", CountId = "2131020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204310", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "509"};
        public static readonly Materia ImperialHelm = new Materia { Name = "Imperial Helm", MateriaId = "504204320", Description = "皇国軍ヘルメット", CountId = "2131160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204320", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "510"};
        public static readonly Materia MP_504203240 = new Materia { Name = "MP + 15%", MateriaId = "504203240", Description = "MP+15%", CountId = "2112020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203240", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "511"};
        public static readonly Materia ATK_504101600 = new Materia { Name = "ATK +15%", MateriaId = "504101600", Description = "攻撃+15%", CountId = "2113020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101600", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "512"};
        public static readonly Materia DarkBond = new Materia { Name = "Dark Bond", MateriaId = "504204590", Description = "ヘスの血脈", CountId = "2151530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204590", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "513"};
        public static readonly Materia WaterGodsProtection = new Materia { Name = "Water God's Protection", MateriaId = "504204600", Description = "水神の加護", CountId = "2132170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204600", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "514"};
        public static readonly Materia Breaker = new Materia { Name = "Breaker", MateriaId = "504207510", Description = "ブレイカー", CountId = "8000200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207510", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "562"};
        public static readonly Materia DemonicLife = new Materia { Name = "Demonic Life", MateriaId = "504207680", Description = "魔神の燃命", CountId = "2139020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207680", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "563"};
        public static readonly Materia DestroyersAuthority = new Materia { Name = "Destroyer's Authority", MateriaId = "504207690", Description = "破神の威光", CountId = "2131110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "564"};
        public static readonly Materia GuardiansAuthority = new Materia { Name = "Guardian's Authority", MateriaId = "504207700", Description = "守神の威光", CountId = "2131170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207700", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "565"};
        public static readonly Materia PowerofCreation = new Materia { Name = "Power of Creation", MateriaId = "504207710", Description = "創造神の力", CountId = "2133510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207710", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "566"};
        public static readonly Materia DarkResistance_504207720 = new Materia { Name = "Dark Resistance +15%", MateriaId = "504207720", Description = "闇属性耐性+15%", CountId = "2153820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207720", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000098", BitNumber = "567"};
        public static readonly Materia ChillingAura = new Materia { Name = "Chilling Aura", MateriaId = "1500000001", Description = "恐怖のオーラ", CountId = "90001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "900010", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "1500000001", BitNumber = "90001"};
        public static readonly Materia SpookyAura = new Materia { Name = "Spooky Aura", MateriaId = "1500000002", Description = "不気味なオーラ", CountId = "90002", EquipmentActiveAbility = "", EquipmentPassiveAbility = "900011", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "1500000002", BitNumber = "90002"};
        public static readonly Materia SealofDestruction_1500000003 = new Materia { Name = "Seal of Destruction", MateriaId = "1500000003", Description = "破壊の刻印", CountId = "90003", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910025", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90003"};
        public static readonly Materia MAG_504101700 = new Materia { Name = "MAG +15%", MateriaId = "504101700", Description = "魔力+15%", CountId = "2115020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101700", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "520"};
        public static readonly Materia Death = new Materia { Name = "Death", MateriaId = "504020280", Description = "デス", CountId = "1259010", EquipmentActiveAbility = "20280", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000038", BitNumber = "515"};
        public static readonly Materia EquipClothes = new Materia { Name = "Equip Clothes", MateriaId = "504100920", Description = "服装備", CountId = "2155550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100920", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "516"};
        public static readonly Materia ManEater_504101040 = new Materia { Name = "Man-Eater", MateriaId = "504101040", Description = "マンイーター", CountId = "2152050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101040", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "517"};
        public static readonly Materia BirdKiller = new Materia { Name = "Bird Killer", MateriaId = "504101090", Description = "バードキラー", CountId = "2152100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101090", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "518"};
        public static readonly Materia AutoPotion = new Materia { Name = "Auto-Potion", MateriaId = "504101120", Description = "オートポーション", CountId = "2179010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101120", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "519"};
        public static readonly Materia PowerBreak = new Materia { Name = "Power Break", MateriaId = "504201130", Description = "パワーブレイク", CountId = "2219010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201130", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "521"};
        public static readonly Materia MagicBreak = new Materia { Name = "Magic Break", MateriaId = "504201140", Description = "マジックブレイク", CountId = "2219210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201140", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "522"};
        public static readonly Materia MiracleStep = new Materia { Name = "Miracle Step", MateriaId = "504204900", Description = "ミラクルステップ", CountId = "2177040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204900", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "523"};
        public static readonly Materia CrushHelm = new Materia { Name = "Crush Helm", MateriaId = "504204910", Description = "星天爆撃打", CountId = "8000140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204910", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "524"};
        public static readonly Materia HealingWaltzII = new Materia { Name = "Healing Waltz II", MateriaId = "504204920", Description = "ヒーリングワルツII", CountId = "8000150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204920", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000050", BitNumber = "525"};
        public static readonly Materia Poach = new Materia { Name = "Poach", MateriaId = "504204930", Description = "密猟", CountId = "2152210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204930", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000079", BitNumber = "526"};
        public static readonly Materia FirstStrike = new Materia { Name = "First Strike", MateriaId = "504204940", Description = "ハメドる", CountId = "2177030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204940", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000068", BitNumber = "527"};
        public static readonly Materia Lifefont = new Materia { Name = "Lifefont", MateriaId = "504204950", Description = "HP回復移動", CountId = "2179110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204950", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000073", BitNumber = "528"};
        public static readonly Materia QuickAssault = new Materia { Name = "Quick Assault", MateriaId = "504205130", Description = "クイックアサルト", CountId = "2177050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205130", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "529"};
        public static readonly Materia DarkKnightsSoul = new Materia { Name = "Dark Knight's Soul", MateriaId = "504205260", Description = "ダークナイトソウル", CountId = "2151320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205260", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "530"};
        public static readonly Materia HillDigger = new Materia { Name = "Hill Digger", MateriaId = "504205350", Description = "山そだち", CountId = "2131720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205350", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "531"};
        public static readonly Materia Successor = new Materia { Name = "Successor", MateriaId = "504205430", Description = "後継者", CountId = "2131420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205430", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "532"};
        public static readonly Materia Magician = new Materia { Name = "Magician", MateriaId = "504205440", Description = "マジシャン", CountId = "2135110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205440", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "533"};
        public static readonly Materia Fighter = new Materia { Name = "Fighter", MateriaId = "504205450", Description = "ファイター", CountId = "2133110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205450", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "534"};
        public static readonly Materia SeethingCauldron = new Materia { Name = "Seething Cauldron", MateriaId = "504205460", Description = "あふれる魔力", CountId = "2132100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205460", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "535"};
        public static readonly Materia SwellingPower = new Materia { Name = "Swelling Power", MateriaId = "504205470", Description = "みなぎる力", CountId = "2131130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205470", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "536"};
        public static readonly Materia BushidoFreedom = new Materia { Name = "Bushido - Freedom", MateriaId = "504205490", Description = "奥義・天下御免", CountId = "2219510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "537"};
        public static readonly Materia DomineeringSpirit = new Materia { Name = "Domineering Spirit", MateriaId = "504205650", Description = "覇者の闘気", CountId = "2171990", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205650", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "538"};
        public static readonly Materia Scorch = new Materia { Name = "Scorch", MateriaId = "504205980", Description = "しゃくねつ", CountId = "2212710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205980", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000021", BitNumber = "539"};
        public static readonly Materia MightyDefense = new Materia { Name = "Mighty Defense", MateriaId = "504205880", Description = "つねにだいぼうぎょ", CountId = "2134710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205880", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "540"};
        public static readonly Materia InstinctualGuard = new Materia { Name = "Instinctual Guard", MateriaId = "504206070", Description = "ぼうえいほんのう", CountId = "2133710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206070", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "541"};
        public static readonly Materia ThunderBlade = new Materia { Name = "Thunder Blade", MateriaId = "504200530", Description = "サンダー剣", CountId = "2240210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200530", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000020", BitNumber = "346"};
        public static readonly Materia ArmorBreak = new Materia { Name = "Armor Break", MateriaId = "504201150", Description = "アーマーブレイク", CountId = "2219110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201150", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "542"};
        public static readonly Materia MetalSlash = new Materia { Name = "Metal Slash", MateriaId = "504205710", Description = "メタル斬り", CountId = "2211020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205710", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000054", BitNumber = "543"};
        public static readonly Materia HustleDance = new Materia { Name = "Hustle Dance", MateriaId = "504205990", Description = "ハッスルダンス", CountId = "2285020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205990", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000050", BitNumber = "544"};
        public static readonly Materia WaveofPanic = new Materia { Name = "Wave of Panic", MateriaId = "504205660", Description = "やみのはどう", CountId = "8000160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205660", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000039", BitNumber = "545"};
        public static readonly Materia UndeadKiller = new Materia { Name = "Undead Killer", MateriaId = "504101060", Description = "アンデッドキラー", CountId = "2152070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101060", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "546"};
        public static readonly Materia ElementalDamageDown = new Materia { Name = "Elemental Damage Down", MateriaId = "504206080", Description = "属性ダメージ減", CountId = "8000170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206080", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000018", BitNumber = "547"};
        public static readonly Materia EmperorsMajesty = new Materia { Name = "Emperor's Majesty", MateriaId = "504206270", Description = "皇帝の威厳", CountId = "2131515", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "548"};
        public static readonly Materia HereticsAbyss = new Materia { Name = "Heretic's Abyss", MateriaId = "504206320", Description = "魔道の深淵", CountId = "2132140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206320", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "549"};
        public static readonly Materia Resuscitate = new Materia { Name = "Resuscitate", MateriaId = "504206390", Description = "起死回生", CountId = "2139010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206390", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "550"};
        public static readonly Materia Love = new Materia { Name = "Love", MateriaId = "504206630", Description = "愛", CountId = "2131710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206630", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "551"};
        public static readonly Materia Resolve = new Materia { Name = "Resolve", MateriaId = "504206680", Description = "決断する力", CountId = "2172020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206680", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000091", BitNumber = "552"};
        public static readonly Materia Persistence = new Materia { Name = "Persistence", MateriaId = "504206750", Description = "執着する力", CountId = "2134310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206750", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "553"};
        public static readonly Materia SiphonDelta = new Materia { Name = "Siphon Delta", MateriaId = "504206650", Description = "アスピルフィールド", CountId = "8000180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206650", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000015", BitNumber = "554"};
        public static readonly Materia Multitask = new Materia { Name = "Multitask", MateriaId = "504206740", Description = "リロード射撃", CountId = "8000190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206740", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000040", BitNumber = "555"};
        public static readonly Materia AzureHelm = new Materia { Name = "Azure Helm", MateriaId = "504206840", Description = "蒼龍風の兜", CountId = "2132130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206840", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "556"};
        public static readonly Materia AzureArmor = new Materia { Name = "Azure Armor", MateriaId = "504206850", Description = "蒼龍風の鎧", CountId = "2132040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206850", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "557"};
        public static readonly Materia AutoRefresh = new Materia { Name = "Auto-Refresh", MateriaId = "504100740", Description = "オートリフレシュ", CountId = "2172010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100740", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "558"};
        public static readonly Materia EquipLShield = new Materia { Name = "Equip L Shield", MateriaId = "504100980", Description = "軽盾装備", CountId = "2155510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100980", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "559"};
        public static readonly Materia MageCannon = new Materia { Name = "Mage Cannon", MateriaId = "504207380", Description = "魔導砲", CountId = "2212510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207380", ItemStack = "99", ItemBuyPrice = "1500", ItemSellPrice = "1500", ItemIdClone = "700000019", BitNumber = "560"};
        public static readonly Materia LargeSwordMastery = new Materia { Name = "Large Sword Mastery", MateriaId = "504207410", Description = "大剣の極意", CountId = "2151330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207410", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "561"};
        public static readonly Materia DivineSeal = new Materia { Name = "Divine Seal", MateriaId = "504207770", Description = "ディヴァインシール", CountId = "8000210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207770", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "568"};
        public static readonly Materia ProtectionoftheTwelve = new Materia { Name = "Protection of the Twelve", MateriaId = "504208090", Description = "十二神の冥加", CountId = "8000220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208090", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000068", BitNumber = "569"};
        public static readonly Materia ShardofGenius = new Materia { Name = "Shard of Genius", MateriaId = "504208100", Description = "叡知の結晶", CountId = "2151610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208100", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "570"};
        public static readonly Materia FollowersOath = new Materia { Name = "Follower's Oath", MateriaId = "504208110", Description = "盟主への誓い", CountId = "2131140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208110", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "571"};
        public static readonly Materia HydaelynGuard = new Materia { Name = "Hydaelyn Guard", MateriaId = "504208120", Description = "ハイデリンの加護", CountId = "2153910", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208120", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000018", BitNumber = "572"};
        public static readonly Materia BeastKiller = new Materia { Name = "Beast Killer", MateriaId = "504101080", Description = "ビーストキラー", CountId = "2152090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101080", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "573"};
        public static readonly Materia Returner = new Materia { Name = "Returner", MateriaId = "504208480", Description = "リターナー", CountId = "2132050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208480", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "576"};
        public static readonly Materia WarriorMage = new Materia { Name = "Warrior Mage", MateriaId = "504208490", Description = "魔導戦士", CountId = "2132090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208490", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "577"};
        public static readonly Materia ToxicRain = new Materia { Name = "Toxic Rain", MateriaId = "504208500", Description = "暴風酸性雨", CountId = "2212560", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208580", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000009", BitNumber = "578"};
        public static readonly Materia RodMastery = new Materia { Name = "Rod Mastery", MateriaId = "504208510", Description = "ロッドの極意", CountId = "2151533", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208590", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "579"};
        public static readonly Materia RageMeteor = new Materia { Name = "Rage - Meteor", MateriaId = "504208570", Description = "あばれる【メテオ】", CountId = "2212320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208570", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000019", BitNumber = "580"};
        public static readonly Materia LightResistance_504208900 = new Materia { Name = "Light Resistance +15%", MateriaId = "504208900", Description = "光属性耐性+15%", CountId = "2153720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208900", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000099", BitNumber = "581"};
        public static readonly Materia HealersWisdom = new Materia { Name = "Healer's Wisdom", MateriaId = "504208740", Description = "癒し手の心得", CountId = "2136710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208740", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "582"};
        public static readonly Materia DEF_504208970 = new Materia { Name = "DEF +15%", MateriaId = "504208970", Description = "防御+15%", CountId = "2114020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208970", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "583"};
        public static readonly Materia SPR_504208980 = new Materia { Name = "SPR +15%", MateriaId = "504208980", Description = "精神+15%", CountId = "2116020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208980", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "584"};
        public static readonly Materia NullParalysis = new Materia { Name = "Null Paralysis", MateriaId = "504208990", Description = "麻痺無効", CountId = "2154050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208990", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "585"};
        public static readonly Materia DemonKiller = new Materia { Name = "Demon Killer", MateriaId = "504101070", Description = "デーモンキラー", CountId = "2152080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101070", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "586"};
        public static readonly Materia EquipFists = new Materia { Name = "Equip Fists", MateriaId = "504100910", Description = "格闘装備", CountId = "2155160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100910", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "587"};
        public static readonly Materia WarriorLore = new Materia { Name = "Warrior Lore", MateriaId = "504209480", Description = "戦士の心得", CountId = "2131120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209480", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "588"};
        public static readonly Materia MagesMonograph = new Materia { Name = "Mage's Monograph", MateriaId = "504209490", Description = "魔道士の心得", CountId = "2131190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209490", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "589"};
        public static readonly Materia Imperil = new Materia { Name = "Imperil", MateriaId = "504030200", Description = "ウィーク", CountId = "1359010", EquipmentActiveAbility = "30200", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000039", BitNumber = "590"};
        public static readonly Materia PatrioticRecall = new Materia { Name = "Patriotic Recall", MateriaId = "504209350", Description = "祖国への想い", CountId = "2131730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "591"};
        public static readonly Materia Curaga = new Materia { Name = "Curaga", MateriaId = "504010160", Description = "ケアルガ", CountId = "1150050", EquipmentActiveAbility = "10160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000004", BitNumber = "592"};
        public static readonly Materia DEF_504100140 = new Materia { Name = "DEF +20%", MateriaId = "504100140", Description = "防御+20%", CountId = "2114030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100140", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "593"};
        public static readonly Materia ManufactedNethicite = new Materia { Name = "Manufacted Nethicite", MateriaId = "504209500", Description = "人造破魔石", CountId = "2295020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209500", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000015", BitNumber = "594"};
        public static readonly Materia EarthResistance_504209550 = new Materia { Name = "Earth Resistance +15%", MateriaId = "504209550", Description = "土属性耐性+15%", CountId = "2153620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209550", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000012", BitNumber = "595"};
        public static readonly Materia PureHeart = new Materia { Name = "Pure Heart", MateriaId = "1500000004", Description = "ピュアハート", CountId = "90004", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910045", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90004"};
        public static readonly Materia WinterWard = new Materia { Name = "Winter Ward", MateriaId = "1500000005", Description = "防寒対策", CountId = "90005", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910057", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000005", BitNumber = "90005"};
        public static readonly Materia Deliverance = new Materia { Name = "Deliverance", MateriaId = "1500000007", Description = "引渡し", CountId = "90006", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910066", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90006"};
        public static readonly Materia FirewallPower = new Materia { Name = "Firewall: Power↑", MateriaId = "1500000008", Description = "ＨＳ威力増大", CountId = "90007", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910067", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90007"};
        public static readonly Materia SymphonicFlair = new Materia { Name = "Symphonic Flair", MateriaId = "504212570", Description = "シンフォニックフレア", CountId = "90008", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910096", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90008"};
        public static readonly Materia LightspeedJab = new Materia { Name = "Lightspeed Jab", MateriaId = "1500000009", Description = "光速ジャブ", CountId = "90009", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101470,910133", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90009"};
        public static readonly Materia Cheerleader = new Materia { Name = "Cheerleader", MateriaId = "1500000010", Description = "チアリーダー", CountId = "90010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200450,910134", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90010"};
        public static readonly Materia ElvenPride = new Materia { Name = "Elven Pride", MateriaId = "504209690", Description = "エルフの誇り", CountId = "2132180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209690", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "596"};
        public static readonly Materia PoisonResistance = new Materia { Name = "Poison Resistance", MateriaId = "504209940", Description = "毒無効", CountId = "2154010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209940", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "597"};
        public static readonly Materia ProudFencer = new Materia { Name = "Proud Fencer", MateriaId = "504210110", Description = "誇り高き剣豪", CountId = "2131530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210110", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "598"};
        public static readonly Materia HeavensGuidance = new Materia { Name = "Heaven's Guidance", MateriaId = "504210490", Description = "星天の導き", CountId = "2295030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210490", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000043", BitNumber = "599"};
        public static readonly Materia March = new Materia { Name = "March", MateriaId = "504210640", Description = "進軍", CountId = "2132070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210640", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "600"};
        public static readonly Materia Vigilance = new Materia { Name = "Vigilance", MateriaId = "504210650", Description = "警戒", CountId = "2132080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210650", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "601"};
        public static readonly Materia SPR_504100170 = new Materia { Name = "SPR +20%", MateriaId = "504100170", Description = "精神+20%", CountId = "2116030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "602"};
        public static readonly Materia WindResistance_504210660 = new Materia { Name = "Wind Resistance +15%", MateriaId = "504210660", Description = "風属性耐性+15%", CountId = "2153520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210680", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000007", BitNumber = "603"};
        public static readonly Materia FalseSaint = new Materia { Name = "False Saint", MateriaId = "504210670", Description = "偽りの聖者", CountId = "2132110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210690", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "604"};
        public static readonly Materia SwornSixsPrideDark = new Materia { Name = "Sworn Six's Pride - Dark", MateriaId = "504210720", Description = "六盟傑の誇り・闇", CountId = "2151340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210720", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "605"};
        public static readonly Materia SwornSixsPrideFire = new Materia { Name = "Sworn Six's Pride - Fire", MateriaId = "504210800", Description = "六盟傑の誇り・火", CountId = "2151350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210800", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "606"};
        public static readonly Materia SwornSixsPrideEarth = new Materia { Name = "Sworn Six's Pride - Earth", MateriaId = "504210890", Description = "六盟傑の誇り・土", CountId = "2151430", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210890", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "607"};
        public static readonly Materia ConfusionResistance = new Materia { Name = "Confusion Resistance", MateriaId = "504211100", Description = "混乱無効", CountId = "2154060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211100", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "608"};
        public static readonly Materia MogSearch = new Materia { Name = "Mog Search", MateriaId = "504211120", Description = "モグサーチ", CountId = "2299010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211120", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000002", BitNumber = "609"};
        public static readonly Materia MogSong = new Materia { Name = "Mog Song", MateriaId = "504211130", Description = "モグソング", CountId = "2280001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211130", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000100", BitNumber = "610"};
        public static readonly Materia MogStep = new Materia { Name = "Mog Step", MateriaId = "504211140", Description = "モグステップ", CountId = "2285001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211140", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000050", BitNumber = "611"};
        public static readonly Materia MogResist = new Materia { Name = "Mog Resist", MateriaId = "504211150", Description = "モグレジスト", CountId = "2154901", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211150", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "612"};
        public static readonly Materia MogRise = new Materia { Name = "Mog Rise", MateriaId = "504211160", Description = "モグライズ", CountId = "2131510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211160", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "613"};
        public static readonly Materia MartialArtsMastery = new Materia { Name = "Martial Arts Mastery", MateriaId = "504211340", Description = "格闘の極意", CountId = "2151360", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211340", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "614"};
        public static readonly Materia WorldDestroyer = new Materia { Name = "World Destroyer", MateriaId = "504211350", Description = "世界崩壊", CountId = "2219410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "615"};
        public static readonly Materia MogWisdom = new Materia { Name = "Mog Wisdom", MateriaId = "504211290", Description = "モグの心得", CountId = "2173030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211290", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000078", BitNumber = "616"};
        public static readonly Materia HeartofFire = new Materia { Name = "Heart of Fire", MateriaId = "504211680", Description = "火のこころ", CountId = "2131200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211680", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000006", BitNumber = "617"};
        public static readonly Materia HeartofWater = new Materia { Name = "Heart of Water", MateriaId = "504211690", Description = "水のこころ", CountId = "2131210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "618"};
        public static readonly Materia HeartofWind = new Materia { Name = "Heart of Wind", MateriaId = "504211700", Description = "風のこころ", CountId = "2131220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211700", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000007", BitNumber = "619"};
        public static readonly Materia HeartofEarth = new Materia { Name = "Heart of Earth", MateriaId = "504211710", Description = "土のこころ", CountId = "2131230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211710", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000012", BitNumber = "620"};
        public static readonly Materia SwornSixsPrideLight = new Materia { Name = "Sworn Six's Pride - Light", MateriaId = "504212360", Description = "六盟傑の誇り・光", CountId = "2131540", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "621"};
        public static readonly Materia SwornSixsPrideWind = new Materia { Name = "Sworn Six's Pride - Wind", MateriaId = "504212370", Description = "六盟傑の誇り・風", CountId = "2151620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "622"};
        public static readonly Materia SwornSixsPrideWater = new Materia { Name = "Sworn Six's Pride - Water", MateriaId = "504212380", Description = "六盟傑の誇り・水", CountId = "2151630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "623"};
        public static readonly Materia SleepResistance = new Materia { Name = "Sleep Resistance", MateriaId = "504212340", Description = "睡眠無効", CountId = "2154070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212340", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "624"};
        public static readonly Materia WaterResistance_504212350 = new Materia { Name = "Water Resistance +15%", MateriaId = "504212350", Description = "水属性耐性+15%", CountId = "2153530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212350", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000013", BitNumber = "625"};
        public static readonly Materia Relax = new Materia { Name = "Relax", MateriaId = "504213210", Description = "休息", CountId = "2172030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213210", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "626"};
        public static readonly Materia EvasivenessSmall = new Materia { Name = "Evasiveness - Small", MateriaId = "504213220", Description = "回避性能【小】", CountId = "2177060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213220", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000097", BitNumber = "627"};
        public static readonly Materia GreatEarplugs = new Materia { Name = "Great Earplugs", MateriaId = "504213230", Description = "高級耳栓", CountId = "2116040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213230", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000014", BitNumber = "628"};
        public static readonly Materia GuardoftheFuture = new Materia { Name = "Guard of the Future", MateriaId = "504213420", Description = "未来を守る力", CountId = "2113060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213420", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "629"};
        public static readonly Materia ThirstforSurvival = new Materia { Name = "Thirst for Survival", MateriaId = "504213530", Description = "生存への渇望", CountId = "2131550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213530", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "630"};
        public static readonly Materia LightningResistance_504213700 = new Materia { Name = "Lightning Resistance +15%", MateriaId = "504213700", Description = "雷属性耐性+15%", CountId = "2153540", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213700", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000008", BitNumber = "631"};
        public static readonly Materia DarknesssFoe = new Materia { Name = "Darkness's Foe", MateriaId = "504213710", Description = "闇に抗う力", CountId = "2131240", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213710", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000098", BitNumber = "632"};
        public static readonly Materia LightsFoe = new Materia { Name = "Light's Foe", MateriaId = "504213720", Description = "光に抗う力", CountId = "2131250", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213720", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000099", BitNumber = "633"};
        public static readonly Materia MPStroll = new Materia { Name = "MP Stroll", MateriaId = "504213730", Description = "歩くとMP回復", CountId = "2179120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101420", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000090", BitNumber = "634"};
        public static readonly Materia GeneralOffensive = new Materia { Name = "General Offensive", MateriaId = "504213740", Description = "総攻撃", CountId = "2133810", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213740", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "635"};
        public static readonly Materia MAG_504100110 = new Materia { Name = "MAG +20%", MateriaId = "504100110", Description = "魔力+20%", CountId = "2115030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100110", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "636"};
        public static readonly Materia EquipInstrument = new Materia { Name = "Equip Instrument", MateriaId = "504100860", Description = "楽器装備", CountId = "2155110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100860", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "637"};
        public static readonly Materia Darkra = new Materia { Name = "Darkra", MateriaId = "504020460", Description = "ダーラ", CountId = "1250820", EquipmentActiveAbility = "20460", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000026", BitNumber = "638"};
        public static readonly Materia FiraBlade = new Materia { Name = "Fira Blade", MateriaId = "504200610", Description = "ファイラ剣", CountId = "2240020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200610", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000021", BitNumber = "639"};
        public static readonly Materia AwesomeSwordsman = new Materia { Name = "Awesome Swordsman", MateriaId = "504213800", Description = "凛々しき剣士", CountId = "2151710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213800", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "640"};
        public static readonly Materia PureWhiteBlessing = new Materia { Name = "Pure White Blessing", MateriaId = "504214350", Description = "純白の祝福", CountId = "2171980", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "641"};
        public static readonly Materia HighSpirits = new Materia { Name = "High Spirits", MateriaId = "504214360", Description = "気炎万丈", CountId = "2133820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214360", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "642"};
        public static readonly Materia NA = new Materia { Name = "N/A", MateriaId = "504214720", Description = "アルタメノスの光", CountId = "2151720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214720", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "643"};
        public static readonly Materia DragonKiller_504211360 = new Materia { Name = "Dragon Killer+", MateriaId = "504211360", Description = "ドラゴンキラー改", CountId = "2152310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211360", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "645"};
        public static readonly Materia MagesResolution = new Materia { Name = "Mage's Resolution", MateriaId = "504214930", Description = "魔道士の覚悟", CountId = "2151731", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "646"};
        public static readonly Materia BusterStyle = new Materia { Name = "Buster Style", MateriaId = "504214990", Description = "バスターフォーム", CountId = "2171030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214990", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "647"};
        public static readonly Materia IceResistance_504215180 = new Materia { Name = "Ice Resistance +15%", MateriaId = "504215180", Description = "氷属性耐性+15%", CountId = "2153550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215180", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000010", BitNumber = "648"};
        public static readonly Materia Powerful = new Materia { Name = "Powerful", MateriaId = "504215190", Description = "パワフル", CountId = "2132200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215190", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "649"};
        public static readonly Materia Toughness = new Materia { Name = "Toughness", MateriaId = "504215200", Description = "タフネス", CountId = "2111120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215200", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "650"};
        public static readonly Materia ProofofTalent = new Materia { Name = "Proof of Talent", MateriaId = "504215360", Description = "才媛の証明", CountId = "2135320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215360", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000068", BitNumber = "651"};
        public static readonly Materia BlindResistance = new Materia { Name = "Blind Resistance", MateriaId = "504215440", Description = "暗闇無効", CountId = "2154080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215440", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "652"};
        public static readonly Materia Encore = new Materia { Name = "Encore", MateriaId = "1500000011", Description = "アンコール", CountId = "90011", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910142,101700,100010", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90011"};
        public static readonly Materia EchidnasKiss = new Materia { Name = "Echidna's Kiss", MateriaId = "1500000012", Description = "エキドナのキス", CountId = "90012", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100120", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "1500000012", BitNumber = "90012"};
        public static readonly Materia Renewal = new Materia { Name = "Renewal", MateriaId = "1500000014", Description = "リニューアル", CountId = "90014", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100740", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "90014"};
        public static readonly Materia SpiritofFreedom = new Materia { Name = "Spirit of Freedom", MateriaId = "504216990", Description = "不羈への気焔", CountId = "2133330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216990", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "665"};
        public static readonly Materia SagesPrajna = new Materia { Name = "Sage's Prajna", MateriaId = "504217040", Description = "賢人の智慧", CountId = "2111130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217040", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "666"};
        public static readonly Materia Adventurer = new Materia { Name = "Adventurer", MateriaId = "1500000013", Description = "探検者", CountId = "90013", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910230", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90013"};
        public static readonly Materia AdventurerII = new Materia { Name = "Adventurer II", MateriaId = "1500000015", Description = "探検者 +1", CountId = "90015", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910231", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90015"};
        public static readonly Materia AdventurerIII = new Materia { Name = "Adventurer III", MateriaId = "1500000016", Description = "探検者 +2", CountId = "90016", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910232", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90016"};
        public static readonly Materia AdventurerIV = new Materia { Name = "Adventurer IV", MateriaId = "1500000017", Description = "探検者 +3", CountId = "90017", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910233", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90017"};
        public static readonly Materia AdventurerV = new Materia { Name = "Adventurer V", MateriaId = "1500000018", Description = "探検者 +4", CountId = "90018", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910234", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90018"};
        public static readonly Materia AeroraBlade = new Materia { Name = "Aerora Blade", MateriaId = "504200650", Description = "エアロラ剣", CountId = "2240420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200650", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000025", BitNumber = "688"};
        public static readonly Materia DreamMaidensOracle = new Materia { Name = "Dream Maiden's Oracle", MateriaId = "504215930", Description = "夢巫女の託宣", CountId = "2151440", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "653"};
        public static readonly Materia CrazyDay = new Materia { Name = "Crazy Day", MateriaId = "504216050", Description = "ルナティックサバト", CountId = "2212570", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216050", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "654"};
        public static readonly Materia StaffMastery = new Materia { Name = "Staff Mastery", MateriaId = "504216060", Description = "杖の極意", CountId = "2151370", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216060", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "655"};
        public static readonly Materia BlizzaraBlade = new Materia { Name = "Blizzara Blade", MateriaId = "504200620", Description = "ブリザラ剣", CountId = "2240120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200620", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000022", BitNumber = "656"};
        public static readonly Materia HPStroll = new Materia { Name = "HP Stroll", MateriaId = "504101410", Description = "歩くとHP回復", CountId = "2179130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101410", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000073", BitNumber = "657"};
        public static readonly Materia LoyalWarrior = new Materia { Name = "Loyal Warrior", MateriaId = "504216360", Description = "忠義の武人", CountId = "2133320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216360", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "658"};
        public static readonly Materia ColdDefense = new Materia { Name = "Cold Defense", MateriaId = "504216370", Description = "コールドディフェンド", CountId = "2131260", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216370", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000010", BitNumber = "659"};
        public static readonly Materia ThunderDefense = new Materia { Name = "Thunder Defense", MateriaId = "504216380", Description = "サンダーディフェンド", CountId = "2131270", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216380", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000008", BitNumber = "660"};
        public static readonly Materia FireResistance_504216400 = new Materia { Name = "Fire Resistance +15%", MateriaId = "504216400", Description = "火属性耐性+15%", CountId = "2153560", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216400", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000006", BitNumber = "661"};
        public static readonly Materia DragoonsPride = new Materia { Name = "Dragoon's Pride", MateriaId = "504216520", Description = "竜騎士の誇り", CountId = "2151380", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216520", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "662"};
        public static readonly Materia BarrierMaster = new Materia { Name = "Barrier Master", MateriaId = "504216730", Description = "魔壁の操者", CountId = "2134330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216730", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "663"};
        public static readonly Materia NullDisease = new Materia { Name = "Null Disease", MateriaId = "504216900", Description = "病気無効", CountId = "2154090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216900", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "664"};
        public static readonly Materia BlackImpulse = new Materia { Name = "Black Impulse", MateriaId = "504217350", Description = "黒き衝動", CountId = "2135330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217350", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "667"};
        public static readonly Materia FrozenHurricane = new Materia { Name = "Frozen Hurricane", MateriaId = "504217610", Description = "フローズンハリケーン", CountId = "2219420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217610", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000022", BitNumber = "668"};
        public static readonly Materia Spirit = new Materia { Name = "Spirit", MateriaId = "504217630", Description = "スピリット", CountId = "2132210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217630", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "669"};
        public static readonly Materia Girder = new Materia { Name = "Girder", MateriaId = "504217640", Description = "ガーダー", CountId = "2131760", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217640", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "670"};
        public static readonly Materia ThundaraBlade = new Materia { Name = "Thundara Blade", MateriaId = "504200630", Description = "サンダラ剣", CountId = "2240130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200630", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000020", BitNumber = "671"};
        public static readonly Materia HatArts = new Materia { Name = "Hat Arts", MateriaId = "504217650", Description = "帽子の秘義", CountId = "2151390", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217650", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "672"};
        public static readonly Materia LightResistance_504216040 = new Materia { Name = "Light Resistance +20%", MateriaId = "504216040", Description = "光属性耐性+20%", CountId = "2153730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216040", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000099", BitNumber = "674"};
        public static readonly Materia PetrificationResistance = new Materia { Name = "Petrification Resistance", MateriaId = "504215170", Description = "石化無効", CountId = "2154100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "675"};
        public static readonly Materia Broadminded = new Materia { Name = "Broadminded", MateriaId = "504217950", Description = "豪放磊落", CountId = "2133340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217950", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "676"};
        public static readonly Materia AzureCrimsonSoul = new Materia { Name = "Azure Crimson Soul", MateriaId = "504218380", Description = "蒼紅の魂", CountId = "2131770", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "677"};
        public static readonly Materia StrategistsIngenuity = new Materia { Name = "Strategist's Ingenuity", MateriaId = "504218390", Description = "軍師の知略", CountId = "2135340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218390", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "678"};
        public static readonly Materia MechanicalHeart = new Materia { Name = "Mechanical Heart", MateriaId = "504218860", Description = "機械仕掛けの心", CountId = "2131780", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218860", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "679"};
        public static readonly Materia VengefulWrath = new Materia { Name = "Vengeful Wrath", MateriaId = "504218870", Description = "憎悪", CountId = "2131790", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218870", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "680"};
        public static readonly Materia YevonsWisdom = new Materia { Name = "Yevon's Wisdom", MateriaId = "504219080", Description = "エボンの教え", CountId = "2111300", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219080", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "681"};
        public static readonly Materia PowerofPurification = new Materia { Name = "Power of Purification", MateriaId = "504219220", Description = "浄化の力", CountId = "2152130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219220", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "682"};
        public static readonly Materia ArtofPurification = new Materia { Name = "Art of Purification", MateriaId = "504219230", Description = "浄化の術", CountId = "2152140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219230", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "683"};
        public static readonly Materia IceResistance_504219240 = new Materia { Name = "Ice Resistance +20%", MateriaId = "504219240", Description = "氷属性耐性+20%", CountId = "2153740", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219240", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000010", BitNumber = "684"};
        public static readonly Materia CradleofHorns = new Materia { Name = "Cradle of Horns", MateriaId = "504219250", Description = "ホーンクレイドル", CountId = "2290000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219250", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "685"};
        public static readonly Materia LShieldArts = new Materia { Name = "L Shield Arts", MateriaId = "504219260", Description = "軽盾の秘義", CountId = "2151400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "686"};
        public static readonly Materia DualWield_504219270 = new Materia { Name = "Dual Wield+", MateriaId = "504219270", Description = "にとうりゅう改", CountId = "2156010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "687"};
        public static readonly Materia UncollapsingWill = new Materia { Name = "Uncollapsing Will", MateriaId = "504219820", Description = "潰えぬ闘志", CountId = "2151410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219820", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "689"};
        public static readonly Materia Hammersmith = new Materia { Name = "Hammersmith", MateriaId = "504219880", Description = "ハンマースミス", CountId = "2151351", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219880", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "690"};
        public static readonly Materia SilenceResistance = new Materia { Name = "Silence Resistance", MateriaId = "504213200", Description = "沈黙無効", CountId = "2154110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213200", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "691"};
        public static readonly Materia SageofMysidia = new Materia { Name = "Sage of Mysidia", MateriaId = "504219890", Description = "ミシディアの賢者", CountId = "2132220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219890", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "692"};
        public static readonly Materia ManEater_504219910 = new Materia { Name = "Man-Eater+", MateriaId = "504219910", Description = "マンイーター改", CountId = "2152320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "693"};
        public static readonly Materia Resentment = new Materia { Name = "Resentment", MateriaId = "1500000020", Description = "Resentment", CountId = "90020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910311", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90020"};
        public static readonly Materia Regenerator = new Materia { Name = "Regenerator", MateriaId = "1500000021", Description = "Regenerator", CountId = "90021", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910313", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000019", BitNumber = "90021"};
        public static readonly Materia ReactiveDefense = new Materia { Name = "Reactive Defense", MateriaId = "1500000022", Description = "Reactive Defense", CountId = "90022", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910314", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000019", BitNumber = "90022"};
        public static readonly Materia MalborosWhisper = new Materia { Name = "Malboro's Whisper", MateriaId = "1500000019", Description = "Malboro's Whisper", CountId = "90019", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910338", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90019"};
        public static readonly Materia RhythmicFlair = new Materia { Name = "Rhythmic Flair", MateriaId = "1500000025", Description = "Rhythmic Flair", CountId = "90025", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910387", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90025"};
        public static readonly Materia Casanova = new Materia { Name = "Casanova", MateriaId = "1500000023", Description = "カサノバ", CountId = "90023", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910388,101500", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90023"};
        public static readonly Materia WaterMaidenBlessing = new Materia { Name = "Water Maiden Blessing", MateriaId = "1500000024", Description = "ウォーターメイデン", CountId = "90024", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910389,208980", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90024"};
        public static readonly Materia CodexofSwordMaster = new Materia { Name = "Codex of Sword Master", MateriaId = "1500000030", Description = "剣の秘伝書", CountId = "90030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910336", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "1500000030", BitNumber = "90030"};
        public static readonly Materia FullMoon = new Materia { Name = "Full Moon", MateriaId = "1500000026", Description = "フルムーン", CountId = "90026", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910391", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1100000096", BitNumber = "90026"};
        public static readonly Materia BlightedDespot = new Materia { Name = "Blighted Despot", MateriaId = "1500000027", Description = "ブライテッドデスポット", CountId = "90027", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910395", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000019", BitNumber = "90027"};
        public static readonly Materia DrownedKing = new Materia { Name = "Drowned King", MateriaId = "1500000028", Description = "ドロウンキング", CountId = "90028", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910396", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000019", BitNumber = "90028"};
        public static readonly Materia LunariansHate = new Materia { Name = "Lunarian's Hate", MateriaId = "1500000029", Description = "つきのたみの憎悪", CountId = "90029", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910397", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90029"};
        public static readonly Materia BarbaricciasSpirit = new Materia { Name = "Barbariccia's Spirit", MateriaId = "1500000031", Description = "バルバリシアの魂", CountId = "90031", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910436", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90031"};
        public static readonly Materia Graviga = new Materia { Name = "Graviga", MateriaId = "504020270", Description = "グラビガ", CountId = "1251020", EquipmentActiveAbility = "20270", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000026", BitNumber = "45"};
        public static readonly Materia TrueShardofGenius = new Materia { Name = "True Shard of Genius", MateriaId = "504218970", Description = "真・叡知の結晶", CountId = "2151640", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218970", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "694"};
        public static readonly Materia TrueFollowersOath = new Materia { Name = "True Follower's Oath", MateriaId = "504218980", Description = "真・盟主への誓い", CountId = "2131181", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218980", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000077", BitNumber = "695"};
        public static readonly Materia TrueHydaelynGuard = new Materia { Name = "True Hydaelyn Guard", MateriaId = "504218990", Description = "真・ハイデリンの加護", CountId = "2153920", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218990", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000018", BitNumber = "696"};
        public static readonly Materia TrueSpiritofFreedom = new Materia { Name = "True Spirit of Freedom", MateriaId = "504219000", Description = "真・不羈への気焔", CountId = "2133350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219000", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "697"};
        public static readonly Materia TrueSagesPrajna = new Materia { Name = "True Sage's Prajna", MateriaId = "504219010", Description = "真・賢人の智慧", CountId = "2111200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219010", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "698"};
        public static readonly Materia Refresh = new Materia { Name = "Refresh", MateriaId = "504010380", Description = "リフレシュ", CountId = "1150060", EquipmentActiveAbility = "10380", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000092", BitNumber = "699"};
        public static readonly Materia KatanaEnchantment = new Materia { Name = "Katana Enchantment", MateriaId = "504219930", Description = "妖刀の知識", CountId = "2151740", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000053", BitNumber = "700"};
        public static readonly Materia HeavyChimera = new Materia { Name = "Heavy Chimera", MateriaId = "504219940", Description = "ヘヴィキマイラ", CountId = "2151750", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219940", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "701"};
        public static readonly Materia AntiDisaster = new Materia { Name = "Anti-Disaster", MateriaId = "504219950", Description = "アンチディスアスター", CountId = "2154120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219950", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000014", BitNumber = "702"};
        public static readonly Materia Battler = new Materia { Name = "Battler", MateriaId = "504220140", Description = "バトルドランカー", CountId = "2111310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220140", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "703"};
        public static readonly Materia BeastsHeart = new Materia { Name = "Beast's Heart", MateriaId = "504220280", Description = "獣人の心", CountId = "2151760", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220280", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "704"};
        public static readonly Materia HalfelfsHeart = new Materia { Name = "Half-elf's Heart", MateriaId = "504220290", Description = "ハーフエルフの心", CountId = "2131810", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220290", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "705"};
        public static readonly Materia KnightofGemma = new Materia { Name = "Knight of Gemma", MateriaId = "504220270", Description = "ジェマの騎士", CountId = "2131820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "706"};
        public static readonly Materia Brawn = new Materia { Name = "Brawn", MateriaId = "504220620", Description = "屈強", CountId = "2131830", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220620", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "707"};
        public static readonly Materia Intrique = new Materia { Name = "Intrique", MateriaId = "504220630", Description = "術策", CountId = "2131840", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220630", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "708"};
        public static readonly Materia HP_504100020 = new Materia { Name = "HP +20%", MateriaId = "504100020", Description = "HP+20%", CountId = "2111030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100020", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "709"};
        public static readonly Materia WindResistance_504220650 = new Materia { Name = "Wind Resistance +20%", MateriaId = "504220650", Description = "風属性耐性+20%", CountId = "2153750", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220650", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000007", BitNumber = "710"};
        public static readonly Materia GreatMagesChant = new Materia { Name = "Great Mage's Chant", MateriaId = "504220660", Description = "大魔道士の詠唱法", CountId = "2131850", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220660", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "711"};
        public static readonly Materia NatureLovingSpellblade = new Materia { Name = "Nature Loving Spellblade", MateriaId = "504220680", Description = "自然を愛する魔法剣士", CountId = "2151352", EquipmentActiveAbility = "", EquipmentPassiveAbility = "220680", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "712"};
        public static readonly Materia MoodMaker = new Materia { Name = "Mood Maker", MateriaId = "504221550", Description = "ムードメーカー", CountId = "2111400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221550", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "713"};
        public static readonly Materia HArmorArts = new Materia { Name = "H Armor Arts", MateriaId = "504221560", Description = "重鎧の秘義", CountId = "2151140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221560", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "714"};
        public static readonly Materia CalamityBorder = new Materia { Name = "Calamity Border", MateriaId = "504221570", Description = "カラミティボーダー", CountId = "2290001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221570", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "715"};
        public static readonly Materia CallousStrategist = new Materia { Name = "Callous Strategist", MateriaId = "504221580", Description = "非情なる策謀家", CountId = "2111340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221600", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "716"};
        public static readonly Materia ImperialTalent = new Materia { Name = "Imperial Talent", MateriaId = "504221590", Description = "賢帝の素養", CountId = "2116100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221610", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "717"};
        public static readonly Materia SpiritFighter = new Materia { Name = "Spirit Fighter", MateriaId = "504221600", Description = "スピリットファイター", CountId = "2152150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221580", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "718"};
        public static readonly Materia SpiritMagician = new Materia { Name = "Spirit Magician", MateriaId = "504221610", Description = "スピリットマジシャン", CountId = "2152160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "221590", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "719"};
        public static readonly Materia AutoBravery = new Materia { Name = "Auto-Bravery", MateriaId = "504221620", Description = "オートブレイブ", CountId = "2174310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202510", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "720"};
        public static readonly Materia AutoFaith = new Materia { Name = "Auto-Faith", MateriaId = "504221630", Description = "オートフェイス", CountId = "2174410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217620", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "721"};
        public static readonly Materia EarthResistance_504221640 = new Materia { Name = "Earth Resistance +20%", MateriaId = "504221640", Description = "土属性耐性+20%", CountId = "2153940", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222220", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000012", BitNumber = "722"};
        public static readonly Materia ChosenOne = new Materia { Name = "Chosen One", MateriaId = "504222860", Description = "選ばれし者", CountId = "2151130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222860", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "723"};
        public static readonly Materia ShadowBearer = new Materia { Name = "Shadow Bearer", MateriaId = "504222870", Description = "影の担い手", CountId = "2151300", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222870", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "724"};
        public static readonly Materia AgnsCrystalguardCaptain = new Materia { Name = "Agnès' Crystalguard Captain", MateriaId = "504221650", Description = "アニエス様たすけ隊隊長", CountId = "2131860", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222760", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "726"};
        public static readonly Materia FragmentofThought = new Materia { Name = "Fragment of Thought", MateriaId = "504221660", Description = "想いの欠片", CountId = "2135350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222780", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "727"};
        public static readonly Materia EquipHelm = new Materia { Name = "Equip Helm", MateriaId = "504221670", Description = "兜装備", CountId = "2155580", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223360", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "725"};
        public static readonly Materia PurebredSummoner = new Materia { Name = "Pure-bred Summoner", MateriaId = "504221680", Description = "純血の召喚士", CountId = "2132221", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223670", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "728"};
        public static readonly Materia MonksEnlightenment = new Materia { Name = "Monk's Enlightenment", MateriaId = "504221690", Description = "モンクの悟り", CountId = "2151770", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223680", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "729"};
        public static readonly Materia AttackCastleWarfare = new Materia { Name = "Attack - Castle Warfare", MateriaId = "504221700", Description = "攻・城内戦の知識", CountId = "2152170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223710", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "730"};
        public static readonly Materia MagicCastleWarfare = new Materia { Name = "Magic - Castle Warfare", MateriaId = "504221710", Description = "魔・城内戦の知識", CountId = "2152180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223720", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "731"};
        public static readonly Materia MentalClarity = new Materia { Name = "Mental Clarity", MateriaId = "504221720", Description = "カームメンタル", CountId = "2133360", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223730", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "732"};
        public static readonly Materia LionsAwakening = new Materia { Name = "Lion's Awakening", MateriaId = "504221730", Description = "ししのめざめ", CountId = "2135360", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223740", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000068", BitNumber = "733"};
        public static readonly Materia Sleep_504221740 = new Materia { Name = "Sleep", MateriaId = "504221740", Description = "ねむりにつく", CountId = "2172040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223750", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000004", BitNumber = "734"};
        public static readonly Materia DarkResistance_504223800 = new Materia { Name = "Dark Resistance +20%", MateriaId = "504223800", Description = "闇属性耐性+20%", CountId = "2153821", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223800", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000098", BitNumber = "735"};
        public static readonly Materia Raise = new Materia { Name = "Raise", MateriaId = "504010100", Description = "レイズ", CountId = "1150070", EquipmentActiveAbility = "10100", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000001", BitNumber = "736"};
        public static readonly Materia DualWhiteMagic = new Materia { Name = "Dual White Magic", MateriaId = "504213980", Description = "W白魔法", CountId = "2295000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213980", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000005", BitNumber = "737"};
        public static readonly Materia EVOMAG_504223810 = new Materia { Name = "EVO MAG +15%", MateriaId = "504223810", Description = "召喚魔法+15%", CountId = "2117011", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223810", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "738"};
        public static readonly Materia Kappower = new Materia { Name = "Kappower", MateriaId = "504223820", Description = "カッパワー", CountId = "2296000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "223820", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000013", BitNumber = "739"};
        public static readonly Materia AxeProfessional = new Materia { Name = "Axe Professional", MateriaId = "504224170", Description = "プロフェッショナル・斧", CountId = "2151391", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224170", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "740"};
        public static readonly Materia HungryWolf = new Materia { Name = "Hungry Wolf", MateriaId = "504224190", Description = "餓狼再起", CountId = "2154130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224190", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000014", BitNumber = "741"};
        public static readonly Materia Quintessence = new Materia { Name = "Quintessence", MateriaId = "504224490", Description = "クインテッセンス", CountId = "2151711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "742"};
        public static readonly Materia BarrierMagesOath = new Materia { Name = "Barrier Mage's Oath", MateriaId = "504224840", Description = "壁魔道士の誓い", CountId = "2116110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224840", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "743"};
        public static readonly Materia ThunderousAvoidance = new Materia { Name = "Thunderous Avoidance", MateriaId = "504224860", Description = "避雷の希求", CountId = "2111100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224860", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000008", BitNumber = "744"};
        public static readonly Materia NebulousAvoidance = new Materia { Name = "Nebulous Avoidance", MateriaId = "504224870", Description = "破闇の希求", CountId = "2111110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224870", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000098", BitNumber = "745"};
        public static readonly Materia BombSpirit = new Materia { Name = "Bomb Spirit", MateriaId = "504224900", Description = "ボム魂", CountId = "2173040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224900", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000006", BitNumber = "746"};
        public static readonly Materia BombArms = new Materia { Name = "Bomb Arms", MateriaId = "504224910", Description = "ボムアームズ", CountId = "2293000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224910", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000021", BitNumber = "747"};
        public static readonly Materia FireResistance_504213160 = new Materia { Name = "Fire Resistance +20%", MateriaId = "504213160", Description = "火属性耐性+20%", CountId = "2153561", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213160", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000006", BitNumber = "748"};
        public static readonly Materia EquipSword = new Materia { Name = "Equip Sword", MateriaId = "504224920", Description = "剣装備", CountId = "2155020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224920", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "749"};
        public static readonly Materia ModishWitch = new Materia { Name = "Modish Witch", MateriaId = "504224930", Description = "モディッシュ・ウィッチ", CountId = "2151732", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "750"};
        public static readonly Materia Necropolis = new Materia { Name = "Necropolis", MateriaId = "504225930", Description = "ネクロポリス", CountId = "2152220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "225930", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "751"};
        public static readonly Materia SeedofHope = new Materia { Name = "Seed of Hope", MateriaId = "504225720", Description = "フォーチュンベイビー", CountId = "2154140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "225720", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000097", BitNumber = "752"};
        public static readonly Materia FortitudeandVigor = new Materia { Name = "Fortitude and Vigor", MateriaId = "504225890", Description = "質実剛健", CountId = "2133370", EquipmentActiveAbility = "", EquipmentPassiveAbility = "225890", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "753"};
        public static readonly Materia WaterResistance_504213170 = new Materia { Name = "Water Resistance +20%", MateriaId = "504213170", Description = "水属性耐性+20%", CountId = "2153533", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000013", BitNumber = "754"};
        public static readonly Materia MagesHope = new Materia { Name = "Mage's Hope", MateriaId = "504226050", Description = "魔道士の願い", CountId = "2135111", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226050", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "756"};
        public static readonly Materia KnightsHope = new Materia { Name = "Knight's Hope", MateriaId = "504226041", Description = "騎士の願い", CountId = "2133111", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226040", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "760"};
        public static readonly Materia RulingFiend = new Materia { Name = "Ruling Fiend", MateriaId = "504226031", Description = "裁定する悪魔", CountId = "2134340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226030", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "761"};
        public static readonly Materia HerosVowDark = new Materia { Name = "Hero's Vow - Dark", MateriaId = "504226380", Description = "英雄の誓い・闇", CountId = "2151521", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "762"};
        public static readonly Materia CheerfulTune = new Materia { Name = "Cheerful Tune", MateriaId = "1500000032", Description = "チアフルチューン", CountId = "90032", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910569", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90032"};
        public static readonly Materia InstrumentalFlair = new Materia { Name = "Instrumental Flair", MateriaId = "1500000033", Description = "インストゥルメンタルフレア", CountId = "90033", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910568", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90033"};
        public static readonly Materia MagicSanctuary = new Materia { Name = "Magic Sanctuary", MateriaId = "1500000034", Description = "Magic Sanctuary", CountId = "90034", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910606", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "90034"};
        public static readonly Materia JoyfulSpirit = new Materia { Name = "Joyful Spirit", MateriaId = "1500000035", Description = "Joyful Spirit", CountId = "90035", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910775", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000035", BitNumber = "90035"};
        public static readonly Materia TurbulentEvasion = new Materia { Name = "Turbulent Evasion", MateriaId = "1500000036", Description = "Turbulent Evasion", CountId = "90036", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910734", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90036"};
        public static readonly Materia CoweredCourage = new Materia { Name = "Cowered Courage", MateriaId = "1500000037", Description = "Cowered Courage", CountId = "90037", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910749,910750", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90037"};
        public static readonly Materia UnmatchedWizardry = new Materia { Name = "Unmatched Wizardry", MateriaId = "1500000038", Description = "Unmatched Wizardry", CountId = "90038", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910762", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90038"};
        public static readonly Materia WhiteKnightsSoul = new Materia { Name = "White Knight's Soul", MateriaId = "1500000039", Description = "White Knight's Soul", CountId = "90039", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910726", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90039"};
        public static readonly Materia TombRaider = new Materia { Name = "Tomb Raider", MateriaId = "1500000040", Description = "Tomb Raider", CountId = "90040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910781", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90040"};
        public static readonly Materia PoweroftheSands = new Materia { Name = "Power of the Sands", MateriaId = "1500000041", Description = "Power of the Sands", CountId = "90041", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910929,910967", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90041"};
        public static readonly Materia CroftsIntuition = new Materia { Name = "Croft's Intuition", MateriaId = "1500000043", Description = "Croft's Intuition", CountId = "90043", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910968,910948", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90043"};
        public static readonly Materia OffensiveDefense = new Materia { Name = "Offensive Defense", MateriaId = "1500000044", Description = "Offensive Defense", CountId = "90044", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910980", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90044"};
        public static readonly Materia SpiritualWrath = new Materia { Name = "Spiritual Wrath", MateriaId = "1500000042", Description = "Spiritual Wrath", CountId = "90042", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910979", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90042"};
        public static readonly Materia MagicalOffensive = new Materia { Name = "Magical Offensive", MateriaId = "1500000046", Description = "Magical Offensive", CountId = "90046", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910981", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90046"};
        public static readonly Materia DemonBanisher = new Materia { Name = "Demon Banisher", MateriaId = "1500000047", Description = "Demon Banisher", CountId = "90047", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910982", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "90047"};
        public static readonly Materia NagasProtection = new Materia { Name = "Naga's Protection", MateriaId = "1500000048", Description = "Naga's Protection", CountId = "90048", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910983", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90048"};
        public static readonly Materia IntenseDetermination = new Materia { Name = "Intense Determination", MateriaId = "1500000049", Description = "Intense Determination", CountId = "90049", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911018", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90049"};
        public static readonly Materia MotherlyLove = new Materia { Name = "Motherly Love", MateriaId = "1500000050", Description = "Motherly Love", CountId = "90050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911019", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90050"};
        public static readonly Materia VagrantKnight = new Materia { Name = "Vagrant Knight", MateriaId = "504226406", Description = "彷徨の騎士", CountId = "2131870", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226406", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "763"};
        public static readonly Materia ProtectorofLapis = new Materia { Name = "Protector of Lapis", MateriaId = "504226422", Description = "ラピスを守りし者", CountId = "2131880", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226422", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "764"};
        public static readonly Materia TheSubservient = new Materia { Name = "The Subservient", MateriaId = "504226880", Description = "利用される者", CountId = "2133380", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226880", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "765"};
        public static readonly Materia DarkSwordArts = new Materia { Name = "Dark Sword Arts", MateriaId = "504226881", Description = "暗黒の剣技", CountId = "2171015", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226881", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "766"};
        public static readonly Materia OriginalArrival = new Materia { Name = "Original Arrival", MateriaId = "504226882", Description = "アライバルオリジン", CountId = "2151790", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226882", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000018", BitNumber = "767"};
        public static readonly Materia DreamoftheFayth = new Materia { Name = "Dream of the Fayth", MateriaId = "504226883", Description = "祈り子の夢", CountId = "2151800", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226883", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "768"};
        public static readonly Materia CorruptEmperor = new Materia { Name = "Corrupt Emperor", MateriaId = "504226892", Description = "背徳の皇帝", CountId = "2131890", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226892", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "769"};
        public static readonly Materia OnionKnightsMission = new Materia { Name = "Onion Knight's Mission", MateriaId = "504226893", Description = "たまねぎの使命", CountId = "2152600", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226893", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "770"};
        public static readonly Materia PanzerOmega = new Materia { Name = "Panzer Omega", MateriaId = "504226894", Description = "パンツァーオメガ", CountId = "2134711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226894", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "771"};
        public static readonly Materia WaveCannon = new Materia { Name = "Wave Cannon", MateriaId = "504226895", Description = "はどうほう", CountId = "2219120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226895", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000105", BitNumber = "772"};
        public static readonly Materia LightningResistance_504226896 = new Materia { Name = "Lightning Resistance +20%", MateriaId = "504226896", Description = "雷属性耐性+20%", CountId = "2153541", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226896", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000008", BitNumber = "773"};
        public static readonly Materia PhysicalForce = new Materia { Name = "Physical Force", MateriaId = "504226898", Description = "フィジカルフォース", CountId = "2131141", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226898", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "774"};
        public static readonly Materia MagicalForce = new Materia { Name = "Magical Force", MateriaId = "504226899", Description = "マジカルフォース", CountId = "2132101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226899", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "775"};
        public static readonly Materia SwiftHunter = new Materia { Name = "Swift Hunter", MateriaId = "504226900", Description = "神速の狩人", CountId = "2171031", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226900", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "776"};
        public static readonly Materia WhipMastery = new Materia { Name = "Whip Mastery", MateriaId = "504226901", Description = "鞭の極意", CountId = "2151371", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226901", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "777"};
        public static readonly Materia BraveLancer = new Materia { Name = "Brave Lancer", MateriaId = "504226902", Description = "ブレイブランサー", CountId = "2151381", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226902", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "778"};
        public static readonly Materia TwinRepellent = new Materia { Name = "Twin Repellent", MateriaId = "504226903", Description = "剣魔双麗", CountId = "2152230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226903", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "779"};
        public static readonly Materia TheLordoftheUnderworld = new Materia { Name = "The Lord of the Underworld", MateriaId = "504226980", Description = "地獄の帝王", CountId = "2151210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226980", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "780"};
        public static readonly Materia TheKingofBeasts = new Materia { Name = "The King of Beasts", MateriaId = "504227020", Description = "獣族の王", CountId = "2152240", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227020", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "781"};
        public static readonly Materia DevilishDesigns = new Materia { Name = "Devilish Designs", MateriaId = "504227076", Description = "小悪魔のたくらみ", CountId = "2132230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227076", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000098", BitNumber = "782"};
        public static readonly Materia DevourerofShadows = new Materia { Name = "Devourer of Shadows", MateriaId = "504227237", Description = "デバウアーオブシャドーズ", CountId = "2151522", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227237", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "783"};
        public static readonly Materia ReduceEncounter = new Materia { Name = "Reduce Encounter", MateriaId = "504400110", Description = "エンカウント率減少", CountId = "2179500", EquipmentActiveAbility = "", EquipmentPassiveAbility = "400110", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000071", BitNumber = "784"};
        public static readonly Materia BraveAdventurer = new Materia { Name = "Brave Adventurer", MateriaId = "504227260", Description = "冒険者の勇気", CountId = "2131142", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227260", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "785"};
        public static readonly Materia FaithfulAdventurer = new Materia { Name = "Faithful Adventurer", MateriaId = "504227261", Description = "冒険者の信念", CountId = "2132102", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227261", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "786"};
        public static readonly Materia PlantKiller_504222190 = new Materia { Name = "Plant Killer+", MateriaId = "504222190", Description = "プラントキラー改", CountId = "2152330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "222190", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "787"};
        public static readonly Materia EquipRobe = new Materia { Name = "Equip Robe", MateriaId = "504100770", Description = "ローブ装備", CountId = "2155590", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100770", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "793"};
        public static readonly Materia WitchsCackle = new Materia { Name = "Witch's Cackle", MateriaId = "504227209", Description = "魔女の高笑い", CountId = "2151540", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227209", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000091", BitNumber = "796"};
        public static readonly Materia ForceMysterion = new Materia { Name = "Force Mysterion", MateriaId = "504227270", Description = "フォスミステリオン", CountId = "2152250", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227270", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "788"};
        public static readonly Materia DarkAspirations = new Materia { Name = "Dark Aspirations", MateriaId = "504227271", Description = "黒き野望", CountId = "2174420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227271", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "789"};
        public static readonly Materia HexatheonsRevelation = new Materia { Name = "Hexatheon's Revelation", MateriaId = "504227272", Description = "六神の啓示", CountId = "2131900", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227272", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "790"};
        public static readonly Materia LoyalGeneral = new Materia { Name = "Loyal General", MateriaId = "504227273", Description = "忠義の女将軍", CountId = "2151810", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227273", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "791"};
        public static readonly Materia EssenceofSummoning = new Materia { Name = "Essence of Summoning", MateriaId = "504227274", Description = "召喚の真髄", CountId = "2131910", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227274", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "792"};
        public static readonly Materia ALionsHeart = new Materia { Name = "A Lion's Heart", MateriaId = "504226639", Description = "獅子の心(FFVIII)", CountId = "2173005", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226639", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000091", BitNumber = "794"};
        public static readonly Materia WingedHeart = new Materia { Name = "Winged Heart", MateriaId = "504226653", Description = "ウィングハート", CountId = "2153990", EquipmentActiveAbility = "", EquipmentPassiveAbility = "226653", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000014", BitNumber = "795"};
        public static readonly Materia DragonofAffection = new Materia { Name = "Dragon of Affection", MateriaId = "504227318", Description = "慈愛の竜賢", CountId = "2135370", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227318", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "797"};
        public static readonly Materia WhiteHeart = new Materia { Name = "White Heart", MateriaId = "504227328", Description = "ホワイトハート", CountId = "2131920", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227328", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "798"};
        public static readonly Materia KeepingBacktheDark = new Materia { Name = "Keeping Back the Dark", MateriaId = "504227389", Description = "闇を払う力", CountId = "2133390", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227389", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "799"};
        public static readonly Materia Metamalboro = new Materia { Name = "Metamalboro", MateriaId = "504227410", Description = "メタモルモルボル", CountId = "2134712", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227410", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000068", BitNumber = "800"};
        public static readonly Materia BadBreath = new Materia { Name = "Bad Breath", MateriaId = "504227411", Description = "くさい息", CountId = "2216000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227411", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000009", BitNumber = "801"};
        public static readonly Materia FireproofAspiration = new Materia { Name = "Fireproof Aspiration", MateriaId = "504227413", Description = "耐火の希求", CountId = "2111098", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227413", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000006", BitNumber = "802"};
        public static readonly Materia WaterproofAspiration = new Materia { Name = "Waterproof Aspiration", MateriaId = "504227414", Description = "止水の希求", CountId = "2111101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227414", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "803"};
        public static readonly Materia HolyKnight = new Materia { Name = "Holy Knight", MateriaId = "504227428", Description = "聖剣の騎士", CountId = "2151820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227428", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "804"};
        public static readonly Materia KalivasGuidance = new Materia { Name = "Kaliva's Guidance", MateriaId = "504227448", Description = "カリバの導き", CountId = "2151830", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227448", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "805"};
        public static readonly Materia TechnicalAttacker = new Materia { Name = "Technical Attacker", MateriaId = "504227459", Description = "テクニカルアタッカー", CountId = "2177070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227459", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000075", BitNumber = "806"};
        public static readonly Materia ZodiacShot = new Materia { Name = "Zodiac Shot", MateriaId = "504227506", Description = "ゾディアックバレット", CountId = "2151840", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227506", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "807"};
        public static readonly Materia TruthSeeker = new Materia { Name = "Truth Seeker", MateriaId = "504227527", Description = "真実を探る者", CountId = "2131930", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227527", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "808"};
        public static readonly Materia ShieldoftheChosenKing = new Materia { Name = "Shield of the Chosen King", MateriaId = "504227555", Description = "選ばれし王の盾", CountId = "2131940", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227555", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "809"};
        public static readonly Materia BoosterCactuar = new Materia { Name = "Booster Cactuar", MateriaId = "504227586", Description = "ブースト・サボテン", CountId = "2135380", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227586", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "810"};
        public static readonly Materia PureLotus = new Materia { Name = "Pure Lotus", MateriaId = "504227605", Description = "白妙の聖蓮", CountId = "2172050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227605", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000091", BitNumber = "811"};
        public static readonly Materia Skylancer = new Materia { Name = "Skylancer", MateriaId = "504227625", Description = "スカイランサー", CountId = "2151850", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227625", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "812"};
        public static readonly Materia EXP_504227640 = new Materia { Name = "EXP +25%", MateriaId = "504227640", Description = "獲得経験値+25%", CountId = "2179208", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227640", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000081", BitNumber = "813"};
        public static readonly Materia EXP_504227641 = new Materia { Name = "EXP +50%", MateriaId = "504227641", Description = "獲得経験値+50%", CountId = "2179209", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227641", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000081", BitNumber = "814"};
        public static readonly Materia BraveSoul = new Materia { Name = "Brave Soul", MateriaId = "504227701", Description = "勇者の魂", CountId = "2133400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227701", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "815"};
        public static readonly Materia HerosVowLight = new Materia { Name = "Hero's Vow - Light", MateriaId = "504227666", Description = "英雄の誓い・光", CountId = "2136910", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227666", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "816"};
        public static readonly Materia MachinePower = new Materia { Name = "Machine Power", MateriaId = "504227682", Description = "マシンパワー", CountId = "2133720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227682", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "817"};
        public static readonly Materia FeelingsforPlatina = new Materia { Name = "Feelings for Platina", MateriaId = "504227712", Description = "プラチナへの想い", CountId = "2131950", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227712", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "818"};
        public static readonly Materia GemofCreation = new Materia { Name = "Gem of Creation", MateriaId = "504227713", Description = "生成の珠", CountId = "2179211", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227713", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000081", BitNumber = "819"};
        public static readonly Materia GemofVision = new Materia { Name = "Gem of Vision", MateriaId = "504227714", Description = "幻視の珠", CountId = "2299020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227714", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000002", BitNumber = "820"};
        public static readonly Materia SoaringHeart = new Materia { Name = "Soaring Heart", MateriaId = "504227847", Description = "ちょっと背伸びした心", CountId = "2151761", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227847", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "821"};
        public static readonly Materia PastRegrets = new Materia { Name = "Past Regrets", MateriaId = "504227865", Description = "悔恨の記憶", CountId = "2133730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227865", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "822"};
        public static readonly Materia PoweroftheLastDragon = new Materia { Name = "Power of the Last Dragon", MateriaId = "504227902", Description = "竜終の武力", CountId = "2152190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227902", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "823"};
        public static readonly Materia MagicoftheLastDragon = new Materia { Name = "Magic of the Last Dragon", MateriaId = "504227903", Description = "竜終の魔力", CountId = "2152191", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227903", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "824"};
        public static readonly Materia UnquestionableLoyalty = new Materia { Name = "Unquestionable Loyalty", MateriaId = "504227930", Description = "絶対の忠義", CountId = "2131960", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227930", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "825"};
        public static readonly Materia TwistedHero = new Materia { Name = "Twisted Hero", MateriaId = "504227931", Description = "歪んだ英雄", CountId = "2151311", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227931", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "826"};
        public static readonly Materia BloodoftheDragon = new Materia { Name = "Blood of the Dragon", MateriaId = "504227926", Description = "竜種の血", CountId = "2153000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "227926", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "827"};
        public static readonly Materia GustMane = new Materia { Name = "Gust Mane", MateriaId = "504228151", Description = "風含むたてがみ", CountId = "2131740", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228151", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "828"};
        public static readonly Materia MagicalPotential = new Materia { Name = "Magical Potential", MateriaId = "504228152", Description = "潜在せし魔力", CountId = "2171041", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228152", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "829"};
        public static readonly Materia GenjiTactics = new Materia { Name = "Genji Tactics", MateriaId = "504228161", Description = "源氏の兵法", CountId = "2133410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228161", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "830"};
        public static readonly Materia Adamantine = new Materia { Name = "Adamantine", MateriaId = "504228200", Description = "金剛不壊", CountId = "2131000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228200", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "831"};
        public static readonly Materia MiracleMagic = new Materia { Name = "Miracle Magic", MateriaId = "504228201", Description = "ミラクルマジック", CountId = "2132000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228201", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "832"};
        public static readonly Materia MHumanMachineKiller = new Materia { Name = "M Human/Machine Killer", MateriaId = "504228202", Description = "特攻魔法陣・人機", CountId = "2152400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228202", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "833"};
        public static readonly Materia IronBody = new Materia { Name = "Iron Body", MateriaId = "504228203", Description = "アイアンボディ", CountId = "2131001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228203", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "834"};
        public static readonly Materia Restraint = new Materia { Name = "Restraint", MateriaId = "504228204", Description = "リストレイント", CountId = "2132001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228204", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "835"};
        public static readonly Materia SoaringLegendaryDragon = new Materia { Name = "Soaring Legendary Dragon", MateriaId = "504228234", Description = "天翔ける伝説の白竜", CountId = "2134810", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228234", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "836"};
        public static readonly Materia SecretofMana = new Materia { Name = "Secret of Mana", MateriaId = "504228254", Description = "シークレット・オブ・マナ", CountId = "2133750", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228254", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "837"};
        public static readonly Materia SpearofthePrincess = new Materia { Name = "Spear of the Princess", MateriaId = "504228277", Description = "王女の槍術", CountId = "2135373", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228277", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "838"};
        public static readonly Materia ProudThief = new Materia { Name = "Proud Thief", MateriaId = "504228287", Description = "誇り高き義賊", CountId = "2133520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228287", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "839"};
        public static readonly Materia HeartofaRabite = new Materia { Name = "Heart of a Rabite", MateriaId = "504228299", Description = "ラビの心", CountId = "2131145", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228299", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000099", BitNumber = "840"};
        public static readonly Materia Opposition = new Materia { Name = "Opposition", MateriaId = "504228324", Description = "立ち向かう力", CountId = "2133300", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228324", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "841"};
        public static readonly Materia Kindness = new Materia { Name = "Kindness", MateriaId = "504228356", Description = "優しき力", CountId = "2135311", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228356", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "842"};
        public static readonly Materia Heroism = new Materia { Name = "Heroism", MateriaId = "504228371", Description = "勇敢なる力", CountId = "2133311", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228371", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "843"};
        public static readonly Materia AkademeiaSupportAttack = new Materia { Name = "Akademeia Support - Attack", MateriaId = "504228380", Description = "魔導院の支援・攻", CountId = "2131143", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228380", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "844"};
        public static readonly Materia AkademeiaSupportDefense = new Materia { Name = "Akademeia Support - Defense", MateriaId = "504228381", Description = "魔導院の支援・守", CountId = "2131144", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228381", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "845"};
        public static readonly Materia DancingDoll = new Materia { Name = "Dancing Doll", MateriaId = "504228390", Description = "ダンシングドール", CountId = "2135390", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228390", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "846"};
        public static readonly Materia DollsEye = new Materia { Name = "Doll's Eye", MateriaId = "504228391", Description = "ドールアイ", CountId = "2216001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228391", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000009", BitNumber = "847"};
        public static readonly Materia GunMastery = new Materia { Name = "Gun Mastery", MateriaId = "504209540", Description = "銃の極意", CountId = "2151372", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209540", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "848"};
        public static readonly Materia HerosVowEarth = new Materia { Name = "Hero's Vow - Earth", MateriaId = "504228416", Description = "英雄の誓い・土", CountId = "2131560", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228416", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "849"};
        public static readonly Materia ShadowWarrior = new Materia { Name = "Shadow Warrior", MateriaId = "504228452", Description = "シャドウウォリアー", CountId = "2131100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228452", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000041", BitNumber = "850"};
        public static readonly Materia LarasIntuition = new Materia { Name = "Lara's Intuition", MateriaId = "504228470", Description = "ララ・クロフトの直感", CountId = "2152410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228470", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "851"};
        public static readonly Materia WisdomofHess = new Materia { Name = "Wisdom of Hess", MateriaId = "504228490", Description = "ヘスの叡智", CountId = "2132240", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "852"};
        public static readonly Materia BlacksmithsDaughter = new Materia { Name = "Blacksmith's Daughter", MateriaId = "504228565", Description = "鍛冶屋の娘", CountId = "2151500", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228565", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "853"};
        public static readonly Materia DarkKnightsKnowledge = new Materia { Name = "Dark Knight's Knowledge", MateriaId = "504228586", Description = "魔剣士の心得", CountId = "2171032", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228586", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "854"};
        public static readonly Materia InheritedMagic = new Materia { Name = "Inherited Magic", MateriaId = "504228610", Description = "引き継いだ魔力", CountId = "2135112", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228610", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "855"};
        public static readonly Materia InheritedSpirit = new Materia { Name = "Inherited Spirit", MateriaId = "504228611", Description = "引き継いだ精神", CountId = "2136000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228611", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "856"};
        public static readonly Materia BugKiller_504224890 = new Materia { Name = "Bug Killer+", MateriaId = "504224890", Description = "ムシキラー改", CountId = "2152340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "224890", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "857"};
        public static readonly Materia ScorpionStinger = new Materia { Name = "Scorpion Stinger", MateriaId = "1500000055", Description = "Scorpion Stinger", CountId = "90055", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911159", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90055"};
        public static readonly Materia KeepersGate = new Materia { Name = "Keeper's Gate", MateriaId = "1500000056", Description = "Keeper's Gate", CountId = "90056", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911160", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000056", BitNumber = "90056"};
        public static readonly Materia DefendersBarrier = new Materia { Name = "Defender's Barrier", MateriaId = "1500000057", Description = "Defender's Barrier", CountId = "90057", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911161", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000057", BitNumber = "90057"};
        public static readonly Materia MidfieldersPotential = new Materia { Name = "Midfielder's Potential", MateriaId = "1500000058", Description = "Midfielder's Potential", CountId = "90058", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911162", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000058", BitNumber = "90058"};
        public static readonly Materia StrikersRoundhouse = new Materia { Name = "Striker's Roundhouse", MateriaId = "1500000059", Description = "Striker's Roundhouse", CountId = "90059", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911163", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000059", BitNumber = "90059"};
        public static readonly Materia GunUpgrade = new Materia { Name = "Gun Upgrade", MateriaId = "1500000045", Description = "Gun Upgrade", CountId = "90045", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910970", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90045"};
        public static readonly Materia FrigoandEtcetera = new Materia { Name = "Frigo and Etcetera", MateriaId = "1500000052", Description = "Frigo and Etcetera", CountId = "90052", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911034,911035", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000091", BitNumber = "90052"};
        public static readonly Materia Distraction = new Materia { Name = "Distraction", MateriaId = "1500000051", Description = "Distraction", CountId = "90051", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911020,100020", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "700000019", BitNumber = "90051"};
        public static readonly Materia DivineBlessing = new Materia { Name = "Divine Blessing", MateriaId = "1500000060", Description = "Divine Blessing", CountId = "90060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911168", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90060"};
        public static readonly Materia ScholarlyWisdom = new Materia { Name = "Scholarly Wisdom", MateriaId = "1500000063", Description = "Scholarly Wisdom", CountId = "90063", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911179", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90063"};
        public static readonly Materia MagicalRecollection = new Materia { Name = "Magical Recollection", MateriaId = "1500000061", Description = "Magical Recollection", CountId = "90061", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911178", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90061"};
        public static readonly Materia CerebralAugmentation = new Materia { Name = "Cerebral Augmentation", MateriaId = "1500000053", Description = "Cerebral Augmentation", CountId = "90053", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911115", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90053"};
        public static readonly Materia TF29Agent = new Materia { Name = "TF29 Agent", MateriaId = "1500000064", Description = "TF29 Agent", CountId = "90064", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911213", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90064"};
        public static readonly Materia EnergyConverter = new Materia { Name = "Energy Converter", MateriaId = "1500000065", Description = "Energy Converter", CountId = "90065", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911236", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90065"};
        public static readonly Materia MarchenkosSecrets = new Materia { Name = "Marchenko's Secrets", MateriaId = "1500000066", Description = "Marchenko's Secrets", CountId = "90066", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911237", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "90066"};
        public static readonly Materia TimeMachinesSecrets = new Materia { Name = "Time Machine's Secrets", MateriaId = "1500000054", Description = "Time Machine's Secrets", CountId = "90054", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911116", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90054"};
        public static readonly Materia RidersInstinct = new Materia { Name = "Rider's Instinct", MateriaId = "1500000067", Description = "Rider's Instinct", CountId = "90067", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911249", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90067"};
        public static readonly Materia SplashofLife = new Materia { Name = "Splash of Life", MateriaId = "1500000062", Description = "Splash of Life", CountId = "90062", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911253", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90062"};
        public static readonly Materia DragoonsWisdom = new Materia { Name = "Dragoon's Wisdom", MateriaId = "1500000068", Description = "Dragoon's Wisdom", CountId = "90068", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911317", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90068"};
        public static readonly Materia JudgesOath = new Materia { Name = "Judge's Oath", MateriaId = "1500000069", Description = "Judge's Oath", CountId = "90069", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911407", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "90069"};
        public static readonly Materia DemonsGambit = new Materia { Name = "Demon's Gambit", MateriaId = "1500000070", Description = "Demon's Gambit", CountId = "90070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911419", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90070"};
        public static readonly Materia GrimBrilliance = new Materia { Name = "Grim Brilliance", MateriaId = "1500000071", Description = "Grim Brilliance", CountId = "90071", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911449", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90071"};
        public static readonly Materia MaliciousAura = new Materia { Name = "Malicious Aura", MateriaId = "1500000072", Description = "Malicious Aura", CountId = "90072", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911501", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000002", BitNumber = "90072"};
        public static readonly Materia MaleficHeart = new Materia { Name = "Malefic Heart", MateriaId = "1500000073", Description = "Malefic Heart", CountId = "90073", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911467", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "1500000073", BitNumber = "90073"};
        public static readonly Materia ChaoticFerocity = new Materia { Name = "Chaotic Ferocity", MateriaId = "1500000074", Description = "Chaotic Ferocity", CountId = "90074", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911502", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "1500000002", BitNumber = "90074"};
        public static readonly Materia Executioner = new Materia { Name = "Executioner", MateriaId = "504230010", Description = "Executioner", CountId = "2151211", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230010", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "924"};
        public static readonly Materia GentleTraitor = new Materia { Name = "Gentle Traitor", MateriaId = "504230013", Description = "優しい復讐者", CountId = "2151334", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230013", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "925"};
        public static readonly Materia KatanaProficiency = new Materia { Name = "Katana Proficiency", MateriaId = "1500000075", Description = "Expert Slasher", CountId = "90075", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203070", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90075"};
        public static readonly Materia SpiritualProficiency = new Materia { Name = "Spiritual Proficiency", MateriaId = "1500000076", Description = "Spirit Mastery", CountId = "90076", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911560", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90076"};
        public static readonly Materia DemonicMight = new Materia { Name = "Demonic Might", MateriaId = "1500000077", Description = "Demon's Might", CountId = "90077", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911561", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000079", BitNumber = "90077"};
        public static readonly Materia DemonicMind = new Materia { Name = "Demonic Mind", MateriaId = "1500000078", Description = "Demon's Mind", CountId = "90078", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911562", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000079", BitNumber = "90078"};
        public static readonly Materia Vampyrism = new Materia { Name = "Vampyrism", MateriaId = "1500000080", Description = "Vampyrism", CountId = "90080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911599", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90080"};
        public static readonly Materia LightsVengeance = new Materia { Name = "Light's Vengeance", MateriaId = "1500000079", Description = "Light's Vengeance", CountId = "90079", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911563", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90079"};
        public static readonly Materia Spiritualism = new Materia { Name = "Spiritualism", MateriaId = "1500000081", Description = "Spiritualism", CountId = "90081", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911841,911674", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000091", BitNumber = "90081"};
        public static readonly Materia InstrumentalRhythm = new Materia { Name = "Instrumental Rhythm", MateriaId = "1500000082", Description = "Instrumental Rhythm", CountId = "90082", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911675", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90082"};
        public static readonly Materia AnimatedEssence = new Materia { Name = "Animated Essence", MateriaId = "1500000084", Description = "Animated Essence", CountId = "90084", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911698", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000035", BitNumber = "90084"};
        public static readonly Materia NoelsLegacy = new Materia { Name = "Noel's Legacy", MateriaId = "1500000087", Description = "Noel's Legacy", CountId = "90087", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911772", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90087"};
        public static readonly Materia WinterChild = new Materia { Name = "Winter Child", MateriaId = "1500000088", Description = "Winter Child", CountId = "90088", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911787", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "1500000035", BitNumber = "90088"};
        public static readonly Materia UnforgivingBlade = new Materia { Name = "Unforgiving Blade", MateriaId = "1500000089", Description = "Unforgiving Blade ", CountId = "90089", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911837", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90089"};
        public static readonly Materia WinterMagic = new Materia { Name = "Winter Magic", MateriaId = "1500000083", Description = "Winter Magic", CountId = "90083", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911765", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000035", BitNumber = "90083"};
        public static readonly Materia WinterSpirit = new Materia { Name = "Winter Spirit", MateriaId = "1500000085", Description = "Winter Spirit", CountId = "90085", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911766", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000035", BitNumber = "90085"};
        public static readonly Materia AssertiveGrowth = new Materia { Name = "Assertive Growth", MateriaId = "1500000086", Description = "Assertive Growth", CountId = "90086", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911767", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90086"};
        public static readonly Materia HeartsLight = new Materia { Name = "Heart's Light", MateriaId = "504230832", Description = "心の光", CountId = "2133321", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230832", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "961"};
        public static readonly Materia AwkwardFatherlyLove = new Materia { Name = "Awkward Fatherly Love", MateriaId = "504228860", Description = "不器用な愛", CountId = "2151331", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228860", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "868"};
        public static readonly Materia LegendaryGuardian = new Materia { Name = "Legendary Guardian", MateriaId = "504228861", Description = "伝説のガード", CountId = "2151312", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228861", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "869"};
        public static readonly Materia CognizantoftheTruth = new Materia { Name = "Cognizant of the Truth", MateriaId = "504228862", Description = "真実を識る者", CountId = "2135400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228862", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "870"};
        public static readonly Materia ExorcismPower = new Materia { Name = "Exorcism Power", MateriaId = "504228865", Description = "退魔の力", CountId = "2152200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228865", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "871"};
        public static readonly Materia ExorcismTechnique = new Materia { Name = "Exorcism Technique", MateriaId = "504228866", Description = "退魔の術", CountId = "2152201", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228866", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "872"};
        public static readonly Materia HerosVowWater = new Materia { Name = "Hero's Vow - Water", MateriaId = "504228637", Description = "英雄の誓い・水", CountId = "2132250", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228637", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "858"};
        public static readonly Materia ReaperoftheDustStorm = new Materia { Name = "Reaper of the Dust Storm", MateriaId = "504228658", Description = "刈り取る黒風", CountId = "2152350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228658", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000079", BitNumber = "859"};
        public static readonly Materia JumpingTechnique = new Materia { Name = "Jumping Technique", MateriaId = "504229221", Description = "跳躍の技法", CountId = "2179400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229221", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000080", BitNumber = "886"};
        public static readonly Materia EverlastingKindness = new Materia { Name = "Everlasting Kindness", MateriaId = "1500000090", Description = "Everlasting Kindness", CountId = "90090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "911936", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90090"};
        public static readonly Materia TranscendentSoul = new Materia { Name = "Transcendent Soul", MateriaId = "1500000091", Description = "Transcendent Soul", CountId = "90091", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912009", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "1500000091", BitNumber = "90091"};
        public static readonly Materia CombatFinesse = new Materia { Name = "Combat Finesse", MateriaId = "1500000092", Description = "Combat Finesse", CountId = "90092", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912013", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90092"};
        public static readonly Materia Sharpshooter = new Materia { Name = "Sharpshooter", MateriaId = "1500000093", Description = "Sharpshooter", CountId = "90093", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912027", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90093"};
        public static readonly Materia Strength = new Materia { Name = "Strength", MateriaId = "504228691", Description = "ストレングス", CountId = "2113031", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228691", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "860"};
        public static readonly Materia Etherize = new Materia { Name = "Etherize", MateriaId = "504228692", Description = "エーテライズ", CountId = "2115031", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228692", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "861"};
        public static readonly Materia PowerofId = new Materia { Name = "Power of Id", MateriaId = "504228693", Description = "イドの力", CountId = "2133312", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228693", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "862"};
        public static readonly Materia MothersReturn = new Materia { Name = "Mother's Return", MateriaId = "504228694", Description = "聖母の再来", CountId = "2151501", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228694", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000018", BitNumber = "863"};
        public static readonly Materia DistantPromise = new Materia { Name = "Distant Promise", MateriaId = "504228695", Description = "遠い約束", CountId = "2135113", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228695", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "864"};
        public static readonly Materia BattlingChamp = new Materia { Name = "Battling Champ", MateriaId = "504228696", Description = "バトリングキング", CountId = "2133313", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228696", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "865"};
        public static readonly Materia PluckyOoki = new Materia { Name = "Plucky Ooki", MateriaId = "504228697", Description = "勇敢なるウーキィー", CountId = "2153001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228697", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000018", BitNumber = "866"};
        public static readonly Materia MargiesWish = new Materia { Name = "Margie's Wish", MateriaId = "504228699", Description = "マルグレーテの想い", CountId = "2133314", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228699", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "867"};
        public static readonly Materia MysticRobes = new Materia { Name = "Mystic Robes", MateriaId = "504228870", Description = "ローブの秘義", CountId = "2151389", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228870", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "873"};
        public static readonly Materia Shielder = new Materia { Name = "Shielder", MateriaId = "504229030", Description = "シールダー", CountId = "2114031", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229030", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "876"};
        public static readonly Materia Soulful = new Materia { Name = "Soulful", MateriaId = "504229031", Description = "ソウルフル", CountId = "2116120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229031", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "877"};
        public static readonly Materia MultiMeleeMaster = new Materia { Name = "Multi-Melee Master", MateriaId = "504229032", Description = "拳刀の極み", CountId = "2151712", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229032", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "878"};
        public static readonly Materia GuardianofShevat = new Materia { Name = "Guardian of Shevat", MateriaId = "504229034", Description = "シェバトの守護者", CountId = "2133315", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229034", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "879"};
        public static readonly Materia SaintsAura = new Materia { Name = "Saint's Aura", MateriaId = "1500000094", Description = "Saint's Aura", CountId = "90094", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912074", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "90094"};
        public static readonly Materia WarriorsIntuitionATK = new Materia { Name = "Warrior's Intuition - ATK", MateriaId = "504230000", Description = "武士の心得・攻", CountId = "2113033", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230000", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "919"};
        public static readonly Materia WarriorsIntuitionDEF = new Materia { Name = "Warrior's Intuition - DEF", MateriaId = "504230001", Description = "武士の心得・防", CountId = "2114033", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230001", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "920"};
        public static readonly Materia AcceleratingPower = new Materia { Name = "Accelerating Power", MateriaId = "504230002", Description = "加速する力", CountId = "2173007", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230002", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000078", BitNumber = "921"};
        public static readonly Materia WarGoddessInsignia_504230005 = new Materia { Name = "War Goddess' Insignia", MateriaId = "504230005", Description = "武神の戦印", CountId = "2173050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230005", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "923"};
        public static readonly Materia HerosVowFire = new Materia { Name = "Hero's Vow - Fire", MateriaId = "504228983", Description = "英雄の誓い・火", CountId = "2171050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "228983", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "874"};
        public static readonly Materia BrushUp = new Materia { Name = "Brush-Up", MateriaId = "504229027", Description = "ブラッシュアップ", CountId = "2179300", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229028", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000078", BitNumber = "875"};
        public static readonly Materia SoulofDarkness = new Materia { Name = "Soul of Darkness", MateriaId = "1500000095", Description = "Soul of Darkness", CountId = "90095", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912112", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90095"};
        public static readonly Materia HerosVowWind = new Materia { Name = "Hero's Vow - Wind", MateriaId = "504229222", Description = "英雄の誓い・風", CountId = "2171060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229231", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "887"};
        public static readonly Materia Artistic = new Materia { Name = "Artistic", MateriaId = "504229223", Description = "アーティスティック", CountId = "2135402", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229232", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "888"};
        public static readonly Materia MagicCharger = new Materia { Name = "Magic Charger", MateriaId = "504229234", Description = "マジックチャージャー", CountId = "2171040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229234", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "889"};
        public static readonly Materia PhysicalBooster = new Materia { Name = "Physical Booster", MateriaId = "1500000098", Description = "Physical Booster", CountId = "90098", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912227", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90098"};
        public static readonly Materia MagicalBooster = new Materia { Name = "Magical Booster", MateriaId = "1500000099", Description = "Magical Booster", CountId = "90099", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912228", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90099"};
        public static readonly Materia UntrueSaint = new Materia { Name = "Untrue Saint", MateriaId = "504229210", Description = "聖者・偽", CountId = "2151531", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229210", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "880"};
        public static readonly Materia HuntersTrade = new Materia { Name = "Hunter's Trade", MateriaId = "504229212", Description = "ハンター稼業", CountId = "2133371", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229212", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "881"};
        public static readonly Materia DragonsTribe = new Materia { Name = "Dragon's Tribe", MateriaId = "504229213", Description = "竜の血族", CountId = "2135401", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229213", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "882"};
        public static readonly Materia IronGiantsArmor = new Materia { Name = "Iron Giant's Armor", MateriaId = "504229214", Description = "鉄巨人の装甲", CountId = "2136720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229214", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "883"};
        public static readonly Materia ProgressionofFervor = new Materia { Name = "Progression of Fervor", MateriaId = "504229219", Description = "勇猛狂符のすゝめ", CountId = "2131145", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229219", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "884"};
        public static readonly Materia ProgressionofBelief = new Materia { Name = "Progression of Belief", MateriaId = "504229220", Description = "信祈仰祷のすゝめ", CountId = "2131146", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229220", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "885"};
        public static readonly Materia AHerosBond = new Materia { Name = "A Hero's Bond", MateriaId = "504229861", Description = "英雄との絆", CountId = "2151332", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229861", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "911"};
        public static readonly Materia HeartOvercomingHatred = new Materia { Name = "Heart Overcoming Hatred", MateriaId = "504229862", Description = "憎しみを乗り越えし心", CountId = "2173004", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229862", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "912"};
        public static readonly Materia HeartBoundbyHatred = new Materia { Name = "Heart Bound by Hatred", MateriaId = "504229430", Description = "憎しみに囚われた心", CountId = "2135114", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229430", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "893"};
        public static readonly Materia FullMoonsGuidance = new Materia { Name = "Full Moon's Guidance", MateriaId = "504229435", Description = "満月の導き", CountId = "2135116", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229435", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000099", BitNumber = "898"};
        public static readonly Materia NewMoonsGuidance = new Materia { Name = "New Moon's Guidance", MateriaId = "504229436", Description = "新月の導き", CountId = "2135117", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229436", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000098", BitNumber = "899"};
        public static readonly Materia LunarianComprehension = new Materia { Name = "Lunarian Comprehension", MateriaId = "504229437", Description = "月の民の思念", CountId = "2135331", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229437", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "900"};
        public static readonly Materia DisparateSwordsman = new Materia { Name = "Disparate Swordsman", MateriaId = "504229599", Description = "異質の刀使い", CountId = "2151313", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229599", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000053", BitNumber = "901"};
        public static readonly Materia YinYangDualHand = new Materia { Name = "Yin-Yang Dual Hand", MateriaId = "504229341", Description = "陰陽双手", CountId = "2133316", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229341", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "890"};
        public static readonly Materia WhipExpert = new Materia { Name = "Whip Expert", MateriaId = "504229343", Description = "鞭の絶技", CountId = "2171070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229343", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "891"};
        public static readonly Materia TwoForOne = new Materia { Name = "Two For One", MateriaId = "504229345", Description = "二人でひとつ", CountId = "2135403", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229345", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "892"};
        public static readonly Materia MasterofMachinery = new Materia { Name = "Master of Machinery", MateriaId = "504229930", Description = "マスターマシーナリー", CountId = "2152041", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229930", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "915"};
        public static readonly Materia LongTrainingPaysOff = new Materia { Name = "Long Training Pays Off", MateriaId = "504229931", Description = "長き修行の成果", CountId = "2151361", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229931", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "916"};
        public static readonly Materia FraternalPower = new Materia { Name = "Fraternal Power", MateriaId = "504229935", Description = "兄弟の絆・力", CountId = "2131148", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229935", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "917"};
        public static readonly Materia FraternalWisdom = new Materia { Name = "Fraternal Wisdom", MateriaId = "504229936", Description = "兄弟の絆・知", CountId = "2131149", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229936", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "918"};
        public static readonly Materia BeachGirls = new Materia { Name = "Beach Girls", MateriaId = "504229860", Description = "ビーチガールズ2018", CountId = "2134812", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229860", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "910"};
        public static readonly Materia CoolBeauty = new Materia { Name = "Cool Beauty", MateriaId = "504230131", Description = "クールビューティー", CountId = "2134813", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230131", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "927"};
        public static readonly Materia EquipWhip = new Materia { Name = "Equip Whip", MateriaId = "504100870", Description = "鞭装備", CountId = "2155090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230003", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "945"};
        public static readonly Materia GuardianofThunder = new Materia { Name = "Guardian of Thunder", MateriaId = "504230004", Description = "雷鳴の守護", CountId = "2153002", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230004", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000008", BitNumber = "922"};
        public static readonly Materia HonorableRodArts = new Materia { Name = "Honorable Rod Arts", MateriaId = "504230133", Description = "ロッドの操術", CountId = "2155061", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230133", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "929"};
        public static readonly Materia BattleIntelligence = new Materia { Name = "Battle Intelligence", MateriaId = "504230132", Description = "バトルインテリジェンス", CountId = "2134811", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230132", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "928"};
        public static readonly Materia PlanetWhisperer = new Materia { Name = "Planet Whisperer", MateriaId = "504229740", Description = "星と語らう力", CountId = "2136100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229740", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "907"};
        public static readonly Materia EverlastingFantasy = new Materia { Name = "Everlasting Fantasy", MateriaId = "1500000100", Description = "Everlasting Fantasy", CountId = "90100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912260", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "504212570", BitNumber = "90100"};
        public static readonly Materia FortunasFaith = new Materia { Name = "Fortuna's Faith", MateriaId = "1500000101", Description = "Fortuna's Faith", CountId = "90101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912266", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000091", BitNumber = "90101"};
        public static readonly Materia TechniqueoftheAncients = new Materia { Name = "Technique of the Ancients", MateriaId = "504229742", Description = "古代種の技巧", CountId = "2131147", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229742", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "908"};
        public static readonly Materia KnowledgeoftheAncients = new Materia { Name = "Knowledge of the Ancients", MateriaId = "504229743", Description = "古代種の知恵", CountId = "2132103", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229743", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "909"};
        public static readonly Materia SwordMastery = new Materia { Name = "Sword Mastery", MateriaId = "1500000104", Description = "Sword Mastery", CountId = "90104", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209530", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90104"};
        public static readonly Materia ChocoboStamina = new Materia { Name = "Chocobo Stamina", MateriaId = "504230141", Description = "スタミナチョコボ", CountId = "2153003", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230141", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000007", BitNumber = "931"};
        public static readonly Materia MagicalChocobo = new Materia { Name = "Magical Chocobo", MateriaId = "504230142", Description = "マジカルチョコボ", CountId = "2153004", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230142", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000007", BitNumber = "932"};
        public static readonly Materia ChocoboAdventure = new Materia { Name = "Chocobo Adventure!", MateriaId = "504230150", Description = "チョコボと冒険！", CountId = "2131871", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230150", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "930"};
        public static readonly Materia ElegantGunner = new Materia { Name = "Elegant Gunner", MateriaId = "504230242", Description = "エレガントガンナー", CountId = "2151641", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230242", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "935"};
        public static readonly Materia AllinHarmony = new Materia { Name = "All in Harmony", MateriaId = "1500000105", Description = "All in Harmony", CountId = "90105", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912494", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "90105"};
        public static readonly Materia SpiritualDefense = new Materia { Name = "Spiritual Defense", MateriaId = "1500000106", Description = "Spiritual Defense", CountId = "90106", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912495", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "90106"};
        public static readonly Materia SuccessorsTalent = new Materia { Name = "Successor's Talent", MateriaId = "504230170", Description = "次代の才能", CountId = "2151791", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230170", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000018", BitNumber = "933"};
        public static readonly Materia WarriorsMight = new Materia { Name = "Warrior's Might", MateriaId = "1500000096", Description = "Warrior's Might", CountId = "90096", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912157", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90096"};
        public static readonly Materia ElectrifyingMight = new Materia { Name = "Electrifying Might", MateriaId = "1500000097", Description = "Electrifying Might", CountId = "90097", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912158", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90097"};
        public static readonly Materia TrueHero = new Materia { Name = "True Hero", MateriaId = "504229873", Description = "真なる英雄", CountId = "2151333", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229872", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "913"};
        public static readonly Materia WutaiNinja = new Materia { Name = "Wutai Ninja", MateriaId = "504229874", Description = "ウータイの忍者少女", CountId = "2133318", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229873", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "914"};
        public static readonly Materia WarrioroftheCrystal = new Materia { Name = "Warrior of the Crystal", MateriaId = "1500000109", Description = "Warrior of the Crystal", CountId = "90109", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912608", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "1500000109", BitNumber = "90109"};
        public static readonly Materia EmpresssSignet = new Materia { Name = "Empress's Signet", MateriaId = "1500000110", Description = "Empress's Signet", CountId = "90110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912631", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "504212570", BitNumber = "90110"};
        public static readonly Materia ImperialAmbitions = new Materia { Name = "Imperial Ambitions", MateriaId = "1500000103", Description = "Imperial Ambitions", CountId = "90103", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912421", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000078", BitNumber = "90103"};
        public static readonly Materia ThirdAnniversaryPartyGuest = new Materia { Name = "Third Anniversary Party Guest", MateriaId = "504230240", Description = "三周年記念パーティー出席者", CountId = "2172011", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230240", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "934"};
        public static readonly Materia SanctumsMilitantArt = new Materia { Name = "Sanctum's Militant Art", MateriaId = "504230376", Description = "聖府軍式機壊術", CountId = "2152042", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230376", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "943"};
        public static readonly Materia SanctumsMilitantLaw = new Materia { Name = "Sanctum's Militant Law", MateriaId = "504230377", Description = "聖府軍式機壊法", CountId = "2152043", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230377", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "944"};
        public static readonly Materia DualForm = new Materia { Name = "Dual Form", MateriaId = "504230370", Description = "繝・Η繧｢繝ｫ繝輔か繝ｼ繝", CountId = "2171080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "939"};
        public static readonly Materia ShiningGuardianofHope = new Materia { Name = "Shining Guardian of Hope", MateriaId = "504230372", Description = "蟶梧悍繧貞ｮ医ｋ霈昴″", CountId = "2135332", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230372", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000099", BitNumber = "940"};
        public static readonly Materia SeaDragon = new Materia { Name = "Sea Dragon", MateriaId = "1500000111", Description = "Sea Dragon", CountId = "90111", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912833", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "912802", BitNumber = "90111"};
        public static readonly Materia ScepterofJustice = new Materia { Name = "Scepter of Justice", MateriaId = "1500000107", Description = "Scepter of Justice", CountId = "90107", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912499", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000095", BitNumber = "90107"};
        public static readonly Materia EngulfingLight = new Materia { Name = "Engulfing Light", MateriaId = "1500000108", Description = "Engulfing Light", CountId = "90108", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912500", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000095", BitNumber = "90108"};
        public static readonly Materia WanderingWarrior = new Materia { Name = "Wandering Warrior", MateriaId = "504229634", Description = "旅立ちの剣士", CountId = "2131732", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229634", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "905"};
        public static readonly Materia DreamsofaWiderWorld = new Materia { Name = "Dreams of a Wider World", MateriaId = "504229637", Description = "見果てぬ世界への夢", CountId = "2179401", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229637", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000081", BitNumber = "906"};
        public static readonly Materia Faithshallbemyshield = new Materia { Name = "Faith shall be my shield!", MateriaId = "504229633", Description = "蟾ｱ繧剃ｿ｡縺倥∬ｲｫ縺・", CountId = "2116121", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229633", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "904"};
        public static readonly Materia JewelofStrength = new Materia { Name = "Jewel of Strength", MateriaId = "504229630", Description = "力の宝玉", CountId = "2113032", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229630", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "902"};
        public static readonly Materia JewelofProtection = new Materia { Name = "Jewel of Protection", MateriaId = "504229631", Description = "守りの宝玉", CountId = "2114032", EquipmentActiveAbility = "", EquipmentPassiveAbility = "229631", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "903"};
        public static readonly Materia TranquilHealing = new Materia { Name = "Tranquil Healing", MateriaId = "504230651", Description = "やすらかなる癒し", CountId = "2136101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230651", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "952"};
        public static readonly Materia AweInspiringOrigin = new Materia { Name = "Awe-Inspiring Origin", MateriaId = "504230652", Description = "威服同源", CountId = "2151314", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230652", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "953"};
        public static readonly Materia CastleExdeathStormIn = new Materia { Name = "Castle Exdeath - Storm In", MateriaId = "504230656", Description = "エクスデス城・突入", CountId = "2131151", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230656", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "955"};
        public static readonly Materia CastleExdeathIllusionPerception = new Materia { Name = "Castle Exdeath - Illusion Perception", MateriaId = "504230657", Description = "エクスデス城・幻影看破", CountId = "2131152", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230657", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "956"};
        public static readonly Materia DodgeRoll = new Materia { Name = "Dodge Roll", MateriaId = "504232937", Description = "ドッジロール", CountId = "2112060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232937", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000097", BitNumber = "1031"};
        public static readonly Materia MPHaste = new Materia { Name = "MP Haste", MateriaId = "504232940", Description = "MPヘイスト", CountId = "2112070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232940", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000091", BitNumber = "1032"};
        public static readonly Materia HeartsDarkness = new Materia { Name = "Heart's Darkness", MateriaId = "504232931", Description = "心の闇", CountId = "2113213", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232931", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "1030"};
        public static readonly Materia SamuraisMight = new Materia { Name = "Samurai's Might", MateriaId = "1500000112", Description = "Samurai's Might", CountId = "90112", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912845", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000095", BitNumber = "90112"};
        public static readonly Materia FlowingMight = new Materia { Name = "Flowing Might", MateriaId = "1500000113", Description = "Flowing Might	", CountId = "90113", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912846", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000095", BitNumber = "90113"};
        public static readonly Materia PhantomForce = new Materia { Name = "Phantom Force", MateriaId = "504230550", Description = "ファントムフォース", CountId = "2151801", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230550", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "946"};
        public static readonly Materia LifeoftheLaboratory = new Materia { Name = "Life of the Laboratory", MateriaId = "504230551", Description = "研究室の元気者", CountId = "2133372", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230551", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "947"};
        public static readonly Materia BoundlessLove = new Materia { Name = "Boundless Love", MateriaId = "1500000115", Description = "Boundless Love", CountId = "90115", EquipmentActiveAbility = "", EquipmentPassiveAbility = "912989", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90115"};
        public static readonly Materia WayoftheDragon = new Materia { Name = "Way of the Dragon", MateriaId = "504233003", Description = "巨竜のチカラ", CountId = "2113216", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233003", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1035"};
        public static readonly Materia ChannelAnger = new Materia { Name = "Channel Anger", MateriaId = "504233006", Description = "魔力かくせい", CountId = "2115713", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233006", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1036"};
        public static readonly Materia DivineIntervention = new Materia { Name = "Divine Intervention", MateriaId = "504233009", Description = "女神の祝福", CountId = "2116051", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233009", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000041", BitNumber = "1037"};
        public static readonly Materia WeaponsSpecialist = new Materia { Name = "Weapons Specialist", MateriaId = "504231141", Description = "スペリオルオブアームズ", CountId = "2133402", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231141", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "971"};
        public static readonly Materia DarkKnightsAuthority = new Materia { Name = "Dark Knight's Authority", MateriaId = "504231143", Description = "ダークナイトオーソリティ", CountId = "2151321", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231143", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "972"};
        public static readonly Materia WildRoseWarrior = new Materia { Name = "Wild Rose Warrior", MateriaId = "504231144", Description = "のばらの戦士", CountId = "2152202", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231144", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "973"};
        public static readonly Materia WildRoseMage = new Materia { Name = "Wild Rose Mage", MateriaId = "504231145", Description = "のばらの魔導士", CountId = "2152203", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231145", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "974"};
        public static readonly Materia GirlEntrustedWithHope = new Materia { Name = "Girl Entrusted With Hope", MateriaId = "504230561", Description = "希望の心を託された少女", CountId = "2135371", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230561", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "949"};
        public static readonly Materia WarriorfromAnotherWorld = new Materia { Name = "Warrior from Another World", MateriaId = "504230564", Description = "異世界より来た戦士", CountId = "2131371", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230564", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "951"};
        public static readonly Materia OvercomingDeath = new Materia { Name = "Overcoming Death", MateriaId = "504230563", Description = "死を超える者", CountId = "2135372", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230563", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "950"};
        public static readonly Materia HeartsAgainsttheVoid = new Materia { Name = "Hearts Against the Void", MateriaId = "504230560", Description = "無に抗う心", CountId = "2133401", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230560", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "948"};
        public static readonly Materia ILoveChocobos = new Materia { Name = "I Love Chocobos!", MateriaId = "504230760", Description = "チョコボだーいすき！", CountId = "2154993", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230760", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000014", BitNumber = "954"};
        public static readonly Materia KnowledgeofKatanasandRods = new Materia { Name = "Knowledge of Katanas and Rods", MateriaId = "504231070", Description = "刀・ロッド熟知", CountId = "2151336", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231070", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "968"};
        public static readonly Materia HeartlessAssassin = new Materia { Name = "Heartless Assassin", MateriaId = "504231071", Description = "非情の暗殺者", CountId = "2151341", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231071", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "969"};
        public static readonly Materia CorruptedMage = new Materia { Name = "Corrupted Mage", MateriaId = "504231073", Description = "壊乱の魔導士", CountId = "2135374", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231073", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "970"};
        public static readonly Materia FierceGreatswordUser = new Materia { Name = "Fierce Greatsword User", MateriaId = "504231384", Description = "猛攻の大剣使い", CountId = "2151231", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231384", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "980"};
        public static readonly Materia RulersMight = new Materia { Name = "Ruler's Might", MateriaId = "1500000117", Description = "Ruler's Might", CountId = "90117", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913332", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000076", BitNumber = "90117"};
        public static readonly Materia ProtecttheEspersPhysical = new Materia { Name = "Protect the Espers! - Physical", MateriaId = "504230916", Description = "幻獣を守れ！・攻", CountId = "2133112", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230916", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "966"};
        public static readonly Materia ProtecttheEspersMagic = new Materia { Name = "Protect the Espers! - Magic", MateriaId = "504230917", Description = "幻獣を守れ！・魔", CountId = "2135000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230917", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "967"};
        public static readonly Materia LovesWhereabouts = new Materia { Name = "Love's Whereabouts", MateriaId = "504230910", Description = "愛の在処", CountId = "2151511", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230910", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "963"};
        public static readonly Materia FirstRateTreasureHunter = new Materia { Name = "First-Rate Treasure Hunter", MateriaId = "504230911", Description = "一流のトレジャーハンター", CountId = "2151301", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230911", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "964"};
        public static readonly Materia FortuneTellersVision = new Materia { Name = "Fortune Teller's Vision", MateriaId = "504230913", Description = "占術者の幻視", CountId = "2154051", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230913", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000014", BitNumber = "965"};
        public static readonly Materia ChivalrySkills = new Materia { Name = "Chivalry Skills", MateriaId = "504233763", Description = "きしどうスキル", CountId = "2111313", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233763", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1060"};
        public static readonly Materia TheStrategist = new Materia { Name = "The Strategist", MateriaId = "504233001", Description = "冷徹なる心", CountId = "2113214", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233001", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1033"};
        public static readonly Materia SupremeSentinel = new Materia { Name = "Supreme Sentinel", MateriaId = "504233002", Description = "六軍王を束ねる者", CountId = "2113215", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233002", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "1034"};
        public static readonly Materia NickersKnack = new Materia { Name = "Nicker's Knack", MateriaId = "504233011", Description = "盗賊の心得", CountId = "2113217", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233011", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "1038"};
        public static readonly Materia TheBeginningoftheEnd = new Materia { Name = "The Beginning of the End", MateriaId = "504233760", Description = "終わりのはじまり", CountId = "2212711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233760", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "1058"};
        public static readonly Materia AllureSkills = new Materia { Name = "Allure Skills", MateriaId = "504233761", Description = "おいろけスキル", CountId = "2113227", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233761", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000068", BitNumber = "1059"};
        public static readonly Materia PuffPuff = new Materia { Name = "Puff-Puff", MateriaId = "504233770", Description = "ぱふぱふ", CountId = "2290005", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233770", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000009", BitNumber = "1062"};
        public static readonly Materia SpyofAllTrades = new Materia { Name = "Spy of All Trades", MateriaId = "1500000118", Description = "Spy of All Trades", CountId = "90118", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913317", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000095", BitNumber = "90118"};
        public static readonly Materia SuitUp = new Materia { Name = "Suit Up", MateriaId = "1500000119", Description = "Suit Up", CountId = "90119", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913318", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000095", BitNumber = "90119"};
        public static readonly Materia LocktekCipher = new Materia { Name = "Locktek Cipher", MateriaId = "1500000120", Description = "Locktek Cipher", CountId = "90120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913319,913480", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000120", BitNumber = "90120"};
        public static readonly Materia TopOperative = new Materia { Name = "Top Operative", MateriaId = "1500000121", Description = "Top Operative", CountId = "90121", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913475", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000060", BitNumber = "90121"};
        public static readonly Materia AdvancedWeaponry = new Materia { Name = "Advanced Weaponry", MateriaId = "1500000116", Description = "Advanced Weaponry", CountId = "90116", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913325", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90116"};
        public static readonly Materia EveryDemonsRushin = new Materia { Name = "Every Demon's Rushin'", MateriaId = "1500000122", Description = "Every Demon's Rushin", CountId = "90122", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913481", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "2000", ItemIdClone = "700000079", BitNumber = "90122"};
        public static readonly Materia AuroralAura = new Materia { Name = "Auroral Aura", MateriaId = "504233769", Description = "オーロラのかがやき", CountId = "2290004", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233769", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000003", BitNumber = "1061"};
        public static readonly Materia TwinGunner = new Materia { Name = "Twin Gunner", MateriaId = "504230770", Description = "ツインガンナー", CountId = "2151373", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230770", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "957"};
        public static readonly Materia CrossingtheLand = new Materia { Name = "Crossing the Land", MateriaId = "504230772", Description = "大地を駆ける者", CountId = "2153921", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230772", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "958"};
        public static readonly Materia TheAstralsProtection = new Materia { Name = "The Astrals' Protection", MateriaId = "504231800", Description = "六神の加護", CountId = "2133712", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231810", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "991"};
        public static readonly Materia MarkoftheGlacian = new Materia { Name = "Mark of the Glacian", MateriaId = "504231812", Description = "氷神の証", CountId = "2137050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231812", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "992"};
        public static readonly Materia DutytotheWorld = new Materia { Name = "Duty to the World", MateriaId = "504231890", Description = "世界を守る使命", CountId = "2137100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231890", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "993"};
        public static readonly Materia SistersofWinter = new Materia { Name = "Sisters of Winter", MateriaId = "504230834", Description = "聖夜のメイド姉妹", CountId = "2151335", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230834", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "962"};
        public static readonly Materia SorceressofHess = new Materia { Name = "Sorceress of Hess", MateriaId = "504231201", Description = "ヘスの魔人", CountId = "2151991", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231201", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "975"};
        public static readonly Materia KnightofChaos = new Materia { Name = "Knight of Chaos", MateriaId = "504231302", Description = "混沌の騎士", CountId = "2133322", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231302", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "978"};
        public static readonly Materia UndyingVengeance = new Materia { Name = "Undying Vengeance", MateriaId = "504232100", Description = "不滅の復讐者", CountId = "2137150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232100", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "997"};
        public static readonly Materia KingofLucisCharacter = new Materia { Name = "King of Lucis' Character", MateriaId = "504232101", Description = "ルシス王の風格", CountId = "2151323", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232101", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "998"};
        public static readonly Materia EnduringFlame = new Materia { Name = "Enduring Flame", MateriaId = "504232103", Description = "硬火の術", CountId = "2153131", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232103", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000006", BitNumber = "999"};
        public static readonly Materia BladeArtSuccession = new Materia { Name = "Blade Art Succession", MateriaId = "504231651", Description = "継承せし絶技", CountId = "2151450", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231651", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000053", BitNumber = "987"};
        public static readonly Materia BattleAdvantage = new Materia { Name = "Battle Advantage", MateriaId = "504231654", Description = "バトルアドバンテージ", CountId = "2133511", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231654", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "988"};
        public static readonly Materia HeavenlyPresence = new Materia { Name = "Heavenly Presence", MateriaId = "1500000123", Description = "Heavenly Presence", CountId = "90123", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913678", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "912010", BitNumber = "90123"};
        public static readonly Materia SPR_504100180 = new Materia { Name = "SPR +30%", MateriaId = "504100180", Description = "精神+30%", CountId = "2116050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100180", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "1004"};
        public static readonly Materia LastStand = new Materia { Name = "Last Stand+", MateriaId = "504232110", Description = "ふんばる改", CountId = "2151324", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232110", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "1000"};
        public static readonly Materia StubbornOx = new Materia { Name = "Stubborn Ox", MateriaId = "504232114", Description = "頑固な人情家", CountId = "2131532", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232114", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1003"};
        public static readonly Materia ProdigiesofMysidia = new Materia { Name = "Prodigies of Mysidia", MateriaId = "504232112", Description = "ミシディアの天才双児", CountId = "2132352", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232112", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1002"};
        public static readonly Materia MarkofthePaladin = new Materia { Name = "Mark of the Paladin", MateriaId = "504232111", Description = "パラディンの証", CountId = "2151325", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232111", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1001"};
        public static readonly Materia LovingSpirit = new Materia { Name = "Loving Spirit", MateriaId = "1500000124", Description = "Loving Spirit", CountId = "90124", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913715,100010,100180", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90124"};
        public static readonly Materia FlurryofPetals = new Materia { Name = "Flurry of Petals", MateriaId = "1500000125", Description = "Flurry of Petals", CountId = "90125", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913757", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90125"};
        public static readonly Materia LukasValentineRecipe = new Materia { Name = "Luka's Valentine Recipe", MateriaId = "504231204", Description = "ルルカのバレンタインレシピ", CountId = "2131471", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231204", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "977"};
        public static readonly Materia IcyPassion = new Materia { Name = "Icy Passion", MateriaId = "504231203", Description = "氷の情熱", CountId = "2132351", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231203", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "976"};
        public static readonly Materia LoveisVital = new Materia { Name = "Love is Vital", MateriaId = "1500000126", Description = "Love is Vital", CountId = "90126", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913886", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90126"};
        public static readonly Materia LoveisMagical = new Materia { Name = "Love is Magical", MateriaId = "1500000127", Description = "Love is Magical", CountId = "90127", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913887", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90127"};
        public static readonly Materia CupidsBlessing = new Materia { Name = "Cupid's Blessing", MateriaId = "1500000128", Description = "Cupid's Blessing", CountId = "90128", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913888", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "910830", BitNumber = "90128"};
        public static readonly Materia DemonKingsPower = new Materia { Name = "Demon King's Power", MateriaId = "504231563", Description = "魔王の力", CountId = "2135712", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231563", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "985"};
        public static readonly Materia TapestryofChaos = new Materia { Name = "Tapestry of Chaos", MateriaId = "504231564", Description = "暗黒の生み出す力", CountId = "2151631", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231564", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "986"};
        public static readonly Materia TwinSwordsMastery = new Materia { Name = "Twin Swords Mastery", MateriaId = "504231562", Description = "ツインソードの奥義", CountId = "2171081", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231562", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "984"};
        public static readonly Materia LeaderoftheSoiree = new Materia { Name = "Leader of the Soiree", MateriaId = "504231910", Description = "夜会主宰者", CountId = "2151322", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231910", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "994"};
        public static readonly Materia WarGoddessInsignia_504232200 = new Materia { Name = "War Goddess' Insignia+", MateriaId = "504232200", Description = "武神の戦印・改", CountId = "2173060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232200", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1005"};
        public static readonly Materia EquipGun = new Materia { Name = "Equip Gun", MateriaId = "504231970", Description = "銃装備", CountId = "2155140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231970", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "995"};
        public static readonly Materia ExploringtheDepths = new Materia { Name = "Exploring the Depths", MateriaId = "504231972", Description = "深層探検家", CountId = "2134350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231972", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "996"};
        public static readonly Materia Deconstruction = new Materia { Name = "Deconstruction", MateriaId = "504233336", Description = "ディコンストラクション", CountId = "2290003", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233336", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000003", BitNumber = "1042"};
        public static readonly Materia DanceMaster = new Materia { Name = "Dance Master", MateriaId = "504233332", Description = "踊り子の極意", CountId = "2113220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233332", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1041"};
        public static readonly Materia BondswiththeAeons = new Materia { Name = "Bonds with the Aeons", MateriaId = "504232704", Description = "召喚獣たちとの絆", CountId = "2137152", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232704", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1022"};
        public static readonly Materia RonsoGuardian = new Materia { Name = "Ronso Guardian", MateriaId = "504232705", Description = "ロンゾ族のガード", CountId = "2113211", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232705", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "1023"};
        public static readonly Materia AceofAces = new Materia { Name = "Ace of Aces", MateriaId = "504232700", Description = "正真正銘のエース", CountId = "2139101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232700", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1020"};
        public static readonly Materia OriginatoroftheFinalSummoning = new Materia { Name = "Originator of the Final Summoning", MateriaId = "504232703", Description = "究極召喚の伝承者", CountId = "2137151", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232703", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "1021"};
        public static readonly Materia KnowledgeofAeons = new Materia { Name = "Knowledge of Aeons", MateriaId = "504232708", Description = "召喚の心得", CountId = "2137153", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232708", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1024"};
        public static readonly Materia HighClassDagger = new Materia { Name = "High Class Dagger", MateriaId = "504232863", Description = "ハイクラスダガー", CountId = "2113212", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232863", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "1029"};
        public static readonly Materia RookieSphereHunter = new Materia { Name = "Rookie Sphere Hunter", MateriaId = "504232860", Description = "新人スフィアハンター", CountId = "2153711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232860", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "1028"};
        public static readonly Materia TheLivingofSpira_504232790 = new Materia { Name = "The Living of Spira", MateriaId = "504232790", Description = "スピラで生きる者", CountId = "2111311", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232790", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1025"};
        public static readonly Materia TheLivingofSpira_504232791 = new Materia { Name = "The Living of Spira+", MateriaId = "504232791", Description = "スピラで生きる者 改", CountId = "2111510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232791", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1026"};
        public static readonly Materia TidalWaves = new Materia { Name = "Tidal Waves", MateriaId = "504230774", Description = "タイダルウエイブ", CountId = "2212561", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230774", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000035", BitNumber = "959"};
        public static readonly Materia SurpassingtheLegend = new Materia { Name = "Surpassing the Legend", MateriaId = "504230775", Description = "伝説を超えし者", CountId = "2153731", EquipmentActiveAbility = "", EquipmentPassiveAbility = "230775", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000099", BitNumber = "960"};
        public static readonly Materia DEF = new Materia { Name = "DEF +30%", MateriaId = "504100150", Description = "DEF +30%", CountId = "90129", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100150", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "90129"};
        public static readonly Materia FundamentalsofAlchemy = new Materia { Name = "Fundamentals of Alchemy", MateriaId = "504234097", Description = "錬金術の基礎知識", CountId = "2113234", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234097", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000091", BitNumber = "1076"};
        public static readonly Materia IshvalsHero = new Materia { Name = "Ishval's Hero", MateriaId = "504234095", Description = "イシュヴァールの英雄", CountId = "2115719", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234095", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000006", BitNumber = "1074"};
        public static readonly Materia KnowledgeoftheTruth = new Materia { Name = "Knowledge of the Truth", MateriaId = "504234091", Description = "真理の知識", CountId = "2153232", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234091", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000018", BitNumber = "1072"};
        public static readonly Materia PhilosophersStoneSeeker = new Materia { Name = "Philosopher's Stone Seeker", MateriaId = "504234092", Description = "賢者の石を求める者", CountId = "2172013", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234092", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "1073"};
        public static readonly Materia TheHawksEye = new Materia { Name = "The Hawk's Eye", MateriaId = "504234096", Description = "鷹の目", CountId = "2112071", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234096", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1075"};
        public static readonly Materia LongReach_504232401 = new Materia { Name = "Long Reach", MateriaId = "504232401", Description = "忍者の教え", CountId = "2177101", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232401", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000097", BitNumber = "1014"};
        public static readonly Materia Thievery_504232450 = new Materia { Name = "Thievery", MateriaId = "504232450", Description = "盗賊のあかし", CountId = "2113711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232450", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1009"};
        public static readonly Materia MasterDragonKnight_504232452 = new Materia { Name = "Master Dragon Knight", MateriaId = "504232452", Description = "竜技の極意", CountId = "2132222", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232452", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "1010"};
        public static readonly Materia BlackMagesPotential_504232454 = new Materia { Name = "Black Mage's Potential", MateriaId = "504232454", Description = "黒魔道士の潜在能力", CountId = "2151512", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232454", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1011"};
        public static readonly Materia BurmeciasStrongestDragonKnight_504232456 = new Materia { Name = "Burmecia's Strongest Dragon Knight", MateriaId = "504232456", Description = "ブルメシア最強の竜騎士", CountId = "2151326", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232456", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "1012"};
        public static readonly Materia CourtJesters_504232457 = new Materia { Name = "Court Jesters", MateriaId = "504232457", Description = "月なきみそらの道化師たち", CountId = "2135405", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232457", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1013"};
        public static readonly Materia ExceptionalIngenuity_504232511 = new Materia { Name = "Exceptional Ingenuity", MateriaId = "504232511", Description = "隙なき知謀家", CountId = "2174430", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232511", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000091", BitNumber = "1015"};
        public static readonly Materia WingsthatTranscendTime_504234420 = new Materia { Name = "Wings that Transcend Time", MateriaId = "504234420", Description = "刻を超える翼", CountId = "2113237", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234420", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "1087"};
        public static readonly Materia PhantasmicMelody_504233464 = new Materia { Name = "Phantasmic Melody", MateriaId = "504233464", Description = "幻妖の旋律", CountId = "2153401", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233464", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "1049"};
        public static readonly Materia DiabolosSynergy_504233455 = new Materia { Name = "Diabolos Synergy", MateriaId = "504233455", Description = "ディアボロスシナジー", CountId = "2115715", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233455", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000098", BitNumber = "1047"};
        public static readonly Materia IfritSynergy_504233450 = new Materia { Name = "Ifrit Synergy", MateriaId = "504233450", Description = "イフリートシナジー", CountId = "2113221", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233450", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1045"};
        public static readonly Materia BahamutSynergy_504233452 = new Materia { Name = "Bahamut Synergy", MateriaId = "504233452", Description = "バハムートシナジー", CountId = "2115714", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233452", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1046"};
        public static readonly Materia AsuraSynergy_504233456 = new Materia { Name = "Asura Synergy", MateriaId = "504233456", Description = "阿修羅シナジー", CountId = "2113222", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233456", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1048"};
        public static readonly Materia ScionSorceress_504232670 = new Materia { Name = "Scion Sorceress", MateriaId = "504232670", Description = "暁の魔女", CountId = "2115710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232670", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1018"};
        public static readonly Materia WiseintheWaysofMagic_504232671 = new Materia { Name = "Wise in the Ways of Magic", MateriaId = "504232671", Description = "魔法学を究めし賢人", CountId = "2115711", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232671", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "1019"};
        public static readonly Materia GiftedSorceresssKnowledge_504232603 = new Materia { Name = "Gifted Sorceress's Knowledge", MateriaId = "504232603", Description = "天才魔術師の知識", CountId = "2115033", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232603", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000018", BitNumber = "1016"};
        public static readonly Materia DropfromtheHolyGrail_504232605 = new Materia { Name = "Drop from the Holy Grail", MateriaId = "504232605", Description = "聖杯の雫", CountId = "2113210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "232605", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "1017"};
        public static readonly Materia UnfalteringFist_504233913 = new Materia { Name = "Unfaltering Fist", MateriaId = "504233913", Description = "迷いなき拳", CountId = "2113229", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233913", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "1064"};
        public static readonly Materia CouragetoMoveOn_504233910 = new Materia { Name = "Courage to Move On", MateriaId = "504233910", Description = "前進する勇気", CountId = "2113228", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233910", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1063"};
        public static readonly Materia MotherSeekingHeart_504233915 = new Materia { Name = "Mother-Seeking Heart", MateriaId = "504233915", Description = "母を求める心", CountId = "2113230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233915", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "1065"};
        public static readonly Materia WaterFFVIIAC_504233919 = new Materia { Name = "Water (FFVII: AC)", MateriaId = "504233919", Description = "Water", CountId = "2115717", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233919", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000018", BitNumber = "1066"};
        public static readonly Materia BlackWater_504233920 = new Materia { Name = "Black Water", MateriaId = "504233920", Description = "Black Water", CountId = "2113231", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233920", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000018", BitNumber = "1067"};
        public static readonly Materia Needles_504234022 = new Materia { Name = "10000 Needles", MateriaId = "504234022", Description = "はりまんぼん", CountId = "2212712", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234022", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000097", BitNumber = "1070"};
        public static readonly Materia RunAway_504234023 = new Materia { Name = "Run Away", MateriaId = "504234023", Description = "逃げ足", CountId = "2177102", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234023", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000097", BitNumber = "1071"};
        public static readonly Materia BrawlersMight_1500000129 = new Materia { Name = "Brawler's Might", MateriaId = "1500000129", Description = "Brawlers Might", CountId = "90130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913996", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90130"};
        public static readonly Materia ObscureMight_1500000130 = new Materia { Name = "Obscure Might", MateriaId = "1500000130", Description = "Shaded Might", CountId = "90131", EquipmentActiveAbility = "", EquipmentPassiveAbility = "913997", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90131"};
        public static readonly Materia AlexanderSynergy_504233566 = new Materia { Name = "Alexander Synergy", MateriaId = "504233566", Description = "アレキサンダーシナジー", CountId = "2114034", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233566", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000099", BitNumber = "1053"};
        public static readonly Materia TetraSylphidSynergy_504233564 = new Materia { Name = "Tetra Sylphid Synergy", MateriaId = "504233564", Description = "テトラシルフィードシナジー", CountId = "2115716", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233564", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "1052"};
        public static readonly Materia OdinSynergy_504233562 = new Materia { Name = "Odin Synergy", MateriaId = "504233562", Description = "オーディンシナジー", CountId = "2113223", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233562", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1051"};
        public static readonly Materia FenrirSynergy_504233569 = new Materia { Name = "Fenrir Synergy", MateriaId = "504233569", Description = "フェンリルシナジー", CountId = "2111312", EquipmentActiveAbility = "", EquipmentPassiveAbility = "233569", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "1050"};
        public static readonly Materia StrengthOverChaos_1500000131 = new Materia { Name = "Strength Over Chaos", MateriaId = "1500000131", Description = "Strength Over Chaos", CountId = "90132", EquipmentActiveAbility = "", EquipmentPassiveAbility = "914016", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90132"};
        public static readonly Materia MindOverChaos_1500000132 = new Materia { Name = "Mind Over Chaos", MateriaId = "1500000132", Description = "Mind Over Chaos", CountId = "90133", EquipmentActiveAbility = "", EquipmentPassiveAbility = "914017", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "90133"};
        public static readonly Materia OerbasBoon_504234461 = new Materia { Name = "Oerba's Boon", MateriaId = "504234461", Description = "ヲルバの祝福", CountId = "2115724", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234461", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000041", BitNumber = "1088"};
        public static readonly Materia MemoriesofRagnarok_504234463 = new Materia { Name = "Memories of Ragnarok", MateriaId = "504234463", Description = "ラグナロクの記憶", CountId = "2113238", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234463", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000080", BitNumber = "1089"};
        public static readonly Materia DeterminationtoPullThrough_504234465 = new Materia { Name = "Determination to Pull Through", MateriaId = "504234465", Description = "つらぬく覚悟", CountId = "2113239", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234465", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "1090"};
        public static readonly Materia LoomingWrath_504234466 = new Materia { Name = "Looming Wrath", MateriaId = "504234466", Description = "リベンジスタイル", CountId = "2175011", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234466", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000068", BitNumber = "1091"};
        public static readonly Materia EtrosChampion_504234204 = new Materia { Name = "Etro's Champion", MateriaId = "504234204", Description = "女神の騎士", CountId = "2111314", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234204", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1080"};
        public static readonly Materia EnchantingArcher_504234201 = new Materia { Name = "Enchanting Archer", MateriaId = "504234201", Description = "魔弓の射手", CountId = "2115720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234201", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "1077"};
        public static readonly Materia LastGuardian_504234202 = new Materia { Name = "Last Guardian", MateriaId = "504234202", Description = "最後の守護者", CountId = "2113235", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234202", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "1078"};
        public static readonly Materia AcademiasProdigy_504234203 = new Materia { Name = "Academia's Prodigy", MateriaId = "504234203", Description = "アカデミアの俊英", CountId = "2115721", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234203", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000078", BitNumber = "1079"};
        public static readonly Materia GustyAttack_504234760 = new Materia { Name = "Gusty Attack", MateriaId = "504234760", Description = "ウェイビーアタック", CountId = "2212713", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234760", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000025", BitNumber = "1105"};
        public static readonly Materia ChocoboBattalion_504234761 = new Materia { Name = "Chocobo Battalion", MateriaId = "504234761", Description = "チョコボバタリオン", CountId = "2111318", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234761", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000007", BitNumber = "1106"};
        public static readonly Materia WaterArrow_504234205 = new Materia { Name = "Water Arrow", MateriaId = "504234205", Description = "ウォータリングアロー", CountId = "2290006", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234205", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000023", BitNumber = "1081"};
        public static readonly Materia Fringeward_504234206 = new Materia { Name = "Fringeward", MateriaId = "504234206", Description = "エリアバリア", CountId = "2290007", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234206", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000043", BitNumber = "1082"};
        public static readonly Materia SeeDUpperclassman_504234524 = new Materia { Name = "SeeD Upperclassman", MateriaId = "504234524", Description = "先輩SeeD", CountId = "2111315", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234524", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1094"};
        public static readonly Materia GunbladeWielderSeifer_504234522 = new Materia { Name = "Gunblade Wielder (Seifer)", MateriaId = "504234522", Description = "ガンブレードの使い手【サイファー】", CountId = "2171083", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234522", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1093"};
        public static readonly Materia TheMightiest_504234520 = new Materia { Name = "The Mightiest", MateriaId = "504234520", Description = "最も強き者", CountId = "2171082", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234520", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1092"};
        public static readonly Materia EvaJunction_504234531 = new Materia { Name = "Eva Junction", MateriaId = "504234531", Description = "回避ジャンクション", CountId = "2114036", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234531", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000075", BitNumber = "1095"};
        public static readonly Materia LuckJunction_504234532 = new Materia { Name = "Luck Junction", MateriaId = "504234532", Description = "運ジャンクション", CountId = "2179402", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234532", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000088", BitNumber = "1096"};
        public static readonly Materia STDefJunction_504234533 = new Materia { Name = "ST-Def Junction", MateriaId = "504234533", Description = "ST防御ジャンクション", CountId = "2114035", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234533", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000014", BitNumber = "1097"};
        public static readonly Materia LoveforTrabia_504234750 = new Materia { Name = "Love for Trabia", MateriaId = "504234750", Description = "トラビアへの想い", CountId = "2115726", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234750", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "1101"};
        public static readonly Materia ValuedMemories_504234752 = new Materia { Name = "Valued Memories", MateriaId = "504234752", Description = "大切な記憶", CountId = "2152601", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234752", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000079", BitNumber = "1102"};
        public static readonly Materia ElemDefJunction_504234754 = new Materia { Name = "Elem-Def Junction", MateriaId = "504234754", Description = "属性防御ジャンクション", CountId = "2153233", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234754", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000018", BitNumber = "1103"};
        public static readonly Materia GFExtension_504234755 = new Materia { Name = "GF Extension", MateriaId = "504234755", Description = "G.F.エクステンド", CountId = "2111317", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234755", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1104"};
        public static readonly Materia DestinedPrince_504235504 = new Materia { Name = "Destined Prince", MateriaId = "504235504", Description = "運命の王子", CountId = "2111326", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235504", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1131"};
        public static readonly Materia NightBloomingFlower_504235503 = new Materia { Name = "Night-Blooming Flower", MateriaId = "504235503", Description = "闇に咲く一輪花", CountId = "2113247", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235503", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000072", BitNumber = "1130"};
        public static readonly Materia FatedPrince_504235500 = new Materia { Name = "Fated Prince", MateriaId = "504235500", Description = "宿命の王子", CountId = "2113246", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235500", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1129"};
        public static readonly Materia H5ShockAbsorber_504234880 = new Materia { Name = "H5-Shock Absorber", MateriaId = "504234880", Description = "衝撃吸収装置H5", CountId = "2111320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234880", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000014", BitNumber = "1109"};
        public static readonly Materia KnowingTag_504234842 = new Materia { Name = "Knowing Tag", MateriaId = "504234842", Description = "ノーウィングタグ", CountId = "2111319", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234842", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "1107"};
        public static readonly Materia InheritingOnesFocus_504234846 = new Materia { Name = "Inheriting One's Focus", MateriaId = "504234846", Description = "使命の継承者", CountId = "2115727", EquipmentActiveAbility = "", EquipmentPassiveAbility = "234846", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "1108"};
        public static readonly Materia PhoenixSynergy_504235182 = new Materia { Name = "Phoenix Synergy", MateriaId = "504235182", Description = "フェニックスシナジー", CountId = "2113233", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235182", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1116"};
        public static readonly Materia DarkBahamutSynergy_504235180 = new Materia { Name = "Dark Bahamut Synergy", MateriaId = "504235180", Description = "ダークバハムートシナジー", CountId = "2115729", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235180", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "1115"};
        public static readonly Materia LakshmiSynergy_504235184 = new Materia { Name = "Lakshmi Synergy", MateriaId = "504235184", Description = "ラクシュミシナジー", CountId = "2111324", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235184", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000068", BitNumber = "1117"};
        public static readonly Materia WilltoFighttheDarkness_504235186 = new Materia { Name = "Will to Fight the Darkness", MateriaId = "504235186", Description = "闇に抗う意志", CountId = "2113240", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235186", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000072", BitNumber = "1118"};
        public static readonly Materia DragonConqueror_504235187 = new Materia { Name = "Dragon Conqueror", MateriaId = "504235187", Description = "討竜の力", CountId = "2115730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235187", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000079", BitNumber = "1119"};
        public static readonly Materia PoweroftheGems_504235286 = new Materia { Name = "Power of the Gems", MateriaId = "504235286", Description = "星宮のもたらす力", CountId = "2113242", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235286", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "1123"};
        public static readonly Materia PeopleoftheWoodArchery_504235284 = new Materia { Name = "People of the Wood: Archery", MateriaId = "504235284", Description = "森の民の弓術", CountId = "2113241", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235284", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "1122"};
        public static readonly Materia DesertBloom_504235282 = new Materia { Name = "Desert Bloom", MateriaId = "504235282", Description = "幼馴染への恋心", CountId = "2115731", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235282", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1121"};
        public static readonly Materia ABrothersSentiments_504235280 = new Materia { Name = "A Brother's Sentiments", MateriaId = "504235280", Description = "亡き兄への想い", CountId = "2154052", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235280", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "1120"};
        public static readonly Materia DoubleCatharsis_504231472 = new Materia { Name = "Double Catharsis", MateriaId = "504231472", Description = "ダブルカタリシス", CountId = "2135361", EquipmentActiveAbility = "", EquipmentPassiveAbility = "231472", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000077", BitNumber = "982"};
        public static readonly Materia GracefulFootwork_504235372 = new Materia { Name = "Graceful Footwork", MateriaId = "504235372", Description = "華麗なる足技使い", CountId = "2113243", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235372", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "1125"};
        public static readonly Materia SoldiersMight_1500000133 = new Materia { Name = "Soldier's Might", MateriaId = "1500000133", Description = "Saint's Might", CountId = "90134", EquipmentActiveAbility = "", EquipmentPassiveAbility = "914143", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90134"};
        public static readonly Materia FreezingEnchantment_1500000134 = new Materia { Name = "Freezing Enchantment", MateriaId = "1500000134", Description = "Freezing enchantment	", CountId = "90135", EquipmentActiveAbility = "", EquipmentPassiveAbility = "914144", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "90135"};
        public static readonly Materia SuccessionofMemories = new Materia { Name = "Succession of Memories", MateriaId = "504235696", Description = "受け継がれし記憶", CountId = "2112072", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235696", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "1140"};
        public static readonly Materia ThirdOffering = new Materia { Name = "Third Offering", MateriaId = "504235694", Description = "誰かを助けるのに理由がいるかい？", CountId = "2113250", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235694", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1139"};
        public static readonly Materia DesireforCycleofRebirth = new Materia { Name = "Desire for Cycle of Rebirth", MateriaId = "504235692", Description = "命の循環を願う者", CountId = "2115735", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235692", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1138"};
        public static readonly Materia TrancePower = new Materia { Name = "Trance Power", MateriaId = "504235690", Description = "トランスパワー", CountId = "2115734", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235690", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "1137"};
        public static readonly Materia RageBeastsRoar = new Materia { Name = "Rage Beast's Roar", MateriaId = "504235601", Description = "??????", CountId = "2290008", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235601", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "1135"};
        public static readonly Materia RageBeastsMight = new Materia { Name = "Rage Beast's Might", MateriaId = "504235602", Description = "????", CountId = "2113249", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235602", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1136"};
        public static readonly Materia SimplyMyself = new Materia { Name = "Simply Myself", MateriaId = "504235590", Description = "私は私", CountId = "2115732", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235590", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1132"};
        public static readonly Materia KnightsSpirit = new Materia { Name = "Knight's Spirit", MateriaId = "504235598", Description = "ナイトスピリット", CountId = "2113248", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235598", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "1133"};
        public static readonly Materia HuntClubAquan = new Materia { Name = "Hunt Club - Aquan", MateriaId = "504235599", Description = "ハントループ・水棲系", CountId = "2115733", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235599", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000079", BitNumber = "1134"};
        public static readonly Materia MasterofFate_504236244 = new Materia { Name = "Master of Fate", MateriaId = "504236244", Description = "運命の覇者", CountId = "2171033", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236051", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000076", BitNumber = "1152"};
        public static readonly Materia FightingDad_504236240 = new Materia { Name = "Fighting Dad", MateriaId = "504236240", Description = "戦う父ちゃん", CountId = "2113254", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236240", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1153"};
        public static readonly Materia NothingPersonal_504236242 = new Materia { Name = "Nothing Personal", MateriaId = "504236242", Description = "仕事の時間だぞ、と", CountId = "2114037", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236242", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1154"};
        public static readonly Materia MakoEnergy_504236246 = new Materia { Name = "Mako Energy", MateriaId = "504236246", Description = "魔晄エネルギー", CountId = "2113255", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236246", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "1155"};
        public static readonly Materia SaviorsofthePlanet_504236247 = new Materia { Name = "Saviors of the Planet", MateriaId = "504236247", Description = "星の命を守る者", CountId = "2111330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236247", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000078", BitNumber = "1156"};
        public static readonly Materia ANewPower_504236270 = new Materia { Name = "A New Power", MateriaId = "504236270", Description = "新しい力", CountId = "2171084", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "1157"};
        public static readonly Materia AFathersConviction_504236276 = new Materia { Name = "A Father's Conviction", MateriaId = "504236276", Description = "父の信念", CountId = "2151992", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236276", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "1160"};
        public static readonly Materia IllusionaryGun_504236272 = new Materia { Name = "Illusionary Gun", MateriaId = "504236272", Description = "ガンイリュージョン", CountId = "2113256", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236272", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1158"};
        public static readonly Materia TrainConductor_504236274 = new Materia { Name = "Train Conductor", MateriaId = "504236274", Description = "トレインコンダクター", CountId = "2111331", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236274", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000004", BitNumber = "1159"};
        public static readonly Materia LastJudgmentGrimoire_504235120 = new Materia { Name = "Last Judgment Grimoire", MateriaId = "504235120", Description = "真・断撃のグリモア", CountId = "2111323", EquipmentActiveAbility = "", EquipmentPassiveAbility = "235120", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "1114"};
        public static readonly Materia LegacyoftheAncients_504236415 = new Materia { Name = "Legacy of the Ancients", MateriaId = "504236415", Description = "古代種の遺産", CountId = "2112073", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236415", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "1163"};
        public static readonly Materia ShinraSupportSystem_504236416 = new Materia { Name = "Shinra Support System", MateriaId = "504236416", Description = "神羅式支援システム", CountId = "2113257", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236416", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "1164"};
        public static readonly Materia TheNewBoss_504236413 = new Materia { Name = "The New Boss", MateriaId = "504236413", Description = "新たな指導者", CountId = "2151993", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236413", ItemStack = "99", ItemBuyPrice = "200000", ItemSellPrice = "20000", ItemIdClone = "700000095", BitNumber = "1162"};
        public static readonly Materia APrayertoChangetheFuture_504236410 = new Materia { Name = "A Prayer to Change the Future", MateriaId = "504236410", Description = "未来を変える祈り", CountId = "2115738", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236410", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000018", BitNumber = "1161"};
        public static readonly Materia AwakenedDragon_504236540 = new Materia { Name = "Awakened Dragon", MateriaId = "504236540", Description = "目覚めし臥竜", CountId = "2113258", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236540", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000079", BitNumber = "1167"};
        public static readonly Materia CalloftheWild_504236417 = new Materia { Name = "Call of the Wild", MateriaId = "504236417", Description = "獣性の目覚め", CountId = "2173052", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236417", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "1165"};
        public static readonly Materia CoeurlsBlaster_504236418 = new Materia { Name = "Coeurl's Blaster", MateriaId = "504236418", Description = "ブラスター", CountId = "2216002", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236418", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000009", BitNumber = "1166"};
        public static readonly Materia SoCuteItsCriminal_504236544 = new Materia { Name = "So Cute It's Criminal", MateriaId = "504236544", Description = "罪な可愛さ", CountId = "2113259", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236544", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000083", BitNumber = "1169"};
        public static readonly Materia DreamofBecomingMadam_504236542 = new Materia { Name = "Dream of Becoming Madam", MateriaId = "504236542", Description = "マダムになる夢", CountId = "2112074", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236542", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1168"};
        public static readonly Materia DemonicDestruction_504236548 = new Materia { Name = "Demonic Destruction", MateriaId = "504236548", Description = "壊魔の力", CountId = "2113260", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236548", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000079", BitNumber = "1170"};
        public static readonly Materia SnowstormKatana_504236549 = new Materia { Name = "Snowstorm Katana", MateriaId = "504236549", Description = "破氷の操刀術", CountId = "2151994", EquipmentActiveAbility = "", EquipmentPassiveAbility = "236549", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "1171"};
/*VersionControldefinitions*/
























		public static readonly List<Materia> Materias = new List<Materia>
		{
           Libra,
           Cure,
           Blindna,
           Vox,
           Poisona,
           Banish,
           Paralyna,
           Stona,
           Esuna,
           Regen,
           Cleanse,
           Holy,
           Fire,
           Blizzard,
           Thunder,
           Water,
           Aero,
           Stone,
           Bio,
           Fira,
           Blizzara,
           Thundara,
           Watera,
           Aerora,
           Stonra,
           Gravity,
           Drain,
           Biora,
           Firaga,
           Blizzaga,
           Thundaga,
           Flare,
           Ultima,
           Sleep_504030010,
           Blind,
           Barfire,
           Barblizzard,
           Barthunder,
           Barwater,
           Baraero,
           Barstone,
           Silence,
           Barfira,
           Barblizzara,
           Barthundara,
           Shell,
           Deprotect,
           Deshell,
           Barwatera,
           Baraerora,
           Barstonra,
           HP_504100010,
           MP_504100040,
           MP_504100050,
           ATK_504100070,
           ATK_504100080,
           MAG_504100120,
           AutoLimit,
           EquipSSword,
           EquipLSword,
           EquipStaff,
           EquipHArmor,
           StoneKiller,
           MachineKiller,
           DragonKiller_504101050,
           AquanKiller,
           Cover,
           Counter,
           Evade,
           Camouflage,
           Doublehand,
           DualWield_504101370,
           Steal,
           Pilfer,
           Drink,
           Brace,
           Throw,
           Store,
           RagingFist,
           Escape,
           Barrage,
           MirrorofEquity,
           Aim,
           Bladeblitz,
           FireBlade,
           BlizzardBlade,
           SilenceBlade,
           WaterBlade,
           StoneBlade,
           BlindBlade,
           BioBlade,
           DrainBlade,
           ThundagaBlade,
           BiogaBlade,
           MagicInfuse,
           Lullaby,
           Paean,
           MentalBreak,
           SilenceDance,
           FireBeam,
           BlizzardBeam,
           BioBlaster,
           PowerShot,
           Sunbeam,
           Meteor,
           Comet,
           Protect,
           SPR_504100160,
           BugKiller_504101020,
           Cura,
           DEF_504100130,
           EquipBow,
           Bravery,
           ATK_504100090,
           MAG_504100100,
           MP_504100060,
           HolyBlade,
           KatanaMastery,
           LightsBlessing,
           Dispel,
           Faith,
           HP_504100030,
           EquipAxe,
           EquipHat,
           SpiritSlayer,
           HP_504101500,
           SleepBlade,
           AeroBlade,
           StonraBlade,
           MelodyofLife,
           SealofDestruction_504201950,
           SealofProtection,
           GoddesssProtection,
           EquipHShield,
           Dualcast,
           Curada,
           EVOMAG_504100190,
           PlantKiller_504101000,
           WateraBlade,
           SecondWind,
           CrushArmor,
           Medicate,
           StoneThrow,
           EquipSpear,
           Thunderfall,
           HereWeGo,
           Attacker,
           Defender,
           StickyFingers,
           CoinSteal,
           LungeCombo,
           BurstShot,
           AutoProtect,
           EquipRod,
           BioraBlade,
           Acceptance,
           Knowledge,
           Ignorance,
           Discernment,
           Accelerate,
           Twinspell,
           InsulttoInjury,
           CutCards,
           Mentality,
           LettersandArms,
           ManasProtection,
           ManasBlessing,
           DeepThoughts,
           FairyWisdom,
           Mana,
           FullMoonSlash,
           AutoShell,
           OsmoseBlade,
           SyldrasProtection,
           Wisdom,
           Action,
           Innocence,
           Tranquility,
           GateofDestiny,
           WhiteKnight,
           TemperedShield,
           ImperialHelm,
           MP_504203240,
           ATK_504101600,
           DarkBond,
           WaterGodsProtection,
           Breaker,
           DemonicLife,
           DestroyersAuthority,
           GuardiansAuthority,
           PowerofCreation,
           DarkResistance_504207720,
           ChillingAura,
           SpookyAura,
           SealofDestruction_1500000003,
           MAG_504101700,
           Death,
           EquipClothes,
           ManEater_504101040,
           BirdKiller,
           AutoPotion,
           PowerBreak,
           MagicBreak,
           MiracleStep,
           CrushHelm,
           HealingWaltzII,
           Poach,
           FirstStrike,
           Lifefont,
           QuickAssault,
           DarkKnightsSoul,
           HillDigger,
           Successor,
           Magician,
           Fighter,
           SeethingCauldron,
           SwellingPower,
           BushidoFreedom,
           DomineeringSpirit,
           Scorch,
           MightyDefense,
           InstinctualGuard,
           ThunderBlade,
           ArmorBreak,
           MetalSlash,
           HustleDance,
           WaveofPanic,
           UndeadKiller,
           ElementalDamageDown,
           EmperorsMajesty,
           HereticsAbyss,
           Resuscitate,
           Love,
           Resolve,
           Persistence,
           SiphonDelta,
           Multitask,
           AzureHelm,
           AzureArmor,
           AutoRefresh,
           EquipLShield,
           MageCannon,
           LargeSwordMastery,
           DivineSeal,
           ProtectionoftheTwelve,
           ShardofGenius,
           FollowersOath,
           HydaelynGuard,
           BeastKiller,
           Returner,
           WarriorMage,
           ToxicRain,
           RodMastery,
           RageMeteor,
           LightResistance_504208900,
           HealersWisdom,
           DEF_504208970,
           SPR_504208980,
           NullParalysis,
           DemonKiller,
           EquipFists,
           WarriorLore,
           MagesMonograph,
           Imperil,
           PatrioticRecall,
           Curaga,
           DEF_504100140,
           ManufactedNethicite,
           EarthResistance_504209550,
           PureHeart,
           WinterWard,
           Deliverance,
           FirewallPower,
           SymphonicFlair,
           LightspeedJab,
           Cheerleader,
           ElvenPride,
           PoisonResistance,
           ProudFencer,
           HeavensGuidance,
           March,
           Vigilance,
           SPR_504100170,
           WindResistance_504210660,
           FalseSaint,
           SwornSixsPrideDark,
           SwornSixsPrideFire,
           SwornSixsPrideEarth,
           ConfusionResistance,
           MogSearch,
           MogSong,
           MogStep,
           MogResist,
           MogRise,
           MartialArtsMastery,
           WorldDestroyer,
           MogWisdom,
           HeartofFire,
           HeartofWater,
           HeartofWind,
           HeartofEarth,
           SwornSixsPrideLight,
           SwornSixsPrideWind,
           SwornSixsPrideWater,
           SleepResistance,
           WaterResistance_504212350,
           Relax,
           EvasivenessSmall,
           GreatEarplugs,
           GuardoftheFuture,
           ThirstforSurvival,
           LightningResistance_504213700,
           DarknesssFoe,
           LightsFoe,
           MPStroll,
           GeneralOffensive,
           MAG_504100110,
           EquipInstrument,
           Darkra,
           FiraBlade,
           AwesomeSwordsman,
           PureWhiteBlessing,
           HighSpirits,
           NA,
           DragonKiller_504211360,
           MagesResolution,
           BusterStyle,
           IceResistance_504215180,
           Powerful,
           Toughness,
           ProofofTalent,
           BlindResistance,
           Encore,
           EchidnasKiss,
           Renewal,
           SpiritofFreedom,
           SagesPrajna,
           Adventurer,
           AdventurerII,
           AdventurerIII,
           AdventurerIV,
           AdventurerV,
           AeroraBlade,
           DreamMaidensOracle,
           CrazyDay,
           StaffMastery,
           BlizzaraBlade,
           HPStroll,
           LoyalWarrior,
           ColdDefense,
           ThunderDefense,
           FireResistance_504216400,
           DragoonsPride,
           BarrierMaster,
           NullDisease,
           BlackImpulse,
           FrozenHurricane,
           Spirit,
           Girder,
           ThundaraBlade,
           HatArts,
           LightResistance_504216040,
           PetrificationResistance,
           Broadminded,
           AzureCrimsonSoul,
           StrategistsIngenuity,
           MechanicalHeart,
           VengefulWrath,
           YevonsWisdom,
           PowerofPurification,
           ArtofPurification,
           IceResistance_504219240,
           CradleofHorns,
           LShieldArts,
           DualWield_504219270,
           UncollapsingWill,
           Hammersmith,
           SilenceResistance,
           SageofMysidia,
           ManEater_504219910,
           Resentment,
           Regenerator,
           ReactiveDefense,
           MalborosWhisper,
           RhythmicFlair,
           Casanova,
           WaterMaidenBlessing,
           CodexofSwordMaster,
           FullMoon,
           BlightedDespot,
           DrownedKing,
           LunariansHate,
           BarbaricciasSpirit,
           Graviga,
           TrueShardofGenius,
           TrueFollowersOath,
           TrueHydaelynGuard,
           TrueSpiritofFreedom,
           TrueSagesPrajna,
           Refresh,
           KatanaEnchantment,
           HeavyChimera,
           AntiDisaster,
           Battler,
           BeastsHeart,
           HalfelfsHeart,
           KnightofGemma,
           Brawn,
           Intrique,
           HP_504100020,
           WindResistance_504220650,
           GreatMagesChant,
           NatureLovingSpellblade,
           MoodMaker,
           HArmorArts,
           CalamityBorder,
           CallousStrategist,
           ImperialTalent,
           SpiritFighter,
           SpiritMagician,
           AutoBravery,
           AutoFaith,
           EarthResistance_504221640,
           ChosenOne,
           ShadowBearer,
           AgnsCrystalguardCaptain,
           FragmentofThought,
           EquipHelm,
           PurebredSummoner,
           MonksEnlightenment,
           AttackCastleWarfare,
           MagicCastleWarfare,
           MentalClarity,
           LionsAwakening,
           Sleep_504221740,
           DarkResistance_504223800,
           Raise,
           DualWhiteMagic,
           EVOMAG_504223810,
           Kappower,
           AxeProfessional,
           HungryWolf,
           Quintessence,
           BarrierMagesOath,
           ThunderousAvoidance,
           NebulousAvoidance,
           BombSpirit,
           BombArms,
           FireResistance_504213160,
           EquipSword,
           ModishWitch,
           Necropolis,
           SeedofHope,
           FortitudeandVigor,
           WaterResistance_504213170,
           MagesHope,
           KnightsHope,
           RulingFiend,
           HerosVowDark,
           CheerfulTune,
           InstrumentalFlair,
           MagicSanctuary,
           JoyfulSpirit,
           TurbulentEvasion,
           CoweredCourage,
           UnmatchedWizardry,
           WhiteKnightsSoul,
           TombRaider,
           PoweroftheSands,
           CroftsIntuition,
           OffensiveDefense,
           SpiritualWrath,
           MagicalOffensive,
           DemonBanisher,
           NagasProtection,
           IntenseDetermination,
           MotherlyLove,
           VagrantKnight,
           ProtectorofLapis,
           TheSubservient,
           DarkSwordArts,
           OriginalArrival,
           DreamoftheFayth,
           CorruptEmperor,
           OnionKnightsMission,
           PanzerOmega,
           WaveCannon,
           LightningResistance_504226896,
           PhysicalForce,
           MagicalForce,
           SwiftHunter,
           WhipMastery,
           BraveLancer,
           TwinRepellent,
           TheLordoftheUnderworld,
           TheKingofBeasts,
           DevilishDesigns,
           DevourerofShadows,
           ReduceEncounter,
           BraveAdventurer,
           FaithfulAdventurer,
           PlantKiller_504222190,
           EquipRobe,
           WitchsCackle,
           ForceMysterion,
           DarkAspirations,
           HexatheonsRevelation,
           LoyalGeneral,
           EssenceofSummoning,
           ALionsHeart,
           WingedHeart,
           DragonofAffection,
           WhiteHeart,
           KeepingBacktheDark,
           Metamalboro,
           BadBreath,
           FireproofAspiration,
           WaterproofAspiration,
           HolyKnight,
           KalivasGuidance,
           TechnicalAttacker,
           ZodiacShot,
           TruthSeeker,
           ShieldoftheChosenKing,
           BoosterCactuar,
           PureLotus,
           Skylancer,
           EXP_504227640,
           EXP_504227641,
           BraveSoul,
           HerosVowLight,
           MachinePower,
           FeelingsforPlatina,
           GemofCreation,
           GemofVision,
           SoaringHeart,
           PastRegrets,
           PoweroftheLastDragon,
           MagicoftheLastDragon,
           UnquestionableLoyalty,
           TwistedHero,
           BloodoftheDragon,
           GustMane,
           MagicalPotential,
           GenjiTactics,
           Adamantine,
           MiracleMagic,
           MHumanMachineKiller,
           IronBody,
           Restraint,
           SoaringLegendaryDragon,
           SecretofMana,
           SpearofthePrincess,
           ProudThief,
           HeartofaRabite,
           Opposition,
           Kindness,
           Heroism,
           AkademeiaSupportAttack,
           AkademeiaSupportDefense,
           DancingDoll,
           DollsEye,
           GunMastery,
           HerosVowEarth,
           ShadowWarrior,
           LarasIntuition,
           WisdomofHess,
           BlacksmithsDaughter,
           DarkKnightsKnowledge,
           InheritedMagic,
           InheritedSpirit,
           BugKiller_504224890,
           ScorpionStinger,
           KeepersGate,
           DefendersBarrier,
           MidfieldersPotential,
           StrikersRoundhouse,
           GunUpgrade,
           FrigoandEtcetera,
           Distraction,
           DivineBlessing,
           ScholarlyWisdom,
           MagicalRecollection,
           CerebralAugmentation,
           TF29Agent,
           EnergyConverter,
           MarchenkosSecrets,
           TimeMachinesSecrets,
           RidersInstinct,
           SplashofLife,
           DragoonsWisdom,
           JudgesOath,
           DemonsGambit,
           GrimBrilliance,
           MaliciousAura,
           MaleficHeart,
           ChaoticFerocity,
           Executioner,
           GentleTraitor,
           KatanaProficiency,
           SpiritualProficiency,
           DemonicMight,
           DemonicMind,
           Vampyrism,
           LightsVengeance,
           Spiritualism,
           InstrumentalRhythm,
           AnimatedEssence,
           NoelsLegacy,
           WinterChild,
           UnforgivingBlade,
           WinterMagic,
           WinterSpirit,
           AssertiveGrowth,
           HeartsLight,
           AwkwardFatherlyLove,
           LegendaryGuardian,
           CognizantoftheTruth,
           ExorcismPower,
           ExorcismTechnique,
           HerosVowWater,
           ReaperoftheDustStorm,
           JumpingTechnique,
           EverlastingKindness,
           TranscendentSoul,
           CombatFinesse,
           Sharpshooter,
           Strength,
           Etherize,
           PowerofId,
           MothersReturn,
           DistantPromise,
           BattlingChamp,
           PluckyOoki,
           MargiesWish,
           MysticRobes,
           Shielder,
           Soulful,
           MultiMeleeMaster,
           GuardianofShevat,
           SaintsAura,
           WarriorsIntuitionATK,
           WarriorsIntuitionDEF,
           AcceleratingPower,
           WarGoddessInsignia_504230005,
           HerosVowFire,
           BrushUp,
           SoulofDarkness,
           HerosVowWind,
           Artistic,
           MagicCharger,
           PhysicalBooster,
           MagicalBooster,
           UntrueSaint,
           HuntersTrade,
           DragonsTribe,
           IronGiantsArmor,
           ProgressionofFervor,
           ProgressionofBelief,
           AHerosBond,
           HeartOvercomingHatred,
           HeartBoundbyHatred,
           FullMoonsGuidance,
           NewMoonsGuidance,
           LunarianComprehension,
           DisparateSwordsman,
           YinYangDualHand,
           WhipExpert,
           TwoForOne,
           MasterofMachinery,
           LongTrainingPaysOff,
           FraternalPower,
           FraternalWisdom,
           BeachGirls,
           CoolBeauty,
           EquipWhip,
           GuardianofThunder,
           HonorableRodArts,
           BattleIntelligence,
           PlanetWhisperer,
           EverlastingFantasy,
           FortunasFaith,
           TechniqueoftheAncients,
           KnowledgeoftheAncients,
           SwordMastery,
           ChocoboStamina,
           MagicalChocobo,
           ChocoboAdventure,
           ElegantGunner,
           AllinHarmony,
           SpiritualDefense,
           SuccessorsTalent,
           WarriorsMight,
           ElectrifyingMight,
           TrueHero,
           WutaiNinja,
           WarrioroftheCrystal,
           EmpresssSignet,
           ImperialAmbitions,
           ThirdAnniversaryPartyGuest,
           SanctumsMilitantArt,
           SanctumsMilitantLaw,
           DualForm,
           ShiningGuardianofHope,
           SeaDragon,
           ScepterofJustice,
           EngulfingLight,
           WanderingWarrior,
           DreamsofaWiderWorld,
           Faithshallbemyshield,
           JewelofStrength,
           JewelofProtection,
           TranquilHealing,
           AweInspiringOrigin,
           CastleExdeathStormIn,
           CastleExdeathIllusionPerception,
           DodgeRoll,
           MPHaste,
           HeartsDarkness,
           SamuraisMight,
           FlowingMight,
           PhantomForce,
           LifeoftheLaboratory,
           BoundlessLove,
           WayoftheDragon,
           ChannelAnger,
           DivineIntervention,
           WeaponsSpecialist,
           DarkKnightsAuthority,
           WildRoseWarrior,
           WildRoseMage,
           GirlEntrustedWithHope,
           WarriorfromAnotherWorld,
           OvercomingDeath,
           HeartsAgainsttheVoid,
           ILoveChocobos,
           KnowledgeofKatanasandRods,
           HeartlessAssassin,
           CorruptedMage,
           FierceGreatswordUser,
           RulersMight,
           ProtecttheEspersPhysical,
           ProtecttheEspersMagic,
           LovesWhereabouts,
           FirstRateTreasureHunter,
           FortuneTellersVision,
           ChivalrySkills,
           TheStrategist,
           SupremeSentinel,
           NickersKnack,
           TheBeginningoftheEnd,
           AllureSkills,
           PuffPuff,
           SpyofAllTrades,
           SuitUp,
           LocktekCipher,
           TopOperative,
           AdvancedWeaponry,
           EveryDemonsRushin,
           AuroralAura,
           TwinGunner,
           CrossingtheLand,
           TheAstralsProtection,
           MarkoftheGlacian,
           DutytotheWorld,
           SistersofWinter,
           SorceressofHess,
           KnightofChaos,
           UndyingVengeance,
           KingofLucisCharacter,
           EnduringFlame,
           BladeArtSuccession,
           BattleAdvantage,
           HeavenlyPresence,
           SPR_504100180,
           LastStand,
           StubbornOx,
           ProdigiesofMysidia,
           MarkofthePaladin,
           LovingSpirit,
           FlurryofPetals,
           LukasValentineRecipe,
           IcyPassion,
           LoveisVital,
           LoveisMagical,
           CupidsBlessing,
           DemonKingsPower,
           TapestryofChaos,
           TwinSwordsMastery,
           LeaderoftheSoiree,
           WarGoddessInsignia_504232200,
           EquipGun,
           ExploringtheDepths,
           Deconstruction,
           DanceMaster,
           BondswiththeAeons,
           RonsoGuardian,
           AceofAces,
           OriginatoroftheFinalSummoning,
           KnowledgeofAeons,
           HighClassDagger,
           RookieSphereHunter,
           TheLivingofSpira_504232790,
           TheLivingofSpira_504232791,
           TidalWaves,
           SurpassingtheLegend,
           DEF,
           FundamentalsofAlchemy,
           IshvalsHero,
           KnowledgeoftheTruth,
           PhilosophersStoneSeeker,
           TheHawksEye,
           LongReach_504232401,
           Thievery_504232450,
           MasterDragonKnight_504232452,
           BlackMagesPotential_504232454,
           BurmeciasStrongestDragonKnight_504232456,
           CourtJesters_504232457,
           ExceptionalIngenuity_504232511,
           WingsthatTranscendTime_504234420,
           PhantasmicMelody_504233464,
           DiabolosSynergy_504233455,
           IfritSynergy_504233450,
           BahamutSynergy_504233452,
           AsuraSynergy_504233456,
           ScionSorceress_504232670,
           WiseintheWaysofMagic_504232671,
           GiftedSorceresssKnowledge_504232603,
           DropfromtheHolyGrail_504232605,
           UnfalteringFist_504233913,
           CouragetoMoveOn_504233910,
           MotherSeekingHeart_504233915,
           WaterFFVIIAC_504233919,
           BlackWater_504233920,
           Needles_504234022,
           RunAway_504234023,
           BrawlersMight_1500000129,
           ObscureMight_1500000130,
           AlexanderSynergy_504233566,
           TetraSylphidSynergy_504233564,
           OdinSynergy_504233562,
           FenrirSynergy_504233569,
           StrengthOverChaos_1500000131,
           MindOverChaos_1500000132,
           OerbasBoon_504234461,
           MemoriesofRagnarok_504234463,
           DeterminationtoPullThrough_504234465,
           LoomingWrath_504234466,
           EtrosChampion_504234204,
           EnchantingArcher_504234201,
           LastGuardian_504234202,
           AcademiasProdigy_504234203,
           GustyAttack_504234760,
           ChocoboBattalion_504234761,
           WaterArrow_504234205,
           Fringeward_504234206,
           SeeDUpperclassman_504234524,
           GunbladeWielderSeifer_504234522,
           TheMightiest_504234520,
           EvaJunction_504234531,
           LuckJunction_504234532,
           STDefJunction_504234533,
           LoveforTrabia_504234750,
           ValuedMemories_504234752,
           ElemDefJunction_504234754,
           GFExtension_504234755,
           DestinedPrince_504235504,
           NightBloomingFlower_504235503,
           FatedPrince_504235500,
           H5ShockAbsorber_504234880,
           KnowingTag_504234842,
           InheritingOnesFocus_504234846,
           PhoenixSynergy_504235182,
           DarkBahamutSynergy_504235180,
           LakshmiSynergy_504235184,
           WilltoFighttheDarkness_504235186,
           DragonConqueror_504235187,
           PoweroftheGems_504235286,
           PeopleoftheWoodArchery_504235284,
           DesertBloom_504235282,
           ABrothersSentiments_504235280,
           DoubleCatharsis_504231472,
           GracefulFootwork_504235372,
           SoldiersMight_1500000133,
           FreezingEnchantment_1500000134,
           SuccessionofMemories,
           ThirdOffering,
           DesireforCycleofRebirth,
           TrancePower,
           RageBeastsRoar,
           RageBeastsMight,
           SimplyMyself,
           KnightsSpirit,
           HuntClubAquan,
           MasterofFate_504236244,
           FightingDad_504236240,
           NothingPersonal_504236242,
           MakoEnergy_504236246,
           SaviorsofthePlanet_504236247,
           ANewPower_504236270,
           AFathersConviction_504236276,
           IllusionaryGun_504236272,
           TrainConductor_504236274,
           LastJudgmentGrimoire_504235120,
           LegacyoftheAncients_504236415,
           ShinraSupportSystem_504236416,
           TheNewBoss_504236413,
           APrayertoChangetheFuture_504236410,
           AwakenedDragon_504236540,
           CalloftheWild_504236417,
           CoeurlsBlaster_504236418,
           SoCuteItsCriminal_504236544,
           DreamofBecomingMadam_504236542,
           DemonicDestruction_504236548,
           SnowstormKatana_504236549,
/*VersionControldefinitionsList*/























		};
    }
}