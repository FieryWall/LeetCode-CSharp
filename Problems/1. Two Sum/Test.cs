using Xunit;

namespace csharp.Problems._1._Two_Sum
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new []{2,7,11,15}, 9, new []{0, 1})]
        [InlineData(new []{3, 2, 4}, 6, new []{1, 2})]
        [InlineData(new []{3, 3}, 6, new []{0, 1})]
        public void Test(int[] nums, int target, int[] expectedResult)
        {
            // Act
            var result = new TwoSumSolution().TwoSum(nums, target);
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}