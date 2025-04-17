using TestCalc;

namespace TestCalcTests
{
    public class CalculatorTest
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(2, 8) == 10);
        }

        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(10, 2) == 8);
        }

        public void MiltiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(2, 8) == 16);
        }

        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(8, 2) == 4);

            Assert.Throws<DivideByZeroException>(() => calc.Division(30, 0));
        }
    }
}