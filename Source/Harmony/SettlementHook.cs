using Harmony;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Diplomacy.Harmony
{
    [HarmonyPatch(typeof(Settlement), "GetFloatMenuOption", null)]
    //[HarmonyPatch("GetFloatMenuOptions")]

    class SettlementHook
    {
        public SettlementHook()
        {
            Log.Message("asdf");
        }

        //static void Prefix(IEnumerable<FloatMenuOption> __result)
        //{
           
        //    __result.Add<FloatMenuOption>(new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null));
        //    new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null);

        //    Log.Message("ass " + __result.Count<FloatMenuOption>());


        //}

        public static void Prefix(ref IEnumerable<FloatMenuOption> __result, Settlement __instance)
        {

            //FloatMenuOption floatMenuOption = new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null);
            //new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null);

            FloatMenuOption floatMenuOption = new FloatMenuOption("Finish_off_floatMenu", delegate
                    {
                        Log.Message("ass");
                    }, MenuOptionPriority.Default, null, null, 0f, null, null);


            List<FloatMenuOption> list = __result.ToList<FloatMenuOption>();
            list.Add(floatMenuOption);
            __result = list;

            //__result.Add<FloatMenuOption>(new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null));
            //new FloatMenuOption("Ass", delegate { Log.Message("ass"); }, MenuOptionPriority.Default, null, null, 0f, null, null);

            


        }


    }
}
