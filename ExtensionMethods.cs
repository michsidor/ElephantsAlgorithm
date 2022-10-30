using System;
using System.Linq;

namespace Enrolment
{
    public static class ExtensionMethods
    {
        public static List<int> ReturningOneCycle(this Dictionary<int,int> Positions) // Working Good
        {
            List<int> elephantsInCycle = new List<int>();
            int sPosition = Positions.ElementAt(0).Key;
            do
            {
                var result = Positions.Where(x => x.Value == sPosition)
                    .Select(x => x.Key)
                    .FirstOrDefault();
                elephantsInCycle.Add(sPosition);
                sPosition = result;
            }   
            while (elephantsInCycle.FindAll(val => val.Equals(Positions.ElementAt(0).Key)).Count() < 2);
            elephantsInCycle.Remove(elephantsInCycle.Last()); // remove last duplicate item
            return elephantsInCycle;
        }

        public static Dictionary<int,int> RemovingItemsFromList(this Dictionary<int,int> elephantsAndMass, Dictionary<int,int> positions) 
        {
            foreach (var values in elephantsAndMass)
            {
                positions.Remove(values.Key);
            }
            return positions;
        }

        public static Dictionary<int,int> AddingMassOfDirectElephant(this List<int> elephants, List<int> mass)
        {
            Dictionary<int, int> elephantsAndMass = new Dictionary<int, int>();
            foreach(var values in elephants)
            {
                var result = mass.ElementAt(values - 1);
                elephantsAndMass.Add(values, result);
            }
            return elephantsAndMass;
        }

    }
}
