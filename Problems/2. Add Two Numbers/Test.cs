using Xunit;
using Xunit.Abstractions;

namespace csharp.Problems._2._Add_Two_Numbers
{
    public class AddTwoNumbersTest
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly LinkedListBuilder _builder;

        public AddTwoNumbersTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _builder = new LinkedListBuilder();
        }

        [Theory]
        [InlineData(new []{2,4,3}, new []{5,6,4}, new []{7,0,8})]
        [InlineData(new []{0}, new []{0}, new []{0})]
        [InlineData(new []{9,9,9,9,9,9,9}, new []{9,9,9,9}, new []{8,9,9,9,0,0,0,1})]
        internal void Test(int[] values1, int[] values2, int[] expectedValues)
        {
            // Arrange
            var l1 = _builder.Build(values1);
            var l2 = _builder.Build(values2);
            var expectedResult = _builder.Build(expectedValues);

            // Act
            var result = new AddTwoNumbersSolution().AddTwoNumbers(l1, l2);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}