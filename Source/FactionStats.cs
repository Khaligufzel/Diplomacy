using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplomacy
{
    public class FactionStats
    {
        private int baseCount = 0;
        private int factionPower = 0;
        public Faction faction = null;

        public int BaseCount { get => baseCount; }
        public int FactionPower { get => factionPower; }

        public FactionStats()
        {
            
        }

        

        public FactionStats(Faction faction)
        {
            this.faction = faction;
        }

        public void AddBase()
        {
            baseCount = baseCount + 1;
        }

        public void RemoveBase()
        {
            if (BaseCount > 0)
            {
                baseCount = baseCount - 1;
            }
        }

        public void CalculatePower()
        {
            int techPower = 1;

            switch (faction.def.techLevel)
            {
                case TechLevel.Undefined:
                    techPower = 1;
                    break;

                case TechLevel.Animal:
                    techPower = 1;
                    break;

                case TechLevel.Neolithic:
                    techPower = 2;
                    break;

                case TechLevel.Medieval:
                    techPower = 3;
                    break;

                case TechLevel.Industrial:
                    techPower = 5;
                    break;

                case TechLevel.Spacer:
                    techPower = 7;
                    break;

                case TechLevel.Ultra:
                    techPower = 10;
                    break;

                case TechLevel.Transcendent:
                    techPower = 15;
                    break;      
            }

            factionPower = baseCount * techPower;


        }


    }
}
