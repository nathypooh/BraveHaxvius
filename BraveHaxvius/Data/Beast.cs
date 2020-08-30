//MST_BEAST_NAME_19^Kokuryu^Kokuryu---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Beast
    {
        public String Name { get; set; } 
        public String BeastId { get; set; } 
        public String Description { get; set; } 
        public String CountId { get; set; } 

        public static readonly Beast Siren = new Beast { Name = "Siren", BeastId = "1", Description = "セイレーン", CountId = "1"};
        public static readonly Beast Ifrit = new Beast { Name = "Ifrit", BeastId = "2", Description = "イフリート", CountId = "2"};
        public static readonly Beast Shiva = new Beast { Name = "Shiva", BeastId = "3", Description = "シヴァ", CountId = "3"};
        public static readonly Beast Carbuncle = new Beast { Name = "Carbuncle", BeastId = "4", Description = "カーバンクル", CountId = "7"};
        public static readonly Beast Diabolos = new Beast { Name = "Diabolos", BeastId = "5", Description = "ディアボロス", CountId = "6"};
        public static readonly Beast Golem = new Beast { Name = "Golem", BeastId = "6", Description = "ゴーレム", CountId = "4"};
        public static readonly Beast Ramuh = new Beast { Name = "Ramuh", BeastId = "7", Description = "ラムウ", CountId = "5"};
        public static readonly Beast Titan = new Beast { Name = "Titan", BeastId = "8", Description = "タイタン", CountId = "9"};
        public static readonly Beast TetraSylphid = new Beast { Name = "Tetra Sylphid", BeastId = "9", Description = "テトラシルフィード", CountId = "11"};
        public static readonly Beast Odin = new Beast { Name = "Odin", BeastId = "10", Description = "オーディン", CountId = "8"};
        public static readonly Beast Lakshmi = new Beast { Name = "Lakshmi", BeastId = "11", Description = "ラクシュミ", CountId = "10"};
        public static readonly Beast Leviathan = new Beast { Name = "Leviathan", BeastId = "12", Description = "繝ｪ繝ｴ繧｡繧､繧｢繧ｵ繝ｳ", CountId = "14"};
        public static readonly Beast Phoenix = new Beast { Name = "Phoenix", BeastId = "14", Description = "フェニックス", CountId = "15"};
        public static readonly Beast Bahamut = new Beast { Name = "Bahamut", BeastId = "15", Description = "繝舌ワ繝繝ｼ繝", CountId = "12"};
        public static readonly Beast Fenrir = new Beast { Name = "Fenrir", BeastId = "16", Description = "繝輔ぉ繝ｳ繝ｪ繝ｫ", CountId = "13"};
        public static readonly Beast Alexander = new Beast { Name = "Alexander", BeastId = "13", Description = "アレキサンダー", CountId = "16"};
        public static readonly Beast Anima = new Beast { Name = "Anima", BeastId = "17", Description = "アニマ", CountId = "17"};
        public static readonly Beast Asura = new Beast { Name = "Asura", BeastId = "18", Description = "阿修羅", CountId = "18"};
        public static readonly Beast Kokuryu = new Beast { Name = "Kokuryu", BeastId = "19", Description = "黒龍", CountId = "19"};
/*VersionControldefinitions*/

		public static readonly List<Beast> Beasts = new List<Beast>
		{
           Siren,
           Ifrit,
           Shiva,
           Carbuncle,
           Diabolos,
           Golem,
           Ramuh,
           Titan,
           TetraSylphid,
           Odin,
           Lakshmi,
           Leviathan,
           Phoenix,
           Bahamut,
           Fenrir,
           Alexander,
           Anima,
           Asura,
           Kokuryu,
/*VersionControldefinitionsList*/
		};
    }
}