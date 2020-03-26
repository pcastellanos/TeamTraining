using System.Linq;

namespace SOLID.Liskov.CalculatorExample
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers) { }

        public override int Calcutate() => _numbers.Sum();
    }
}
