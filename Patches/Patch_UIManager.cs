using DDSS_SlimPromotions.Utils;
using HarmonyLib;
using Il2CppUMUI;

namespace DDSS_SlimPromotions.Patches
{
    [HarmonyPatch]
    internal class Patch_UIManager
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(UIManager), nameof(UIManager.ShowGameEvent))]
        private static bool ShowGameEvent_Prefix(UIManager __instance, string __0, string __1, float __2)
        {
            // Check for Promotion/Demotion Game Events
            if ((ConfigHandler._prefs_Promotions.Value && IsPromotion(__0))
                || (ConfigHandler._prefs_Demotions.Value && IsDemotion(__0)))
            {
                // Run ShowNotification
                __instance.ShowNotification(__0, __1, __2);

                // Prevent Original
                return false;
            }

            // Run Original
            return true;
        }
		
        private static bool IsPromotion(string header)
            => ((header == "Congratulations!")
                || (header == "Promotion!"));

        private static bool IsDemotion(string header)
            => ((header == "Apologies!")
                || (header == "Demotion!"));
    }
}