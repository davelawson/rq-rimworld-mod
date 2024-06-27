using HarmonyLib;
using RimWorld;
using System;
using Verse;

namespace RqLib
{
    [StaticConstructorOnStartup]
    public static class RqMod
    {
        static RqMod()
        {
            Log.Message("Hello Glorantha!"); //Outputs "Hello Glorantha!" to the dev console.
            RqPatcher.DoPatching();
        }
    }

    public class RqPatcher
    {
        // make sure DoPatching() is called at start either by
        // the mod loader or by your injector

        public static void DoPatching()
        {
            Log.Message("Hello Harmony!"); //Outputs "Hello Glorantha!" to the dev console.
            var harmony = new Harmony("com.example.patch");
            harmony.PatchAll();
        }
    }


    //[HarmonyPatch(typeof(Verb_MeleeAttack), "TryCastShot")]
    //public class Rq_Verb_MeleeAttack_TryCastShot_Patcher
    //{
    //    static bool Prefix(Verb_MeleeAttack __instance) 
    //    {
    //        Pawn pawn = __instance.CurrentTarget.Thing as Pawn;
    //        float dodgeChance = pawn.GetStatValue(StatDefOf.MeleeDodgeChance);
    //        Log.Message("Rq_Verb_MeleeAttack_TryCastShot_Patcher.Prefix() dodge chance: " + dodgeChance);

    //        return true;
    //    }
    //}

    //[HarmonyPatch(typeof(Verb_MeleeAttack), "GetDodgeChance", new Type[] { typeof(LocalTargetInfo) })]
    //public class Rq_Verb_MeleeAttack_GetDodgeChance_Patcher
    //{
    //}
}
