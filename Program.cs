using System;
namespace Enrolment // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFile = @"C:\Users\michs\Desktop\zadanie_B\zadanie_B\slo1.in";
            List<string> allLines = new List<string>();
            using(StreamReader file = new StreamReader(textFile))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    allLines.Add(ln);
                }
            }
            int all_elephants = Int32.Parse(allLines[0]);
            List<int> mas_elephants = allLines[1].Split(' ')
                .Select(s => Int32.Parse(s))
                .ToList();
            List<int> sPosition = allLines[2].Split(' ')
                .Select(s => Int32.Parse(s))
                .ToList();
            List<int> ePosition = allLines[3].Split(' ')
                .Select(s => Int32.Parse(s))
                .ToList();
            ElephantsOrder elephantsOrder = new ElephantsOrder(all_elephants, mas_elephants, sPosition, ePosition);
            elephantsOrder.PrintResult();
        }
    }
}