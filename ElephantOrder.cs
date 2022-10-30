using System;
using System.Linq;

namespace Enrolment
{
    public class ElephantsOrder : ElephnatsLogicMethods
    {
        private readonly int         _numberOfElephants;
        private List<int>            _elephantsMass;
        private Dictionary<int, int> _positions;
        private int                  _finalResult;

        public ElephantsOrder(int numOfElephants, List<int> elephantsMass, Dictionary<int,int> positions)
        {
            _numberOfElephants = numOfElephants;
            _positions         = positions;
            _elephantsMass     = elephantsMass;
        }

        public void PrintResult()
        {
            do
            {
                var oneCycle = _positions.ReturningOneCycle();
                var elephantsAndMass = oneCycle.AddingMassOfDirectElephant(_elephantsMass);
                var resultMethodOne = MethodOneForCycle(elephantsAndMass);
                var resultMethodTwo = MethodTwoForCycle(elephantsAndMass, _elephantsMass.Min());
                if (resultMethodOne > resultMethodTwo)
                    _finalResult = _finalResult + resultMethodTwo;
                else
                    _finalResult = _finalResult + resultMethodOne;
                elephantsAndMass.RemovingItemsFromList(_positions);

            }
            while (_positions.Any());
            Console.WriteLine(_finalResult);
        }
    }
}
