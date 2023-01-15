using BTD_Mod_Helper;
using HarmonyLib;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Unity.Towers;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using MelonLoader;
using PlaceEverywhere;

[assembly: MelonInfo(typeof(PlaceEverywhere.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace PlaceEverywhere;

[HarmonyPatch]
public class Main : BloonsTD6Mod
{
    [HarmonyPatch(typeof(TowerModel), nameof(TowerModel.IsTowerPlaceableInAreaType))]
    [HarmonyPostfix]
    public static void TowerModel_IsTowerPlaceableInAreaType(ref bool __result)
    {
        __result = true;
    }
    
    [HarmonyPatch(typeof(Map), nameof(Map.CanPlace))]
    [HarmonyPostfix]
    public static void Map_CanPlace(ref bool __result)
    {
        __result = true;
    }
    
    [HarmonyPatch(typeof(Map), nameof(Map.IsTowerPlaceableInAreaType))]
    [HarmonyPostfix]
    public static void Map_IsTowerPlaceableInAreaType(ref bool __result)
    {
        __result = true;
    }
    
    
}
