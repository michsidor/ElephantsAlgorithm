using Xunit;

namespace Enrolment.Tests
{
    public class ExtensionMethodsTests
    {
        [Fact]
        public void ReturningOneCycle_WhenDictionaryIsCalledByExtensionMethod_ExtensionMethodShouldReturnOneCycle()
        {
            //arrange
            Dictionary<int, int> dictionaryElephants = new Dictionary<int, int>()
            {
                {3,4},
                {10,9},
                {1,5},
                {8,3},
                {9,1},
                {4,6},
                {2,10},
                {7,7},
                {6,8},
                {5,2},
            };
            List<int> cycle = new List<int>() { 6, 8, 3, 4 }; // oczekiwana odpowiedz

            // act
            var result = dictionaryElephants.ReturningOneCycle();
            cycle.Sort();
            result.Sort();

            //assert
            Assert.Equal(cycle, result);
        }

        [Fact]
        public void RemovingItemsFromList_WhenWeCallExtensionMethod_ExtensionMethodShouldReturnDictionaryWithoutElementsFromPrimaryDictionary()
        {
            //arrange
            Dictionary<int, int> dictionaryPrimary = new Dictionary<int, int>()
            {
                { 9,1},
                { 4,6},
                { 2,10},
                { 7,7},
                { 6,8},
                { 5,2},
            };

            Dictionary<int, int> dictionaryAllElements = new Dictionary<int, int>()
            {
                { 3,4},
                { 10,9},
                { 1,5},
                { 8,3},
                { 9,1},
                { 4,6},
                { 2,10},
                { 7,7},
                { 6,8},
                { 5,2},
            };

            Dictionary<int, int> dictionaryReturn = new Dictionary<int, int>()
            {
                { 3,4},
                { 10,9},
                { 1,5},
                { 8,3},
            };

            // act
            var result = dictionaryPrimary.RemovingItemsFromList(dictionaryAllElements);

            // assert
            Assert.Equal(result, dictionaryReturn);
        }

        [Fact]
        public void AddingMassOfDirectElephant_WhenExtensionMethodIsCalled_ShouldReturnDictionaryWithElephantsWithTheirMass()
        {
            //arrange
            List<int> mass = new List<int>() { 10, 20, 30, 40, 50 };
            List<int> elephants = new List<int>() { 1,4,5 };
            Dictionary<int, int> dictionaryReturn = new Dictionary<int, int>()
            {
                {1,10 },
                {4,40 },
                {5,50 }
            };

            //act
            var result = elephants.AddingMassOfDirectElephant(mass);

            //assert
            Assert.Equal(dictionaryReturn, result);

        }



    }
}