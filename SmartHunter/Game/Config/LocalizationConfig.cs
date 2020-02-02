using SmartHunter.Core.Config;
using System.Collections.Generic;

namespace SmartHunter.Config
{
    public class LocalizationConfig
    {
        [PreserveCollectionIntegrity]
        public Dictionary<string, string> Strings = new Dictionary<string, string>()
        {
            { "LOC_UNKNOWN_PLAYER", "Player" },
            { "LOC_WIDGET_MONSTER", "Monster Widget" },
            { "LOC_WIDGET_TEAM", "Team Widget" },
            { "LOC_WIDGET_PLAYER", "Player Widget" },

            { "LOC_MONSTER_NARGACUGA", "Nargacuga" },
            { "LOC_MONSTER_NAMIELLE", "Namielle" },
            { "LOC_MONSTER_SHARA_ISHVALDA", "Shara Ishvalda" },
            { "LOC_MONSTER_BANBARO", "Banbaro" },
            { "LOC_MONSTER_TIGREX", "Tigrex" },
            { "LOC_MONSTER_BRUTE_TIGREX", "Brute Tigrex" },
            { "LOC_MONSTER_ZINOGRE", "Zinogre" },
            { "LOC_MONSTER_PAOLUMU_NIGHTSHADE", "Nightshade Paolumu" },
            { "LOC_MONSTER_EBONY_ODOGARON", "Ebony Odogaron" },
            { "LOC_MONSTER_ANJANATH_FULGUR", "Fulgur Anjanath" },
            { "LOC_MONSTER_PUKEI_PUKEI_CORAL", "Coral Pukei-Pukei" },
            { "LOC_MONSTER_BRACHYDIOS", "Brachydios" },
            { "LOC_MONSTER_VELKHANA", "Velkhana" },
            { "LOC_MONSTER_BEOTODUS", "Beotodus" },
            { "LOC_MONSTER_GLAVENUS", "Glavenus" },
            { "LOC_MONSTER_ACIDIC_GLAVENUS", "Acidic Glavenus" },
            { "LOC_MONSTER_BLACKVEIL_VAAL_HAZAK", "Blackveil Vaal Hazak" },
            { "LOC_MONSTER_BARIOTH", "Barioth" },
            { "LOC_MONSTER_SAVAGE_DEVILJHO", "Savage Deviljho" },
            { "LOC_MONSTER_RUINER_NERGIGANTE", "Ruiner Nergigante" },
            { "LOC_MONSTER_VIPER_TOBI_KADACHI", "Viper Tobi Kadachi" },
            { "LOC_MONSTER_SHRIEKING_LEGIANA", "Shrieking Legiana" },
            { "LOC_MONSTER_SEETHING_BAZELGEUSE", "Seething Bazelgeuse" },
            { "LOC_MONSTER_YIAN_GARUGA", "Yian Garuga" },
            { "LOC_MONSTER_SCARRED_YIAN_GARUGA", "Scarred Yian Garuga" },
			{ "LOC_MONSTER_GOLD_RATHIAN", "Gold Rathian" },
			{ "LOC_MONSTER_SILVER_RATHALOS", "Silver Rathalos" },

            //{ "LOC_MONSTER_UKNOWN", "Unknown Monster" },
            { "LOC_MONSTER_UKNOWN", "Kono Dio da!" },
            { "LOC_MONSTER_ANJANATH", "Anjanath" },
            { "LOC_MONSTER_AZURE_RATHALOS", "Azure Rathalos" },
            { "LOC_MONSTER_BARROTH", "Barroth" },
            { "LOC_MONSTER_BAZELGEUSE", "Bazelgeuse" },
            { "LOC_MONSTER_BEHEMOTH", "Behemoth" },
            { "LOC_MONSTER_BLACK_DIABLOS", "Black Diablos" },
            { "LOC_MONSTER_DEVILJHO", "Deviljho" },
            { "LOC_MONSTER_DIABLOS", "Diablos" },
            { "LOC_MONSTER_DODOGAMA", "Dodogama" },
            { "LOC_MONSTER_GREAT_GIRROS", "Great Girros" },
            { "LOC_MONSTER_GREAT_JAGRAS", "Great Jagras" },
            { "LOC_MONSTER_JYURATODUS", "Jyuratodus" },
            { "LOC_MONSTER_KIRIN", "Kirin" },
            { "LOC_MONSTER_KULU_YA_KU", "Kulu-Ya-Ku" },
            { "LOC_MONSTER_KULVE_TAROTH", "Kulve Taroth" },
            { "LOC_MONSTER_KUSHALA_DAORA", "Kushala Daora" },
            { "LOC_MONSTER_LAVASIOTH", "Lavasioth" },
            { "LOC_MONSTER_LEGIANA", "Legiana" },
            { "LOC_MONSTER_LUNASTRA", "Lunastra" },
            { "LOC_MONSTER_NERGIGANTE", "Nergigante" },
            { "LOC_MONSTER_ODOGARON", "Odogaron" },
            { "LOC_MONSTER_PAOLUMU", "Paolumu" },
            { "LOC_MONSTER_PINK_RATHIAN", "Pink Rathian" },
            { "LOC_MONSTER_PUKEI_PUKEI", "Pukei-Pukei" },
            { "LOC_MONSTER_RADOBAAN", "Radobaan" },
            { "LOC_MONSTER_RATHALOS", "Rathalos" },
            { "LOC_MONSTER_RATHIAN", "Rathian" },
            { "LOC_MONSTER_TEOSTRA", "Teostra" },
            { "LOC_MONSTER_TOBI_KADACHI", "Tobi-Kadachi" },
            { "LOC_MONSTER_TZITZI_YA_KU", "Tzitzi-Ya-Ku" },
            { "LOC_MONSTER_URAGAAN", "Uragaan" },
            { "LOC_MONSTER_VAAL_HAZAK", "Vaal Hazak" },
            { "LOC_MONSTER_XENO_JIIVA", "Xeno'jiiva" },
            { "LOC_MONSTER_ZORAH_MAGDAROS", "Zorah Magdaros" },
            { "LOC_PART_UKNOWN", "Unknown Part" },

            { "LOC_PART_HEAD_SNOW", "Head Snow" },
            { "LOC_PART_BODY_SNOW", "Body Snow" },
            { "LOC_PART_TAIL_SNOW", "Tail Snow" },

            { "LOC_PART_HEAD_ICE", "Head Ice" },
            { "LOC_PART_BODY_ICE", "Body Ice" },
            { "LOC_PART_WINGS_ICE", "Wings Ice" },
            { "LOC_PART_ARMS_ICE", "Arms Ice" },
            { "LOC_PART_LEGS_ICE", "Legs Ice" },
            { "LOC_PART_TAIL_ICE", "Tail Ice" },

            { "LOC_PART_HEAD_ROCK", "Head Rock" },
            { "LOC_PART_NECK_LEFT_ROCK", "Left Neck Rock" },
            { "LOC_PART_NECK_RIGHT_ROCK", "Right Right Rock" },
            { "LOC_PART_TAIL_ROCK", "Tail Rock" },
            { "LOC_PART_WING_LEFT_ROCK", "Left Wing Rock" },
            { "LOC_PART_WING_RIGHT_ROCK", "Right Wing Rock" },
            { "LOC_PART_ARM_LEFT_ROCK", "Left Arm Rock" },
            { "LOC_PART_ARM_RIGHT_ROCK", "Right Arm Rock" },
            { "LOC_PART_LEGS_ROCK", "Legs Rock" },

            { "LOC_PART_FIN", "Fin" },
            { "LOC_PART_HEAD", "Head" },
            { "LOC_PART_HEAD_LEFT", "Left Head" },
            { "LOC_PART_HEAD_RIGHT", "Right Head" },
            { "LOC_PART_BODY", "Body" },
            { "LOC_PART_ABDOMEN", "Abdomen" },
            { "LOC_PART_CHEST", "Chest" },
            { "LOC_PART_REAR", "Rear" },
            { "LOC_PART_ARMS", "Arms" },
            { "LOC_PART_ARM_LEFT", "Left Arm" },
            { "LOC_PART_ARM_RIGHT", "Right Arm" },
            { "LOC_PART_LEGS", "Legs" },
            { "LOC_PART_LEG_LEFT", "Left Leg" },
            { "LOC_PART_LEG_RIGHT", "Right Leg" },
            { "LOC_PART_LIMBS", "Limbs" },
            { "LOC_PART_LIMBS_LEFT", "Left Limbs" },
            { "LOC_PART_LIMBS_RIGHT", "Right Limbs" },
            { "LOC_PART_TAIL", "Tail" },
            { "LOC_PART_WINGS", "Wings" },
            { "LOC_PART_WING_LEFT", "Left Wing" },
            { "LOC_PART_WING_RIGHT", "Right Wing" },
            { "LOC_PART_HEAD_MUD", "Muddy Head" },
            { "LOC_PART_BODY_MUD", "Muddy Body" },
            { "LOC_PART_ARMS_MUD", "Muddy Arms" },
            { "LOC_PART_LEG_LEFT_MUD", "Muddy Left Leg" },
            { "LOC_PART_LEG_RIGHT_MUD", "Muddy Right Leg" },
            { "LOC_PART_TAIL_MUD", "Muddy Tail" },
            { "LOC_PART_HORNS", "Horns" },
            { "LOC_PART_MANE", "Mane" },
            { "LOC_PART_ROCK", "Rock" },
            { "LOC_PART_BALLOON", "Balloon" },
            { "LOC_PART_JAW", "Jaw" },
            { "LOC_PART_BACK", "Back" },
            { "LOC_PART_BONE_LEFT", "Left Bone" },
            { "LOC_PART_BONE_RIGHT", "Right Bone" },
            { "LOC_PART_NECK", "Neck" },
            { "LOC_PART_HAND_LEFT", "Left Hand" },
            { "LOC_PART_HAND_RIGHT", "Right Hand" },
            { "LOC_PART_FOOT_LEFT", "Left Foot" },
            { "LOC_PART_FOOT_RIGHT", "Right Foot" },
            { "LOC_PART_HORNS_GOLD", "Golden Horns" },
            { "LOC_PART_MANE_GOLD", "Golden Mane" },
            { "LOC_PART_CHEST_LEFT_GOLD", "Golden Left Chest" },
            { "LOC_PART_CHEST_RIGHT_GOLD", "Golden Right Chest" },
            { "LOC_PART_ARM_LEFT_GOLD", "Golden Left Arm" },
            { "LOC_PART_ARM_RIGHT_GOLD", "Golden Right Arm" },
            { "LOC_PART_LEG_LEFT_GOLD", "Golden Left Leg" },
            { "LOC_PART_LEG_RIGHT_GOLD", "Golden Right Leg" },
            { "LOC_PART_TAIL_LEFT_GOLD", "Golden Left Tail" },
            { "LOC_PART_TAIL_RIGHT_GOLD", "Golden Right Tail" },
            { "LOC_REMOVABLE_PART_UKNOWN", "Unknown Removable Part" },
            { "LOC_REMOVABLE_PART_TAIL", "Removable Tail" },
            { "LOC_REMOVABLE_PART_HORNS", "Removable Horns" },
            { "LOC_REMOVABLE_PART_HORNS_2", "Removable Horn Chip" },

            //To test monster parts
            { "LOC_PART_0", "0" },
            { "LOC_PART_1", "1" },
            { "LOC_PART_2", "2" },
            { "LOC_PART_3", "3" },
            { "LOC_PART_4", "4" },
            { "LOC_PART_5", "5" },
            { "LOC_PART_6", "6" },
            { "LOC_PART_7", "7" },
            { "LOC_PART_8", "8" },
            { "LOC_PART_9", "9" },
            { "LOC_PART_10", "10" },
            { "LOC_PART_11", "11" },
            { "LOC_PART_12", "12" },
            { "LOC_PART_13", "13" },
            { "LOC_PART_14", "14" },
            { "LOC_PART_15", "15" },
            { "LOC_PART_16", "16" },
            { "LOC_PART_17", "17" },
            { "LOC_PART_18", "18" },
            { "LOC_PART_19", "19" },
            { "LOC_PART_20", "20" },
            { "LOC_PART_21", "21" },
            { "LOC_PART_22", "22" },
            { "LOC_PART_23", "23" },
            { "LOC_PART_24", "24" },
            { "LOC_PART_25", "25" },
            { "LOC_PART_26", "26" },
            { "LOC_PART_27", "27" },
            { "LOC_PART_28", "28" },
            { "LOC_PART_29", "29" },
            { "LOC_PART_30", "30" },
            { "LOC_PART_31", "31" },
            { "LOC_PART_32", "32" },

            //statuses
            { "LOC_STATUS_0", "Status 0" },
            { "LOC_STATUS_EFFECT_UNKNOWN", "Unknown Status Effect" },
            { "LOC_STATUS_EFFECT_POISON", "Poison" },
            { "LOC_STATUS_EFFECT_PARALYSIS", "Paralysis" },
            { "LOC_STATUS_EFFECT_SLEEP", "Sleep" },
            { "LOC_STATUS_EFFECT_BLAST", "Blast" },
            { "LOC_STATUS_EFFECT_MOUNT", "Mount" },
            { "LOC_STATUS_EFFECT_EXHAUST", "Exhaust" },
            { "LOC_STATUS_EFFECT_STUN", "Stun" },
            { "LOC_STATUS_EFFECT_KO", "KO" },
            { "LOC_STATUS_EFFECT_TRANQUILIZE", "Tranquilize" },
            { "LOC_STATUS_EFFECT_FLASH", "Flash" },
            { "LOC_STATUS_EFFECT_DUNG", "Dung Pods" },
            { "LOC_STATUS_EFFECT_KNOW_DOWN", "Kown Down" },
            { "LOC_STATUS_EFFECT_SMOKING", "Smoking" },
            { "LOC_STATUS_EFFECT_VIOLATED", "Violated" },
            { "LOC_STATUS_EFFECT_CLAW_ATTACK", "Claw Attack" },
            { "LOC_STATUS_EFFECT_FELVYNE_KNOCK_DOWN_TRAP", "Felvyne Knock Down Trap" },

            // Hunting Horn
            { "LOC_STATUS_EFFECT_SELF_IMPROVEMENT", "Self-improvement" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_S", "Attack Up (S)" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_L", "Attack Up (L)" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_S", "Health Boost (S)" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_L", "Health Boost (L)" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_S", "Stamina Use Reduced (S)" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_L", "Stamina Use Reduced (L)" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED", "Wind Pressure Negated" },
            { "LOC_STATUS_EFFECT_ALL_WIND_PRESSURE_NEGATED", "All Wind Pressure Negated" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_S", "Defense Up (S)" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_L", "Defense Up (L)" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_S", "Tool Use Drain Reduced (S)" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_L", "Tool Use Drain Reduced (L)" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_S", "Health Rec. (S)" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_L", "Health Rec. (L)" },
            { "LOC_STATUS_EFFECT_EARPLUGS_S", "Earplugs (S)" },
            { "LOC_STATUS_EFFECT_EARPLUGS_L", "Earplugs (L)" },
            { "LOC_STATUS_EFFECT_DIVINE_PROTECTION", "Divine Protection" },
            { "LOC_STATUS_EFFECT_SCOUTFLY_POWER_UP", "Scoutfly Power Up" },
            { "LOC_STATUS_EFFECT_ENVIRONMENTAL_DAMAGE_NEGATED", "Envir. Damage Negated" },
            { "LOC_STATUS_EFFECT_STUN_NEGATED", "Stun Negated" },
            { "LOC_STATUS_EFFECT_PARALYSIS_NEGATED", "Paralysis Negated" },
            { "LOC_STATUS_EFFECT_TREMORS_NEGATED", "Tremors Negated" },
            { "LOC_STATUS_EFFECT_MUCK_RESISTANCE", "Muck Res" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_S", "Fire Res Boost (S)" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_L", "Fire Res Boost (L)" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_S", "Water Res Boost (S)" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_L", "Water Res Boost (L)" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_S", "Thunder Res Boost (S)" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_L", "Thunder Res Boost (L)" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_S", "Ice Res Boost (S)" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_L", "Ice Res Boost (L)" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_S", "Dragon Res Boost (S)" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_L", "Dragon Res Boost (L)" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_ATTACK_BOOST", "Elemental Attack Boost" },
            { "LOC_STATUS_EFFECT_BLIGHT_NEGATED", "Blight Negated" },
            { "LOC_STATUS_EFFECT_KNOCKBACKS_NEGATED", "Knockbacks Negated" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_UP", "Elemental Resistance Up" },
            { "LOC_STATUS_EFFECT_AFFINITY_UP", "Affinity Up" },
            { "LOC_STATUS_EFFECT_ALL_AILMENTS_NEGATED", "All Ailments Negated" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED_AND_EARPLUGS_S", "Wind Pressure Negated & Earplugs (S)" },
            { "LOC_STATUS_EFFECT_ABNORMAL_STATUS_ATTACK_INCREASED", "Abnormal Status Atk. Increased" },
            
            // Orchestra
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY", "Health Recovery" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST", "Health Boost" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED", "Stamina Use Reduced" },
            
            // Debuffs
            { "LOC_STATUS_EFFECT_FIREBLIGHT", "Fireblight" },
            { "LOC_STATUS_EFFECT_THUNDERBLIGHT", "Thunderblight" },
            { "LOC_STATUS_EFFECT_ICEBLIGHT", "Iceblight" },
            { "LOC_STATUS_EFFECT_WATERBLIGHT", "Waterblight" },
            { "LOC_STATUS_EFFECT_DRAGONBLIGHT", "Dragonblight" },
            { "LOC_STATUS_EFFECT_BLEEDING", "Bleeding" },
            { "LOC_STATUS_EFFECT_BLEEDING_RECOVERY", "Bleeding Recovery" },
            { "LOC_STATUS_EFFECT_EFFLUVIA", "Effluvia" },
            { "LOC_STATUS_EFFECT_DEFENSE_DOWN", "Defense Down" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_DOWN", "Elemental Resistance Down" },
            { "LOC_STATUS_EFFECT_NO_ITEMS", "No Items" },
            { "LOC_STATUS_EFFECT_BLASTBLIGHT", "Blastblight" },
            
            // Buffs
            { "LOC_STATUS_EFFECT_DASH_JUICE", "Dash Juice" },
            { "LOC_STATUS_EFFECT_WIGGLY_LITCHI", "Wiggly Litchi" },
            { "LOC_STATUS_EFFECT_IMMUNIZER", "Immunizer" },            
            { "LOC_STATUS_EFFECT_MIGHT_PILL", "Might Pill" },
            { "LOC_STATUS_EFFECT_MIGHT_SEED", "Might Seed" },            
            { "LOC_STATUS_EFFECT_ADAMANT_PILL", "Adamant Pill" },
            { "LOC_STATUS_EFFECT_ADAMANT_SEED", "Adamant Seed" },            
            { "LOC_STATUS_EFFECT_DEMON_POWDER", "Demon Powder" },
            { "LOC_STATUS_EFFECT_HARDSHELL_POWDER", "Hardshell Powder" },            
            { "LOC_STATUS_EFFECT_DEMONDRUG", "Demondrug" },
            { "LOC_STATUS_EFFECT_MEGA_DEMONDRUG", "Mega Demondrug" },
            { "LOC_STATUS_EFFECT_ARMORSKIN", "Armorskin" },
            { "LOC_STATUS_EFFECT_MEGA_ARMORSKIN", "Mega Armorskin" },
            { "LOC_STATUS_EFFECT_COOL_DRINK", "Cool Drink" },
            { "LOC_STATUS_EFFECT_PROTECTIVE_POLISH", "Protective Polish" },
            { "LOC_STATUS_EFFECT_AFFINITY_SLIDING", "Affinity Sliding" },

            // Equipment
            { "LOC_EQUIPMENT_MANTLE_GHILLIE", "Ghillie Mantle" },
            { "LOC_EQUIPMENT_MANTLE_TEMPORAL", "Temporal Mantle" },
            { "LOC_EQUIPMENT_MANTLE_ROCKSTEADY", "Rocksteady Mantle" },
            { "LOC_EQUIPMENT_MANTLE_CHALLENGER", "Challenger Mantle" },
            { "LOC_EQUIPMENT_MANTLE_VITALITY", "Vitality Mantle" },
            { "LOC_EQUIPMENT_MANTLE_FIREPROOF", "Fireproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_WATERPROOF", "Waterproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_ICEPROOF", "Iceproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_THUNDERPROOF", "Thunderproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_DRAGONPROOF", "Dragonproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_GLIDER", "Glider Mantle" },
            { "LOC_EQUIPMENT_MANTLE_EVASION", "Evasion Mantle" },
            { "LOC_EQUIPMENT_MANTLE_IMPACT", "Impact Mantle" },
            { "LOC_EQUIPMENT_MANTLE_APOTHECARY", "Apothecary Mantle" },
            { "LOC_EQUIPMENT_MANTLE_IMMUNITY", "Immunity Mantle" },
            { "LOC_EQUIPMENT_MANTLE_BANDIT", "Bandit Mantle" },
            { "LOC_EQUIPMENT_AFFINITY_BOOSTER", "Affinity Booster" },

            // Weapon
            { "LOC_WEAPON_INSECT_GLAIVE_ATTACK", "Attack Up" },
            { "LOC_WEAPON_INSECT_GLAIVE_SPEED", "Speed Up" },
            { "LOC_WEAPON_INSECT_GLAIVE_DEFENSE", "Defense Up" },
            { "LOC_WEAPON_LONGSWORD_SPIRIT_GAUGE_REGEN", "Spirit Gauge Regen" },
            { "LOC_WEAPON_LONGSWORD_STEADY_SPIRIT_LEVEL", "Steady Spirit Level" },
            { "LOC_WEAPON_CHARGE_BLADE_SHIELD_CHARGE", "Shield Charge" },
            { "LOC_WEAPON_CHARGE_BLADE_BLADE_CHARGE", "Blade Charge" },
            { "LOC_WEAPON_SWITCH_AXE_AMPED_STATE", "Amped State" },
            { "LOC_WEAPON_HAMMER_POWER_CHARGE", "Power Charge" },

            { "LOC_PART_SHELL", "Shell" },
            { "LOC_PART_EXHAUST_ORGAN_CENTRAL", "Central Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_HEAD", "Head Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_CRATER", "Crater Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_REAR", "Rear Exhaust Organ" },
            { "LOC_PART_WEAK_SHELL_LEFT", "Left Weak Shell" },
            { "LOC_PART_WEAK_SHELL_RIGHT", "Right Weak Shell" },

            { "LOC_STATUS_EFFECT_SHOCK_TRAP", "Shock Trap" },
            { "LOC_STATUS_EFFECT_PITFALL_TRAP", "Pitfall Trap" },
            { "LOC_STATUS_EFFECT_ELDERSEAL", "Elderseal" },

            { "LOC_EQUIPMENT_ASSASSINS_HOOD", "Assassin's Hood" },
            { "LOC_MONSTER_LESHEN", "Leshen" },
            { "LOC_MONSTER_ANCIENT_LESHEN", "Ancient Leshen" },
            { "LOC_REMOVABLE_PART_ANTLER_LEFT", "Removable Left Antler" },
            { "LOC_REMOVABLE_PART_ANTLER_RIGHT", "Removable Right Antler" },
            { "LOC_JAGRAS_SUMMONER", "Jagras Summoner" },

            { "LOC_STATUS_EFFECT_RAGE", "Rage" },
            { "LOC_STATUS_EFFECT_STAMINA", "Stamina" },
            { "LOC_STATUS_EFFECT_FATIGUE", "Fatigue" },
        };
        
        public LocalizationConfig()
        {

        }
    }

    public class LocalizationConfig_zhTW
    {
        [PreserveCollectionIntegrity]
        public Dictionary<string, string> Strings = new Dictionary<string, string>()
        {
            { "LOC_UNKNOWN_PLAYER", "玩家" },
            { "LOC_WIDGET_MONSTER", "怪物小部件" },
            { "LOC_WIDGET_TEAM", "團隊小部件" },
            { "LOC_WIDGET_PLAYER", "玩家小部件" },

            { "LOC_MONSTER_NARCACUGA", "迅龍" },
            { "LOC_MONSTER_NAMIELLE", "溟波龍" },
            { "LOC_MONSTER_SHARA_ISHVALDA", "天地煌啼龍" },
            { "LOC_MONSTER_BANBARO", "猛牛龍" },
            { "LOC_MONSTER_TIGREX", "轟龍" },
            { "LOC_MONSTER_BRUTE_TIGREX", "Brute Tigrex" },
            { "LOC_MONSTER_ZINOGRE", "雷狼龍" },
            { "LOC_MONSTER_PAOLUMU_NIGHTSHADE", "浮眠龍" },
            { "LOC_MONSTER_EBONY_ODOGARON", "凶爪龍" },
            { "LOC_MONSTER_ANJANATH_FULGUR", "雷顎龍" },
            { "LOC_MONSTER_PUKEI_PUKEI_CORAL", "水妖鳥" },
            { "LOC_MONSTER_BRACHYDIOS", "碎龍" },
            { "LOC_MONSTER_VELKHANA", "冰呪龍" },
            { "LOC_MONSTER_BEOTODUS", "冰魚龍" },
            { "LOC_MONSTER_GLAVENUS", "斬龍" },
            { "LOC_MONSTER_ACIDIC_GLAVENUS", "硫斬龍" },
            { "LOC_MONSTER_BLACKVEIL_VAAL_HAZAK", "霧瘴屍套龍" },
            { "LOC_MONSTER_BARIOTH", "冰牙龍" },
            { "LOC_MONSTER_SAVAGE_DEVILJHO", "煌怒恐爆龍" },
            { "LOC_MONSTER_RUINER_NERGIGANTE", "殲世滅盡龍" },
            { "LOC_MONSTER_VIPER_TOBI_KADACHI", "痹毒龍" },
            { "LOC_MONSTER_SHRIEKING_LEGIANA", "霜翼風漂龍" },
            { "LOC_MONSTER_SEETHING_BAZELGEUSE", "紅蓮爆鱗龍" },
            { "LOC_MONSTER_YIAN_GARUGA", "黑狼鳥" },
            { "LOC_MONSTER_SCARRED_YIAN_GARUGA", "戰痕黑狼鳥" },
            { "LOC_MONSTER_GOLD_RATHIAN", "金火龍" },
            { "LOC_MONSTER_SILVER_RATHALOS", "銀火龍" },

            { "LOC_MONSTER_UKNOWN", "未知魔物" },
            { "LOC_MONSTER_ANJANATH", "蠻顎龍" },
            { "LOC_MONSTER_AZURE_RATHALOS", "蒼火龍" },
            { "LOC_MONSTER_BARROTH", "土砂龍" },
            { "LOC_MONSTER_BAZELGEUSE", "爆鱗龍" },
            { "LOC_MONSTER_BEHEMOTH", "貝希摩斯" },
            { "LOC_MONSTER_BLACK_DIABLOS", "黑角龍" },
            { "LOC_MONSTER_DEVILJHO", "恐暴龍" },
            { "LOC_MONSTER_DIABLOS", "角龍" },
            { "LOC_MONSTER_DODOGAMA", "岩賊龍" },
            { "LOC_MONSTER_GREAT_GIRROS", "大兇顎龍" },
            { "LOC_MONSTER_GREAT_JAGRAS", "大兇豺龍" },
            { "LOC_MONSTER_JYURATODUS", "泥魚龍" },
            { "LOC_MONSTER_KIRIN", "麒麟" },
            { "LOC_MONSTER_KULU_YA_KU", "騷鳥" },
            { "LOC_MONSTER_KULVE_TAROTH", "絢輝龍" },
            { "LOC_MONSTER_KUSHALA_DAORA", "鋼龍" },
            { "LOC_MONSTER_LAVASIOTH", "熔岩龍" },
            { "LOC_MONSTER_LEGIANA", "風飄龍" },
            { "LOC_MONSTER_LUNASTRA", "炎妃龍" },
            { "LOC_MONSTER_NERGIGANTE", "滅盡龍" },
            { "LOC_MONSTER_ODOGARON", "慘爪龍" },
            { "LOC_MONSTER_PAOLUMU", "浮空龍" },
            { "LOC_MONSTER_PINK_RATHIAN", "櫻火龍" },
            { "LOC_MONSTER_PUKEI_PUKEI", "毒妖鳥" },
            { "LOC_MONSTER_RADOBAAN", "骨錘龍" },
            { "LOC_MONSTER_RATHALOS", "火龍" },
            { "LOC_MONSTER_RATHIAN", "雌火龍" },
            { "LOC_MONSTER_TEOSTRA", "炎王龍" },
            { "LOC_MONSTER_TOBI_KADACHI", "飛雷龍" },
            { "LOC_MONSTER_TZITZI_YA_KU", "眩鳥" },
            { "LOC_MONSTER_URAGAAN", "爆鎚龍" },
            { "LOC_MONSTER_VAAL_HAZAK", "屍套龍" },
            { "LOC_MONSTER_XENO_JIIVA", "冥燈龍" },
            { "LOC_MONSTER_ZORAH_MAGDAROS", "熔山龍" },
            { "LOC_PART_UKNOWN", "未知部位" },

            { "LOC_PART_HEAD_SNOW", "Head Snow" },
            { "LOC_PART_BODY_SNOW", "Body Snow" },
            { "LOC_PART_TAIL_SNOW", "Tail Snow" },

            { "LOC_PART_HEAD_ICE", "Head Ice" },
            { "LOC_PART_BODY_ICE", "Body Ice" },
            { "LOC_PART_WINGS_ICE", "Wings Ice" },
            { "LOC_PART_ARMS_ICE", "Arms Ice" },
            { "LOC_PART_LEGS_ICE", "Legs Ice" },
            { "LOC_PART_TAIL_ICE", "Tail Ice" },

            { "LOC_PART_HEAD_ROCK", "Head Rock" },
            { "LOC_PART_NECK_LEFT_ROCK", "Left Neck Rock" },
            { "LOC_PART_NECK_RIGHT_ROCK", "Right Right Rock" },
            { "LOC_PART_TAIL_ROCK", "Tail Rock" },
            { "LOC_PART_WING_LEFT_ROCK", "Left Wing Rock" },
            { "LOC_PART_WING_RIGHT_ROCK", "Right Wing Rock" },
            { "LOC_PART_ARM_LEFT_ROCK", "Left Arm Rock" },
            { "LOC_PART_ARM_RIGHT_ROCK", "Right Arm Rock" },
            { "LOC_PART_LEGS_ROCK", "Legs Rock" },

            { "LOC_PART_FIN", "Fin" },
            { "LOC_PART_HEAD", "頭" },
            { "LOC_PART_HEAD_LEFT", "頭部左側" },
            { "LOC_PART_HEAD_RIGHT", "頭部右側" },
            { "LOC_PART_BODY", "身體" },
            { "LOC_PART_ABDOMEN", "腹部" },
            { "LOC_PART_CHEST", "胸部" },
            { "LOC_PART_REAR", "臀部" },
            { "LOC_PART_ARMS", "臂" },
            { "LOC_PART_ARM_LEFT", "左臂" },
            { "LOC_PART_ARM_RIGHT", "右臂" },
            { "LOC_PART_LEGS", "腿" },
            { "LOC_PART_LEG_LEFT", "左腿" },
            { "LOC_PART_LEG_RIGHT", "右腿" },
            { "LOC_PART_LIMBS", "爪" },
            { "LOC_PART_LIMBS_LEFT", "左爪" },
            { "LOC_PART_LIMBS_RIGHT", "右爪" },
            { "LOC_PART_TAIL", "尾巴" },
            { "LOC_PART_WINGS", "翅膀" },
            { "LOC_PART_WING_LEFT", "左翅膀" },
            { "LOC_PART_WING_RIGHT", "右翅膀" },
            { "LOC_PART_HEAD_MUD", "頭部的泥" },
            { "LOC_PART_BODY_MUD", "身體的泥" },
            { "LOC_PART_ARMS_MUD", "前臂的泥" },
            { "LOC_PART_LEG_LEFT_MUD", "左腿的泥" },
            { "LOC_PART_LEG_RIGHT_MUD", "右腿的泥" },
            { "LOC_PART_TAIL_MUD", "尾巴的泥" },
            { "LOC_PART_HORNS", "大角" },
            { "LOC_PART_MANE", "鬃毛" },
            { "LOC_PART_ROCK", "石塊" },
            { "LOC_PART_BALLOON", "氣袋" },
            { "LOC_PART_JAW", "下顎" },
            { "LOC_PART_BACK", "背部" },
            { "LOC_PART_BONE_LEFT", "左骨頭" },
            { "LOC_PART_BONE_RIGHT", "右骨頭" },
            { "LOC_PART_NECK", "頸部" },
            { "LOC_PART_HAND_LEFT", "左手" },
            { "LOC_PART_HAND_RIGHT", "右手" },
            { "LOC_PART_FOOT_LEFT", "左腳" },
            { "LOC_PART_FOOT_RIGHT", "右腳" },
            { "LOC_PART_HORNS_GOLD", "黃金角" },
            { "LOC_PART_MANE_GOLD", "背部的黃金" },
            { "LOC_PART_CHEST_LEFT_GOLD", "左胸的黃金" },
            { "LOC_PART_CHEST_RIGHT_GOLD", "右胸的黃金" },
            { "LOC_PART_ARM_LEFT_GOLD", "左臂的黃金" },
            { "LOC_PART_ARM_RIGHT_GOLD", "右臂的黃金" },
            { "LOC_PART_LEG_LEFT_GOLD", "左腿的黃金" },
            { "LOC_PART_LEG_RIGHT_GOLD", "右腿的黃金" },
            { "LOC_PART_TAIL_LEFT_GOLD", "尾巴左側的黃金" },
            { "LOC_PART_TAIL_RIGHT_GOLD", "尾巴右側的黃金" },
            { "LOC_REMOVABLE_PART_UKNOWN", "未知可破壞部位" },
            { "LOC_REMOVABLE_PART_TAIL", "可斷的尾巴" },
            { "LOC_REMOVABLE_PART_HORNS", "可斷的角" },
            { "LOC_REMOVABLE_PART_HORNS_2", "大角的黃金" },

            //To test monster parts
            { "LOC_PART_0", "0" },
            { "LOC_PART_1", "1" },
            { "LOC_PART_2", "2" },
            { "LOC_PART_3", "3" },
            { "LOC_PART_4", "4" },
            { "LOC_PART_5", "5" },
            { "LOC_PART_6", "6" },
            { "LOC_PART_7", "7" },
            { "LOC_PART_8", "8" },
            { "LOC_PART_9", "9" },
            { "LOC_PART_10", "10" },
            { "LOC_PART_11", "11" },
            { "LOC_PART_12", "12" },
            { "LOC_PART_13", "13" },
            { "LOC_PART_14", "14" },
            { "LOC_PART_15", "15" },
            { "LOC_PART_16", "16" },
            { "LOC_PART_17", "17" },
            { "LOC_PART_18", "18" },
            { "LOC_PART_19", "19" },
            { "LOC_PART_20", "20" },
            { "LOC_PART_21", "21" },
            { "LOC_PART_22", "22" },
            { "LOC_PART_23", "23" },
            { "LOC_PART_24", "24" },
            { "LOC_PART_25", "25" },
            { "LOC_PART_26", "26" },
            { "LOC_PART_27", "27" },
            { "LOC_PART_28", "28" },
            { "LOC_PART_29", "29" },
            { "LOC_PART_30", "30" },
            { "LOC_PART_31", "31" },
            { "LOC_PART_32", "32" },

            //statuses
            { "LOC_STATUS_0", "Status 0" },
            { "LOC_STATUS_EFFECT_UNKNOWN", "未知效果狀態" },
            { "LOC_STATUS_EFFECT_POISON", "中毒" },
            { "LOC_STATUS_EFFECT_PARALYSIS", "麻痺" },
            { "LOC_STATUS_EFFECT_SLEEP", "睡眠" },
            { "LOC_STATUS_EFFECT_BLAST", "爆破" },
            { "LOC_STATUS_EFFECT_MOUNT", "騎乘" },
            { "LOC_STATUS_EFFECT_EXHAUST", "疲勞" },
            { "LOC_STATUS_EFFECT_STUN", "眩暈" },
            { "LOC_STATUS_EFFECT_KO", "KO" },
            { "LOC_STATUS_EFFECT_TRANQUILIZE", "麻醉" },
            { "LOC_STATUS_EFFECT_FLASH", "目眩" },
            { "LOC_STATUS_EFFECT_DUNG", "異臭" },
            { "LOC_STATUS_EFFECT_KNOW_DOWN", "Kown Down" },
            { "LOC_STATUS_EFFECT_SMOKING", "Smoking" },
            { "LOC_STATUS_EFFECT_VIOLATED", "Violated" },
            { "LOC_STATUS_EFFECT_CLAW_ATTACK", "Claw Attack" },
            { "LOC_STATUS_EFFECT_FELVYNE_KNOCK_DOWN_TRAP", "Felvyne Knock Down Trap" },

            // Hunting Horn
            { "LOC_STATUS_EFFECT_SELF_IMPROVEMENT", "自我強化" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_S", "攻擊力UP 小" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_L", "攻擊力UP 大" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_S", "體力UP 小" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_L", "體力UP 大" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_S", "耐力消費減輕 小" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_L", "耐力消費減輕 大" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED", "風壓無效 小" },
            { "LOC_STATUS_EFFECT_ALL_WIND_PRESSURE_NEGATED", "風壓完全無效" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_S", "防禦力UP 小" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_L", "防禦力UP 大" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_S", "特殊裝具消費減輕 小" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_L", "特殊裝具消費減輕 大" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_S", "體力恢復速度UP 小" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_L", "體力恢復速度UP 大" },
            { "LOC_STATUS_EFFECT_EARPLUGS_S", "聽覺保護 小" },
            { "LOC_STATUS_EFFECT_EARPLUGS_L", "聽覺保護 大" },
            { "LOC_STATUS_EFFECT_DIVINE_PROTECTION", "精靈王的加護" },
            { "LOC_STATUS_EFFECT_SCOUTFLY_POWER_UP", "導蟲追蹤力強化" },
            { "LOC_STATUS_EFFECT_ENVIRONMENTAL_DAMAGE_NEGATED", "地形傷害無效" },
            { "LOC_STATUS_EFFECT_STUN_NEGATED", "暈厥無效" },
            { "LOC_STATUS_EFFECT_PARALYSIS_NEGATED", "麻痺無效" },
            { "LOC_STATUS_EFFECT_TREMORS_NEGATED", "震動無效" },
            { "LOC_STATUS_EFFECT_MUCK_RESISTANCE", "泥減輕" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_S", "火屬性防禦強化 小" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_L", "火屬性防禦強化 大" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_S", "水屬性防禦強化 小" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_L", "水屬性防禦強化 大" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_S", "雷屬性防禦強化 小" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_L", "雷屬性防禦強化 大" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_S", "冰屬性防禦強化 小" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_L", "冰屬性防禦強化 大" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_S", "龍屬性防禦強化 小" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_L", "龍屬性防禦強化 大" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_ATTACK_BOOST", "屬性攻擊力UP" },
            { "LOC_STATUS_EFFECT_BLIGHT_NEGATED", "全屬性異常狀態無效" },
            { "LOC_STATUS_EFFECT_KNOCKBACKS_NEGATED", "後仰無效" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_UP", "全屬性耐性值UP" },
            { "LOC_STATUS_EFFECT_AFFINITY_UP", "會心率提升" },
            { "LOC_STATUS_EFFECT_ALL_AILMENTS_NEGATED", "全狀態異常無效" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED_AND_EARPLUGS_S", "風壓無效&聽覺保護小" },
            { "LOC_STATUS_EFFECT_ABNORMAL_STATUS_ATTACK_INCREASED", "異常狀態攻擊力UP" },

            // Orchestra
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY", "體力恢復速度UP" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST", "體力UP" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED", "耐力消費減輕" },

            // Debuffs
            { "LOC_STATUS_EFFECT_FIREBLIGHT", "火屬性異常" },
            { "LOC_STATUS_EFFECT_THUNDERBLIGHT", "雷屬性異常" },
            { "LOC_STATUS_EFFECT_ICEBLIGHT", "冰屬性異常" },
            { "LOC_STATUS_EFFECT_WATERBLIGHT", "水屬性異常" },
            { "LOC_STATUS_EFFECT_DRAGONBLIGHT", "龍屬性異常" },
            { "LOC_STATUS_EFFECT_BLEEDING", "裂傷" },
            { "LOC_STATUS_EFFECT_BLEEDING_RECOVERY", "裂傷恢復" },
            { "LOC_STATUS_EFFECT_EFFLUVIA", "瘴氣異常" },
            { "LOC_STATUS_EFFECT_DEFENSE_DOWN", "防禦下降" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_DOWN", "屬性耐性下降" },
            { "LOC_STATUS_EFFECT_NO_ITEMS", "禁止使用物品" },
            { "LOC_STATUS_EFFECT_BLASTBLIGHT", "爆破屬性異常" },

            // Buffs
            { "LOC_STATUS_EFFECT_DASH_JUICE", "強走藥" },
            { "LOC_STATUS_EFFECT_WIGGLY_LITCHI", "耐力雷蟲" },
            { "LOC_STATUS_EFFECT_IMMUNIZER", "活力劑" },
            { "LOC_STATUS_EFFECT_MIGHT_PILL", "怪力藥丸" },
            { "LOC_STATUS_EFFECT_MIGHT_SEED", "怪力種子" },
            { "LOC_STATUS_EFFECT_ADAMANT_PILL", "忍耐藥丸" },
            { "LOC_STATUS_EFFECT_ADAMANT_SEED", "忍耐種子" },
            { "LOC_STATUS_EFFECT_DEMON_POWDER", "鬼人粉塵" },
            { "LOC_STATUS_EFFECT_HARDSHELL_POWDER", "硬化粉塵" },
            { "LOC_STATUS_EFFECT_DEMONDRUG", "鬼人藥" },
            { "LOC_STATUS_EFFECT_MEGA_DEMONDRUG", "鬼人藥·大" },
            { "LOC_STATUS_EFFECT_ARMORSKIN", "硬化藥" },
            { "LOC_STATUS_EFFECT_MEGA_ARMORSKIN", "硬化藥·大" },
            { "LOC_STATUS_EFFECT_COOL_DRINK", "冷飲" },
            { "LOC_STATUS_EFFECT_PROTECTIVE_POLISH", "鋼刃研磨" },
            { "LOC_STATUS_EFFECT_AFFINITY_SLIDING", "滑走強化" },

            // Equipment
            { "LOC_EQUIPMENT_MANTLE_GHILLIE", "隱身衣裝" },
            { "LOC_EQUIPMENT_MANTLE_TEMPORAL", "轉身衣裝" },
            { "LOC_EQUIPMENT_MANTLE_ROCKSTEADY", "不動衣裝" },
            { "LOC_EQUIPMENT_MANTLE_CHALLENGER", "挑釁衣裝" },
            { "LOC_EQUIPMENT_MANTLE_VITALITY", "體力衣裝" },
            { "LOC_EQUIPMENT_MANTLE_FIREPROOF", "耐熱衣裝" },
            { "LOC_EQUIPMENT_MANTLE_WATERPROOF", "耐水衣裝" },
            { "LOC_EQUIPMENT_MANTLE_ICEPROOF", "耐寒衣裝" },
            { "LOC_EQUIPMENT_MANTLE_THUNDERPROOF", "耐雷衣裝" },
            { "LOC_EQUIPMENT_MANTLE_DRAGONPROOF", "耐龍衣裝" },
            { "LOC_EQUIPMENT_MANTLE_GLIDER", "滑空衣裝" },
            { "LOC_EQUIPMENT_MANTLE_EVASION", "迴避衣裝" },
            { "LOC_EQUIPMENT_MANTLE_IMPACT", "強打衣裝" },
            { "LOC_EQUIPMENT_MANTLE_APOTHECARY", "化合衣裝" },
            { "LOC_EQUIPMENT_MANTLE_IMMUNITY", "免疫衣裝" },
            { "LOC_EQUIPMENT_MANTLE_BANDIT", "盜掠衣裝" },
            { "LOC_EQUIPMENT_AFFINITY_BOOSTER", "達人煙筒" },

            // Weapon
            { "LOC_WEAPON_INSECT_GLAIVE_ATTACK", "攻擊力UP" },
            { "LOC_WEAPON_INSECT_GLAIVE_SPEED", "速度UP" },
            { "LOC_WEAPON_INSECT_GLAIVE_DEFENSE", "防禦力UP" },
            { "LOC_WEAPON_LONGSWORD_SPIRIT_GAUGE_REGEN", "氣刃值回復" },
            { "LOC_WEAPON_LONGSWORD_STEADY_SPIRIT_LEVEL", "氣刃等級穩定" },
            { "LOC_WEAPON_CHARGE_BLADE_SHIELD_CHARGE", "紅盾" },
            { "LOC_WEAPON_CHARGE_BLADE_BLADE_CHARGE", "紅刃" },
            { "LOC_WEAPON_SWITCH_AXE_AMPED_STATE", "高出力" },
            { "LOC_WEAPON_HAMMER_POWER_CHARGE", "強蓄力" },

            { "LOC_PART_SHELL", "外殼" },
            { "LOC_PART_EXHAUST_ORGAN_CENTRAL", "中央散熱器官" },
            { "LOC_PART_EXHAUST_ORGAN_HEAD", "頭部散熱器官" },
            { "LOC_PART_EXHAUST_ORGAN_CRATER", "背部散熱器官" },
            { "LOC_PART_EXHAUST_ORGAN_REAR", "尾部散熱器官" },
            { "LOC_PART_WEAK_SHELL_LEFT", "左側薄殼" },
            { "LOC_PART_WEAK_SHELL_RIGHT", "右側薄殼" },

            { "LOC_STATUS_EFFECT_SHOCK_TRAP", "麻痺陷阱" },
            { "LOC_STATUS_EFFECT_PITFALL_TRAP", "落穴陷阱" },
            { "LOC_STATUS_EFFECT_ELDERSEAL", "龍封力" },

            { "LOC_EQUIPMENT_ASSASSINS_HOOD", "刺客衣裝" },
            { "LOC_MONSTER_LESHEN", "鹿首精" },
            { "LOC_REMOVABLE_PART_ANTLER_LEFT", "左側鹿角" },
            { "LOC_REMOVABLE_PART_ANTLER_RIGHT", "右側鹿角" },
            { "LOC_MONSTER_ANCIENT_LESHEN", "古代鹿首精" },
            { "LOC_JAGRAS_SUMMONER", "Jagras Summoner" },

            { "LOC_STATUS_EFFECT_RAGE", "憤怒" },
            { "LOC_STATUS_EFFECT_STAMINA", "耐力" },
            { "LOC_STATUS_EFFECT_FATIGUE", "疲勞" },
        };

        public LocalizationConfig_zhTW()
        {
        }
    }
}
