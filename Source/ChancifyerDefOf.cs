using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace EPOEROrganRejectionChancifyer
{
    public static class ChancifyerDefOf
    {
        public static HediffDef earlyrejection = DefDatabase<HediffDef>.GetNamed("RejectionChance"); //Get our random chance hediff
        public static HediffDef rejection = DefDatabase<HediffDef>.GetNamed("NaturalOrganRejection"); //Get EPOER's natural organ rej. diff
    }
}
