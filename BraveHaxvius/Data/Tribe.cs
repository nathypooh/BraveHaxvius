//MST_TRIBE_NAME_12^Reaper^Reaper---VersionControl
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Tribe
    {
        public String Name { get; set; } 
        public String TribeId { get; set; } 
        public String Description { get; set; } 

        public static readonly Tribe Beast = new Tribe { Name = "Beast", TribeId = "1", Description = "獣系"};
        public static readonly Tribe Avian = new Tribe { Name = "Avian", TribeId = "2", Description = "鳥系"};
        public static readonly Tribe Aquatic = new Tribe { Name = "Aquatic", TribeId = "3", Description = "水棲系"};
        public static readonly Tribe Demon = new Tribe { Name = "Demon", TribeId = "4", Description = "悪魔系"};
        public static readonly Tribe Human = new Tribe { Name = "Human", TribeId = "5", Description = "人系"};
        public static readonly Tribe Machina = new Tribe { Name = "Machina", TribeId = "6", Description = "機械系"};
        public static readonly Tribe Dragon = new Tribe { Name = "Dragon", TribeId = "7", Description = "竜系"};
        public static readonly Tribe Fairy = new Tribe { Name = "Fairy", TribeId = "8", Description = "精霊系"};
        public static readonly Tribe Insect = new Tribe { Name = "Insect", TribeId = "9", Description = "虫系"};
        public static readonly Tribe Stone = new Tribe { Name = "Stone", TribeId = "10", Description = "石系"};
        public static readonly Tribe Plant = new Tribe { Name = "Plant", TribeId = "11", Description = "植物系"};
        public static readonly Tribe Reaper = new Tribe { Name = "Reaper", TribeId = "12", Description = "死霊系"};
/*VersionControldefinitions*/

		public static readonly List<Tribe> Tribes = new List<Tribe>
		{
           Beast,
           Avian,
           Aquatic,
           Demon,
           Human,
           Machina,
           Dragon,
           Fairy,
           Insect,
           Stone,
           Plant,
           Reaper,
/*VersionControldefinitionsList*/
		};
    }
}