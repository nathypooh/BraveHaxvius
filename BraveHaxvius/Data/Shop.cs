//MST_SHOP_NAME_24^Equipment Enhancement Event Orb Recovery Potion^Equipment Enhancement Event Orb Recovery Potion---VersionControl items removed:0
using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Shop
    {
        public String Name { get; set; }
        public String ShopId { get; set; }
        public String Description { get; set; }
        public String DailyQuestName { get; set; }

        public static readonly Shop UnitSlots = new Shop { Name = "Unit Slots", ShopId = "10", Description = "ユニット枠拡張", DailyQuestName = ""};
        public static readonly Shop ItemSlots = new Shop { Name = "Item Slots", ShopId = "11", Description = "アイテム枠拡張", DailyQuestName = ""};
        public static readonly Shop EquipmentSlots = new Shop { Name = "Equipment Slots", ShopId = "12", Description = "装備アイテム枠拡張", DailyQuestName = ""};
        public static readonly Shop AbilitySlots = new Shop { Name = "Ability Slots", ShopId = "13", Description = "マテリア枠拡張", DailyQuestName = ""};
        public static readonly Shop FriendSlots = new Shop { Name = "Friend Slots", ShopId = "14", Description = "フレンド枠拡張", DailyQuestName = ""};
        public static readonly Shop MaterialSlots = new Shop { Name = "Material Slots", ShopId = "15", Description = "素材アイテム枠拡張", DailyQuestName = ""};
        public static readonly Shop RecoverEnergy = new Shop { Name = "Recover Energy", ShopId = "20", Description = "体力回復", DailyQuestName = ""};
        public static readonly Shop RecoverColosseumOrbs = new Shop { Name = "Recover Colosseum Orbs", ShopId = "21", Description = "コロシアムオーブ回復", DailyQuestName = ""};
        public static readonly Shop ReduceCreationTime = new Shop { Name = "Reduce Creation Time", ShopId = "30", Description = "制作時間短縮", DailyQuestName = ""};
        public static readonly Shop UnlockDungeons = new Shop { Name = "Unlock Dungeons", ShopId = "40", Description = "特殊ダンジョン解放", DailyQuestName = ""};
        public static readonly Shop NRGRecoveryItems = new Shop { Name = "NRG Recovery Items", ShopId = "50", Description = "体力回復アイテム", DailyQuestName = ""};
        public static readonly Shop EsperPointReset = new Shop { Name = "Esper Point Reset", ShopId = "60", Description = "幻獣ポイントリセット", DailyQuestName = ""};
        public static readonly Shop RecoverEventOrbs = new Shop { Name = "Recover Event Orbs", ShopId = "22", Description = "イベントオーブ回復", DailyQuestName = ""};
        public static readonly Shop EquipmentEnhancementEventOrbRecovery = new Shop { Name = "Equipment Enhancement Event Orb Recovery", ShopId = "23", Description = "武具強化イベントオーブ回復", DailyQuestName = ""};
        public static readonly Shop EquipmentEnhancementEventOrbRecoveryPotion = new Shop { Name = "Equipment Enhancement Event Orb Recovery Potion", ShopId = "24", Description = "武具強化イベントオーブ回復薬", DailyQuestName = ""};
/*VersionControldefinitions*/
		public static readonly List<Shop> Shops = new List<Shop>
		{
           UnitSlots,
           ItemSlots,
           EquipmentSlots,
           AbilitySlots,
           FriendSlots,
           MaterialSlots,
           RecoverEnergy,
           RecoverColosseumOrbs,
           ReduceCreationTime,
           UnlockDungeons,
           NRGRecoveryItems,
           EsperPointReset,
           RecoverEventOrbs,
           EquipmentEnhancementEventOrbRecovery,
           EquipmentEnhancementEventOrbRecoveryPotion,
/*VersionControldefinitionsList*/		};
    }
}