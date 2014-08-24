namespace Warhammer40KSimulator.Armies
{
    public static class UnitConstants
    {
        public enum UnitType
        {
            Infantry,
            Vehicle
        }

        #region Roles

        public const string HQ_ROLE = "HQ";

        public const string TROOPS_ROLE = "Troops";

        public const string ELITES_ROLE = "Elites";

        public const string DEDICATED_TRANSPORTS_ROLE = "Dedicated Transports";

        public const string FAST_ATTACK_ROLE = "Fast Attack";

        public const string HEAVY_SUPPORT_ROLE = "Heavy Support";

        #endregion

        #region Faction names

        public const string BLOOD_ANGELS_ARMY = "Blood Angels";
        public const string CHAOS_DAEMONS_ARMY = "Chaos Daemons";
        public const string CHAOS_SPACE_MARINES_ARMY = "Chaos Space Marines";
        public const string DARK_ANGELS_ARMY = "Dark Angels";
        public const string DARK_ELDAR_ARMY = "Dark Eldar";
        public const string ELDAR_ARMY = "Eldar";
        public const string GREY_KNIGHTS_ARMY = "Grey Knights";
        public const string IMPERIAL_GUARD_ARMY = "Imperial Guard";
        public const string NECRONS_ARMY = "Necrons";
        public const string ORKS_ARMY = "Orks";
        public const string SISTERS_OF_BATTLE_ARMY = "Sisters Of Battle";
        public const string SPACE_MARINES_ARMY = "Space Marines";
        public const string SPACE_WOLVES_ARMY = "Space Wolves";
        public const string TAU_EMPIRE_ARMY = "Tau Empire";
        public const string TYRANIDS_ARMY = "Tyranids";

        public static string[] ARMY_FACTIONS = new string[]
                                                   {
                                                       BLOOD_ANGELS_ARMY,
                                                       CHAOS_DAEMONS_ARMY,
                                                       CHAOS_SPACE_MARINES_ARMY,
                                                       DARK_ANGELS_ARMY,
                                                       DARK_ELDAR_ARMY,
                                                       ELDAR_ARMY,
                                                       GREY_KNIGHTS_ARMY,
                                                       IMPERIAL_GUARD_ARMY,
                                                       NECRONS_ARMY,
                                                       ORKS_ARMY,
                                                       SISTERS_OF_BATTLE_ARMY,
                                                       SPACE_MARINES_ARMY,
                                                       SPACE_WOLVES_ARMY,
                                                       TAU_EMPIRE_ARMY,
                                                       TYRANIDS_ARMY
                                                   };



        #endregion

    }
}