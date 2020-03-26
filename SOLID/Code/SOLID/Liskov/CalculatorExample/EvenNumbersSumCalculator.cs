using System.Linq;

namespace SOLID.Liskov.CalculatorExample
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers) { }

        public override int Calcutate() => _numbers.Where(x => x % 2 == 0).Sum();
        
    }
}
