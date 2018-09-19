using RimWorld;
using Verse;
using System;

namespace EPOEROrganRejectionChancifyer
{
    public class Hediff_RejectionChance : HediffWithComps
    {

        private const int HangoverCheckInterval = 300;

        public override void Tick()
        {
            
            Hediff chancehediff = this.pawn.health.hediffSet.GetFirstHediffOfDef(ChancifyerDefOf.earlyrejection);           
            float RandomNum = UnityEngine.Random.Range(0f, 1f);
            base.Tick();
            if (RandomNum < 0.5f)
            {
                Log.Message(pawn.NameStringShort + " has gotten the rejection!");
                //They get the rejection!
                this.pawn.health.AddHediff(ChancifyerDefOf.rejection, chancehediff.Part);           
                this.pawn.health.RemoveHediff(chancehediff);
            }
            else
            {
                //They dont get it!
                Log.Message(pawn.NameStringShort + " has not gotten the rejection!");
                this.pawn.health.RemoveHediff(chancehediff);
            }
        }
    }
}