using FluentAssertions;

namespace SampleCoverageProject
{
    public class MathClassTest
    {
        [Fact]
        public void SumTest()
        {
            var sut = new MathClass();

            // Act
            var result = sut.Sum(1, 1);

            // Assert
            result.Should().Be(2);
        }
    }
}