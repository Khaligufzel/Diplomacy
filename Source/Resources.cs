using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplomacy
{
    public static class Resources
    {
        public static List<FactionBase> factionBases = new List<FactionBase>();
        public static List<FactionStats> diplomacyFactions = new List<FactionStats>();

        public static bool worldGenerated = false;
    }
}
