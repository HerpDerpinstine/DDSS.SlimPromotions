using MelonLoader;

namespace DDSS_SlimPromotions.Utils
{
    internal static class ConfigHandler
    {
        private static MelonPreferences_Category _prefs_Category;
        internal static MelonPreferences_Entry<bool> _prefs_Promotions;
        internal static MelonPreferences_Entry<bool> _prefs_Demotions;

        internal static void Setup()
        {
            // Create Preferences Category
            _prefs_Category = MelonPreferences.CreateCategory("SlimPromotions", "Slim Promotions");

            // Create Preferences Entries
            _prefs_Promotions = CreatePref("Promotions", "Promotions", "Toggles Slim Promotions", true);
            _prefs_Demotions = CreatePref("Demotions", "Demotions", "Toggles Slim Demotions", true);
        }

        private static MelonPreferences_Entry<T> CreatePref<T>(
            string id,
            string displayName,
            string description, 
            T defaultValue, 
            bool isHidden = false)
            => _prefs_Category.CreateEntry(id,
                defaultValue,
                displayName,
                description,
                isHidden, 
                false,
                null);
    }
}
