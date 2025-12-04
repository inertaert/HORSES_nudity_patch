using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(nudity_patch.Core), "Nudity Patch", "1.0.0", "inertaert", null)]
[assembly: MelonGame("Santa Ragione", "Horses")]

namespace nudity_patch
{ 

        public class Core : MelonMod
    {
        
    }
}



 
[HarmonyLib.HarmonyPatch(typeof(CensorComponent), "ChangeState")]
public static class Patch1
{
    static void Prefix(ref bool isActive)
    {
        isActive = false;
    }
}

[HarmonyLib.HarmonyPatch(typeof(CensorStandaloneComponent), "ChangeState")]
public static class Patch2
{
    static void Prefix(ref bool isActive)
    {
        isActive = false;
    }
}

