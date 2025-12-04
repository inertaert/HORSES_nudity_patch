using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(nudity_patch.Core), "Nudity Patch", "1.0.0", "", null)]
[assembly: MelonGame("Santa Ragione", "Horses")]

namespace nudity_patch
{ 

        public class Core : MelonMod
    {
        /*public override void OnInitializeMelon()
        {
            MelonLogger.Msg("OnApplicationStart");
        }

        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg("OnSceneWasUnloaded: " + buildIndex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            MelonLogger.Msg("OnUpdate");
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }*/
    }
}



 
[HarmonyLib.HarmonyPatch(typeof(CensorComponent), "ChangeState")]
public static class Patch1
{
    static void Prefix(ref bool isActive)
    {
        // The code inside this method will run before 'PrivateMethod' is executed
        // MelonLogger.Msg("PREFIX HERE");
        isActive = false;
    }

    private static void Postfix()
    {
        // MelonLogger.Msg("POSTFIX HERE");
        // The code inside this method will run after 'PrivateMethod' has executed
    }
}

[HarmonyLib.HarmonyPatch(typeof(CensorStandaloneComponent), "ChangeState")]
public static class Patch2
{
    static void Prefix(ref bool isActive)
    {
        // The code inside this method will run before 'PrivateMethod' is executed
        // MelonLogger.Msg("PREFIX HERE");
        isActive = false;
    }

    static void Postfix()
    {
        // MelonLogger.Msg("POSTFIX HERE");
        // The code inside this method will run after 'PrivateMethod' has executed
    }
}
