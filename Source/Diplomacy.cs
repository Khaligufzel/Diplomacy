using Harmony;
using HugsLib;
using HugsLib.Utils;
using RimWorld;
using RimWorld.Planet;
using UnityEngine.SceneManagement;
using Verse;

namespace Diplomacy
{
    

    public class Diplomacy : ModBase
    {
        public override string ModIdentifier => "Diplomacy";

        public override ModContentPack ModContentPack => base.ModContentPack;

        protected override bool HarmonyAutoPatch => base.HarmonyAutoPatch;


        public Diplomacy()
        {
            Log.Message("Diplomacy start");
        }
     

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Tick(int currentTick)
        {
            base.Tick(currentTick);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override void OnGUI()
        {
            base.OnGUI();
        }

        public override void WorldLoaded()
        {
            base.WorldLoaded();
        }

        public override void MapComponentsInitializing(Map map)
        {
            base.MapComponentsInitializing(map);
        }

        public override void MapGenerated(Map map)
        {
            base.MapGenerated(map);
        }

        public override void MapLoaded(Map map)
        {
            base.MapLoaded(map);

            if (!Resources.worldGenerated)
            {
                foreach (Faction f in Find.FactionManager.AllFactionsInViewOrder)
                {
                    Resources.diplomacyFactions.Add(new FactionStats(f));
                    Log.Message(f.def.techLevel + " " + f.Name);
                }

                foreach (FactionStats f in Resources.diplomacyFactions)
                {
                    foreach(FactionBase b in Resources.factionBases)
                    {
                        if(b.Faction == f.faction)
                        {
                            f.AddBase();
                        }
                    }

                    f.CalculatePower();
                    Log.Warning(f.faction.Name + " bases: " + f.BaseCount + " power " + f.FactionPower);
                }

                Resources.worldGenerated = true;

            }


            HugsLibController.Instance.TickDelayScheduler.ScheduleCallback(() => {

                Faction playerFaction;
                foreach(Faction f in Find.FactionManager.AllFactionsVisible)
                {
                    if (f.IsPlayer)
                    {
                        playerFaction = f;
                    }
                }


                Log.Warning(Resources.factionBases.Count + " bases");
                foreach (FactionBase b in Resources.factionBases)
                {
                    if (b != null)
                    {
                        //b.Faction
                    }

                }



            }, 2500, null, true);
        }

        public override void MapDiscarded(Map map)
        {
            base.MapDiscarded(map);
        }

        public override void SceneLoaded(Scene scene)
        {
            base.SceneLoaded(scene);
        }

        public override void SettingsChanged()
        {
            base.SettingsChanged();
        }

        public override void DefsLoaded()
        {
            base.DefsLoaded();
        }
    }
}