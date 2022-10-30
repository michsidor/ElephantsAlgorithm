using System;
using System.Linq;

namespace Enrolment
{
    public abstract class ElephnatsLogicMethods
    {
        public int MethodOneForCycle(Dictionary<int,int> elephants)
        {
            return elephants.Sum(x => x.Value) + ((elephants.Count() - 2) *
                elephants.Min(x => x.Value));
        }

        public int MethodTwoForCycle(Dictionary<int, int> elephants, int LightestOfAll)
        {
            return elephants.Sum(x => x.Value) + elephants.Min(x => x.Value) +
                ((elephants.Count() + 1) * LightestOfAll); 
        }

    }
}
