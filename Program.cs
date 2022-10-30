using System;
namespace Enrolment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // slo5.in - 2:30min --> List<int>
            // slo5.in - 2:15min --> Dictionary<int,int>
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
            int all_elephants = Int32.Parse(allLines[0]); // first line load
            List<int> mas_elephants = allLines[1].Split(' ') // second line load
                .Select(s => Int32.Parse(s))
                .ToList();
            List<int> sPosition = allLines[2].Split(' ') // third line load
                .Select(s => Int32.Parse(s))
                .ToList();
            List<int> ePosition = allLines[3].Split(' ') // fourth line laod
                .Select(s => Int32.Parse(s))
                .ToList();

            Dictionary<int, int> positions = new Dictionary<int, int>();
            for(int i = 0; i < all_elephants; i++)
            {
                positions.Add(sPosition[i], ePosition[i]);
            }

            ElephantsOrder elephantsOrder = new ElephantsOrder(all_elephants, mas_elephants, positions);
            elephantsOrder.PrintResult();
        }
    }
}