using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(DDSS_SlimPromotions.Properties.BuildInfo.Description)]
[assembly: AssemblyDescription(DDSS_SlimPromotions.Properties.BuildInfo.Description)]
[assembly: AssemblyCompany(DDSS_SlimPromotions.Properties.BuildInfo.Company)]
[assembly: AssemblyProduct(DDSS_SlimPromotions.Properties.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + DDSS_SlimPromotions.Properties.BuildInfo.Author)]
[assembly: AssemblyTrademark(DDSS_SlimPromotions.Properties.BuildInfo.Company)]
[assembly: AssemblyVersion(DDSS_SlimPromotions.Properties.BuildInfo.Version)]
[assembly: AssemblyFileVersion(DDSS_SlimPromotions.Properties.BuildInfo.Version)]
[assembly: MelonInfo(typeof(DDSS_SlimPromotions.MelonMain), 
    DDSS_SlimPromotions.Properties.BuildInfo.Name, 
    DDSS_SlimPromotions.Properties.BuildInfo.Version,
    DDSS_SlimPromotions.Properties.BuildInfo.Author,
    DDSS_SlimPromotions.Properties.BuildInfo.DownloadLink)]
[assembly: MelonGame("StripedPandaStudios", "DDSS")]
[assembly: VerifyLoaderVersion("0.6.5", true)]
[assembly: HarmonyDontPatchAll]