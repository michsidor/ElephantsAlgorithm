using System;
using System.Linq;

namespace Enrolment
{
    public class ElephantsOrder : ElephnatsLogicMethods
    {
        private readonly int _numberOfElephants;
        private List<int>    _elephantsMass;
        private List<int>    _elephantsStartPosition;
        private List<int>    _elephantsEndPosition;
        private int          _finalResult;

        public ElephantsOrder(int numOfElephants, List<int> elephantsMass, List<int> elephantsStartPosition, List<int> elephantsEndPosition)
        {
            _numberOfElephants      = numOfElephants;
            _elephantsStartPosition = elephantsStartPosition;
            _elephantsEndPosition   = elephantsEndPosition;
            _elephantsMass          = elephantsMass;
        }

        public void PrintResult()
        {
            do
            {
                var oneCycle = _elephantsStartPosition.ReturningOneCycle(_elephantsEndPosition);
                var resultMethodOne = MethodOneForCycle(_elephantsMass, oneCycle);
                var resultMethodTwo = MethodTwoForCycle(_elephantsMass, oneCycle, _elephantsMass.Min());
                if (resultMethodOne > resultMethodTwo)
                    _finalResult = _finalResult + resultMethodTwo;
                else
                    _finalResult = _finalResult + resultMethodOne;
                _elephantsStartPosition = oneCycle.RemovingItemsFromList(_elephantsStartPosition);
                _elephantsEndPosition = oneCycle.RemovingItemsFromList(_elephantsEndPosition);
            }
            while (_elephantsStartPosition.Any());

            Console.WriteLine(_finalResult);
        }
    }
}
