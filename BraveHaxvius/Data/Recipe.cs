//MST_RECIPEBOOK_NAME_903020830^Soiree Steward's Clothes+^Soiree Steward's Clothes+---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Recipe
    {
        public String Name { get; set; }
        public String RecipeBookId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String Gil { get; set; }

        public static readonly Recipe Potion = new Recipe { Name = "Potion", RecipeBookId = "901000010", Description = "ポーション", CountId = "1", Gil = "30"};
        public static readonly Recipe HiPotion = new Recipe { Name = "Hi-Potion", RecipeBookId = "901000020", Description = "ハイポーション", CountId = "2", Gil = "150"};
        public static readonly Recipe Ether = new Recipe { Name = "Ether", RecipeBookId = "901000040", Description = "エーテル", CountId = "3", Gil = "150"};
        public static readonly Recipe Antidote = new Recipe { Name = "Antidote", RecipeBookId = "901000080", Description = "毒消し", CountId = "4", Gil = "30"};
        public static readonly Recipe EyeDrops = new Recipe { Name = "Eye Drops", RecipeBookId = "901000090", Description = "目薬", CountId = "5", Gil = "30"};
        public static readonly Recipe SmellingSalts = new Recipe { Name = "Smelling Salts", RecipeBookId = "901000100", Description = "気付け薬", CountId = "6", Gil = "60"};
        public static readonly Recipe EchoHerbs = new Recipe { Name = "Echo Herbs", RecipeBookId = "901000110", Description = "やまびこ草", CountId = "7", Gil = "60"};
        public static readonly Recipe UnicornHorn = new Recipe { Name = "Unicorn Horn", RecipeBookId = "901000120", Description = "ユニコーンの角", CountId = "8", Gil = "150"};
        public static readonly Recipe Vaccine = new Recipe { Name = "Vaccine", RecipeBookId = "901000130", Description = "ワクチン", CountId = "9", Gil = "600"};
        public static readonly Recipe GoldNeedle = new Recipe { Name = "Gold Needle", RecipeBookId = "901000140", Description = "金の針", CountId = "10", Gil = "150"};
        public static readonly Recipe Remedy = new Recipe { Name = "Remedy", RecipeBookId = "901000150", Description = "万能薬", CountId = "11", Gil = "300"};
        public static readonly Recipe Hyper = new Recipe { Name = "Hyper", RecipeBookId = "901000160", Description = "興奮剤", CountId = "12", Gil = "300"};
        public static readonly Recipe HealingSpring = new Recipe { Name = "Healing Spring", RecipeBookId = "901000190", Description = "回復の泉", CountId = "13", Gil = "300"};
        public static readonly Recipe SmokeScreen = new Recipe { Name = "Smoke Screen", RecipeBookId = "901000200", Description = "煙玉", CountId = "14", Gil = "30"};
        public static readonly Recipe BodyBoost = new Recipe { Name = "Body Boost", RecipeBookId = "901000230", Description = "力の薬", CountId = "15", Gil = "300"};
        public static readonly Recipe ManaTablet = new Recipe { Name = "Mana Tablet", RecipeBookId = "901000240", Description = "魔力の薬", CountId = "16", Gil = "300"};
        public static readonly Recipe ProtectDrink = new Recipe { Name = "Protect Drink", RecipeBookId = "901000250", Description = "プロテスドリンク", CountId = "17", Gil = "150"};
        public static readonly Recipe ShellDrink = new Recipe { Name = "Shell Drink", RecipeBookId = "901000260", Description = "シェルドリンク", CountId = "18", Gil = "150"};
        public static readonly Recipe BacchussWine = new Recipe { Name = "Bacchus's Wine", RecipeBookId = "901000270", Description = "バッカスの酒", CountId = "19", Gil = "100"};
        public static readonly Recipe Grenade = new Recipe { Name = "Grenade", RecipeBookId = "901000440", Description = "手榴弾", CountId = "20", Gil = "60"};
        public static readonly Recipe FragGrenade = new Recipe { Name = "Frag Grenade", RecipeBookId = "901000450", Description = "徹甲手榴弾", CountId = "21", Gil = "300"};
        public static readonly Recipe Shuriken = new Recipe { Name = "Shuriken", RecipeBookId = "901000460", Description = "手裏剣", CountId = "22", Gil = "150"};
        public static readonly Recipe FumaShuriken = new Recipe { Name = "Fuma Shuriken", RecipeBookId = "901000470", Description = "風魔手裏剣", CountId = "23", Gil = "300"};
        public static readonly Recipe Tent = new Recipe { Name = "Tent", RecipeBookId = "901000490", Description = "テント", CountId = "24", Gil = "150"};
        public static readonly Recipe MagicKey = new Recipe { Name = "Magic Key", RecipeBookId = "901000500", Description = "魔法の鍵", CountId = "25", Gil = "0"};
        public static readonly Recipe BronzeKnife = new Recipe { Name = "Bronze Knife", RecipeBookId = "903000010", Description = "ブロンズナイフ", CountId = "26", Gil = "30"};
        public static readonly Recipe Dagger = new Recipe { Name = "Dagger", RecipeBookId = "903000020", Description = "ダガー", CountId = "27", Gil = "60"};
        public static readonly Recipe SleepDagger = new Recipe { Name = "Sleep Dagger", RecipeBookId = "903000040", Description = "スリプルダガー", CountId = "28", Gil = "150"};
        public static readonly Recipe Broadsword = new Recipe { Name = "Broadsword", RecipeBookId = "903000080", Description = "ブロードソード", CountId = "29", Gil = "60"};
        public static readonly Recipe LongSword = new Recipe { Name = "Long Sword", RecipeBookId = "903000090", Description = "ロングソード", CountId = "30", Gil = "120"};
        public static readonly Recipe GreatSword = new Recipe { Name = "Great Sword", RecipeBookId = "903000160", Description = "グレートソード", CountId = "31", Gil = "450"};
        public static readonly Recipe BusterSword = new Recipe { Name = "Buster Sword", RecipeBookId = "903000180", Description = "バスターソード", CountId = "32", Gil = "450"};
        public static readonly Recipe Kotetsu = new Recipe { Name = "Kotetsu", RecipeBookId = "903000210", Description = "虎鉄", CountId = "33", Gil = "420"};
        public static readonly Recipe Kikuichimonji = new Recipe { Name = "Kiku-ichimonji", RecipeBookId = "903000220", Description = "菊一文字", CountId = "34", Gil = "420"};
        public static readonly Recipe Kazekiri = new Recipe { Name = "Kazekiri", RecipeBookId = "903000230", Description = "風切りの刃", CountId = "35", Gil = "420"};
        public static readonly Recipe Kodachi = new Recipe { Name = "Kodachi", RecipeBookId = "903000270", Description = "小太刀", CountId = "36", Gil = "420"};
        public static readonly Recipe BattleAxe = new Recipe { Name = "Battle Axe", RecipeBookId = "903000290", Description = "バトルアクス", CountId = "37", Gil = "540"};
        public static readonly Recipe GreatAxe = new Recipe { Name = "Great Axe", RecipeBookId = "903000300", Description = "グレートアクス", CountId = "38", Gil = "540"};
        public static readonly Recipe WoodenHammer = new Recipe { Name = "Wooden Hammer", RecipeBookId = "903000360", Description = "木づち", CountId = "39", Gil = "102"};
        public static readonly Recipe IronHammer = new Recipe { Name = "Iron Hammer", RecipeBookId = "903000370", Description = "アイアンハンマー", CountId = "40", Gil = "204"};
        public static readonly Recipe WarHammer = new Recipe { Name = "War Hammer", RecipeBookId = "903000380", Description = "ウォーハンマー", CountId = "41", Gil = "510"};
        public static readonly Recipe BronzeMace = new Recipe { Name = "Bronze Mace", RecipeBookId = "903000420", Description = "ブロンズメイス", CountId = "42", Gil = "54"};
        public static readonly Recipe IronMace = new Recipe { Name = "Iron Mace", RecipeBookId = "903000430", Description = "アイアンメイス", CountId = "43", Gil = "108"};
        public static readonly Recipe Javelin = new Recipe { Name = "Javelin", RecipeBookId = "903000470", Description = "ジャベリン", CountId = "44", Gil = "192"};
        public static readonly Recipe Partisan = new Recipe { Name = "Partisan", RecipeBookId = "903000480", Description = "パルチザン", CountId = "45", Gil = "480"};
        public static readonly Recipe BronzeKnuckles = new Recipe { Name = "Bronze Knuckles", RecipeBookId = "903000580", Description = "ブロンズナックル", CountId = "46", Gil = "60"};
        public static readonly Recipe MetalKnuckles = new Recipe { Name = "Metal Knuckles", RecipeBookId = "903000590", Description = "メタルナックル", CountId = "47", Gil = "120"};
        public static readonly Recipe CatClaws = new Recipe { Name = "Cat Claws", RecipeBookId = "903000640", Description = "猫の爪", CountId = "48", Gil = "900"};
        public static readonly Recipe Rod = new Recipe { Name = "Rod", RecipeBookId = "903000660", Description = "ロッド", CountId = "49", Gil = "42"};
        public static readonly Recipe IronRod = new Recipe { Name = "Iron Rod", RecipeBookId = "903000670", Description = "アイアンロッド", CountId = "50", Gil = "84"};
        public static readonly Recipe Staff = new Recipe { Name = "Staff", RecipeBookId = "903000720", Description = "杖", CountId = "51", Gil = "48"};
        public static readonly Recipe CherryStaff = new Recipe { Name = "Cherry Staff", RecipeBookId = "903000730", Description = "サクラの杖", CountId = "52", Gil = "96"};
        public static readonly Recipe WizardsStaff = new Recipe { Name = "Wizard's Staff", RecipeBookId = "903000750", Description = "魔道士の杖", CountId = "53", Gil = "240"};
        public static readonly Recipe RuneStaff = new Recipe { Name = "Rune Staff", RecipeBookId = "903000760", Description = "ルーンの杖", CountId = "54", Gil = "240"};
        public static readonly Recipe ShortBow = new Recipe { Name = "Short Bow", RecipeBookId = "903000790", Description = "ショートボウ", CountId = "55", Gil = "78"};
        public static readonly Recipe LongBow = new Recipe { Name = "Long Bow", RecipeBookId = "903000800", Description = "ロングボウ", CountId = "56", Gil = "156"};
        public static readonly Recipe GreatBow = new Recipe { Name = "Great Bow", RecipeBookId = "903000820", Description = "グレートボウ", CountId = "57", Gil = "390"};
        public static readonly Recipe Altair = new Recipe { Name = "Altair", RecipeBookId = "903000850", Description = "アルタイル", CountId = "58", Gil = "144"};
        public static readonly Recipe LeatherWhip = new Recipe { Name = "Leather Whip", RecipeBookId = "903000920", Description = "レザーウィップ", CountId = "59", Gil = "54"};
        public static readonly Recipe ChainWhip = new Recipe { Name = "Chain Whip", RecipeBookId = "903000930", Description = "チェンウィップ", CountId = "60", Gil = "108"};
        public static readonly Recipe Boomerang = new Recipe { Name = "Boomerang", RecipeBookId = "903000970", Description = "ブーメラン", CountId = "61", Gil = "60"};
        public static readonly Recipe Chakram = new Recipe { Name = "Chakram", RecipeBookId = "903000980", Description = "チャクラム", CountId = "62", Gil = "120"};
        public static readonly Recipe MoonRingBlade = new Recipe { Name = "Moon Ring Blade", RecipeBookId = "903000990", Description = "円月輪", CountId = "63", Gil = "300"};
        public static readonly Recipe Harp = new Recipe { Name = "Harp", RecipeBookId = "903001020", Description = "ハープ", CountId = "64", Gil = "48"};
        public static readonly Recipe SilverHarp = new Recipe { Name = "Silver Harp", RecipeBookId = "903001030", Description = "銀の竪琴", CountId = "65", Gil = "96"};
        public static readonly Recipe LeatherShield = new Recipe { Name = "Leather Shield", RecipeBookId = "904000010", Description = "皮の盾", CountId = "66", Gil = "72"};
        public static readonly Recipe SmallShield = new Recipe { Name = "Small Shield", RecipeBookId = "904000020", Description = "スモールシールド", CountId = "67", Gil = "72"};
        public static readonly Recipe Buckler = new Recipe { Name = "Buckler", RecipeBookId = "904000030", Description = "バックラー", CountId = "68", Gil = "144"};
        public static readonly Recipe BronzeShield = new Recipe { Name = "Bronze Shield", RecipeBookId = "904000060", Description = "ブロンズシールド", CountId = "69", Gil = "90"};
        public static readonly Recipe IronShield = new Recipe { Name = "Iron Shield", RecipeBookId = "904000070", Description = "アイアンシールド", CountId = "70", Gil = "180"};
        public static readonly Recipe LeatherHat = new Recipe { Name = "Leather Hat", RecipeBookId = "904000150", Description = "皮の帽子", CountId = "71", Gil = "30"};
        public static readonly Recipe FeatheredCap = new Recipe { Name = "Feathered Cap", RecipeBookId = "904000160", Description = "羽根付き帽子", CountId = "72", Gil = "30"};
        public static readonly Recipe WizardsHat = new Recipe { Name = "Wizard's Hat", RecipeBookId = "904000170", Description = "三角帽子", CountId = "73", Gil = "60"};
        public static readonly Recipe Bandana = new Recipe { Name = "Bandana", RecipeBookId = "904000180", Description = "バンダナ", CountId = "74", Gil = "60"};
        public static readonly Recipe CelebrantsMiter = new Recipe { Name = "Celebrant's Miter", RecipeBookId = "904000200", Description = "司祭の帽子", CountId = "75", Gil = "150"};
        public static readonly Recipe HypnoCrown = new Recipe { Name = "Hypno Crown", RecipeBookId = "904000250", Description = "ヒュプノクラウン", CountId = "76", Gil = "450"};
        public static readonly Recipe RedCap = new Recipe { Name = "Red Cap", RecipeBookId = "904000260", Description = "レッドキャップ", CountId = "77", Gil = "450"};
        public static readonly Recipe BronzeHelm = new Recipe { Name = "Bronze Helm", RecipeBookId = "904000310", Description = "ブロンズヘルム", CountId = "78", Gil = "72"};
        public static readonly Recipe IronHelm = new Recipe { Name = "Iron Helm", RecipeBookId = "904000320", Description = "アイアンヘルム", CountId = "79", Gil = "144"};
        public static readonly Recipe LeatherShirt = new Recipe { Name = "Leather Shirt", RecipeBookId = "904000370", Description = "皮の服", CountId = "80", Gil = "60"};
        public static readonly Recipe BardsTunic = new Recipe { Name = "Bard's Tunic", RecipeBookId = "904000380", Description = "詩人の服", CountId = "81", Gil = "120"};
        public static readonly Recipe ScholarRobe = new Recipe { Name = "Scholar Robe", RecipeBookId = "904001380", Description = "学者の服", CountId = "82", Gil = "300"};
        public static readonly Recipe PowerVest = new Recipe { Name = "Power Vest", RecipeBookId = "904000390", Description = "力だすき", CountId = "83", Gil = "900"};
        public static readonly Recipe Kenpogi = new Recipe { Name = "Kenpogi", RecipeBookId = "904000400", Description = "拳法着", CountId = "84", Gil = "120"};
        public static readonly Recipe MagesHabit = new Recipe { Name = "Mage's Habit", RecipeBookId = "904000420", Description = "魔道士の服", CountId = "85", Gil = "120"};
        public static readonly Recipe SurvivalVest = new Recipe { Name = "Survival Vest", RecipeBookId = "904000430", Description = "サバイバルベスト", CountId = "86", Gil = "300"};
        public static readonly Recipe NinjaGear = new Recipe { Name = "Ninja Gear", RecipeBookId = "904000440", Description = "忍びの衣", CountId = "87", Gil = "300"};
        public static readonly Recipe BlackBeltGi = new Recipe { Name = "Black Belt Gi", RecipeBookId = "904000450", Description = "黒帯道着", CountId = "88", Gil = "300"};
        public static readonly Recipe LeatherPlate = new Recipe { Name = "Leather Plate", RecipeBookId = "904000500", Description = "レザープレート", CountId = "89", Gil = "72"};
        public static readonly Recipe CopperCuirass = new Recipe { Name = "Copper Cuirass ", RecipeBookId = "904000510", Description = "銅の胸当て", CountId = "90", Gil = "72"};
        public static readonly Recipe IronPlate = new Recipe { Name = "Iron Plate", RecipeBookId = "904000520", Description = "アイアンプレート", CountId = "91", Gil = "144"};
        public static readonly Recipe BronzeArmor = new Recipe { Name = "Bronze Armor", RecipeBookId = "904000570", Description = "ブロンズアーマー", CountId = "92", Gil = "90"};
        public static readonly Recipe IronArmor = new Recipe { Name = "Iron Armor", RecipeBookId = "904000580", Description = "アイアンアーマー", CountId = "93", Gil = "180"};
        public static readonly Recipe CottonRobe = new Recipe { Name = "Cotton Robe", RecipeBookId = "904000660", Description = "木綿のローブ", CountId = "94", Gil = "60"};
        public static readonly Recipe SilkRobe = new Recipe { Name = "Silk Robe", RecipeBookId = "904000670", Description = "シルクのローブ", CountId = "95", Gil = "60"};
        public static readonly Recipe TravelersGarbs = new Recipe { Name = "Traveler's Garbs", RecipeBookId = "904000680", Description = "旅人の法衣", CountId = "96", Gil = "120"};
        public static readonly Recipe GaiaGear = new Recipe { Name = "Gaia Gear", RecipeBookId = "904000710", Description = "大地の衣", CountId = "97", Gil = "900"};
        public static readonly Recipe ClericsRobes = new Recipe { Name = "Cleric's Robes", RecipeBookId = "904000720", Description = "クリリカルガウン", CountId = "98", Gil = "900"};
        public static readonly Recipe IronGloves = new Recipe { Name = "Iron Gloves", RecipeBookId = "904000760", Description = "鉄の篭手", CountId = "99", Gil = "60"};
        public static readonly Recipe PowerWrist = new Recipe { Name = "Power Wrist", RecipeBookId = "904000770", Description = "パワーリスト", CountId = "100", Gil = "60"};
        public static readonly Recipe HyperWrist = new Recipe { Name = "Hyper Wrist", RecipeBookId = "904000780", Description = "ハイパーリスト", CountId = "101", Gil = "300"};
        public static readonly Recipe SilverArmlet = new Recipe { Name = "Silver Armlet", RecipeBookId = "904000820", Description = "銀の腕輪", CountId = "102", Gil = "300"};
        public static readonly Recipe FireRing = new Recipe { Name = "Fire Ring", RecipeBookId = "904000950", Description = "炎の指輪", CountId = "103", Gil = "60"};
        public static readonly Recipe IceRing = new Recipe { Name = "Ice Ring", RecipeBookId = "904000980", Description = "氷の指輪", CountId = "104", Gil = "60"};
        public static readonly Recipe SparkRing = new Recipe { Name = "Spark Ring", RecipeBookId = "904001010", Description = "雷の指輪", CountId = "105", Gil = "60"};
        public static readonly Recipe WaterRing = new Recipe { Name = "Water Ring", RecipeBookId = "904001040", Description = "水の指輪", CountId = "106", Gil = "60"};
        public static readonly Recipe GaleRing = new Recipe { Name = "Gale Ring", RecipeBookId = "904001070", Description = "風の指輪", CountId = "107", Gil = "60"};
        public static readonly Recipe EarthRing = new Recipe { Name = "Earth Ring", RecipeBookId = "904001100", Description = "土の指輪", CountId = "108", Gil = "60"};
        public static readonly Recipe ProtectRing_904001140 = new Recipe { Name = "Protect Ring", RecipeBookId = "904001140", Description = "プロテクトリング", CountId = "109", Gil = "120"};
        public static readonly Recipe BarrierRing = new Recipe { Name = "Barrier Ring", RecipeBookId = "904001150", Description = "バリアリング", CountId = "110", Gil = "120"};
        public static readonly Recipe RegenRing = new Recipe { Name = "Regen Ring", RecipeBookId = "904001160", Description = "リジェネリング", CountId = "111", Gil = "300"};
        public static readonly Recipe CatsBell = new Recipe { Name = "Cat's Bell", RecipeBookId = "904001310", Description = "タマの鈴", CountId = "112", Gil = "900"};
        public static readonly Recipe HerosRing = new Recipe { Name = "Hero's Ring", RecipeBookId = "904001360", Description = "ブレイブリング", CountId = "113", Gil = "6000"};
        public static readonly Recipe MuscleBelt = new Recipe { Name = "Muscle Belt", RecipeBookId = "904001370", Description = "マッスルベルト", CountId = "114", Gil = "300"};
        public static readonly Recipe Libra = new Recipe { Name = "Libra", RecipeBookId = "905000010", Description = "ライブラ", CountId = "115", Gil = "300"};
        public static readonly Recipe Cure = new Recipe { Name = "Cure", RecipeBookId = "905000020", Description = "ケアル", CountId = "116", Gil = "300"};
        public static readonly Recipe Blindna = new Recipe { Name = "Blindna", RecipeBookId = "905000030", Description = "ブラナ", CountId = "117", Gil = "300"};
        public static readonly Recipe Vox = new Recipe { Name = "Vox", RecipeBookId = "905000040", Description = "ボキャル", CountId = "118", Gil = "900"};
        public static readonly Recipe Poisona = new Recipe { Name = "Poisona", RecipeBookId = "905000050", Description = "ポイゾナ", CountId = "119", Gil = "900"};
        public static readonly Recipe Paralyna = new Recipe { Name = "Paralyna", RecipeBookId = "905000080", Description = "パラナ", CountId = "120", Gil = "1500"};
        public static readonly Recipe Stona = new Recipe { Name = "Stona", RecipeBookId = "905000090", Description = "ストナ", CountId = "121", Gil = "1500"};
        public static readonly Recipe Fire = new Recipe { Name = "Fire", RecipeBookId = "905000230", Description = "ファイア", CountId = "122", Gil = "300"};
        public static readonly Recipe Blizzard = new Recipe { Name = "Blizzard", RecipeBookId = "905000240", Description = "ブリザド", CountId = "123", Gil = "300"};
        public static readonly Recipe Thunder = new Recipe { Name = "Thunder", RecipeBookId = "905000250", Description = "サンダー", CountId = "124", Gil = "300"};
        public static readonly Recipe Water = new Recipe { Name = "Water", RecipeBookId = "905000260", Description = "ウォータ", CountId = "125", Gil = "900"};
        public static readonly Recipe Aero = new Recipe { Name = "Aero", RecipeBookId = "905000270", Description = "エアロ", CountId = "126", Gil = "900"};
        public static readonly Recipe Stone = new Recipe { Name = "Stone", RecipeBookId = "905000280", Description = "ストーン", CountId = "127", Gil = "900"};
        public static readonly Recipe Bio = new Recipe { Name = "Bio", RecipeBookId = "905000290", Description = "バイオ", CountId = "128", Gil = "900"};
        public static readonly Recipe Blizzara = new Recipe { Name = "Blizzara", RecipeBookId = "905000310", Description = "ブリザラ", CountId = "129", Gil = "1500"};
        public static readonly Recipe Thundara = new Recipe { Name = "Thundara", RecipeBookId = "905000320", Description = "サンダラ", CountId = "130", Gil = "1500"};
        public static readonly Recipe Watera = new Recipe { Name = "Watera", RecipeBookId = "905000330", Description = "ウォタラ", CountId = "131", Gil = "2400"};
        public static readonly Recipe Aerora = new Recipe { Name = "Aerora", RecipeBookId = "905000340", Description = "エアロラ", CountId = "132", Gil = "2400"};
        public static readonly Recipe Gravity = new Recipe { Name = "Gravity", RecipeBookId = "905000370", Description = "グラビデ", CountId = "133", Gil = "2400"};
        public static readonly Recipe Drain = new Recipe { Name = "Drain", RecipeBookId = "905000380", Description = "ドレイン", CountId = "134", Gil = "2400"};
        public static readonly Recipe Biora = new Recipe { Name = "Biora", RecipeBookId = "905000400", Description = "バイオラ", CountId = "135", Gil = "4500"};
        public static readonly Recipe Sleep = new Recipe { Name = "Sleep", RecipeBookId = "905000670", Description = "スリプル", CountId = "136", Gil = "300"};
        public static readonly Recipe Blind = new Recipe { Name = "Blind", RecipeBookId = "905000680", Description = "ブライン", CountId = "137", Gil = "300"};
        public static readonly Recipe Barfire = new Recipe { Name = "Barfire", RecipeBookId = "905000690", Description = "バファイ", CountId = "138", Gil = "300"};
        public static readonly Recipe Barblizzard = new Recipe { Name = "Barblizzard", RecipeBookId = "905000700", Description = "バブリザ", CountId = "139", Gil = "300"};
        public static readonly Recipe Barthunder = new Recipe { Name = "Barthunder", RecipeBookId = "905000710", Description = "バサンダ", CountId = "140", Gil = "300"};
        public static readonly Recipe Barwater = new Recipe { Name = "Barwater", RecipeBookId = "905000720", Description = "バウォタ", CountId = "141", Gil = "900"};
        public static readonly Recipe Baraero = new Recipe { Name = "Baraero", RecipeBookId = "905000730", Description = "バエアロ", CountId = "142", Gil = "900"};
        public static readonly Recipe Barstone = new Recipe { Name = "Barstone", RecipeBookId = "905000740", Description = "バストン", CountId = "143", Gil = "900"};
        public static readonly Recipe Silence = new Recipe { Name = "Silence", RecipeBookId = "905000760", Description = "サイレス", CountId = "144", Gil = "900"};
        public static readonly Recipe Barfira = new Recipe { Name = "Barfira", RecipeBookId = "905000770", Description = "バファイラ", CountId = "145", Gil = "1500"};
        public static readonly Recipe Barblizzara = new Recipe { Name = "Barblizzara", RecipeBookId = "905000780", Description = "バブリザラ", CountId = "146", Gil = "1500"};
        public static readonly Recipe Barthundara = new Recipe { Name = "Barthundara", RecipeBookId = "905000790", Description = "バサンダラ", CountId = "147", Gil = "1500"};
        public static readonly Recipe Shell = new Recipe { Name = "Shell", RecipeBookId = "905000800", Description = "シェル", CountId = "148", Gil = "1500"};
        public static readonly Recipe Deshell = new Recipe { Name = "Deshell", RecipeBookId = "905000820", Description = "デシェル", CountId = "149", Gil = "1500"};
        public static readonly Recipe Barwatera = new Recipe { Name = "Barwatera", RecipeBookId = "905000830", Description = "バウォタラ", CountId = "150", Gil = "2400"};
        public static readonly Recipe Baraerora = new Recipe { Name = "Baraerora", RecipeBookId = "905000840", Description = "バエアロラ", CountId = "151", Gil = "2400"};
        public static readonly Recipe Barstonra = new Recipe { Name = "Barstonra", RecipeBookId = "905000850", Description = "バストンラ", CountId = "152", Gil = "2400"};
        public static readonly Recipe Steal = new Recipe { Name = "Steal", RecipeBookId = "905200010", Description = "ぬすむ", CountId = "153", Gil = "1500"};
        public static readonly Recipe Brace = new Recipe { Name = "Brace", RecipeBookId = "905200120", Description = "がまん", CountId = "154", Gil = "900"};
        public static readonly Recipe FireBlade = new Recipe { Name = "Fire Blade", RecipeBookId = "905200510", Description = "ファイア剣", CountId = "155", Gil = "300"};
        public static readonly Recipe BlizzardBlade = new Recipe { Name = "Blizzard Blade", RecipeBookId = "905200520", Description = "ブリザド剣", CountId = "156", Gil = "300"};
        public static readonly Recipe SilenceBlade = new Recipe { Name = "Silence Blade", RecipeBookId = "905200550", Description = "サイレス剣", CountId = "157", Gil = "300"};
        public static readonly Recipe WaterBlade = new Recipe { Name = "Water Blade", RecipeBookId = "905200560", Description = "ウォータ剣", CountId = "158", Gil = "900"};
        public static readonly Recipe StoneBlade = new Recipe { Name = "Stone Blade", RecipeBookId = "905200580", Description = "ストーン剣", CountId = "159", Gil = "900"};
        public static readonly Recipe BlindBlade = new Recipe { Name = "Blind Blade", RecipeBookId = "905200590", Description = "ブライン剣", CountId = "160", Gil = "900"};
        public static readonly Recipe BioBlade = new Recipe { Name = "Bio Blade", RecipeBookId = "905200600", Description = "バイオ剣", CountId = "161", Gil = "900"};
        public static readonly Recipe MagicInfuse = new Recipe { Name = "Magic Infuse", RecipeBookId = "905200800", Description = "まれんけい", CountId = "162", Gil = "4500"};
        public static readonly Recipe MentalBreak = new Recipe { Name = "Mental Break", RecipeBookId = "905201160", Description = "メンタルブレイク", CountId = "163", Gil = "1500"};
        public static readonly Recipe BioBlaster = new Recipe { Name = "Bio Blaster", RecipeBookId = "905201320", Description = "バイオブラスター", CountId = "164", Gil = "1500"};
        public static readonly Recipe BombFragment = new Recipe { Name = "Bomb Fragment", RecipeBookId = "901000280", Description = "ボムのかけら", CountId = "165", Gil = "30"};
        public static readonly Recipe FishScale = new Recipe { Name = "Fish Scale", RecipeBookId = "901000340", Description = "魚のウロコ", CountId = "166", Gil = "30"};
        public static readonly Recipe GiantFeather = new Recipe { Name = "Giant Feather", RecipeBookId = "901000360", Description = "巨鳥の羽", CountId = "167", Gil = "30"};
        public static readonly Recipe Pinwheel = new Recipe { Name = "Pinwheel", RecipeBookId = "901000480", Description = "風車", CountId = "168", Gil = "600"};
        public static readonly Recipe Icebrand = new Recipe { Name = "Icebrand", RecipeBookId = "903000130", Description = "アイスブランド", CountId = "169", Gil = "900"};
        public static readonly Recipe CoralSword = new Recipe { Name = "Coral Sword", RecipeBookId = "903000140", Description = "珊瑚の剣", CountId = "170", Gil = "900"};
        public static readonly Recipe FireRod = new Recipe { Name = "Fire Rod", RecipeBookId = "903000680", Description = "炎のロッド", CountId = "171", Gil = "210"};
        public static readonly Recipe Capella = new Recipe { Name = "Capella", RecipeBookId = "903000860", Description = "カペラ", CountId = "172", Gil = "144"};
        public static readonly Recipe ShockWhip = new Recipe { Name = "Shock Whip", RecipeBookId = "903000940", Description = "電撃鞭", CountId = "173", Gil = "270"};
        public static readonly Recipe OchreShield = new Recipe { Name = "Ochre Shield", RecipeBookId = "904000040", Description = "ライトシールド", CountId = "174", Gil = "144"};
        public static readonly Recipe GreenBeret = new Recipe { Name = "Green Beret", RecipeBookId = "904000210", Description = "グリーンベレー", CountId = "175", Gil = "150"};
        public static readonly Recipe Barbut = new Recipe { Name = "Barbut", RecipeBookId = "904000330", Description = "バルビュータ", CountId = "176", Gil = "360"};
        public static readonly Recipe SagesSurplice = new Recipe { Name = "Sage's Surplice", RecipeBookId = "904000690", Description = "司祭のローブ", CountId = "177", Gil = "300"};
        public static readonly Recipe Protect = new Recipe { Name = "Protect", RecipeBookId = "905000750", Description = "プロテス", CountId = "178", Gil = "900"};
        public static readonly Recipe MP_905100040 = new Recipe { Name = "MP +10%", RecipeBookId = "905100040", Description = "MP+10%", CountId = "179", Gil = "300"};
        public static readonly Recipe SPR_905100160 = new Recipe { Name = "SPR +10%", RecipeBookId = "905100160", Description = "精神+10%", CountId = "180", Gil = "300"};
        public static readonly Recipe BugKiller = new Recipe { Name = "Bug Killer", RecipeBookId = "905101020", Description = "ムシキラー", CountId = "181", Gil = "2400"};
        public static readonly Recipe XPotion = new Recipe { Name = "X-Potion", RecipeBookId = "901000030", Description = "エクスポーション", CountId = "182", Gil = "600"};
        public static readonly Recipe TurboEther = new Recipe { Name = "Turbo Ether", RecipeBookId = "901000050", Description = "エーテルターボ", CountId = "183", Gil = "600"};
        public static readonly Recipe HolyTorch = new Recipe { Name = "Holy Torch", RecipeBookId = "901000430", Description = "聖なるトーチ", CountId = "184", Gil = "600"};
        public static readonly Recipe MythrilSpear = new Recipe { Name = "Mythril Spear", RecipeBookId = "903000490", Description = "ミスリルスピア", CountId = "185", Gil = "480"};
        public static readonly Recipe MagesHat = new Recipe { Name = "Mage's Hat", RecipeBookId = "904000220", Description = "魔術師の帽子", CountId = "186", Gil = "900"};
        public static readonly Recipe SagesRobe = new Recipe { Name = "Sage's Robe", RecipeBookId = "904000750", Description = "賢者のローブ", CountId = "187", Gil = "900"};
        public static readonly Recipe MythrilGloves = new Recipe { Name = "Mythril Gloves", RecipeBookId = "904000800", Description = "ミスリルの篭手", CountId = "188", Gil = "300"};
        public static readonly Recipe Cura = new Recipe { Name = "Cura", RecipeBookId = "905000070", Description = "ケアルラ", CountId = "189", Gil = "1500"};
        public static readonly Recipe DEF = new Recipe { Name = "DEF +10%", RecipeBookId = "905100130", Description = "防御+10%", CountId = "190", Gil = "300"};
        public static readonly Recipe MythrilHammer = new Recipe { Name = "Mythril Hammer", RecipeBookId = "903000390", Description = "ミスリルハンマー", CountId = "191", Gil = "1530"};
        public static readonly Recipe WindSpear = new Recipe { Name = "Wind Spear", RecipeBookId = "903000540", Description = "ウィンドスピア", CountId = "192", Gil = "1440"};
        public static readonly Recipe MythrilHelm = new Recipe { Name = "Mythril Helm", RecipeBookId = "904000340", Description = "ミスリルヘルム", CountId = "193", Gil = "360"};
        public static readonly Recipe Bravery = new Recipe { Name = "Bravery", RecipeBookId = "905000870", Description = "ブレイブ", CountId = "194", Gil = "2400"};
        public static readonly Recipe MAG = new Recipe { Name = "MAG +10%", RecipeBookId = "905100100", Description = "魔力+10%", CountId = "195", Gil = "300"};
        public static readonly Recipe FineBlade = new Recipe { Name = "Fine Blade", RecipeBookId = "1000000000", Description = "BroadSword+", CountId = "90000", Gil = "50"};
        public static readonly Recipe SuperiorBlade = new Recipe { Name = "Superior Blade", RecipeBookId = "1000000001", Description = "BroadSword++", CountId = "90001", Gil = "50"};
        public static readonly Recipe AntarcticWind = new Recipe { Name = "Antarctic Wind", RecipeBookId = "901000300", Description = "南極の風", CountId = "198", Gil = "30"};
        public static readonly Recipe ZeussRage = new Recipe { Name = "Zeus's Rage", RecipeBookId = "901000320", Description = "ゼウスの怒り", CountId = "199", Gil = "30"};
        public static readonly Recipe EarthDrum = new Recipe { Name = "Earth Drum", RecipeBookId = "901000380", Description = "大地のドラム", CountId = "200", Gil = "30"};
        public static readonly Recipe MythrilDagger = new Recipe { Name = "Mythril Dagger", RecipeBookId = "903000030", Description = "ミスリルダガー", CountId = "201", Gil = "150"};
        public static readonly Recipe MainGauche = new Recipe { Name = "Main Gauche", RecipeBookId = "903000050", Description = "マインゴーシュ", CountId = "202", Gil = "450"};
        public static readonly Recipe MythrilSword = new Recipe { Name = "Mythril Sword", RecipeBookId = "903000100", Description = "ミスリルソード", CountId = "203", Gil = "300"};
        public static readonly Recipe Osafune = new Recipe { Name = "Osafune", RecipeBookId = "903000240", Description = "備前長船", CountId = "204", Gil = "1260"};
        public static readonly Recipe MythrilMace = new Recipe { Name = "Mythril Mace", RecipeBookId = "903000450", Description = "ミスリルメイス", CountId = "205", Gil = "270"};
        public static readonly Recipe MythrilClaws = new Recipe { Name = "Mythril Claws", RecipeBookId = "903000600", Description = "ミスリルクロー", CountId = "206", Gil = "300"};
        public static readonly Recipe MythrilBow = new Recipe { Name = "Mythril Bow", RecipeBookId = "903000810", Description = "ミスリルボウ", CountId = "207", Gil = "390"};
        public static readonly Recipe MythrilWhip = new Recipe { Name = "Mythril Whip", RecipeBookId = "903000950", Description = "ミスリルウィップ", CountId = "208", Gil = "270"};
        public static readonly Recipe MythrilBuckler = new Recipe { Name = "Mythril Buckler", RecipeBookId = "904000050", Description = "ミスリルの軽盾", CountId = "209", Gil = "360"};
        public static readonly Recipe LargeShield = new Recipe { Name = "Large Shield", RecipeBookId = "904000080", Description = "ラージシールド", CountId = "210", Gil = "450"};
        public static readonly Recipe MythrilShield = new Recipe { Name = "Mythril Shield", RecipeBookId = "904000090", Description = "ミスリルシールド", CountId = "211", Gil = "1350"};
        public static readonly Recipe TigerMask = new Recipe { Name = "Tiger Mask", RecipeBookId = "904000230", Description = "タイガーマスク", CountId = "212", Gil = "150"};
        public static readonly Recipe MythrilPlate = new Recipe { Name = "Mythril Plate", RecipeBookId = "904000530", Description = "ミスリルプレート", CountId = "177", Gil = "360"};
        public static readonly Recipe SilverCuirass = new Recipe { Name = "Silver Cuirass", RecipeBookId = "904000540", Description = "銀の胸当て", CountId = "213", Gil = "360"};
        public static readonly Recipe PaladinArmor = new Recipe { Name = "Paladin Armor", RecipeBookId = "904000590", Description = "ナイトの鎧", CountId = "214", Gil = "450"};
        public static readonly Recipe MythrilArmor = new Recipe { Name = "Mythril Armor", RecipeBookId = "904000600", Description = "ミスリルアーマー", CountId = "215", Gil = "450"};
        public static readonly Recipe WizardsRobe = new Recipe { Name = "Wizard's Robe", RecipeBookId = "904000700", Description = "魔術師のローブ", CountId = "216", Gil = "300"};
        public static readonly Recipe MoonBracer = new Recipe { Name = "Moon Bracer", RecipeBookId = "904001170", Description = "月の腕輪", CountId = "217", Gil = "900"};
        public static readonly Recipe Dispel = new Recipe { Name = "Dispel", RecipeBookId = "905000130", Description = "デスペル", CountId = "218", Gil = "4500"};
        public static readonly Recipe Faith = new Recipe { Name = "Faith", RecipeBookId = "905000880", Description = "フェイス", CountId = "219", Gil = "2400"};
        public static readonly Recipe SpiritSlayer = new Recipe { Name = "Spirit Slayer", RecipeBookId = "905101100", Description = "スピリットキラー", CountId = "220", Gil = "2400"};
        public static readonly Recipe HP_905101500 = new Recipe { Name = "HP +15%"};
        public static readonly Recipe SleepBlade = new Recipe { Name = "Sleep Blade", RecipeBookId = "905200540", Description = "スリプル剣", CountId = "221", Gil = "300"};
        public static readonly Recipe AeroBlade = new Recipe { Name = "Aero Blade", RecipeBookId = "905200570", Description = "エアロ剣", CountId = "222", Gil = "900"};
        public static readonly Recipe StonraBlade_905200660 = new Recipe { Name = "Stonra Blade"};
        public static readonly Recipe VorpalAxe = new Recipe { Name = "Vorpal Axe"};
        public static readonly Recipe GaeBolg = new Recipe { Name = "Gae Bolg"};
        public static readonly Recipe LightCurtain = new Recipe { Name = "Light Curtain", RecipeBookId = "901000170", Description = "光のカーテン", CountId = "225", Gil = "1200"};
        public static readonly Recipe WyvernsFeather = new Recipe { Name = "Wyvern's Feather", RecipeBookId = "901000370", Description = "ワイバーンの羽", CountId = "226", Gil = "150"};
        public static readonly Recipe WhiteFang = new Recipe { Name = "White Fang", RecipeBookId = "901000410", Description = "白い牙", CountId = "227", Gil = "600"};
        public static readonly Recipe MythrilSaber = new Recipe { Name = "Mythril Saber", RecipeBookId = "903000190", Description = "ミスリルセイバー", CountId = "228", Gil = "1350"};
        public static readonly Recipe Chirijiraden = new Recipe { Name = "Chirijiraden", RecipeBookId = "903000280", Description = "塵地螺鈿飾剣", CountId = "229", Gil = "8400"};
        public static readonly Recipe MythrilAxe = new Recipe { Name = "Mythril Axe", RecipeBookId = "903000320", Description = "ミスリルアクス", CountId = "230", Gil = "540"};
        public static readonly Recipe Escutcheon = new Recipe { Name = "Escutcheon", RecipeBookId = "904000100", Description = "エスカッション", CountId = "231", Gil = "1080"};
        public static readonly Recipe Brigandine = new Recipe { Name = "Brigandine", RecipeBookId = "904000550", Description = "ブリガンダイン", CountId = "232", Gil = "360"};
        public static readonly Recipe Curaga = new Recipe { Name = "Curaga", RecipeBookId = "905000150", Description = "ケアルダ", CountId = "233", Gil = "4500"};
        public static readonly Recipe EVOMAG = new Recipe { Name = "EVO MAG +10%", RecipeBookId = "905100190", Description = "召喚魔法+10%", CountId = "234", Gil = "300"};
        public static readonly Recipe WateraBlade = new Recipe { Name = "Watera Blade", RecipeBookId = "905200640", Description = "ウォタラ剣", CountId = "235", Gil = "2400"};
        public static readonly Recipe WingedSaint = new Recipe { Name = "Winged Saint", RecipeBookId = "903000650", Description = "仁義エンブレム", CountId = "236", Gil = "6000"};
        public static readonly Recipe MoraleTalisman = new Recipe { Name = "Morale Talisman", RecipeBookId = "901000180", Description = "豪傑のタリスマン", CountId = "237", Gil = "900"};
        public static readonly Recipe RodofGravity = new Recipe { Name = "Rod of Gravity", RecipeBookId = "1000000002", Description = "重力の杖", CountId = "90002", Gil = "50"};
        public static readonly Recipe VoidVessel = new Recipe { Name = "Void Vessel", RecipeBookId = "1000000003", Description = "虚無の器", CountId = "90003", Gil = "50"};
        public static readonly Recipe StonraBlade_1000000004 = new Recipe { Name = "Stonra Blade", RecipeBookId = "1000000004", Description = "ストンラ剣", CountId = "90004", Gil = "1500"};
        public static readonly Recipe HP_1000000005 = new Recipe { Name = "HP +15%", RecipeBookId = "1000000005", Description = "HP+15%", CountId = "90005", Gil = "900"};
        public static readonly Recipe BurstShot = new Recipe { Name = "Burst Shot", RecipeBookId = "1000000006", Description = "バーストショット", CountId = "90006", Gil = "1000"};
        public static readonly Recipe StandardMogcakePack = new Recipe { Name = "Standard Mogcake Pack", RecipeBookId = "1000000007", Description = "モグケーキ通常ボックス", CountId = "90007", Gil = "30"};
        public static readonly Recipe RareMogcakePack = new Recipe { Name = "Rare Mogcake Pack", RecipeBookId = "1000000008", Description = "モグケーキスペシャルボックス", CountId = "90008", Gil = "60"};
        public static readonly Recipe PremiumMogcakePack = new Recipe { Name = "Premium Mogcake Pack", RecipeBookId = "1000000009", Description = "モグケーキプレミアムボックス", CountId = "90009", Gil = "90"};
        public static readonly Recipe LunarCurtain = new Recipe { Name = "Lunar Curtain", RecipeBookId = "901000510", Description = "月のカーテン", CountId = "238", Gil = "1200"};
        public static readonly Recipe NorthWind = new Recipe { Name = "North Wind", RecipeBookId = "901000310", Description = "北極の風", CountId = "239", Gil = "150"};
        public static readonly Recipe Flametongue = new Recipe { Name = "Flametongue", RecipeBookId = "903000120", Description = "フレイムタン", CountId = "240", Gil = "900"};
        public static readonly Recipe ATK = new Recipe { Name = "ATK +10%", RecipeBookId = "905100070", Description = "攻撃+10%", CountId = "241", Gil = "300"};
        public static readonly Recipe AutoProtect = new Recipe { Name = "Auto-Protect", RecipeBookId = "905100710", Description = "オートプロテス", CountId = "242", Gil = "2400"};
        public static readonly Recipe BioraBlade = new Recipe { Name = "Biora Blade", RecipeBookId = "905200680", Description = "バイオラ剣", CountId = "243", Gil = "4500"};
        public static readonly Recipe RightArm = new Recipe { Name = "Right Arm", RecipeBookId = "901000290", Description = "ボムの右腕", CountId = "244", Gil = "150"};
        public static readonly Recipe BlueFang = new Recipe { Name = "Blue Fang", RecipeBookId = "901000420", Description = "青い牙", CountId = "245", Gil = "600"};
        public static readonly Recipe SleepSword = new Recipe { Name = "Sleep Sword", RecipeBookId = "903000110", Description = "眠りの剣", CountId = "246", Gil = "300"};
        public static readonly Recipe FlameLance = new Recipe { Name = "Flame Lance", RecipeBookId = "903000510", Description = "炎の槍", CountId = "247", Gil = "1440"};
        public static readonly Recipe PoisonKnuckles = new Recipe { Name = "Poison Knuckles", RecipeBookId = "903000620", Description = "ポイズンナックル", CountId = "248", Gil = "300"};
        public static readonly Recipe ThunderShield = new Recipe { Name = "Thunder Shield", RecipeBookId = "904000120", Description = "雷神の盾", CountId = "249", Gil = "1350"};
        public static readonly Recipe IceArmor = new Recipe { Name = "Ice Armor", RecipeBookId = "904000620", Description = "アイスアーマー", CountId = "250", Gil = "1350"};
        public static readonly Recipe AutoShell = new Recipe { Name = "Auto-Shell", RecipeBookId = "905100720", Description = "オートシェル", CountId = "251", Gil = "2400"};
        public static readonly Recipe OsmoseBlade = new Recipe { Name = "Osmose Blade", RecipeBookId = "905200690", Description = "アスピル剣", CountId = "252", Gil = "4500"};
        public static readonly Recipe ShiningSplendor = new Recipe { Name = "Shining Splendor", RecipeBookId = "1000000010", Description = "シャイニング・スプレンダー", CountId = "90010", Gil = "50000"};
        public static readonly Recipe YPotion = new Recipe { Name = "Y-Potion", RecipeBookId = "1000000011", Description = "ワイポーション", CountId = "90011", Gil = "10000"};
        public static readonly Recipe MegaEther = new Recipe { Name = "Mega Ether", RecipeBookId = "1000000012", Description = "メガエーテル", CountId = "90012", Gil = "10000"};
        public static readonly Recipe BloodSword = new Recipe { Name = "Blood Sword", RecipeBookId = "1000000013", Description = "ブラッドソード", CountId = "90013", Gil = "50000"};
        public static readonly Recipe RedFang = new Recipe { Name = "Red Fang", RecipeBookId = "901000400", Description = "赤い牙", CountId = "253", Gil = "600"};
        public static readonly Recipe Trident = new Recipe { Name = "Trident", RecipeBookId = "903000500", Description = "トライデント", CountId = "254", Gil = "1440"};
        public static readonly Recipe RodofLightning = new Recipe { Name = "Rod of Lightning", RecipeBookId = "903000700", Description = "雷のロッド", CountId = "255", Gil = "210"};
        public static readonly Recipe ElvenBow = new Recipe { Name = "Elven Bow", RecipeBookId = "903000830", Description = "エルフィンボウ", CountId = "256", Gil = "1170"};
        public static readonly Recipe FlameMail = new Recipe { Name = "Flame Mail", RecipeBookId = "904000610", Description = "フレイムメイル", CountId = "257", Gil = "1350"};
        public static readonly Recipe Death = new Recipe { Name = "Death", RecipeBookId = "905000500", Description = "デス", CountId = "258", Gil = "9000"};
        public static readonly Recipe BirdKiller = new Recipe { Name = "Bird Killer", RecipeBookId = "905101090", Description = "バードキラー", CountId = "259", Gil = "2400"};
        public static readonly Recipe AutoPotion = new Recipe { Name = "Auto-Potion", RecipeBookId = "905101120", Description = "オートポーション", CountId = "260", Gil = "2400"};
        public static readonly Recipe PowerBreak = new Recipe { Name = "Power Break", RecipeBookId = "905201130", Description = "パワーブレイク", CountId = "261", Gil = "1500"};
        public static readonly Recipe MagicBreak = new Recipe { Name = "Magic Break", RecipeBookId = "905201140", Description = "マジックブレイク", CountId = "262", Gil = "1500"};
        public static readonly Recipe GiantsAxe = new Recipe { Name = "Giant's Axe", RecipeBookId = "903000330", Description = "巨人の斧", CountId = "263", Gil = "1620"};
        public static readonly Recipe Werebuster = new Recipe { Name = "Werebuster", RecipeBookId = "903000440", Description = "ウェアバスター", CountId = "264", Gil = "270"};
        public static readonly Recipe IceLance = new Recipe { Name = "Ice Lance", RecipeBookId = "903000520", Description = "アイスランス", CountId = "265", Gil = "1440"};
        public static readonly Recipe IceRod = new Recipe { Name = "Ice Rod", RecipeBookId = "903000690", Description = "氷のロッド", CountId = "266", Gil = "210"};
        public static readonly Recipe Sirius = new Recipe { Name = "Sirius", RecipeBookId = "903000880", Description = "シリウス", CountId = "267", Gil = "360"};
        public static readonly Recipe MysteryVeil = new Recipe { Name = "Mystery Veil", RecipeBookId = "904000270", Description = "神秘のヴェール", CountId = "268", Gil = "450"};
        public static readonly Recipe GoldenArmor = new Recipe { Name = "Golden Armor", RecipeBookId = "904000630", Description = "ゴールドアーマー", CountId = "269", Gil = "1350"};
        public static readonly Recipe BlackRobe = new Recipe { Name = "Black Robe", RecipeBookId = "904000740", Description = "黒のローブ", CountId = "270", Gil = "900"};
        public static readonly Recipe UndeadKiller = new Recipe { Name = "Undead Killer", RecipeBookId = "905101060", Description = "アンデッドキラー", CountId = "271", Gil = "2400"};
        public static readonly Recipe ArmorBreak = new Recipe { Name = "Armor Break", RecipeBookId = "905201150", Description = "アーマーブレイク", CountId = "272", Gil = "1500"};
        public static readonly Recipe ThunderBlade = new Recipe { Name = "Thunder Blade", RecipeBookId = "905200530", Description = "サンダー剣", CountId = "273", Gil = "300"};
        public static readonly Recipe MonarchsRing = new Recipe { Name = "Monarch's Ring", RecipeBookId = "904001410", Description = "モナークリング", CountId = "274", Gil = "15000"};
        public static readonly Recipe DominationRing = new Recipe { Name = "Domination Ring", RecipeBookId = "904001420", Description = "ドミネートリング", CountId = "275", Gil = "15000"};
        public static readonly Recipe RulersRing = new Recipe { Name = "Ruler's Ring", RecipeBookId = "904001430", Description = "ルーラーリング", CountId = "276", Gil = "15000"};
        public static readonly Recipe RingofDominion = new Recipe { Name = "Ring of Dominion", RecipeBookId = "904001440", Description = "エクシードリング", CountId = "277", Gil = "30000"};
        public static readonly Recipe HeavenlyWrath = new Recipe { Name = "Heavenly Wrath", RecipeBookId = "901000330", Description = "神々の怒り", CountId = "278", Gil = "150"};
        public static readonly Recipe DragonScale_901000350 = new Recipe { Name = "Dragon Scale", RecipeBookId = "901000350", Description = "龍のウロコ", CountId = "279", Gil = "150"};
        public static readonly Recipe GoldenStaff = new Recipe { Name = "Golden Staff", RecipeBookId = "903000780", Description = "ゴールドスタッフ", CountId = "280", Gil = "720"};
        public static readonly Recipe BlessedHammer = new Recipe { Name = "Blessed Hammer", RecipeBookId = "903001060", Description = "ブレスドハンマー", CountId = "281", Gil = "1530"};
        public static readonly Recipe IceShield = new Recipe { Name = "Ice Shield", RecipeBookId = "904000110", Description = "アイスシールド", CountId = "282", Gil = "1350"};
        public static readonly Recipe GoldenVest = new Recipe { Name = "Golden Vest", RecipeBookId = "904000560", Description = "ゴールドプレート", CountId = "283", Gil = "1080"};
        public static readonly Recipe WhiteRobe = new Recipe { Name = "White Robe", RecipeBookId = "904000730", Description = "白のローブ", CountId = "284", Gil = "900"};
        public static readonly Recipe BuddingMapleWand = new Recipe { Name = "Budding Maple Wand", RecipeBookId = "903001070", Description = "バッデッドワンド", CountId = "285", Gil = "999"};
        public static readonly Recipe ScionConjurersDalmatica = new Recipe { Name = "Scion Conjurer's Dalmatica", RecipeBookId = "904001450", Description = "サイオンズコンジュラー・ダルマティカ", CountId = "286", Gil = "999"};
        public static readonly Recipe ScionConjurersPattens = new Recipe { Name = "Scion Conjurer's Pattens", RecipeBookId = "904001460", Description = "サイオンズコンジュラー・パッテン", CountId = "287", Gil = "999"};
        public static readonly Recipe CobaltWinglet = new Recipe { Name = "Cobalt Winglet", RecipeBookId = "903001080", Description = "ウィングレット", CountId = "288", Gil = "999"};
        public static readonly Recipe AntecedentsAttire = new Recipe { Name = "Antecedent's Attire", RecipeBookId = "904001470", Description = "サイオンズレディ・アタイア", CountId = "289", Gil = "999"};
        public static readonly Recipe MeteorSurvivorRing = new Recipe { Name = "Meteor Survivor Ring", RecipeBookId = "904001480", Description = "メテオサバイバーリング", CountId = "290", Gil = "999"};
        public static readonly Recipe UldahnFalchion = new Recipe { Name = "Ul'dahn Falchion", RecipeBookId = "903001090", Description = "ウルダハンファルシオン", CountId = "291", Gil = "999"};
        public static readonly Recipe ScionThiefsTunic = new Recipe { Name = "Scion Thief's Tunic", RecipeBookId = "904001490", Description = "サイオンズシーフ・チュニック", CountId = "292", Gil = "999"};
        public static readonly Recipe ScionThiefsHalfgloves = new Recipe { Name = "Scion Thief's Halfgloves", RecipeBookId = "904001500", Description = "サイオンズシーフ・ハーフグローブ", CountId = "293", Gil = "999"};
        public static readonly Recipe GaiasCry = new Recipe { Name = "Gaia's Cry", RecipeBookId = "901000390", Description = "大地のうなり", CountId = "294", Gil = "150"};
        public static readonly Recipe GoldenBlade = new Recipe { Name = "Golden Blade", RecipeBookId = "903001100", Description = "ゴールドブレイド", CountId = "295", Gil = "1350"};
        public static readonly Recipe FlameShield = new Recipe { Name = "Flame Shield", RecipeBookId = "904001600", Description = "フレイムシールド", CountId = "296", Gil = "1350"};
        public static readonly Recipe Circlet = new Recipe { Name = "Circlet", RecipeBookId = "904000280", Description = "サークレット", CountId = "297", Gil = "450"};
        public static readonly Recipe AngelRing = new Recipe { Name = "Angel Ring", RecipeBookId = "904001190", Description = "天使の指輪", CountId = "298", Gil = "15000"};
        public static readonly Recipe BasiliskSteel = new Recipe { Name = "Basilisk Steel", RecipeBookId = "903001110", Description = "ブレイクブレイド", CountId = "299", Gil = "3000"};
        public static readonly Recipe Razzmatazz = new Recipe { Name = "Razzmatazz", RecipeBookId = "903001120", Description = "ラズマタズ", CountId = "300", Gil = "6000"};
        public static readonly Recipe HyperBall = new Recipe { Name = "Hyper Ball", RecipeBookId = "903001130", Description = "ハイパーボール", CountId = "301", Gil = "3000"};
        public static readonly Recipe Override = new Recipe { Name = "Override", RecipeBookId = "903001140", Description = "オーバーライド", CountId = "302", Gil = "3000"};
        public static readonly Recipe ThunderSpear = new Recipe { Name = "Thunder Spear", RecipeBookId = "903000530", Description = "サンダースピア", CountId = "303", Gil = "1440"};
        public static readonly Recipe Betelgeuse = new Recipe { Name = "Betelgeuse", RecipeBookId = "903000890", Description = "ベテルギウス", CountId = "304", Gil = "1080"};
        public static readonly Recipe GoldenShield = new Recipe { Name = "Golden Shield", RecipeBookId = "904000130", Description = "ゴールドシールド", CountId = "305", Gil = "1350"};
        public static readonly Recipe Imperil = new Recipe { Name = "Imperil", RecipeBookId = "905000860", Description = "ウィーク", CountId = "306", Gil = "2400"};
        public static readonly Recipe Microphone_1000000014 = new Recipe { Name = "Microphone", RecipeBookId = "1000000014", Description = "マイク", CountId = "90014", Gil = "0"};
        public static readonly Recipe EveningGloves = new Recipe { Name = "Evening Gloves", RecipeBookId = "1000000015", Description = "イヴニンググローブ", CountId = "90015", Gil = "0"};
        public static readonly Recipe BunnyMask_1000000016 = new Recipe { Name = "Bunny Mask", RecipeBookId = "1000000016", Description = "バニーマスク", CountId = "90016", Gil = "0"};
        public static readonly Recipe StylishBlackDress_1000000017 = new Recipe { Name = "Stylish Black Dress", RecipeBookId = "1000000017", Description = "スタイリッシュブラックドレス", CountId = "90017", Gil = "0"};
        public static readonly Recipe MemoryCandy = new Recipe { Name = "Memory Candy", RecipeBookId = "901000520", Description = "思い出の飴玉", CountId = "351", Gil = "60"};
        public static readonly Recipe MageMasher = new Recipe { Name = "Mage Masher", RecipeBookId = "903000060", Description = "メイジマッシャー", CountId = "324", Gil = "450"};
        public static readonly Recipe RasAlgethi = new Recipe { Name = "Ras Algethi", RecipeBookId = "903000900", Description = "ラス・アルゲテイ", CountId = "323", Gil = "1080"};
        public static readonly Recipe GalkanDagger = new Recipe { Name = "Galkan Dagger", RecipeBookId = "903001150", Description = "ガルカンダガー", CountId = "307", Gil = "1500"};
        public static readonly Recipe LeucosVoulge = new Recipe { Name = "Leucos Voulge", RecipeBookId = "903001160", Description = "レコスヴォウジェ", CountId = "308", Gil = "5400"};
        public static readonly Recipe ThothsWand = new Recipe { Name = "Thoth's Wand", RecipeBookId = "903001170", Description = "トートワンド", CountId = "309", Gil = "810"};
        public static readonly Recipe OrcPiercer = new Recipe { Name = "Orc Piercer", RecipeBookId = "903001180", Description = "オークピアッサー", CountId = "310", Gil = "1440"};
        public static readonly Recipe Retaliator = new Recipe { Name = "Retaliator", RecipeBookId = "903001190", Description = "リタリエーター", CountId = "311", Gil = "6000"};
        public static readonly Recipe IridalStaff = new Recipe { Name = "Iridal Staff", RecipeBookId = "903001200", Description = "イリダルスタッフ", CountId = "312", Gil = "4200"};
        public static readonly Recipe TacticianMagiciansWand = new Recipe { Name = "Tactician Magician's Wand", RecipeBookId = "903001210", Description = "連邦軍師制式錫", CountId = "313", Gil = "630"};
        public static readonly Recipe SharkGun = new Recipe { Name = "Shark Gun", RecipeBookId = "903001220", Description = "シャークガン", CountId = "314", Gil = "7200"};
        public static readonly Recipe SlickDart = new Recipe { Name = "Slick Dart", RecipeBookId = "903001230", Description = "スリックダート", CountId = "315", Gil = "3000"};
        public static readonly Recipe Raikiri = new Recipe { Name = "Raikiri", RecipeBookId = "903001240", Description = "雷切", CountId = "322", Gil = "8400"};
        public static readonly Recipe MoogleSpear = new Recipe { Name = "Moogle Spear", RecipeBookId = "903001250", Description = "モーグリスピア", CountId = "326", Gil = "8400"};
        public static readonly Recipe BreakShot = new Recipe { Name = "Break Shot"};
        public static readonly Recipe TwinWhip = new Recipe { Name = "Twin Whip", RecipeBookId = "903001280", Description = "双散鞭", CountId = "336", Gil = "3000"};
        public static readonly Recipe Microphone_903001290 = new Recipe { Name = "Microphone"};
        public static readonly Recipe TorrentRing = new Recipe { Name = "Torrent Ring", RecipeBookId = "904001060", Description = "水神の指輪", CountId = "325", Gil = "300"};
        public static readonly Recipe DivineShield = new Recipe { Name = "Divine Shield", RecipeBookId = "904001510", Description = "ディバインシールド", CountId = "316", Gil = "3600"};
        public static readonly Recipe RavenBeret = new Recipe { Name = "Raven Beret", RecipeBookId = "904001520", Description = "レイヴンベレー", CountId = "317", Gil = "450"};
        public static readonly Recipe TacticianMagiciansCoat = new Recipe { Name = "Tactician Magician's Coat", RecipeBookId = "904001530", Description = "連邦軍師制式コート", CountId = "318", Gil = "6000"};
        public static readonly Recipe ParadeCuirass = new Recipe { Name = "Parade Cuirass", RecipeBookId = "904001540", Description = "パレードキュイラス", CountId = "319", Gil = "7200"};
        public static readonly Recipe GoldenHairpin = new Recipe { Name = "Golden Hairpin", RecipeBookId = "904001550", Description = "金の髪飾り", CountId = "320", Gil = "6000"};
        public static readonly Recipe ParadeGorget = new Recipe { Name = "Parade Gorget", RecipeBookId = "904001560", Description = "パレードゴルゲット", CountId = "321", Gil = "6000"};
        public static readonly Recipe MoogleCrown = new Recipe { Name = "Moogle Crown", RecipeBookId = "904001570", Description = "モーグリクラウン", CountId = "327", Gil = "6000"};
        public static readonly Recipe MoogleCape = new Recipe { Name = "Moogle Cape", RecipeBookId = "904001580", Description = "モーグリマント", CountId = "328", Gil = "6000"};
        public static readonly Recipe UnsuiClothes = new Recipe { Name = "Unsui Clothes", RecipeBookId = "904001590", Description = "雲水の衣", CountId = "332", Gil = "3000"};
        public static readonly Recipe GoldenHelm = new Recipe { Name = "Golden Helm", RecipeBookId = "904001610", Description = "ゴールドヘルム", CountId = "333", Gil = "1080"};
        public static readonly Recipe FestivalRobe_904001710 = new Recipe { Name = "Festival Robe+"};
        public static readonly Recipe FestivalCap_904001720 = new Recipe { Name = "Festival Cap+"};
        public static readonly Recipe PlatinumTiara = new Recipe { Name = "Platinum Tiara", RecipeBookId = "904001730", Description = "プラチナティアラ", CountId = "347", Gil = "1440"};
        public static readonly Recipe Fransisca = new Recipe { Name = "Fransisca"};
        public static readonly Recipe GloryStaff = new Recipe { Name = "Glory Staff"};
        public static readonly Recipe KrisKnife = new Recipe { Name = "Kris Knife"};
        public static readonly Recipe RoyalRing = new Recipe { Name = "Royal Ring"};
        public static readonly Recipe EveningGlove = new Recipe { Name = "Evening Glove"};
        public static readonly Recipe BunnyMask_904001810 = new Recipe { Name = "Bunny Mask"};
        public static readonly Recipe StylishBlackDress_904001820 = new Recipe { Name = "Stylish Black Dress"};
        public static readonly Recipe Darkra = new Recipe { Name = "Darkra", RecipeBookId = "905000890", Description = "ダーラ", CountId = "349", Gil = "2400"};
        public static readonly Recipe DragonKiller = new Recipe { Name = "Dragon Killer+", RecipeBookId = "905101510", Description = "ドラゴンキラー改", CountId = "358", Gil = "9000"};
        public static readonly Recipe MogSearch = new Recipe { Name = "Mog Search", RecipeBookId = "905211120", Description = "モグサーチ", CountId = "329", Gil = "1500"};
        public static readonly Recipe MogResist = new Recipe { Name = "Mog Resist", RecipeBookId = "905211150", Description = "モグレジスト", CountId = "330", Gil = "1500"};
        public static readonly Recipe MogRise = new Recipe { Name = "Mog Rise", RecipeBookId = "905211160", Description = "モグライズ", CountId = "331", Gil = "2400"};
        public static readonly Recipe FiraBlade = new Recipe { Name = "Fira Blade", RecipeBookId = "905211170", Description = "ファイラ剣", CountId = "350", Gil = "2400"};
        public static readonly Recipe ChocolateEgg = new Recipe { Name = "Chocolate Egg", RecipeBookId = "1000000020", Description = "Chocolate Egg", CountId = "90020", Gil = "100"};
        public static readonly Recipe GreatEgg = new Recipe { Name = "Great Egg", RecipeBookId = "1000000021", Description = "Great Egg", CountId = "90021", Gil = "100"};
        public static readonly Recipe MagicalEgg = new Recipe { Name = "Magical Egg", RecipeBookId = "1000000022", Description = "Magical Egg", CountId = "90022", Gil = "100"};
        public static readonly Recipe RadiantEgg = new Recipe { Name = "Radiant Egg", RecipeBookId = "1000000023", Description = "Radiant Egg", CountId = "90023", Gil = "100"};
        public static readonly Recipe StaffofWrath = new Recipe { Name = "Staff of Wrath", RecipeBookId = "1000000024", Description = "Staff of Wrath", CountId = "90024", Gil = "100"};
        public static readonly Recipe CrownofJustice_1000000025 = new Recipe { Name = "Crown of Justice", RecipeBookId = "1000000025", Description = "Crown of Justice", CountId = "90025", Gil = "100"};
        public static readonly Recipe BlackBandana_1000000026 = new Recipe { Name = "Black Bandana", RecipeBookId = "1000000026", Description = "Black Bandana", CountId = "90026", Gil = "100"};
        public static readonly Recipe SecondKnife = new Recipe { Name = "Second Knife", RecipeBookId = "1000000027", Description = "Second Knife", CountId = "90027", Gil = "100"};
        public static readonly Recipe IcyVeins_1000000028 = new Recipe { Name = "Icy Veins", RecipeBookId = "1000000028", Description = "Icy Veins", CountId = "90028", Gil = "100"};
        public static readonly Recipe ColdSnap = new Recipe { Name = "Cold Snap", RecipeBookId = "1000000029", Description = "Cold Snap", CountId = "90029", Gil = "100"};
        public static readonly Recipe DrakesclawRod = new Recipe { Name = "Drakesclaw Rod", RecipeBookId = "1000000030", Description = "竜爪のロッド", CountId = "90030", Gil = "100"};
        public static readonly Recipe DrakesguardRobe = new Recipe { Name = "Drakesguard Robe", RecipeBookId = "1000000031", Description = "竜護のローブ", CountId = "90031", Gil = "100"};
        public static readonly Recipe BahamutsFang = new Recipe { Name = "Bahamut's Fang", RecipeBookId = "1000000032", Description = "バハムートの牙", CountId = "90032", Gil = "100"};
        public static readonly Recipe DragonsRoar = new Recipe { Name = "Dragon's Roar", RecipeBookId = "1000000033", Description = "ドラゴンズロア", CountId = "90033", Gil = "100"};
        public static readonly Recipe GutsKnuckle = new Recipe { Name = "Guts Knuckle", RecipeBookId = "903001320", Description = "ガッツナックル", CountId = "364", Gil = "6000"};
        public static readonly Recipe GoldenEye = new Recipe { Name = "Golden Eye", RecipeBookId = "903001330", Description = "ゴールデンアイ", CountId = "365", Gil = "2100"};
        public static readonly Recipe ScionStrikersVisor = new Recipe { Name = "Scion Striker's Visor", RecipeBookId = "904001880", Description = "サイオンズストライカー・バイザー", CountId = "369", Gil = "1440"};
        public static readonly Recipe ScionStrikersAttire = new Recipe { Name = "Scion Striker's Attire", RecipeBookId = "904001890", Description = "サイオンズストライカー・アタイア", CountId = "370", Gil = "3000"};
        public static readonly Recipe ScionThaumaturgesMonocle = new Recipe { Name = "Scion Thaumaturge's Monocle", RecipeBookId = "904001900", Description = "サイオンズサーマタージ・モノクル", CountId = "371", Gil = "900"};
        public static readonly Recipe ScionThaumaturgesRobe = new Recipe { Name = "Scion Thaumaturge's Robe", RecipeBookId = "904001910", Description = "サイオンズサーマタージ・ローブ", CountId = "372", Gil = "3000"};
        public static readonly Recipe Adventurer = new Recipe { Name = "Adventurer", RecipeBookId = "1000000034", Description = "冒険者", CountId = "90034", Gil = "10000"};
        public static readonly Recipe AdventurerII = new Recipe { Name = "Adventurer II", RecipeBookId = "1000000035", Description = "冒険者 +1", CountId = "90035", Gil = "10000"};
        public static readonly Recipe AdventurerIII = new Recipe { Name = "Adventurer III", RecipeBookId = "1000000036", Description = "冒険者 +2", CountId = "90036", Gil = "10000"};
        public static readonly Recipe AdventurerIV = new Recipe { Name = "Adventurer IV", RecipeBookId = "1000000037", Description = "冒険者 +3", CountId = "90037", Gil = "10000"};
        public static readonly Recipe AdventurerV = new Recipe { Name = "Adventurer V", RecipeBookId = "1000000038", Description = "冒険者 +4", CountId = "90038", Gil = "10000"};
        public static readonly Recipe BrokenArm = new Recipe { Name = "Broken Arm", RecipeBookId = "903001300", Description = "ブロッケンアーム", CountId = "362", Gil = "6000"};
        public static readonly Recipe AngelWand = new Recipe { Name = "Angel Wand", RecipeBookId = "903001310", Description = "エンジェルワンド", CountId = "363", Gil = "6000"};
        public static readonly Recipe PlatinumMusket = new Recipe { Name = "Platinum Musket", RecipeBookId = "903001340", Description = "プラチナマスケット", CountId = "373", Gil = "3600"};
        public static readonly Recipe AncientOverlord = new Recipe { Name = "Ancient Overlord", RecipeBookId = "903001350", Description = "古の覇王", CountId = "376", Gil = "6000"};
        public static readonly Recipe IronWill = new Recipe { Name = "Iron Will", RecipeBookId = "903001360", Description = "鉄塊", CountId = "377", Gil = "1350"};
        public static readonly Recipe DragoonLance = new Recipe { Name = "Dragoon Lance", RecipeBookId = "903001370", Description = "草原の竜騎槍", CountId = "378", Gil = "4800"};
        public static readonly Recipe TypeFists = new Recipe { Name = "Type-3 Fists", RecipeBookId = "903001380", Description = "三式拳鍔", CountId = "379", Gil = "3000"};
        public static readonly Recipe CruelOath = new Recipe { Name = "Cruel Oath", RecipeBookId = "903001390", Description = "黒の誓約", CountId = "380", Gil = "21000"};
        public static readonly Recipe BellowsArmGuard = new Recipe { Name = "Bellows Arm Guard", RecipeBookId = "904001830", Description = "ジャバラアームカバー", CountId = "364", Gil = "6000"};
        public static readonly Recipe MagicBarrierDevice = new Recipe { Name = "Magic Barrier Device", RecipeBookId = "904001840", Description = "魔導バリア発生装置", CountId = "365", Gil = "6000"};
        public static readonly Recipe ZDHelmet = new Recipe { Name = "ZD Helmet", RecipeBookId = "904001850", Description = "ZDヘルメット", CountId = "366", Gil = "6000"};
        public static readonly Recipe AngelWing = new Recipe { Name = "Angel Wing", RecipeBookId = "904001860", Description = "エンジェルウィング", CountId = "367", Gil = "6000"};
        public static readonly Recipe PlatinumRobe = new Recipe { Name = "Platinum Robe", RecipeBookId = "904001870", Description = "プラチナローブ", CountId = "368", Gil = "900"};
        public static readonly Recipe SeraphimShield = new Recipe { Name = "Seraphim Shield", RecipeBookId = "904001920", Description = "セラフィムシールド", CountId = "374", Gil = "4500"};
        public static readonly Recipe EmilsHead = new Recipe { Name = "Emil's Head", RecipeBookId = "904001930", Description = "エミールの被り物", CountId = "381", Gil = "7200"};
        public static readonly Recipe HeavyArmorB = new Recipe { Name = "Heavy Armor: B", RecipeBookId = "904001940", Description = "重装アーマー：B", CountId = "382", Gil = "1350"};
        public static readonly Recipe PlatinaArmor = new Recipe { Name = "Platina Armor", RecipeBookId = "904001950", Description = "プラチナアーマー", CountId = "383", Gil = "4500"};
        public static readonly Recipe BlizzaraBlade = new Recipe { Name = "Blizzara Blade", RecipeBookId = "905211180", Description = "ブリザラ剣", CountId = "369", Gil = "2400"};
        public static readonly Recipe ThundaraBlade = new Recipe { Name = "Thundara Blade", RecipeBookId = "905211190", Description = "サンダラ剣", CountId = "375", Gil = "2400"};
        public static readonly Recipe AeroraBlade = new Recipe { Name = "Aerora Blade", RecipeBookId = "905211200", Description = "エアロラ剣", CountId = "384", Gil = "2400"};
        public static readonly Recipe PlatinumDagger = new Recipe { Name = "Platinum Dagger", RecipeBookId = "903001400", Description = "プラチナメッサー", CountId = "390", Gil = "1500"};
        public static readonly Recipe ValiantII = new Recipe { Name = "Valiant II", RecipeBookId = "903001410", Description = "バリアントⅡ", CountId = "392", Gil = "18000"};
        public static readonly Recipe PrecisionLance = new Recipe { Name = "Precision Lance", RecipeBookId = "903001420", Description = "プレサイズランス", CountId = "393", Gil = "9600"};
        public static readonly Recipe Valiant = new Recipe { Name = "Valiant", RecipeBookId = "903001430", Description = "バリアント", CountId = "394", Gil = "1080"};
        public static readonly Recipe CypressPile = new Recipe { Name = "Cypress Pile", RecipeBookId = "903001440", Description = "サイプレスパイル", CountId = "398", Gil = "2400"};
        public static readonly Recipe PlatinumSaber = new Recipe { Name = "Platinum Saber", RecipeBookId = "903001450", Description = "プラチナセイバー", CountId = "399", Gil = "4500"};
        public static readonly Recipe Darkbringer = new Recipe { Name = "Darkbringer"};
        public static readonly Recipe YggdrasilStaff = new Recipe { Name = "Yggdrasil Staff"};
        public static readonly Recipe Dragvandil = new Recipe { Name = "Dragvandil"};
        public static readonly Recipe SweetKiss = new Recipe { Name = "Sweet Kiss"};
        public static readonly Recipe PlatinumMace = new Recipe { Name = "Platinum Mace", RecipeBookId = "903001500", Description = "プラチナメイス", CountId = "408", Gil = "810"};
        public static readonly Recipe PlatinumWhip = new Recipe { Name = "Platinum Whip", RecipeBookId = "903001510", Description = "プラチナウィップ", CountId = "409", Gil = "2700"};
        public static readonly Recipe TamersGloves = new Recipe { Name = "Tamer's Gloves"};
        public static readonly Recipe SecretKnife = new Recipe { Name = "Secret Knife"};
        public static readonly Recipe StaffofResentment = new Recipe { Name = "Staff of Resentment"};
        public static readonly Recipe PlatinumEdge = new Recipe { Name = "Platinum Edge", RecipeBookId = "903001550", Description = "プラチナエッジ", CountId = "420", Gil = "900"};
        public static readonly Recipe FierceBow = new Recipe { Name = "Fierce Bow", RecipeBookId = "903001560", Description = "剛弓“烈風新月”", CountId = "421", Gil = "19500"};
        public static readonly Recipe Kogarasumaru = new Recipe { Name = "Kogarasumaru", RecipeBookId = "903001570", Description = "霊剣・小烏丸", CountId = "422", Gil = "8400"};
        public static readonly Recipe ScarletRoses = new Recipe { Name = "Scarlet Roses", RecipeBookId = "903001580", Description = "スカーレットローゼス", CountId = "423", Gil = "7200"};
        public static readonly Recipe Takemikazuchi = new Recipe { Name = "Takemikazuchi", RecipeBookId = "903001590", Description = "霹剣・タケミカヅチ", CountId = "424", Gil = "1500"};
        public static readonly Recipe MetalPipe = new Recipe { Name = "Metal Pipe", RecipeBookId = "903001600", Description = "鉄パイプ", CountId = "425", Gil = "900"};
        public static readonly Recipe PlatinumAxe = new Recipe { Name = "Platinum Axe", RecipeBookId = "903001610", Description = "プラチナアクス", CountId = "427", Gil = "5400"};
        public static readonly Recipe RubberSuit = new Recipe { Name = "Rubber Suit", RecipeBookId = "904001960", Description = "ラバーコンシャス", CountId = "391", Gil = "3000"};
        public static readonly Recipe A1ClassPowershield = new Recipe { Name = "A1-Class Powershield", RecipeBookId = "904001970", Description = "士官用特A級シールド", CountId = "395", Gil = "6000"};
        public static readonly Recipe AssistSuit = new Recipe { Name = "Assist Suit", RecipeBookId = "904001980", Description = "アシストスーツ", CountId = "396", Gil = "3000"};
        public static readonly Recipe ChobhamArmor = new Recipe { Name = "Chobham Armor", RecipeBookId = "904001990", Description = "チョバムアーマー", CountId = "397", Gil = "3600"};
        public static readonly Recipe TacticalManual = new Recipe { Name = "Tactical Manual"};
        public static readonly Recipe MagnoliasUniform = new Recipe { Name = "Magnolia's Uniform"};
        public static readonly Recipe IcyVeins_904002010 = new Recipe { Name = "Icy Veins"};
        public static readonly Recipe BlackBandana_904002020 = new Recipe { Name = "Black Bandana"};
        public static readonly Recipe CrownofJustice_904002030 = new Recipe { Name = "Crown of Justice"};
        public static readonly Recipe JeweledBelt = new Recipe { Name = "Jeweled Belt", RecipeBookId = "904002040", Description = "ジュエルベルト", CountId = "418", Gil = "6000"};
        public static readonly Recipe PlatinumBreastplate = new Recipe { Name = "Platinum Breastplate", RecipeBookId = "904002050", Description = "プラチナの胸当て", CountId = "419", Gil = "7200"};
        public static readonly Recipe RiotGear = new Recipe { Name = "Riot Gear", RecipeBookId = "904002060", Description = "ライオットギア", CountId = "426", Gil = "3600"};
        public static readonly Recipe PlatinumShield = new Recipe { Name = "Platinum Shield", RecipeBookId = "904002070", Description = "プラチナシールド", CountId = "428", Gil = "1080"};
        public static readonly Recipe TrueShardofGenius = new Recipe { Name = "True Shard of Genius", RecipeBookId = "905100300", Description = "真・叡知の結晶", CountId = "385", Gil = "30000"};
        public static readonly Recipe TrueFollowersOath = new Recipe { Name = "True Follower's Oath", RecipeBookId = "905100310", Description = "真・盟主への誓い", CountId = "386", Gil = "2400"};
        public static readonly Recipe TrueHydaelynGuard = new Recipe { Name = "True Hydaelyn Guard", RecipeBookId = "905100320", Description = "真・ハイデリンの加護", CountId = "387", Gil = "15000"};
        public static readonly Recipe TrueSpiritofFreedom = new Recipe { Name = "True Spirit of Freedom", RecipeBookId = "905100330", Description = "真・不羈への気焔", CountId = "388", Gil = "15000"};
        public static readonly Recipe TrueSagesPrajna = new Recipe { Name = "True Sage's Prajna", RecipeBookId = "905100340", Description = "真・賢人の智慧", CountId = "389", Gil = "15000"};
        public static readonly Recipe Kappower = new Recipe { Name = "Kappower", RecipeBookId = "905211210", Description = "カッパワー", CountId = "411", Gil = "2400"};
        public static readonly Recipe AutoBravery = new Recipe { Name = "Auto-Bravery", RecipeBookId = "905100350", Description = "オートブレイブ", CountId = "400", Gil = "2400"};
        public static readonly Recipe AutoFaith = new Recipe { Name = "Auto-Faith", RecipeBookId = "905100360", Description = "オートフェイス", CountId = "401", Gil = "2400"};
        public static readonly Recipe MP_905100370 = new Recipe { Name = "MP + 15%", RecipeBookId = "905100370", Description = "MP+15%", CountId = "410", Gil = "900"};
        public static readonly Recipe KittyHeadband = new Recipe { Name = "Kitty Headband", RecipeBookId = "1000000039", Description = "Kitty Headband", CountId = "90039", Gil = "0"};
        public static readonly Recipe CloakofResentment = new Recipe { Name = "Cloak of Resentment", RecipeBookId = "1000000040", Description = "Cloak of Resentment", CountId = "90040", Gil = "0"};
        public static readonly Recipe SparklingHeels = new Recipe { Name = "Sparkling Heels", RecipeBookId = "1000000041", Description = "Sparkling Heels", CountId = "90041", Gil = "0"};
        public static readonly Recipe EvilPipe = new Recipe { Name = "Evil Pipe", RecipeBookId = "1000000042", Description = "Evil Pipe", CountId = "90042", Gil = "0"};
        public static readonly Recipe PinkStripedFloat = new Recipe { Name = "Pink Striped Float", RecipeBookId = "1000000043", Description = "Pink Striped Float", CountId = "90043", Gil = "0"};
        public static readonly Recipe CheerfulTune = new Recipe { Name = "Cheerful Tune", RecipeBookId = "1500000032", Description = "Cheerful Tune", CountId = "90044", Gil = "0"};
        public static readonly Recipe JoyfulSpirit = new Recipe { Name = "Joyful Spirit", RecipeBookId = "1000000044", Description = "Joyful Spirit", CountId = "90045", Gil = "0"};
        public static readonly Recipe Lightbringer = new Recipe { Name = "Lightbringer", RecipeBookId = "1000000045", Description = "Lightbringer", CountId = "90046", Gil = "0"};
        public static readonly Recipe GraspingSphere = new Recipe { Name = "Grasping Sphere", RecipeBookId = "1000000046", Description = "Grasping Sphere", CountId = "90047", Gil = "0"};
        public static readonly Recipe StaffofBlizzards = new Recipe { Name = "Staff of Blizzards", RecipeBookId = "1000000047", Description = "Staff of Blizzards", CountId = "90048", Gil = "0"};
        public static readonly Recipe WingEdges = new Recipe { Name = "Wing Edges", RecipeBookId = "1000000048", Description = "Wing Edges", CountId = "90049", Gil = "0"};
        public static readonly Recipe SalamandersGauntlets = new Recipe { Name = "Salamander's Gauntlets", RecipeBookId = "1000000049", Description = "Salamander's Gauntlets", CountId = "90050", Gil = "0"};
        public static readonly Recipe CragSplitter = new Recipe { Name = "Crag Splitter", RecipeBookId = "1000000050", Description = "Crag Splitter", CountId = "90051", Gil = "0"};
        public static readonly Recipe FlaxShield = new Recipe { Name = "Flax Shield", RecipeBookId = "1000000051", Description = "Flax Shield", CountId = "90052", Gil = "0"};
        public static readonly Recipe JadeMoonPendant = new Recipe { Name = "Jade Moon Pendant", RecipeBookId = "1000000052", Description = "Jade Pendant of Moon", CountId = "90053", Gil = "0"};
        public static readonly Recipe JadeSunPendant = new Recipe { Name = "Jade Sun Pendant", RecipeBookId = "1000000053", Description = "Jade Pendant of Sun", CountId = "90054", Gil = "0"};
        public static readonly Recipe FieryPassion = new Recipe { Name = "Fiery Passion", RecipeBookId = "1000000054", Description = "Fiery Passion", CountId = "90055", Gil = "0"};
        public static readonly Recipe StaffofOsiris_1000000055 = new Recipe { Name = "Staff of Osiris", RecipeBookId = "1000000055", Description = "Staff of Osiris", CountId = "90056", Gil = "50000"};
        public static readonly Recipe IcyDeath = new Recipe { Name = "Icy Death", RecipeBookId = "1000000056", Description = "Icy Death", CountId = "90057", Gil = "50000"};
        public static readonly Recipe Flamethrower_1000000057 = new Recipe { Name = "Flamethrower", RecipeBookId = "1000000057", Description = "Flamethrower", CountId = "90058", Gil = "50000"};
        public static readonly Recipe ToxicShotgun_1000000058 = new Recipe { Name = "Toxic Shotgun", RecipeBookId = "1000000058", Description = "Toxic Shotgun", CountId = "90059", Gil = "50000"};
        public static readonly Recipe OnyxSpiritofRa = new Recipe { Name = "Onyx Spirit of Ra", RecipeBookId = "1000000059", Description = "Onyx Spirit of Ra", CountId = "90060", Gil = "50000"};
        public static readonly Recipe GoldRingofSet = new Recipe { Name = "Gold Ring of Set", RecipeBookId = "1000000060", Description = "Gold Ring of Set", CountId = "90061", Gil = "50000"};
        public static readonly Recipe PlatinumLance = new Recipe { Name = "Platinum Lance", RecipeBookId = "903001620", Description = "プラチナランス", CountId = "433", Gil = "4800"};
        public static readonly Recipe PlatinumBow = new Recipe { Name = "Platinum Bow", RecipeBookId = "903001630", Description = "プラチナボウ", CountId = "434", Gil = "3900"};
        public static readonly Recipe DiamondKnife = new Recipe { Name = "Diamond Knife", RecipeBookId = "903001640", Description = "ダイヤナイフ", CountId = "452", Gil = "3000"};
        public static readonly Recipe DragonScale_904002080 = new Recipe { Name = "Dragon Scale", RecipeBookId = "904002080", Description = "Dragon Scale", CountId = "429", Gil = "3000"};
        public static readonly Recipe SagesStaff = new Recipe { Name = "Sage's Staff", RecipeBookId = "904002090", Description = "Sage Staff", CountId = "430", Gil = "2400"};
        public static readonly Recipe SacredClaws = new Recipe { Name = "Sacred Claws", RecipeBookId = "904002110", Description = "Sacred Claw", CountId = "431", Gil = "6000"};
        public static readonly Recipe DragovianSpear = new Recipe { Name = "Dragovian Spear", RecipeBookId = "904002120", Description = "Dragonvian Spear", CountId = "432", Gil = "24000"};
        public static readonly Recipe WolfMask = new Recipe { Name = "Wolf Mask", RecipeBookId = "904002130", Description = "ウルフマスク", CountId = "435", Gil = "1500"};
        public static readonly Recipe FestivalRobe_904002140 = new Recipe { Name = "Festival Robe"};
        public static readonly Recipe FestivalCap_904002150 = new Recipe { Name = "Festival Cap"};
        public static readonly Recipe YinYangCharm_904002180 = new Recipe { Name = "Yin Yang Charm"};
        public static readonly Recipe SantasClothesII = new Recipe { Name = "Santa's Clothes II"};
        public static readonly Recipe SantasHatII = new Recipe { Name = "Santa's Hat II"};
        public static readonly Recipe TsukumoDoll_904002210 = new Recipe { Name = "Tsukumo Doll"};
        public static readonly Recipe KimonoVest_904002220 = new Recipe { Name = "Kimono Vest"};
        public static readonly Recipe SantasCane = new Recipe { Name = "Santa's Cane"};
        public static readonly Recipe PlatinumFist = new Recipe { Name = "Platinum Fist", RecipeBookId = "904002240", Description = "プラチナフィスト", CountId = "446", Gil = "3000"};
        public static readonly Recipe GemofCreation = new Recipe { Name = "Gem of Creation", RecipeBookId = "905101520", Description = "生成の珠", CountId = "448", Gil = "2400"};
        public static readonly Recipe GemofVision = new Recipe { Name = "Gem of Vision", RecipeBookId = "905211220", Description = "幻視の珠", CountId = "447", Gil = "2400"};
        public static readonly Recipe NibelungenRing = new Recipe { Name = "Nibelungen Ring", RecipeBookId = "904002270", Description = "ニーベルンゲンの指環", CountId = "449", Gil = "3000"};
        public static readonly Recipe DragoonTyrant = new Recipe { Name = "Dragoon Tyrant", RecipeBookId = "904002280", Description = "吼槍ドラグーン・タイラント", CountId = "450", Gil = "9600"};
        public static readonly Recipe RustRedCirclet = new Recipe { Name = "Rust-Red Circlet", RecipeBookId = "904002290", Description = "鈍色の冠", CountId = "451", Gil = "3000"};
        public static readonly Recipe DiamondRobe = new Recipe { Name = "Diamond Robe", RecipeBookId = "904002300", Description = "ダイヤローブ", CountId = "454", Gil = "6000"};
        public static readonly Recipe FaerieCloak = new Recipe { Name = "Faerie Cloak", RecipeBookId = "904002320", Description = "精霊のマント", CountId = "455", Gil = "15000"};
        public static readonly Recipe FlowerSuit = new Recipe { Name = "Flower Suit", RecipeBookId = "904002330", Description = "バラのレオタード", CountId = "456", Gil = "6000"};
        public static readonly Recipe MagicalArmor = new Recipe { Name = "Magical Armor", RecipeBookId = "904002340", Description = "魔法のヨロイ", CountId = "457", Gil = "3600"};
        public static readonly Recipe FrostyRing = new Recipe { Name = "Frosty Ring", RecipeBookId = "904002350", Description = "スノーマンリング", CountId = "458", Gil = "3000"};
        public static readonly Recipe StaffofOsiris_904002370 = new Recipe { Name = "Staff of Osiris"};
        public static readonly Recipe ToxicShotgun_904002380 = new Recipe { Name = "Toxic Shotgun"};
        public static readonly Recipe Flamethrower_904002390 = new Recipe { Name = "Flamethrower"};
        public static readonly Recipe GoldRingofSeth = new Recipe { Name = "Gold Ring of Seth"};
        public static readonly Recipe DiamondSword = new Recipe { Name = "Diamond Sword", RecipeBookId = "904002410", Description = "ダイヤソード", CountId = "464", Gil = "6000"};
        public static readonly Recipe DiamondArmor = new Recipe { Name = "Diamond Armor", RecipeBookId = "904002420", Description = "ダイヤアーマー", CountId = "465", Gil = "9000"};
        public static readonly Recipe RicosWingsuit = new Recipe { Name = "Rico's Wingsuit", RecipeBookId = "1000000061", Description = "Rico's Wingsuit", CountId = "90062", Gil = "100000"};
        public static readonly Recipe GE_1000000062 = new Recipe { Name = "GE-64", RecipeBookId = "1000000062", Description = "GE-64", CountId = "90063", Gil = "80000"};
        public static readonly Recipe RicosCombatGloves = new Recipe { Name = "Rico's Combat Gloves", RecipeBookId = "1000000063", Description = "Rico's Combat Gloves", CountId = "90064", Gil = "20000"};
        public static readonly Recipe UVK = new Recipe { Name = "UVK-13", RecipeBookId = "1000000064", Description = "UVK-13", CountId = "90065", Gil = "5000"};
        public static readonly Recipe CSWraithR = new Recipe { Name = "CS Wraith 225R", RecipeBookId = "1000000065", Description = "CS Wraith 225R", CountId = "90066", Gil = "5000"};
        public static readonly Recipe UZabijak = new Recipe { Name = "U-24 Zabijak", RecipeBookId = "1000000066", Description = "U-24 Zabijak", CountId = "90067", Gil = "3000"};
        public static readonly Recipe YinYangCharm_1000000067 = new Recipe { Name = "Yin Yang Charm", RecipeBookId = "1000000067", Description = "Yin Yang Charm", CountId = "90068", Gil = "6000"};
        public static readonly Recipe VestmentofPrayers = new Recipe { Name = "Vestment of Prayers", RecipeBookId = "1000000068", Description = "Vestment of Prayers", CountId = "90069", Gil = "3000"};
        public static readonly Recipe WhiteBandana = new Recipe { Name = "White Bandana", RecipeBookId = "1000000069", Description = "White Bandana", CountId = "90070", Gil = "1500"};
        public static readonly Recipe TsukumoDoll_1000000070 = new Recipe { Name = "Tsukumo Doll", RecipeBookId = "1000000070", Description = "Tsukumo Doll", CountId = "90071", Gil = "1500"};
        public static readonly Recipe KimonoVest_1000000071 = new Recipe { Name = "Kimono Vest", RecipeBookId = "1000000071", Description = "Kimono Vest", CountId = "90072", Gil = "900"};
        public static readonly Recipe ElvenStaff = new Recipe { Name = "Elven Staff", RecipeBookId = "1000000072", Description = "Elven Staff", CountId = "90073", Gil = "12000"};
        public static readonly Recipe ZenithZAP = new Recipe { Name = "Zenith ZAP", RecipeBookId = "1000000073", Description = "Zenith ZAP", CountId = "90074", Gil = "5000"};
        public static readonly Recipe TITAN = new Recipe { Name = "TITAN", RecipeBookId = "1000000074", Description = "TITAN", CountId = "90075", Gil = "5000"};
        public static readonly Recipe EMPGrenade = new Recipe { Name = "EMP Grenade", RecipeBookId = "1000000075", Description = "EMP Grenade", CountId = "90076", Gil = "5000"};
        public static readonly Recipe CtedAzurSOW = new Recipe { Name = "Côte d'Azur S.O.W.", RecipeBookId = "1000000076", Description = "Côte d'Azur S.O.W.", CountId = "90077", Gil = "20000"};
        public static readonly Recipe NukeVirusSoftware = new Recipe { Name = "Nuke Virus Software", RecipeBookId = "1000000077", Description = "Nuke Virus Software", CountId = "90078", Gil = "80000"};
        public static readonly Recipe LinebackerGMSGL = new Recipe { Name = "Linebacker G-87 MSGL", RecipeBookId = "1000000078", Description = "Linebacker G-87 MSGL", CountId = "90079", Gil = "100000"};
        public static readonly Recipe SturdyUmbrella = new Recipe { Name = "Sturdy Umbrella", RecipeBookId = "1000000079", Description = "Sturdy Umbrella", CountId = "90080", Gil = "10800"};
        public static readonly Recipe BeachBall = new Recipe { Name = "Beach Ball", RecipeBookId = "1000000080", Description = "Beach Ball", CountId = "90081", Gil = "5800"};
        public static readonly Recipe GE_1000000081 = new Recipe { Name = "G-0991E", RecipeBookId = "1000000081", Description = "G-0991E", CountId = "90082", Gil = "3000"};
        public static readonly Recipe SplashofLife = new Recipe { Name = "Splash of Life", RecipeBookId = "1000000082", Description = "Splash of Life", CountId = "90083", Gil = "1800"};
        public static readonly Recipe RavenFigurine = new Recipe { Name = "Raven Figurine", RecipeBookId = "1000000083", Description = "Raven Figurine", CountId = "90084", Gil = "0"};
        public static readonly Recipe HalfCrescentRod = new Recipe { Name = "Half Crescent Rod", RecipeBookId = "1000000084", Description = "Half Crescent Rod", CountId = "90085", Gil = "0"};
        public static readonly Recipe AvianCloak = new Recipe { Name = "Avian Cloak", RecipeBookId = "1000000085", Description = "Avian Cloak", CountId = "90086", Gil = "0"};
        public static readonly Recipe EmpoweredGauntlets = new Recipe { Name = "Empowered Gauntlets", RecipeBookId = "1000000086", Description = "Empowered Wrist Guards", CountId = "90087", Gil = "0"};
        public static readonly Recipe BizarreSculpture = new Recipe { Name = "Bizarre Sculpture", RecipeBookId = "1000000087", Description = "Bizarre Sculpture", CountId = "90088", Gil = "0"};
        public static readonly Recipe BigRedRibbon = new Recipe { Name = "Big Red Ribbon", RecipeBookId = "1000000088", Description = "Big Red Ribbon", CountId = "90089", Gil = "0"};
        public static readonly Recipe CrimsonVest = new Recipe { Name = "Crimson Vest", RecipeBookId = "904002440", Description = "紅の闘着", CountId = "467", Gil = "15000"};
        public static readonly Recipe GallantBelt = new Recipe { Name = "Gallant Belt", RecipeBookId = "904002450", Description = "闘魂ベルト", CountId = "468", Gil = "6000"};
        public static readonly Recipe Strength = new Recipe { Name = "Strength", RecipeBookId = "904002460", Description = "ストレングス", CountId = "469", Gil = "4500"};
        public static readonly Recipe Etherize = new Recipe { Name = "Etherize", RecipeBookId = "904002470", Description = "エーテライズ", CountId = "470", Gil = "4500"};
        public static readonly Recipe DiamondBreastplate = new Recipe { Name = "Diamond Breastplate", RecipeBookId = "904002480", Description = "ダイヤの胸当て", CountId = "471", Gil = "7200"};
        public static readonly Recipe BlackLeather = new Recipe { Name = "Black Leather", RecipeBookId = "904002490", Description = "ブラックレザー", CountId = "472", Gil = "15000"};
        public static readonly Recipe YamatoBelt = new Recipe { Name = "Yamato Belt", RecipeBookId = "904002500", Description = "大和ベルト", CountId = "473", Gil = "6000"};
        public static readonly Recipe Shielder = new Recipe { Name = "Shielder", RecipeBookId = "904002510", Description = "シールダー", CountId = "474", Gil = "4500"};
        public static readonly Recipe Soulful = new Recipe { Name = "Soulful", RecipeBookId = "904002520", Description = "ソウルフル", CountId = "475", Gil = "4500"};
        public static readonly Recipe TornDress = new Recipe { Name = "Torn Dress", RecipeBookId = "1000000089", Description = "Torn Dress", CountId = "90090", Gil = "0"};
        public static readonly Recipe MetalEarrings = new Recipe { Name = "Metal Earrings", RecipeBookId = "1000000090", Description = "Metal Earring", CountId = "90091", Gil = "0"};
        public static readonly Recipe EternalFlame = new Recipe { Name = "Eternal Flame", RecipeBookId = "1000000091", Description = "Eternal Flame", CountId = "90092", Gil = "0"};
        public static readonly Recipe RuinedShield = new Recipe { Name = "Ruined Shield", RecipeBookId = "1000000092", Description = "Ruined Shield", CountId = "90093", Gil = "0"};
        public static readonly Recipe KatanaProficiency = new Recipe { Name = "Katana Proficiency", RecipeBookId = "1000000093", Description = "Expert Slasher", CountId = "90094", Gil = "0"};
        public static readonly Recipe SpiritualProficiency = new Recipe { Name = "Spiritual Proficiency", RecipeBookId = "1000000094", Description = "Spirit Mastery", CountId = "90095", Gil = "0"};
        public static readonly Recipe DemonicMight = new Recipe { Name = "Demonic Might", RecipeBookId = "1000000095", Description = "Demon's Might", CountId = "90096", Gil = "0"};
        public static readonly Recipe DemonicMind = new Recipe { Name = "Demonic Mind", RecipeBookId = "1000000096", Description = "Demon's Mind", CountId = "90097", Gil = "0"};
        public static readonly Recipe PopstarsMicrophone = new Recipe { Name = "Popstar's Microphone", RecipeBookId = "1000000097", Description = "Popstar Microphone", CountId = "90098", Gil = "0"};
        public static readonly Recipe CrimsonDragonRobe = new Recipe { Name = "Crimson Dragon Robe", RecipeBookId = "1000000098", Description = "Crimson Dragon Robe", CountId = "90099", Gil = "0"};
        public static readonly Recipe CrimsonDragonCowl = new Recipe { Name = "Crimson Dragon Cowl", RecipeBookId = "1000000099", Description = "Crimson Dragon Cowl", CountId = "90100", Gil = "0"};
        public static readonly Recipe CrimsonWedgeHeels = new Recipe { Name = "Crimson Wedge Heels", RecipeBookId = "1000000100", Description = "Crimson Wedge Heels", CountId = "90101", Gil = "0"};
        public static readonly Recipe AdamantiteKatana = new Recipe { Name = "Adamantite Katana", RecipeBookId = "904002530", Description = "金剛石の太刀", CountId = "476", Gil = "8400"};
        public static readonly Recipe DiamondJacket = new Recipe { Name = "Diamond Jacket", RecipeBookId = "904002540", Description = "ダイヤジャケット", CountId = "477", Gil = "6000"};
        public static readonly Recipe GenbuRing = new Recipe { Name = "Genbu Ring", RecipeBookId = "904002550", Description = "玄武の指輪", CountId = "478", Gil = "15000"};
        public static readonly Recipe ByakkoRing = new Recipe { Name = "Byakko Ring", RecipeBookId = "904002560", Description = "白虎の指輪", CountId = "479", Gil = "15000"};
        public static readonly Recipe MetalGreaves = new Recipe { Name = "Metal Greaves", RecipeBookId = "904002570", Description = "メタルグリーヴ", CountId = "480", Gil = "6000"};
        public static readonly Recipe YinYangOrnament = new Recipe { Name = "Yin-Yang Ornament", RecipeBookId = "904002580", Description = "陰陽紋の腰飾り", CountId = "481", Gil = "15000"};
        public static readonly Recipe EliteDogTag = new Recipe { Name = "Elite Dog Tag", RecipeBookId = "904002590", Description = "強兵の証", CountId = "482", Gil = "6000"};
        public static readonly Recipe AldoreSpecialOpsSword = new Recipe { Name = "Aldore Special Ops Sword", RecipeBookId = "904002600", Description = "アルドール精兵用軍剣", CountId = "483", Gil = "3000"};
        public static readonly Recipe TypeAldoreRifle = new Recipe { Name = "Type-23 Aldore Rifle", RecipeBookId = "904002610", Description = "二三式アルドール銃", CountId = "484", Gil = "3600"};
        public static readonly Recipe DiamondSaber = new Recipe { Name = "Diamond Saber", RecipeBookId = "904002620", Description = "ダイヤセイバー", CountId = "485", Gil = "9000"};
        public static readonly Recipe JetBlackEyepatch = new Recipe { Name = "Jet Black Eyepatch", RecipeBookId = "904002630", Description = "烏羽色の眼帯", CountId = "486", Gil = "3000"};
        public static readonly Recipe OctopathSpear = new Recipe { Name = "Octopath Spear", RecipeBookId = "904002640", Description = "オクトパススピア", CountId = "487", Gil = "24000"};
        public static readonly Recipe OctopathDagger = new Recipe { Name = "Octopath Dagger", RecipeBookId = "904002650", Description = "オクトパスダガー", CountId = "488", Gil = "3000"};
        public static readonly Recipe JewelofStrength = new Recipe { Name = "Jewel of Strength", RecipeBookId = "904002660", Description = "力の宝玉", CountId = "489", Gil = "4500"};
        public static readonly Recipe JewelofProtection = new Recipe { Name = "Jewel of Protection", RecipeBookId = "904002670", Description = "守りの宝玉", CountId = "490", Gil = "4500"};
        public static readonly Recipe CrystalCrownKH = new Recipe { Name = "Crystal Crown (KH)", RecipeBookId = "904002900", Description = "クリスタルクラウン(キングダム ハーツ)", CountId = "513", Gil = "7500"};
        public static readonly Recipe EXPEarringKH = new Recipe { Name = "EXP Earring (KH)", RecipeBookId = "904002910", Description = "EXPピアス(キングダム ハーツ)", CountId = "514", Gil = "6000"};
        public static readonly Recipe MagesStaffKH = new Recipe { Name = "Mage's Staff (KH)", RecipeBookId = "904002920", Description = "まどうしの杖(キングダム ハーツ)", CountId = "515", Gil = "2100"};
        public static readonly Recipe KnightsShieldKH = new Recipe { Name = "Knight's Shield (KH)", RecipeBookId = "904002930", Description = "騎士の盾(キングダム ハーツ)", CountId = "516", Gil = "4500"};
        public static readonly Recipe BeastCestus = new Recipe { Name = "Beast Cestus", RecipeBookId = "1000000101", Description = "Beast Cestus", CountId = "90102", Gil = "0"};
        public static readonly Recipe TamersWhip = new Recipe { Name = "Tamer's Whip", RecipeBookId = "1000000102", Description = "Tamer's Whip", CountId = "90103", Gil = "0"};
        public static readonly Recipe BakuyaSword = new Recipe { Name = "Bakuya Sword", RecipeBookId = "1000000103", Description = "Bakuya Sword", CountId = "90104", Gil = "0"};
        public static readonly Recipe KanshouGreatSword = new Recipe { Name = "Kanshou Great Sword", RecipeBookId = "1000000104", Description = "Kanshou Great Sword", CountId = "90105", Gil = "0"};
        public static readonly Recipe RiceCakeShield = new Recipe { Name = "Rice Cake Shield", RecipeBookId = "1000000105", Description = "Rice Cake Shield", CountId = "90106", Gil = "0"};
        public static readonly Recipe GiantChopstick = new Recipe { Name = "Giant Chopstick", RecipeBookId = "1000000106", Description = "Giant Chopstick", CountId = "90107", Gil = "0"};
        public static readonly Recipe DemonRevealingMirror = new Recipe { Name = "Demon-Revealing Mirror", RecipeBookId = "1000000107", Description = "Demon-Revealing Mirror", CountId = "90108", Gil = "0"};
        public static readonly Recipe TranscendentSoul = new Recipe { Name = "Transcendent Soul", RecipeBookId = "1000000108", Description = "Transcendent Soul", CountId = "90109", Gil = "0"};
        public static readonly Recipe DiamondHelm = new Recipe { Name = "Diamond Helm", RecipeBookId = "904002680", Description = "ダイヤヘルム", CountId = "491", Gil = "7200"};
        public static readonly Recipe DiamondLance = new Recipe { Name = "Diamond Lance", RecipeBookId = "904002740", Description = "ダイヤランス", CountId = "497", Gil = "9600"};
        public static readonly Recipe SoulofDarkness = new Recipe { Name = "Soul of Darkness", RecipeBookId = "1000000109", Description = "Soul of Darkness", CountId = "90110", Gil = "0"};
        public static readonly Recipe WovenTrapperCap = new Recipe { Name = "Woven Trapper Cap", RecipeBookId = "1000000110", Description = "Woven Trapper Cap", CountId = "90111", Gil = "0"};
        public static readonly Recipe EnchantedBrooch = new Recipe { Name = "Enchanted Brooch", RecipeBookId = "1000000111", Description = "Enchanted Brooch", CountId = "90112", Gil = "0"};
        public static readonly Recipe TatteredOvercoat = new Recipe { Name = "Tattered Overcoat", RecipeBookId = "1000000112", Description = "tattered Overcoat", CountId = "90113", Gil = "0"};
        public static readonly Recipe ShatteredYari = new Recipe { Name = "Shattered Yari", RecipeBookId = "1000000113", Description = "Shattered Yari", CountId = "90114", Gil = "0"};
        public static readonly Recipe CursedLocket = new Recipe { Name = "Cursed Locket", RecipeBookId = "1000000114", Description = "Cursed Locket", CountId = "90115", Gil = "0"};
        public static readonly Recipe StoneBracer = new Recipe { Name = "Stone Bracer", RecipeBookId = "1000000115", Description = "Stone Bracer", CountId = "90116", Gil = "0"};
        public static readonly Recipe StoneCrown = new Recipe { Name = "Stone Crown", RecipeBookId = "1000000116", Description = "Stone Crown", CountId = "90117", Gil = "0"};
        public static readonly Recipe StoneVest = new Recipe { Name = "Stone Vest", RecipeBookId = "1000000117", Description = "Stone Vest", CountId = "90118", Gil = "0"};
        public static readonly Recipe TectonicBracer = new Recipe { Name = "Tectonic Bracer", RecipeBookId = "1000000118", Description = "Tectonic Bracer", CountId = "90119", Gil = "0"};
        public static readonly Recipe TectonicCrown = new Recipe { Name = "Tectonic Crown", RecipeBookId = "1000000119", Description = "Tectonic Crown", CountId = "90120", Gil = "0"};
        public static readonly Recipe TectonicVest = new Recipe { Name = "Tectonic Vest", RecipeBookId = "1000000120", Description = "Tectonic Vest", CountId = "90121", Gil = "0"};
        public static readonly Recipe DiamondTiara = new Recipe { Name = "Diamond Tiara", RecipeBookId = "904002760", Description = "ダイヤティアラ", CountId = "499", Gil = "3000"};
        public static readonly Recipe CrimsonsCoat = new Recipe { Name = "Crimson's Coat", RecipeBookId = "904002690", Description = "クリムゾンの服", CountId = "492", Gil = "6000"};
        public static readonly Recipe BattleGarb = new Recipe { Name = "Battle Garb", RecipeBookId = "904002430", Description = "戦装束", CountId = "466", Gil = "6000"};
        public static readonly Recipe DiamondStaff = new Recipe { Name = "Diamond Staff", RecipeBookId = "904002820", Description = "ダイヤの杖", CountId = "505", Gil = "4800"};
        public static readonly Recipe GatlingArm = new Recipe { Name = "Gatling Arm", RecipeBookId = "904002750", Description = "ハンドガトリング", CountId = "498", Gil = "7200"};
        public static readonly Recipe FrostedGown = new Recipe { Name = "Frosted Gown", RecipeBookId = "1000000121", Description = "Frosted Gown", CountId = "90122", Gil = "0"};
        public static readonly Recipe FrostedStilettos = new Recipe { Name = "Frosted Stilettos", RecipeBookId = "1000000122", Description = "Frosted Stilettos", CountId = "90123", Gil = "0"};
        public static readonly Recipe LuckyCloverHairpin = new Recipe { Name = "Lucky Clover Hairpin", RecipeBookId = "1000000123", Description = "Lucky Clover Hairpin", CountId = "90124", Gil = "0"};
        public static readonly Recipe FrostedMicrophone = new Recipe { Name = "Frosted Microphone", RecipeBookId = "1000000124", Description = "Frosted Microphone", CountId = "90125", Gil = "0"};
        public static readonly Recipe DiamondShieldFFBE = new Recipe { Name = "Diamond Shield (FFBE)", RecipeBookId = "904002880", Description = "ダイヤシールド(FFBE)", CountId = "511", Gil = "9000"};
        public static readonly Recipe SilverKnightsGauntlet = new Recipe { Name = "Silver Knight's Gauntlet", RecipeBookId = "904002770", Description = "白銀の騎士籠手", CountId = "500", Gil = "6000"};
        public static readonly Recipe Onimaru = new Recipe { Name = "Onimaru+", RecipeBookId = "1000000125", Description = "Onimaru +", CountId = "90126", Gil = "0"};
        public static readonly Recipe DiamondRod = new Recipe { Name = "Diamond Rod", RecipeBookId = "904002940", Description = "ダイヤロッド", CountId = "517", Gil = "4200"};
        public static readonly Recipe DiamondBuckler = new Recipe { Name = "Diamond Buckler", RecipeBookId = "904002990", Description = "ダイヤバックラー", CountId = "522", Gil = "7200"};
        public static readonly Recipe PeaceRingFFVII = new Recipe { Name = "Peace Ring (FFVII)", RecipeBookId = "904002700", Description = "安らぎの指輪（FFVII)", CountId = "493", Gil = "15000"};
        public static readonly Recipe StandardIssueSword = new Recipe { Name = "Standard-Issue Sword", RecipeBookId = "904002710", Description = "支給品の剣", CountId = "494", Gil = "6000"};
        public static readonly Recipe ShinraAlpha = new Recipe { Name = "Shinra Alpha", RecipeBookId = "904002720", Description = "神羅甲型防具改", CountId = "495", Gil = "3000"};
        public static readonly Recipe CurseRingFFVII = new Recipe { Name = "Curse Ring (FFVII)", RecipeBookId = "904002730", Description = "呪いの指輪（FFVII)", CountId = "496", Gil = "3000"};
        public static readonly Recipe AmuletofDarkness = new Recipe { Name = "Amulet of Darkness", RecipeBookId = "1000000126", Description = "Amulet of Darkness", CountId = "90127", Gil = "0"};
        public static readonly Recipe HoodofDarkness = new Recipe { Name = "Hood of Darkness", RecipeBookId = "1000000127", Description = "Hood of Darkness", CountId = "90128", Gil = "0"};
        public static readonly Recipe MantleofDarkness = new Recipe { Name = "Mantle of Darkness", RecipeBookId = "1000000128", Description = "Mantle of Darkness", CountId = "90129", Gil = "0"};
        public static readonly Recipe AileensDress = new Recipe { Name = "Aileen’s Dress", RecipeBookId = "904002780", Description = "アイリーンのドレス", CountId = "501", Gil = "15000"};
        public static readonly Recipe ATypeRifleScope = new Recipe { Name = "A-Type Rifle Scope", RecipeBookId = "904002790", Description = "A式ライフルスコープ", CountId = "502", Gil = "6000"};
        public static readonly Recipe FloralObi = new Recipe { Name = "Floral Obi", RecipeBookId = "904002800", Description = "華紋帯", CountId = "503", Gil = "3000"};
        public static readonly Recipe ThirdAnniversaryPartyGuest = new Recipe { Name = "Third Anniversary Party Guest", RecipeBookId = "904002810", Description = "三周年記念パーティー出席者", CountId = "504", Gil = "4500"};
        public static readonly Recipe EsperOre = new Recipe { Name = "Esper Ore", RecipeBookId = "1000200100", Description = "Esper Ore", CountId = "90130", Gil = "0"};
        public static readonly Recipe RedEsperOre = new Recipe { Name = "Red Esper Ore", RecipeBookId = "1000200101", Description = "Red Esper Ore", CountId = "90131", Gil = "0"};
        public static readonly Recipe BlueEsperOre = new Recipe { Name = "Blue Esper Ore", RecipeBookId = "1000200102", Description = "Blue Esper Ore", CountId = "90132", Gil = "0"};
        public static readonly Recipe GreenEsperOre = new Recipe { Name = "Green Esper Ore", RecipeBookId = "1000200103", Description = "Green Esper Ore", CountId = "90133", Gil = "0"};
        public static readonly Recipe WhiteEsperOre = new Recipe { Name = "White Esper Ore", RecipeBookId = "1000200104", Description = "White Esper Ore", CountId = "90134", Gil = "0"};
        public static readonly Recipe BlackEsperOre = new Recipe { Name = "Black Esper Ore", RecipeBookId = "1000200105", Description = "Black Esper Ore", CountId = "90135", Gil = "0"};
        public static readonly Recipe YellowEsperOre = new Recipe { Name = "Yellow Esper Ore", RecipeBookId = "1000200106", Description = "Yellow Esper Ore", CountId = "90136", Gil = "0"};
        public static readonly Recipe OrangeEsperOre = new Recipe { Name = "Orange Esper Ore", RecipeBookId = "1000200107", Description = "Orange Esper Ore", CountId = "90137", Gil = "0"};
        public static readonly Recipe VioletEsperOre = new Recipe { Name = "Violet Esper Ore", RecipeBookId = "1000200108", Description = "Violet Esper Ore", CountId = "90138", Gil = "0"};
        public static readonly Recipe FanofFlames = new Recipe { Name = "Fan of Flames", RecipeBookId = "1000000129", Description = "Fan of Flame", CountId = "90139", Gil = "0"};
        public static readonly Recipe HairpinofFlames = new Recipe { Name = "Hairpin of Flames", RecipeBookId = "1000000130", Description = "Hairpin of Flame", CountId = "90140", Gil = "0"};
        public static readonly Recipe YukataofFlames = new Recipe { Name = "Yukata of Flames", RecipeBookId = "1000000131", Description = "Yukata of Flame", CountId = "90141", Gil = "0"};
        public static readonly Recipe FireFoxPlushie = new Recipe { Name = "Fire Fox Plushie", RecipeBookId = "1000000132", Description = "Fire Fox Plushie", CountId = "90142", Gil = "0"};
        public static readonly Recipe FireFoxMask = new Recipe { Name = "Fire Fox Mask", RecipeBookId = "1000000133", Description = "Fire Fox Mask", CountId = "90143", Gil = "0"};
        public static readonly Recipe FireFoxCloak = new Recipe { Name = "Fire Fox Cloak", RecipeBookId = "1000000134", Description = "Fire Fox Clothes", CountId = "90144", Gil = "0"};
        public static readonly Recipe MPHaste = new Recipe { Name = "MP Haste", RecipeBookId = "904003370", Description = "MPヘイスト", CountId = "560", Gil = "9000"};
        public static readonly Recipe EXPBraceletKH = new Recipe { Name = "EXP Bracelet (KH)", RecipeBookId = "904003380", Description = "EXPブレスレット（キングダム ハーツ）", CountId = "561", Gil = "6000"};
        public static readonly Recipe DodgeRoll = new Recipe { Name = "Dodge Roll", RecipeBookId = "904003390", Description = "ドッジロール", CountId = "562", Gil = "15000"};
        public static readonly Recipe SephirothsBootsKH = new Recipe { Name = "Sephiroth's Boots (KH)", RecipeBookId = "904003400", Description = "セフィロスのブーツ（キングダム ハーツ）", CountId = "563", Gil = "30000"};
        public static readonly Recipe FloatSandals = new Recipe { Name = "Float Sandals", RecipeBookId = "904002830", Description = "フロートサンダル", CountId = "506", Gil = "6000"};
        public static readonly Recipe BlackRobeFFV = new Recipe { Name = "Black Robe (FFV)", RecipeBookId = "904002840", Description = "??????", CountId = "507", Gil = "15000"};
        public static readonly Recipe FlameRing = new Recipe { Name = "Flame Ring", RecipeBookId = "904002850", Description = "???????", CountId = "508", Gil = "6000"};
        public static readonly Recipe CoralRing = new Recipe { Name = "Coral Ring", RecipeBookId = "904002860", Description = "???????", CountId = "509", Gil = "6000"};
        public static readonly Recipe HeartsAgainsttheVoid = new Recipe { Name = "Hearts Against the Void", RecipeBookId = "904002870", Description = "?????", CountId = "510", Gil = "4500"};
        public static readonly Recipe CharcoalRelic = new Recipe { Name = "Charcoal Relic", RecipeBookId = "1000000135", Description = "Charcoal Relic Recipe", CountId = "90145", Gil = "0"};
        public static readonly Recipe CharcoalHood = new Recipe { Name = "Charcoal Hood", RecipeBookId = "1000000136", Description = "Charcoal Hood Recipe", CountId = "90146", Gil = "0"};
        public static readonly Recipe CharcoalCloak = new Recipe { Name = "Charcoal Cloak", RecipeBookId = "1000000137", Description = "Charcoal Cloak Recipe", CountId = "90147", Gil = "0"};
        public static readonly Recipe AshenRelic = new Recipe { Name = "Ashen Relic", RecipeBookId = "1000000138", Description = "Ashen Relic Recipe", CountId = "90148", Gil = "0"};
        public static readonly Recipe AshenHood = new Recipe { Name = "Ashen Hood", RecipeBookId = "1000000139", Description = "Ashen Hood Recipe", CountId = "90149", Gil = "0"};
        public static readonly Recipe AshenCloak = new Recipe { Name = "Ashen Cloak", RecipeBookId = "1000000140", Description = "Ashen Cloak Recipe", CountId = "90150", Gil = "0"};
        public static readonly Recipe CPRKit = new Recipe { Name = "CPR Kit", RecipeBookId = "1000000141", Description = "CPR Kit Recipe", CountId = "90151", Gil = "0"};
        public static readonly Recipe EnergizingShot = new Recipe { Name = "Energizing Shot", RecipeBookId = "1000000142", Description = "Energizing Shot Recipe", CountId = "90152", Gil = "0"};
        public static readonly Recipe RestorativeShot = new Recipe { Name = "Restorative Shot", RecipeBookId = "1000000143", Description = "Restorative Shot Recipe", CountId = "90153", Gil = "0"};
        public static readonly Recipe Flamboyant = new Recipe { Name = "Flamboyant", RecipeBookId = "904002950", Description = "フランボワイヤン", CountId = "518", Gil = "10500"};
        public static readonly Recipe FourPointShuriken = new Recipe { Name = "Four-Point Shuriken", RecipeBookId = "904002960", Description = "四方手裏剣", CountId = "519", Gil = "6000"};
        public static readonly Recipe NinjaGearFFVI = new Recipe { Name = "Ninja Gear (FFVI)", RecipeBookId = "904002970", Description = "忍びの衣(FFVI)", CountId = "520", Gil = "3000"};
        public static readonly Recipe KnowledgeofKatanasandRods = new Recipe { Name = "Knowledge of Katanas and Rods", RecipeBookId = "904002980", Description = "刀・ロッド熟知", CountId = "521", Gil = "4500"};
        public static readonly Recipe KingRainsCloak = new Recipe { Name = "King Rain's Cloak", RecipeBookId = "904003050", Description = "レイン王のマント", CountId = "524", Gil = "6000"};
        public static readonly Recipe DemonSpear = new Recipe { Name = "Demon Spear", RecipeBookId = "904003510", Description = "デーモンスピア", CountId = "589", Gil = "48000"};
        public static readonly Recipe CombatCostume = new Recipe { Name = "Combat Costume", RecipeBookId = "904003520", Description = "ぶしんのドレス", CountId = "590", Gil = "15000"};
        public static readonly Recipe ScholarsSpecs = new Recipe { Name = "Scholar's Specs", RecipeBookId = "904003530", Description = "インテリめがね", CountId = "591", Gil = "6000"};
        public static readonly Recipe PuffPuff = new Recipe { Name = "Puff-Puff", RecipeBookId = "904003540", Description = "ぱふぱふ", CountId = "592", Gil = "9000"};
        public static readonly Recipe LibertyAction = new Recipe { Name = "Liberty Action", RecipeBookId = "904002890", Description = "リバティアクション", CountId = "512", Gil = "7200"};
        public static readonly Recipe ToysWindUpKey = new Recipe { Name = "Toy's Wind-Up Key", RecipeBookId = "1000000144", Description = "Toy's Wind-Up Key", CountId = "90154", Gil = "0"};
        public static readonly Recipe ToyElfsHat = new Recipe { Name = "Toy Elf's Hat", RecipeBookId = "1000000145", Description = "Toy Elf's Hat", CountId = "90155", Gil = "0"};
        public static readonly Recipe ToyElfsTunic = new Recipe { Name = "Toy Elf's Tunic", RecipeBookId = "1000000146", Description = "Toy Elf's Tunic", CountId = "90156", Gil = "0"};
        public static readonly Recipe FestiveSnowGlobe = new Recipe { Name = "Festive Snow Globe", RecipeBookId = "1000000147", Description = "Festive Snow Globe", CountId = "90157", Gil = "0"};
        public static readonly Recipe FestiveReindeerAntlers = new Recipe { Name = "Festive Reindeer Antlers", RecipeBookId = "1000000148", Description = "Festive Reindeer Antlers", CountId = "90158", Gil = "0"};
        public static readonly Recipe FestiveElfSuit = new Recipe { Name = "Festive Elf Suit", RecipeBookId = "1000000149", Description = "Festive Elf Suit", CountId = "90159", Gil = "0"};
        public static readonly Recipe BoxofRegalement = new Recipe { Name = "Box of Regalement", RecipeBookId = "1000000150", Description = "Box of Regalement", CountId = "90160", Gil = "0"};
        public static readonly Recipe Snowball = new Recipe { Name = "Snowball", RecipeBookId = "1000000151", Description = "Snowball", CountId = "90161", Gil = "0"};
        public static readonly Recipe CrimsonEmpress = new Recipe { Name = "Crimson Empress", RecipeBookId = "904003000", Description = "紅き女帝", CountId = "523", Gil = "6000"};
        public static readonly Recipe TruePremiumLeatherJacket = new Recipe { Name = "True Premium Leather Jacket", RecipeBookId = "904003130", Description = "真・プレミアムレザー", CountId = "536", Gil = "30000"};
        public static readonly Recipe PremiumLeatherJacket = new Recipe { Name = "Premium Leather Jacket", RecipeBookId = "904003140", Description = "プレミアムレザー", CountId = "537", Gil = "15000"};
        public static readonly Recipe ObsidianGreatsword = new Recipe { Name = "Obsidian Greatsword", RecipeBookId = "904003150", Description = "黒曜の大剣", CountId = "538", Gil = "9000"};
        public static readonly Recipe EnduringFlame = new Recipe { Name = "Enduring Flame", RecipeBookId = "904003160", Description = "硬火の術", CountId = "539", Gil = "4500"};
        public static readonly Recipe PyroGlacialDefender = new Recipe { Name = "Pyro Glacial Defender", RecipeBookId = "904003060", Description = "氷炎ノ護刀", CountId = "529", Gil = "8400"};
        public static readonly Recipe PurifiedRing = new Recipe { Name = "Purified Ring", RecipeBookId = "1000000152", Description = "Purified Band", CountId = "90162", Gil = "0"};
        public static readonly Recipe FaithswornRing = new Recipe { Name = "Faithsworn Ring", RecipeBookId = "1000000153", Description = "Faithsworn Band", CountId = "90163", Gil = "0"};
        public static readonly Recipe MajesticHeaddressandHeadband = new Recipe { Name = "Majestic Headdress and Headband", RecipeBookId = "1000000154", Description = "Majestic Hairpiece and Headband", CountId = "90164", Gil = "0"};
        public static readonly Recipe ImperialHeaddressandHeadband = new Recipe { Name = "Imperial Headdress and Headband", RecipeBookId = "1000000155", Description = "Imperial Hairpiece and Headband", CountId = "90165", Gil = "0"};
        public static readonly Recipe RusticSandals = new Recipe { Name = "Rustic Sandals", RecipeBookId = "1000000156", Description = "Rustic Sandals", CountId = "90166", Gil = "0"};
        public static readonly Recipe RusticHeadscarf = new Recipe { Name = "Rustic Headscarf", RecipeBookId = "1000000157", Description = "Rustic Headscarf", CountId = "90167", Gil = "0"};
        public static readonly Recipe RusticGarb = new Recipe { Name = "Rustic Garb", RecipeBookId = "1000000158", Description = "Rustic Garb", CountId = "90168", Gil = "0"};
        public static readonly Recipe ElegantPendant = new Recipe { Name = "Elegant Pendant", RecipeBookId = "1000000159", Description = "Elegant Pendant", CountId = "90169", Gil = "0"};
        public static readonly Recipe ElegantHairOrnament = new Recipe { Name = "Elegant Hair Ornament", RecipeBookId = "1000000160", Description = "Elegant Hair Ornament", CountId = "90170", Gil = "0"};
        public static readonly Recipe ElegantApparel = new Recipe { Name = "Elegant Apparel", RecipeBookId = "1000000161", Description = "Elegant Apparel", CountId = "90171", Gil = "0"};
        public static readonly Recipe FlameSwordFFIV = new Recipe { Name = "Flame Sword (FFIV)", RecipeBookId = "904003170", Description = "フレイムソード(FFIV)", CountId = "540", Gil = "15000"};
        public static readonly Recipe SPR_904003180 = new Recipe { Name = "SPR +30%", RecipeBookId = "904003180", Description = "精神+30%", CountId = "541", Gil = "4500"};
        public static readonly Recipe RedPetals = new Recipe { Name = "Red Petals", RecipeBookId = "1000000162", Description = "Red Petals", CountId = "90172", Gil = "0"};
        public static readonly Recipe FragrantFlowers = new Recipe { Name = "Fragrant Flowers", RecipeBookId = "1000000163", Description = "Fragrant Flowers", CountId = "90173", Gil = "0"};
        public static readonly Recipe BouquetofRoses = new Recipe { Name = "Bouquet of Roses", RecipeBookId = "1000000164", Description = "Bouquet of Roses", CountId = "90174", Gil = "0"};
        public static readonly Recipe LoveisVital = new Recipe { Name = "Love is Vital", RecipeBookId = "1000000165", Description = "Love is Vital", CountId = "90175", Gil = "0"};
        public static readonly Recipe LoveisMagical = new Recipe { Name = "Love is Magical", RecipeBookId = "1000000166", Description = "Love is Magical", CountId = "90176", Gil = "0"};
        public static readonly Recipe EdelsEarrings = new Recipe { Name = "Edel's Earrings", RecipeBookId = "904003110", Description = "エーデルのイヤリング", CountId = "534", Gil = "6000"};
        public static readonly Recipe SniperGoggles = new Recipe { Name = "Sniper Goggles", RecipeBookId = "904003120", Description = "スナイパーゴーグル", CountId = "535", Gil = "3000"};
        public static readonly Recipe Paikea = new Recipe { Name = "Paikea", RecipeBookId = "904003420", Description = "パイケア", CountId = "574", Gil = "21000"};
        public static readonly Recipe Khandroma = new Recipe { Name = "Khandroma", RecipeBookId = "904003430", Description = "カンドローマ", CountId = "575", Gil = "7500"};
        public static readonly Recipe CobraKnife = new Recipe { Name = "Cobra Knife", RecipeBookId = "904003440", Description = "コブラナイフ", CountId = "576", Gil = "3000"};
        public static readonly Recipe CobraHat = new Recipe { Name = "Cobra Hat", RecipeBookId = "904003450", Description = "コブラハット", CountId = "577", Gil = "3000"};
        public static readonly Recipe GunnerYunasDress = new Recipe { Name = "Gunner Yuna's Dress+", RecipeBookId = "904003340", Description = "真・ガンナーユウナのドレス", CountId = "557", Gil = "30000"};
        public static readonly Recipe ThiefRikkusBandana = new Recipe { Name = "Thief Rikku's Bandana+", RecipeBookId = "904003350", Description = "真・シーフリュックのバンダナ", CountId = "558", Gil = "30000"};
        public static readonly Recipe WarriorPainesGuise = new Recipe { Name = "Warrior Paine's Guise+", RecipeBookId = "904003360", Description = "真・戦士パインのドレス", CountId = "559", Gil = "30000"};
        public static readonly Recipe TheLivingofSpira_904003290 = new Recipe { Name = "The Living of Spira", RecipeBookId = "904003290", Description = "スピラで生きる者", CountId = "552", Gil = "15000"};
        public static readonly Recipe TheLivingofSpira_904003300 = new Recipe { Name = "The Living of Spira+", RecipeBookId = "904003300", Description = "スピラで生きる者 改", CountId = "553", Gil = "30000"};
        public static readonly Recipe StateAlchemistsWatch = new Recipe { Name = "State Alchemist's Watch", RecipeBookId = "904003570", Description = "国家錬金術師の銀時計", CountId = "595", Gil = "30000"};
        public static readonly Recipe AlphonseDoll = new Recipe { Name = "Alphonse Doll", RecipeBookId = "904003580", Description = "アルフォンス人形", CountId = "596", Gil = "15000"};
        public static readonly Recipe HawkeyesHandgun = new Recipe { Name = "Hawkeye's Handgun", RecipeBookId = "904003590", Description = "リザ・ホークアイの拳銃", CountId = "597", Gil = "7200"};
        public static readonly Recipe WinrysBandana = new Recipe { Name = "Winry's Bandana", RecipeBookId = "904003600", Description = "ウィンリィのバンダナ", CountId = "598", Gil = "3000"};
        public static readonly Recipe AldorePoliceMedal = new Recipe { Name = "Aldore Police Medal", RecipeBookId = "904003240", Description = "アルドール警察勲章", CountId = "547", Gil = "6000"};
        public static readonly Recipe InfernoSaber_904003460 = new Recipe { Name = "Inferno Saber+", RecipeBookId = "904003460", Description = "真・インフェルノセイバー", CountId = "578", Gil = "45000"};
        public static readonly Recipe InfernoSaber_904003470 = new Recipe { Name = "Inferno Saber++", RecipeBookId = "904003470", Description = "絶・インフェルノセイバー", CountId = "579", Gil = "90000"};
        public static readonly Recipe DragonWingBow = new Recipe { Name = "Dragon Wing Bow+", RecipeBookId = "904003480", Description = "真・竜翼の弓", CountId = "580", Gil = "39000"};
        public static readonly Recipe DiabolossRod = new Recipe { Name = "Diabolos's Rod+", RecipeBookId = "904003490", Description = "真・ディアボロスロッド", CountId = "581", Gil = "21000"};
        public static readonly Recipe FierceGoddesssKatana = new Recipe { Name = "Fierce Goddess's Katana+", RecipeBookId = "904003500", Description = "真・鬼神刀", CountId = "582", Gil = "42000"};
        public static readonly Recipe DarkGambanteinn_903020300 = new Recipe { Name = "Dark Gambanteinn (2★)", RecipeBookId = "903020300", Description = "ダークガンバンテイン(★2)", CountId = "608", Gil = "84"};
        public static readonly Recipe DarkGambanteinn_903020310 = new Recipe { Name = "Dark Gambanteinn (3★)", RecipeBookId = "903020310", Description = "ダークガンバンテイン(★3)", CountId = "609", Gil = "210"};
        public static readonly Recipe DarkGambanteinn_903020320 = new Recipe { Name = "Dark Gambanteinn (4★)", RecipeBookId = "903020320", Description = "ダークガンバンテイン(★4)", CountId = "610", Gil = "630"};
        public static readonly Recipe DarkGambanteinn_903020330 = new Recipe { Name = "Dark Gambanteinn (5★)", RecipeBookId = "903020330", Description = "ダークガンバンテイン(★5)", CountId = "611", Gil = "2100"};
        public static readonly Recipe DarkGambanteinn_903020340 = new Recipe { Name = "Dark Gambanteinn+ (6★)", RecipeBookId = "903020340", Description = "ダークガンバンテイン改(★6)", CountId = "612", Gil = "4200"};
        public static readonly Recipe DarkGambanteinn_903020350 = new Recipe { Name = "Dark Gambanteinn+ (7★)", RecipeBookId = "903020350", Description = "ダークガンバンテイン改(★7)", CountId = "613", Gil = "10500"};
        public static readonly Recipe DarkGambanteinn_903020360 = new Recipe { Name = "Dark Gambanteinn+ (8★)", RecipeBookId = "903020360", Description = "ダークガンバンテイン改(★8)", CountId = "614", Gil = "21000"};
        public static readonly Recipe DarkGambanteinn_903020370 = new Recipe { Name = "Dark Gambanteinn+ (9★)", RecipeBookId = "903020370", Description = "ダークガンバンテイン改(★9)", CountId = "615", Gil = "42000"};
        public static readonly Recipe DarkGambanteinn_903020380 = new Recipe { Name = "Dark Gambanteinn++ (10★)", RecipeBookId = "903020380", Description = "真・ダークガンバンテイン(★10)", CountId = "616", Gil = "84000"};
        public static readonly Recipe DarkRagnarok_903020110 = new Recipe { Name = "Dark Ragnarok (2★)", RecipeBookId = "903020110", Description = "ダークラグナロク(★2)", CountId = "564", Gil = "120"};
        public static readonly Recipe DarkRagnarok_903020120 = new Recipe { Name = "Dark Ragnarok (3★)", RecipeBookId = "903020120", Description = "ダークラグナロク(★3)", CountId = "565", Gil = "300"};
        public static readonly Recipe DarkRagnarok_903020130 = new Recipe { Name = "Dark Ragnarok (4★)", RecipeBookId = "903020130", Description = "ダークラグナロク(★4)", CountId = "566", Gil = "900"};
        public static readonly Recipe DarkRagnarok_903020140 = new Recipe { Name = "Dark Ragnarok (5★)", RecipeBookId = "903020140", Description = "ダークラグナロク(★5)", CountId = "567", Gil = "3000"};
        public static readonly Recipe DarkRagnarok_903020150 = new Recipe { Name = "Dark Ragnarok+ (6★)", RecipeBookId = "903020150", Description = "ダークラグナロク改(★6)", CountId = "568", Gil = "6000"};
        public static readonly Recipe DarkRagnarok_903020160 = new Recipe { Name = "Dark Ragnarok+ (7★)", RecipeBookId = "903020160", Description = "ダークラグナロク改(★7)", CountId = "569", Gil = "15000"};
        public static readonly Recipe DarkRagnarok_903020170 = new Recipe { Name = "Dark Ragnarok+ (8★)", RecipeBookId = "903020170", Description = "ダークラグナロク改(★8)", CountId = "570", Gil = "30000"};
        public static readonly Recipe DarkRagnarok_903020180 = new Recipe { Name = "Dark Ragnarok+ (9★)", RecipeBookId = "903020180", Description = "ダークラグナロク改(★9)", CountId = "571", Gil = "60000"};
        public static readonly Recipe DarkRagnarok_903020190 = new Recipe { Name = "Dark Ragnarok++ (10★)", RecipeBookId = "903020190", Description = "真・ダークラグナロク(★10)", CountId = "572", Gil = "120000"};
        public static readonly Recipe MagicBangle_904003250 = new Recipe { Name = "Magic Bangle+", RecipeBookId = "904003250", Description = "真・マジック・バングル", CountId = "548", Gil = "30000"};
        public static readonly Recipe MagicBangle_904003260 = new Recipe { Name = "Magic Bangle", RecipeBookId = "904003260", Description = "マジック・バングル", CountId = "549", Gil = "15000"};
        public static readonly Recipe EmeraldNecklace = new Recipe { Name = "Emerald Necklace", RecipeBookId = "904003270", Description = "青灰色の首飾り", CountId = "550", Gil = "3000"};
        public static readonly Recipe DropfromtheHolyGrail = new Recipe { Name = "Drop from the Holy Grail", RecipeBookId = "904003280", Description = "聖杯の雫", CountId = "551", Gil = "4500"};
        public static readonly Recipe IceDemonsKatana_903020200 = new Recipe { Name = "Ice Demon's Katana+", RecipeBookId = "903020200", Description = "真・氷魔ノ刀", CountId = "583", Gil = "42000"};
        public static readonly Recipe IceDemonsKatana_903020210 = new Recipe { Name = "Ice Demon's Katana++", RecipeBookId = "903020210", Description = "絶・氷魔ノ刀", CountId = "584", Gil = "84000"};
        public static readonly Recipe KnightRidersBlade = new Recipe { Name = "Knight Rider's Blade+", RecipeBookId = "903020220", Description = "真・戦騎闘剣", CountId = "585", Gil = "30000"};
        public static readonly Recipe WindSpritesSpear = new Recipe { Name = "Wind Sprite's Spear+", RecipeBookId = "903020230", Description = "真・風精槍", CountId = "586", Gil = "48000"};
        public static readonly Recipe SacredCastlesShield = new Recipe { Name = "Sacred Castle's Shield+", RecipeBookId = "903020240", Description = "真・聖城の盾", CountId = "587", Gil = "45000"};
        public static readonly Recipe NightbringerWolfsHandgun = new Recipe { Name = "Nightbringer Wolf's Handgun+", RecipeBookId = "903020250", Description = "真・魔狼銃", CountId = "588", Gil = "36000"};
        public static readonly Recipe VanillesClothes = new Recipe { Name = "Vanille's Clothes", RecipeBookId = "904003620", Description = "ヴァニラの服", CountId = "604", Gil = "30000"};
        public static readonly Recipe FangsClothes = new Recipe { Name = "Fang's Clothes", RecipeBookId = "904003630", Description = "ファングの服", CountId = "605", Gil = "15000"};
        public static readonly Recipe VanillesBag = new Recipe { Name = "Vanille's Bag", RecipeBookId = "904003640", Description = "ヴァニラのポーチ", CountId = "606", Gil = "6000"};
        public static readonly Recipe FangsNecklace = new Recipe { Name = "Fang's Necklace", RecipeBookId = "904003650", Description = "ファングのネックレス", CountId = "607", Gil = "6000"};
        public static readonly Recipe DurableGoldBangleFFXIII = new Recipe { Name = "Durable Gold Bangle (FFXIII-2)", RecipeBookId = "903020260", Description = "ゴールドバングル 重式(FFXIII-2)", CountId = "599", Gil = "30000"};
        public static readonly Recipe DurableMagiciansMarkFFXIII = new Recipe { Name = "Durable Magician's Mark (FFXIII-2)", RecipeBookId = "903020270", Description = "マジシャンサイン 重式(FFXIII-2)", CountId = "600", Gil = "15000"};
        public static readonly Recipe GrieverLoneLion = new Recipe { Name = "Griever (Lone Lion)", RecipeBookId = "903020390", Description = "グリーヴァ【孤高】", CountId = "617", Gil = "30000"};
        public static readonly Recipe SeifersCoatDisciplined = new Recipe { Name = "Seifer's Coat (Disciplined)", RecipeBookId = "903020400", Description = "サイファーのコート【克己】", CountId = "618", Gil = "18000"};
        public static readonly Recipe TengallonHat = new Recipe { Name = "Ten-gallon Hat", RecipeBookId = "904003700", Description = "テンガロンハット", CountId = "623", Gil = "3000"};
        public static readonly Recipe GardenGirlsUniform = new Recipe { Name = "Garden Girls' Uniform", RecipeBookId = "904003690", Description = "ガーデン一般女子制服", CountId = "622", Gil = "6000"};
        public static readonly Recipe IrvinesCoat = new Recipe { Name = "Irvine's Coat", RecipeBookId = "904003680", Description = "アーヴァインのコート", CountId = "621", Gil = "18000"};
        public static readonly Recipe SelphiesDress = new Recipe { Name = "Selphie's Dress", RecipeBookId = "904003670", Description = "セルフィの服", CountId = "620", Gil = "30000"};
        public static readonly Recipe OraclesCodex = new Recipe { Name = "Oracle's Codex+", RecipeBookId = "903020430", Description = "神のルールブック改", CountId = "622", Gil = "30000"};
        public static readonly Recipe HoarfrostDagger = new Recipe { Name = "Hoarfrost Dagger+", RecipeBookId = "903020440", Description = "氷のダガー改", CountId = "623", Gil = "7500"};
        public static readonly Recipe BlackEye = new Recipe { Name = "Black Eye", RecipeBookId = "904003720", Description = "ブラックアイ", CountId = "627", Gil = "30000"};
        public static readonly Recipe ImmortalHat = new Recipe { Name = "Immortal Hat", RecipeBookId = "904003730", Description = "イモータルハット", CountId = "628", Gil = "7500"};
        public static readonly Recipe DropofAbundance = new Recipe { Name = "Drop of Abundance", RecipeBookId = "904003740", Description = "豊穣の雫", CountId = "629", Gil = "1200"};
        public static readonly Recipe PetalofAbundance = new Recipe { Name = "Petal of Abundance", RecipeBookId = "904003750", Description = "豊穣の花びら", CountId = "630", Gil = "1200"};
        public static readonly Recipe AdamantHat = new Recipe { Name = "Adamant Hat+", RecipeBookId = "903020480", Description = "アダマン帽+", CountId = "628", Gil = "7500"};
        public static readonly Recipe WhaleWhiskerN = new Recipe { Name = "Whale Whisker N", RecipeBookId = "903020470", Description = "鯨の髭N", CountId = "627", Gil = "27000"};
        public static readonly Recipe ProtectRing_903020700 = new Recipe { Name = "Protect Ring+", RecipeBookId = "903020700", Description = "まもりの指輪+", CountId = "657", Gil = "15000"};
        public static readonly Recipe PumicePiece = new Recipe { Name = "Pumice Piece+", RecipeBookId = "903020690", Description = "ふゆう石のかけら・大", CountId = "656", Gil = "30000"};
        public static readonly Recipe AshesClothes = new Recipe { Name = "Ashe's Clothes", RecipeBookId = "904003770", Description = "アーシェの服", CountId = "634", Gil = "30000"};
        public static readonly Recipe ResistanceArmor = new Recipe { Name = "Resistance Armor", RecipeBookId = "904003780", Description = "解放軍の鎧", CountId = "635", Gil = "18000"};
        public static readonly Recipe AegisShieldFFXII = new Recipe { Name = "Aegis Shield (FFXII)", RecipeBookId = "904003790", Description = "イージスの盾(FFXII TZA)", CountId = "636", Gil = "9000"};
        public static readonly Recipe AshesBoots = new Recipe { Name = "Ashe's Boots", RecipeBookId = "904003800", Description = "アーシェのブーツ", CountId = "637", Gil = "6000"};
        public static readonly Recipe PurplePain_903020760 = new Recipe { Name = "Purple Pain+", RecipeBookId = "903020760", Description = "グランドグラブ+", CountId = "668", Gil = "15000"};
        public static readonly Recipe MythrilSaber_903020770 = new Recipe { Name = "Mythril Saber+", RecipeBookId = "903020770", Description = "ミスリルセイバー+", CountId = "669", Gil = "45000"};
        public static readonly Recipe ElectrostaticRod_903020780 = new Recipe { Name = "Electrostatic Rod+", RecipeBookId = "903020780", Description = "電磁ロッド+", CountId = "670", Gil = "27000"};
        public static readonly Recipe DarkMasamune_903020510 = new Recipe { Name = "Dark Masamune (2★)", RecipeBookId = "903020510", Description = "ダークマサムネ(★2)", CountId = "638", Gil = "168"};
        public static readonly Recipe DarkMasamune_903020520 = new Recipe { Name = "Dark Masamune (3★)", RecipeBookId = "903020520", Description = "ダークマサムネ(★3)", CountId = "639", Gil = "420"};
        public static readonly Recipe DarkMasamune_903020530 = new Recipe { Name = "Dark Masamune (4★)", RecipeBookId = "903020530", Description = "ダークマサムネ(★4)", CountId = "640", Gil = "1260"};
        public static readonly Recipe DarkMasamune_903020540 = new Recipe { Name = "Dark Masamune (5★)", RecipeBookId = "903020540", Description = "ダークマサムネ(★5)", CountId = "641", Gil = "4200"};
        public static readonly Recipe DarkMasamune_903020550 = new Recipe { Name = "Dark Masamune+ (6★)", RecipeBookId = "903020550", Description = "ダークマサムネ改(★6)", CountId = "642", Gil = "8400"};
        public static readonly Recipe DarkMasamune_903020560 = new Recipe { Name = "Dark Masamune+ (7★)", RecipeBookId = "903020560", Description = "ダークマサムネ改(★7)", CountId = "643", Gil = "21000"};
        public static readonly Recipe DarkMasamune_903020570 = new Recipe { Name = "Dark Masamune+ (8★)", RecipeBookId = "903020570", Description = "ダークマサムネ改(★8)", CountId = "644", Gil = "42000"};
        public static readonly Recipe DarkMasamune_903020580 = new Recipe { Name = "Dark Masamune+ (9★)", RecipeBookId = "903020580", Description = "ダークマサムネ改(★9)", CountId = "645", Gil = "84000"};
        public static readonly Recipe DarkMasamune_903020590 = new Recipe { Name = "Dark Masamune++ (10★)", RecipeBookId = "903020590", Description = "真・ダークマサムネ(★10)", CountId = "646", Gil = "168000"};
        public static readonly Recipe DarkGandiva_903020600 = new Recipe { Name = "Dark Gandiva (2★)", RecipeBookId = "903020600", Description = "ダークガーンディーヴァ(★2)", CountId = "647", Gil = "156"};
        public static readonly Recipe DarkGandiva_903020610 = new Recipe { Name = "Dark Gandiva (3★)", RecipeBookId = "903020610", Description = "ダークガーンディーヴァ(★3)", CountId = "648", Gil = "390"};
        public static readonly Recipe DarkGandiva_903020620 = new Recipe { Name = "Dark Gandiva (4★)", RecipeBookId = "903020620", Description = "ダークガーンディーヴァ(★4)", CountId = "649", Gil = "1170"};
        public static readonly Recipe DarkGandiva_903020630 = new Recipe { Name = "Dark Gandiva (5★)", RecipeBookId = "903020630", Description = "ダークガーンディーヴァ(★5)", CountId = "650", Gil = "3900"};
        public static readonly Recipe DarkGandiva_903020640 = new Recipe { Name = "Dark Gandiva+ (6★)", RecipeBookId = "903020640", Description = "ダークガーンディーヴァ改(★6)", CountId = "651", Gil = "7800"};
        public static readonly Recipe DarkGandiva_903020650 = new Recipe { Name = "Dark Gandiva+ (7★)", RecipeBookId = "903020650", Description = "ダークガーンディーヴァ改(★7)", CountId = "652", Gil = "19500"};
        public static readonly Recipe DarkGandiva_903020660 = new Recipe { Name = "Dark Gandiva+ (8★)", RecipeBookId = "903020660", Description = "ダークガーンディーヴァ改(★8)", CountId = "653", Gil = "39000"};
        public static readonly Recipe DarkGandiva_903020670 = new Recipe { Name = "Dark Gandiva+ (9★)", RecipeBookId = "903020670", Description = "ダークガーンディーヴァ改(★9)", CountId = "654", Gil = "78000"};
        public static readonly Recipe DarkGandiva_903020680 = new Recipe { Name = "Dark Gandiva++ (10★)", RecipeBookId = "903020680", Description = "真・ダークガーンディーヴァ(★10)", CountId = "655", Gil = "156000"};
        public static readonly Recipe TrueDarkCoat_903020790 = new Recipe { Name = "True Dark Coat", RecipeBookId = "903020790", Description = "真・ダークコート", CountId = "672", Gil = "15000"};
        public static readonly Recipe ObliteratingDarkCoat_903020800 = new Recipe { Name = "Obliterating Dark Coat", RecipeBookId = "903020800", Description = "絶・ダークコート", CountId = "673", Gil = "30000"};
        public static readonly Recipe DarkCoat_904003860 = new Recipe { Name = "Dark Coat", RecipeBookId = "904003860", Description = "ダークコート", CountId = "671", Gil = "6000"};
        public static readonly Recipe ShinraShotgun_904003870 = new Recipe { Name = "Shinra Shotgun", RecipeBookId = "904003870", Description = "神羅製ショットガン", CountId = "674", Gil = "36000"};
        public static readonly Recipe GuardStick_904003880 = new Recipe { Name = "Guard Stick", RecipeBookId = "904003880", Description = "ガードロッド", CountId = "675", Gil = "21000"};
        public static readonly Recipe MythrilArmlet_904003890 = new Recipe { Name = "Mythril Armlet", RecipeBookId = "904003890", Description = "ミスリルの腕輪", CountId = "676", Gil = "6000"};
        public static readonly Recipe SupernaturalWristguard_904003900 = new Recipe { Name = "Supernatural Wristguard", RecipeBookId = "904003900", Description = "フルパワーリスト", CountId = "677", Gil = "6000"};
        public static readonly Recipe MoraqueBlade_903020810 = new Recipe { Name = "Moraque Blade+", RecipeBookId = "903020810"};
        public static readonly Recipe PearlWhip_903020820 = new Recipe { Name = "Pearl Whip+", RecipeBookId = "903020820"};
        public static readonly Recipe SoireeStewardsClothes_903020830 = new Recipe { Name = "Soiree Steward's Clothes+", RecipeBookId = "903020830"};
/*VersionControldefinitions*/
		public static readonly List<Recipe> Recipes = new List<Recipe>
		{
           Potion,
           HiPotion,
           Ether,
           Antidote,
           EyeDrops,
           SmellingSalts,
           EchoHerbs,
           UnicornHorn,
           Vaccine,
           GoldNeedle,
           Remedy,
           Hyper,
           HealingSpring,
           SmokeScreen,
           BodyBoost,
           ManaTablet,
           ProtectDrink,
           ShellDrink,
           BacchussWine,
           Grenade,
           FragGrenade,
           Shuriken,
           FumaShuriken,
           Tent,
           MagicKey,
           BronzeKnife,
           Dagger,
           SleepDagger,
           Broadsword,
           LongSword,
           GreatSword,
           BusterSword,
           Kotetsu,
           Kikuichimonji,
           Kazekiri,
           Kodachi,
           BattleAxe,
           GreatAxe,
           WoodenHammer,
           IronHammer,
           WarHammer,
           BronzeMace,
           IronMace,
           Javelin,
           Partisan,
           BronzeKnuckles,
           MetalKnuckles,
           CatClaws,
           Rod,
           IronRod,
           Staff,
           CherryStaff,
           WizardsStaff,
           RuneStaff,
           ShortBow,
           LongBow,
           GreatBow,
           Altair,
           LeatherWhip,
           ChainWhip,
           Boomerang,
           Chakram,
           MoonRingBlade,
           Harp,
           SilverHarp,
           LeatherShield,
           SmallShield,
           Buckler,
           BronzeShield,
           IronShield,
           LeatherHat,
           FeatheredCap,
           WizardsHat,
           Bandana,
           CelebrantsMiter,
           HypnoCrown,
           RedCap,
           BronzeHelm,
           IronHelm,
           LeatherShirt,
           BardsTunic,
           ScholarRobe,
           PowerVest,
           Kenpogi,
           MagesHabit,
           SurvivalVest,
           NinjaGear,
           BlackBeltGi,
           LeatherPlate,
           CopperCuirass,
           IronPlate,
           BronzeArmor,
           IronArmor,
           CottonRobe,
           SilkRobe,
           TravelersGarbs,
           GaiaGear,
           ClericsRobes,
           IronGloves,
           PowerWrist,
           HyperWrist,
           SilverArmlet,
           FireRing,
           IceRing,
           SparkRing,
           WaterRing,
           GaleRing,
           EarthRing,
           ProtectRing_904001140,
           BarrierRing,
           RegenRing,
           CatsBell,
           HerosRing,
           MuscleBelt,
           Libra,
           Cure,
           Blindna,
           Vox,
           Poisona,
           Paralyna,
           Stona,
           Fire,
           Blizzard,
           Thunder,
           Water,
           Aero,
           Stone,
           Bio,
           Blizzara,
           Thundara,
           Watera,
           Aerora,
           Gravity,
           Drain,
           Biora,
           Sleep,
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
           Deshell,
           Barwatera,
           Baraerora,
           Barstonra,
           Steal,
           Brace,
           FireBlade,
           BlizzardBlade,
           SilenceBlade,
           WaterBlade,
           StoneBlade,
           BlindBlade,
           BioBlade,
           MagicInfuse,
           MentalBreak,
           BioBlaster,
           BombFragment,
           FishScale,
           GiantFeather,
           Pinwheel,
           Icebrand,
           CoralSword,
           FireRod,
           Capella,
           ShockWhip,
           OchreShield,
           GreenBeret,
           Barbut,
           SagesSurplice,
           Protect,
           MP_905100040,
           SPR_905100160,
           BugKiller,
           XPotion,
           TurboEther,
           HolyTorch,
           MythrilSpear,
           MagesHat,
           SagesRobe,
           MythrilGloves,
           Cura,
           DEF,
           MythrilHammer,
           WindSpear,
           MythrilHelm,
           Bravery,
           MAG,
           FineBlade,
           SuperiorBlade,
           AntarcticWind,
           ZeussRage,
           EarthDrum,
           MythrilDagger,
           MainGauche,
           MythrilSword,
           Osafune,
           MythrilMace,
           MythrilClaws,
           MythrilBow,
           MythrilWhip,
           MythrilBuckler,
           LargeShield,
           MythrilShield,
           TigerMask,
           MythrilPlate,
           SilverCuirass,
           PaladinArmor,
           MythrilArmor,
           WizardsRobe,
           MoonBracer,
           Dispel,
           Faith,
           SpiritSlayer,
           HP_905101500,
           SleepBlade,
           AeroBlade,
           StonraBlade_905200660,
           VorpalAxe,
           GaeBolg,
           LightCurtain,
           WyvernsFeather,
           WhiteFang,
           MythrilSaber,
           Chirijiraden,
           MythrilAxe,
           Escutcheon,
           Brigandine,
           Curaga,
           EVOMAG,
           WateraBlade,
           WingedSaint,
           MoraleTalisman,
           RodofGravity,
           VoidVessel,
           StonraBlade_1000000004,
           HP_1000000005,
           BurstShot,
           StandardMogcakePack,
           RareMogcakePack,
           PremiumMogcakePack,
           LunarCurtain,
           NorthWind,
           Flametongue,
           ATK,
           AutoProtect,
           BioraBlade,
           RightArm,
           BlueFang,
           SleepSword,
           FlameLance,
           PoisonKnuckles,
           ThunderShield,
           IceArmor,
           AutoShell,
           OsmoseBlade,
           ShiningSplendor,
           YPotion,
           MegaEther,
           BloodSword,
           RedFang,
           Trident,
           RodofLightning,
           ElvenBow,
           FlameMail,
           Death,
           BirdKiller,
           AutoPotion,
           PowerBreak,
           MagicBreak,
           GiantsAxe,
           Werebuster,
           IceLance,
           IceRod,
           Sirius,
           MysteryVeil,
           GoldenArmor,
           BlackRobe,
           UndeadKiller,
           ArmorBreak,
           ThunderBlade,
           MonarchsRing,
           DominationRing,
           RulersRing,
           RingofDominion,
           HeavenlyWrath,
           DragonScale_901000350,
           GoldenStaff,
           BlessedHammer,
           IceShield,
           GoldenVest,
           WhiteRobe,
           BuddingMapleWand,
           ScionConjurersDalmatica,
           ScionConjurersPattens,
           CobaltWinglet,
           AntecedentsAttire,
           MeteorSurvivorRing,
           UldahnFalchion,
           ScionThiefsTunic,
           ScionThiefsHalfgloves,
           GaiasCry,
           GoldenBlade,
           FlameShield,
           Circlet,
           AngelRing,
           BasiliskSteel,
           Razzmatazz,
           HyperBall,
           Override,
           ThunderSpear,
           Betelgeuse,
           GoldenShield,
           Imperil,
           Microphone_1000000014,
           EveningGloves,
           BunnyMask_1000000016,
           StylishBlackDress_1000000017,
           MemoryCandy,
           MageMasher,
           RasAlgethi,
           GalkanDagger,
           LeucosVoulge,
           ThothsWand,
           OrcPiercer,
           Retaliator,
           IridalStaff,
           TacticianMagiciansWand,
           SharkGun,
           SlickDart,
           Raikiri,
           MoogleSpear,
           BreakShot,
           TwinWhip,
           Microphone_903001290,
           TorrentRing,
           DivineShield,
           RavenBeret,
           TacticianMagiciansCoat,
           ParadeCuirass,
           GoldenHairpin,
           ParadeGorget,
           MoogleCrown,
           MoogleCape,
           UnsuiClothes,
           GoldenHelm,
           FestivalRobe_904001710,
           FestivalCap_904001720,
           PlatinumTiara,
           Fransisca,
           GloryStaff,
           KrisKnife,
           RoyalRing,
           EveningGlove,
           BunnyMask_904001810,
           StylishBlackDress_904001820,
           Darkra,
           DragonKiller,
           MogSearch,
           MogResist,
           MogRise,
           FiraBlade,
           ChocolateEgg,
           GreatEgg,
           MagicalEgg,
           RadiantEgg,
           StaffofWrath,
           CrownofJustice_1000000025,
           BlackBandana_1000000026,
           SecondKnife,
           IcyVeins_1000000028,
           ColdSnap,
           DrakesclawRod,
           DrakesguardRobe,
           BahamutsFang,
           DragonsRoar,
           GutsKnuckle,
           GoldenEye,
           ScionStrikersVisor,
           ScionStrikersAttire,
           ScionThaumaturgesMonocle,
           ScionThaumaturgesRobe,
           Adventurer,
           AdventurerII,
           AdventurerIII,
           AdventurerIV,
           AdventurerV,
           BrokenArm,
           AngelWand,
           PlatinumMusket,
           AncientOverlord,
           IronWill,
           DragoonLance,
           TypeFists,
           CruelOath,
           BellowsArmGuard,
           MagicBarrierDevice,
           ZDHelmet,
           AngelWing,
           PlatinumRobe,
           SeraphimShield,
           EmilsHead,
           HeavyArmorB,
           PlatinaArmor,
           BlizzaraBlade,
           ThundaraBlade,
           AeroraBlade,
           PlatinumDagger,
           ValiantII,
           PrecisionLance,
           Valiant,
           CypressPile,
           PlatinumSaber,
           Darkbringer,
           YggdrasilStaff,
           Dragvandil,
           SweetKiss,
           PlatinumMace,
           PlatinumWhip,
           TamersGloves,
           SecretKnife,
           StaffofResentment,
           PlatinumEdge,
           FierceBow,
           Kogarasumaru,
           ScarletRoses,
           Takemikazuchi,
           MetalPipe,
           PlatinumAxe,
           RubberSuit,
           A1ClassPowershield,
           AssistSuit,
           ChobhamArmor,
           TacticalManual,
           MagnoliasUniform,
           IcyVeins_904002010,
           BlackBandana_904002020,
           CrownofJustice_904002030,
           JeweledBelt,
           PlatinumBreastplate,
           RiotGear,
           PlatinumShield,
           TrueShardofGenius,
           TrueFollowersOath,
           TrueHydaelynGuard,
           TrueSpiritofFreedom,
           TrueSagesPrajna,
           Kappower,
           AutoBravery,
           AutoFaith,
           MP_905100370,
           KittyHeadband,
           CloakofResentment,
           SparklingHeels,
           EvilPipe,
           PinkStripedFloat,
           CheerfulTune,
           JoyfulSpirit,
           Lightbringer,
           GraspingSphere,
           StaffofBlizzards,
           WingEdges,
           SalamandersGauntlets,
           CragSplitter,
           FlaxShield,
           JadeMoonPendant,
           JadeSunPendant,
           FieryPassion,
           StaffofOsiris_1000000055,
           IcyDeath,
           Flamethrower_1000000057,
           ToxicShotgun_1000000058,
           OnyxSpiritofRa,
           GoldRingofSet,
           PlatinumLance,
           PlatinumBow,
           DiamondKnife,
           DragonScale_904002080,
           SagesStaff,
           SacredClaws,
           DragovianSpear,
           WolfMask,
           FestivalRobe_904002140,
           FestivalCap_904002150,
           YinYangCharm_904002180,
           SantasClothesII,
           SantasHatII,
           TsukumoDoll_904002210,
           KimonoVest_904002220,
           SantasCane,
           PlatinumFist,
           GemofCreation,
           GemofVision,
           NibelungenRing,
           DragoonTyrant,
           RustRedCirclet,
           DiamondRobe,
           FaerieCloak,
           FlowerSuit,
           MagicalArmor,
           FrostyRing,
           StaffofOsiris_904002370,
           ToxicShotgun_904002380,
           Flamethrower_904002390,
           GoldRingofSeth,
           DiamondSword,
           DiamondArmor,
           RicosWingsuit,
           GE_1000000062,
           RicosCombatGloves,
           UVK,
           CSWraithR,
           UZabijak,
           YinYangCharm_1000000067,
           VestmentofPrayers,
           WhiteBandana,
           TsukumoDoll_1000000070,
           KimonoVest_1000000071,
           ElvenStaff,
           ZenithZAP,
           TITAN,
           EMPGrenade,
           CtedAzurSOW,
           NukeVirusSoftware,
           LinebackerGMSGL,
           SturdyUmbrella,
           BeachBall,
           GE_1000000081,
           SplashofLife,
           RavenFigurine,
           HalfCrescentRod,
           AvianCloak,
           EmpoweredGauntlets,
           BizarreSculpture,
           BigRedRibbon,
           CrimsonVest,
           GallantBelt,
           Strength,
           Etherize,
           DiamondBreastplate,
           BlackLeather,
           YamatoBelt,
           Shielder,
           Soulful,
           TornDress,
           MetalEarrings,
           EternalFlame,
           RuinedShield,
           KatanaProficiency,
           SpiritualProficiency,
           DemonicMight,
           DemonicMind,
           PopstarsMicrophone,
           CrimsonDragonRobe,
           CrimsonDragonCowl,
           CrimsonWedgeHeels,
           AdamantiteKatana,
           DiamondJacket,
           GenbuRing,
           ByakkoRing,
           MetalGreaves,
           YinYangOrnament,
           EliteDogTag,
           AldoreSpecialOpsSword,
           TypeAldoreRifle,
           DiamondSaber,
           JetBlackEyepatch,
           OctopathSpear,
           OctopathDagger,
           JewelofStrength,
           JewelofProtection,
           CrystalCrownKH,
           EXPEarringKH,
           MagesStaffKH,
           KnightsShieldKH,
           BeastCestus,
           TamersWhip,
           BakuyaSword,
           KanshouGreatSword,
           RiceCakeShield,
           GiantChopstick,
           DemonRevealingMirror,
           TranscendentSoul,
           DiamondHelm,
           DiamondLance,
           SoulofDarkness,
           WovenTrapperCap,
           EnchantedBrooch,
           TatteredOvercoat,
           ShatteredYari,
           CursedLocket,
           StoneBracer,
           StoneCrown,
           StoneVest,
           TectonicBracer,
           TectonicCrown,
           TectonicVest,
           DiamondTiara,
           CrimsonsCoat,
           BattleGarb,
           DiamondStaff,
           GatlingArm,
           FrostedGown,
           FrostedStilettos,
           LuckyCloverHairpin,
           FrostedMicrophone,
           DiamondShieldFFBE,
           SilverKnightsGauntlet,
           Onimaru,
           DiamondRod,
           DiamondBuckler,
           PeaceRingFFVII,
           StandardIssueSword,
           ShinraAlpha,
           CurseRingFFVII,
           AmuletofDarkness,
           HoodofDarkness,
           MantleofDarkness,
           AileensDress,
           ATypeRifleScope,
           FloralObi,
           ThirdAnniversaryPartyGuest,
           EsperOre,
           RedEsperOre,
           BlueEsperOre,
           GreenEsperOre,
           WhiteEsperOre,
           BlackEsperOre,
           YellowEsperOre,
           OrangeEsperOre,
           VioletEsperOre,
           FanofFlames,
           HairpinofFlames,
           YukataofFlames,
           FireFoxPlushie,
           FireFoxMask,
           FireFoxCloak,
           MPHaste,
           EXPBraceletKH,
           DodgeRoll,
           SephirothsBootsKH,
           FloatSandals,
           BlackRobeFFV,
           FlameRing,
           CoralRing,
           HeartsAgainsttheVoid,
           CharcoalRelic,
           CharcoalHood,
           CharcoalCloak,
           AshenRelic,
           AshenHood,
           AshenCloak,
           CPRKit,
           EnergizingShot,
           RestorativeShot,
           Flamboyant,
           FourPointShuriken,
           NinjaGearFFVI,
           KnowledgeofKatanasandRods,
           KingRainsCloak,
           DemonSpear,
           CombatCostume,
           ScholarsSpecs,
           PuffPuff,
           LibertyAction,
           ToysWindUpKey,
           ToyElfsHat,
           ToyElfsTunic,
           FestiveSnowGlobe,
           FestiveReindeerAntlers,
           FestiveElfSuit,
           BoxofRegalement,
           Snowball,
           CrimsonEmpress,
           TruePremiumLeatherJacket,
           PremiumLeatherJacket,
           ObsidianGreatsword,
           EnduringFlame,
           PyroGlacialDefender,
           PurifiedRing,
           FaithswornRing,
           MajesticHeaddressandHeadband,
           ImperialHeaddressandHeadband,
           RusticSandals,
           RusticHeadscarf,
           RusticGarb,
           ElegantPendant,
           ElegantHairOrnament,
           ElegantApparel,
           FlameSwordFFIV,
           SPR_904003180,
           RedPetals,
           FragrantFlowers,
           BouquetofRoses,
           LoveisVital,
           LoveisMagical,
           EdelsEarrings,
           SniperGoggles,
           Paikea,
           Khandroma,
           CobraKnife,
           CobraHat,
           GunnerYunasDress,
           ThiefRikkusBandana,
           WarriorPainesGuise,
           TheLivingofSpira_904003290,
           TheLivingofSpira_904003300,
           StateAlchemistsWatch,
           AlphonseDoll,
           HawkeyesHandgun,
           WinrysBandana,
           AldorePoliceMedal,
           InfernoSaber_904003460,
           InfernoSaber_904003470,
           DragonWingBow,
           DiabolossRod,
           FierceGoddesssKatana,
           DarkGambanteinn_903020300,
           DarkGambanteinn_903020310,
           DarkGambanteinn_903020320,
           DarkGambanteinn_903020330,
           DarkGambanteinn_903020340,
           DarkGambanteinn_903020350,
           DarkGambanteinn_903020360,
           DarkGambanteinn_903020370,
           DarkGambanteinn_903020380,
           DarkRagnarok_903020110,
           DarkRagnarok_903020120,
           DarkRagnarok_903020130,
           DarkRagnarok_903020140,
           DarkRagnarok_903020150,
           DarkRagnarok_903020160,
           DarkRagnarok_903020170,
           DarkRagnarok_903020180,
           DarkRagnarok_903020190,
           MagicBangle_904003250,
           MagicBangle_904003260,
           EmeraldNecklace,
           DropfromtheHolyGrail,
           IceDemonsKatana_903020200,
           IceDemonsKatana_903020210,
           KnightRidersBlade,
           WindSpritesSpear,
           SacredCastlesShield,
           NightbringerWolfsHandgun,
           VanillesClothes,
           FangsClothes,
           VanillesBag,
           FangsNecklace,
           DurableGoldBangleFFXIII,
           DurableMagiciansMarkFFXIII,
           GrieverLoneLion,
           SeifersCoatDisciplined,
           TengallonHat,
           GardenGirlsUniform,
           IrvinesCoat,
           SelphiesDress,
           OraclesCodex,
           HoarfrostDagger,
           BlackEye,
           ImmortalHat,
           DropofAbundance,
           PetalofAbundance,
           AdamantHat,
           WhaleWhiskerN,
           ProtectRing_903020700,
           PumicePiece,
           AshesClothes,
           ResistanceArmor,
           AegisShieldFFXII,
           AshesBoots,
           PurplePain_903020760,
           MythrilSaber_903020770,
           ElectrostaticRod_903020780,
           DarkMasamune_903020510,
           DarkMasamune_903020520,
           DarkMasamune_903020530,
           DarkMasamune_903020540,
           DarkMasamune_903020550,
           DarkMasamune_903020560,
           DarkMasamune_903020570,
           DarkMasamune_903020580,
           DarkMasamune_903020590,
           DarkGandiva_903020600,
           DarkGandiva_903020610,
           DarkGandiva_903020620,
           DarkGandiva_903020630,
           DarkGandiva_903020640,
           DarkGandiva_903020650,
           DarkGandiva_903020660,
           DarkGandiva_903020670,
           DarkGandiva_903020680,
           TrueDarkCoat_903020790,
           ObliteratingDarkCoat_903020800,
           DarkCoat_904003860,
           ShinraShotgun_904003870,
           GuardStick_904003880,
           MythrilArmlet_904003890,
           SupernaturalWristguard_904003900,
           MoraqueBlade_903020810,
           PearlWhip_903020820,
           SoireeStewardsClothes_903020830,
/*VersionControldefinitionsList*/		};
    }
}