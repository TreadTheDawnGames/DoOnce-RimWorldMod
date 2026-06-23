using Verse;

namespace DoOnceRimworld
{
    public class DoOnceMod : Mod
    {
        public DoOnceMod(ModContentPack content) : base(content)
        {
                // Harmony patch
                var harmony = new HarmonyLib.Harmony("com.TreadTheDan.DoOnce");
                harmony.PatchAll();
                Log.Message("[Do Once] Harmony patches applied.");

        }
    }
}
