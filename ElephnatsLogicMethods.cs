using System;
using System.Linq;

namespace Enrolment
{
    public abstract class ElephnatsLogicMethods
    {
        public int MethodOneForCycle(List<int> mass, List<int> ElephantsInCycle)
        {
            return mass.SumOfMass(ElephantsInCycle) + ((ElephantsInCycle.Count() - 2) *
                mass.LightestElephant(ElephantsInCycle)); ;
        }

        public int MethodTwoForCycle(List<int> mass, List<int> ElephantsInCycle, int LightestOfAll)
        {
            return mass.SumOfMass(ElephantsInCycle) + mass.LightestElephant(ElephantsInCycle) +
                ((ElephantsInCycle.Count() + 1) * LightestOfAll); ;
        }

    }
}
