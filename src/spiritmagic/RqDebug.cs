using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Rq.SpiritMagic
{
    public class Rq_CompProperties_AbilityDebug : CompProperties_AbilityEffect
    {
        public Rq_CompProperties_AbilityDebug()
        {
            compClass = typeof(Rq_CompAbilityEffect_Debug);
        }
    }

    public class Rq_CompAbilityEffect_Debug : CompAbilityEffect
    {
        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            Log.Message("Rq_CompAbilityEffect_Debug.Apply()");
        }
    }
}

