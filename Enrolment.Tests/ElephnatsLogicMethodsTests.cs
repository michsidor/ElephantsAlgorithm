using Xunit;

namespace Enrolment
{
    public class ElephnatsLogicMethodsTests
    {
        [Fact]
        public void ReturningSumOffMas_WhenMethodOneIsCould_ShouldReturnMassOfElephantsInCycle()
        {
            //arrange
            Dictionary<int, int> ElephantsAndMass = new Dictionary<int, int>()
            {
                {1,10 },
                {4,40 },
                {5,50 }
            };
            List<int> list = new List<int>();
            //act
            ElephantsOrder elephantsOrder = new ElephantsOrder(1, list, ElephantsAndMass);
            var result = elephantsOrder.MethodOneForCycle(ElephantsAndMass);
            //asert
            Assert.Equal(110, result);
        }

        [Fact]
        public void ReturningSumOffMas_WhenMethodTwoIsCould_ShouldReturnMassOfElephantsInCycle()
        {
            //arrange
            Dictionary<int, int> ElephantsAndMass = new Dictionary<int, int>()
            {
                {1,10 },
                {4,40 },
                {5,50 }
            };
            List<int> list = new List<int>();
            int lightestElephant = 10;
            //act
            ElephantsOrder elephantsOrder = new ElephantsOrder(1, list, ElephantsAndMass);
            var result = elephantsOrder.MethodTwoForCycle(ElephantsAndMass, lightestElephant);
            //asert
            Assert.Equal(150, result);
        }

    }
}
