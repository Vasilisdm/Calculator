using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    public class Tests
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            // Arrange 
            ConsoleCalculator calculator = new ConsoleCalculator();

            // Act - Assert
            Assert.That(() => calculator.Calculate(1, 2, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>());
        }
    }
}