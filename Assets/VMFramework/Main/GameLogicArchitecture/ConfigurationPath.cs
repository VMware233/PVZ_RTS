﻿namespace VMFramework.GameLogicArchitecture
{
    public static class ConfigurationPath
    {
        public const string INTERNAL_GLOBAL_SETTINGS_PATH =
            "VMFramework/GameResources/GlobalSettings/";

        public const string DEFAULT_RESOURCES_PATH = "Assets/GameResources";
        
        public const string DEFAULT_CONFIGURATIONS_PATH = DEFAULT_RESOURCES_PATH + "/Configurations";

        public const string DEFAULT_GLOBAL_SETTINGS_PATH = DEFAULT_CONFIGURATIONS_PATH + "/GlobalSettings";
        
        public const string DEFAULT_GENERAL_SETTINGS_PATH = DEFAULT_CONFIGURATIONS_PATH + "/GeneralSettings";
        
        public const string DEFAULT_GAME_PREFABS_PATH = DEFAULT_CONFIGURATIONS_PATH + "/GamePrefabs";
    }
}