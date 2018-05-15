using Harmony;
using RimWorld.Planet;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplomacy.Harmony
{
    [HarmonyPatch(typeof(FactionBase))]
    

    class FactionBaseHook
    {
        static void Postfix(FactionBase __instance)
        {            
            Resources.factionBases.Add(__instance);           
            //Log.Message(__instance.Faction.def.defName);

            
        }

    }
}
