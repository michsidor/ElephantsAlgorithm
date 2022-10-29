using System;
using System.Linq;

namespace Enrolment
{
    public static class ExtensionMethods
    {
        public static List<int> ReturningOneCycle(this List<int> Input, List<int> Output) // Working Good
        {
            int iterator = 0;
            List<int> cyfryWCycklu = new List<int>();
            int startPosition = Input[0];
            do
            {
                for (int i = 0; i < Output.Count(); i++)
                {
                    if (Output[i] == startPosition)
                    {
                        cyfryWCycklu.Add(Output[i]);
                        startPosition = Input[i];
                        break;
                    }
                }
                iterator++;
            }
            while (cyfryWCycklu.FindAll(val => val.Equals(Input[0])).Count() < 2);
            cyfryWCycklu.Remove(cyfryWCycklu.Last());
            return cyfryWCycklu;
        }

        public static int SumOfMass(this List<int> mass, List<int> ElephantsInCycle) // Working Good
        {
            int sumOfMass = 0;
            for (int i = 0; i < ElephantsInCycle.Count(); i++)
            {
                sumOfMass = sumOfMass + mass[ElephantsInCycle[i] - 1];
            }
            return sumOfMass;
        }

        public static int LightestElephant(this List<int> mass, List<int> Elephants) // Working Good
        {
            int lightestElephant = mass[Elephants[0] - 1]; // masa pierwszego sloia
            //Console.WriteLine("Najmniejsza masa na poczatek" + lightestElephant);
            for(int i = 0;  i < Elephants.Count(); i++)
            {
                //Console.WriteLine("Masa" + mass[Elephants[i] - 1]);
                if (mass[Elephants[i] - 1] < lightestElephant)
                {

                    lightestElephant = mass[Elephants[i] - 1];
                    //Console.WriteLine("Zamiana masy: " + lightestElephant);
                }
            }
            return lightestElephant;
        }


        public static List<int> RemovingItemsFromList(this List<int> cycle, List<int> fullList) // Working Good
        {
            for (int i = 0; i < cycle.Count(); i++)
            {
                for (int j = 0; j < fullList.Count(); j++)
                {
                    if (cycle[i] == fullList[j])
                    {
                        fullList.RemoveAt(j);
                    }
                }
            }
            return fullList;
        }

    }
}
