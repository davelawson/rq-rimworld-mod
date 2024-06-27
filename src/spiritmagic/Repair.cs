using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Rq.spiritmagic
{
    public class Rq_CompProperties_AbilityRepair : CompProperties_AbilityEffect
    {
        public Rq_CompProperties_AbilityRepair()
        {
            compClass = typeof(Rq_CompAbilityEffect_Repair);
        }
    }

    public class Rq_CompAbilityEffect_Repair : CompAbilityEffect
    {
        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            target.Thing.HitPoints = target.Thing.MaxHitPoints;
            Log.Message("Rq_CompAbilityEffect_Repair.Apply()");
        }

        //public override bool CanApplyOn(GlobalTargetInfo target)
        //{
        //    if (target.Thing.def.useHitPoints == false) { return false; }
        //    if (target.Thing.HitPoints == target.Thing.MaxHitPoints) { return false; }
        //    return true;
        //}
    }
}
