using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using Verse;
using HarmonyLib;
//using VariedBodySizes;

namespace BigAndSmall
{
    [StaticConstructorOnStartup]
    public static class AutoCombat
    {
        private static readonly Type patchType;
        public static Harmony harmony = new("RedMattis.AutoCombat");
        static AutoCombat()
        {
            patchType = typeof(AutoCombat);
            harmony.PatchAll();
        }
    }
}
