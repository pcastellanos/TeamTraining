using SOLID.Liskov.CalculatorExample;
using SOLID.Liskov.NoLiskov;
using System;

namespace SOLID.Liskov
{
    public class LiskovTest
    {

        public void NoLiskovTest()
        {
            var numbers = new int[] { 2, 6, 8, 1, 5, 6, 4, 7 };

            SumCalculatorNoLiskov sumCalculatorNoLiskov = new SumCalculatorNoLiskov(numbers);
            Console.WriteLine($"The sum of all the numbers: {sumCalculatorNoLiskov.Calculate()}");

            Console.WriteLine();

            EvenNumbersSumCalculatorNoLiskov evenNumbersSumCalculatorNoL = new EvenNumbersSumCalculatorNoLiskov(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenNumbersSumCalculatorNoL.Calculate()}");

        }


        public void LiskovTestCalc()
        {
            var numbers = new int[] { 2, 6, 8, 1, 5, 6, 4, 7 };

            //SumCalculator sum = new SumCalculator(numbers);
            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calcutate()}");

            Console.WriteLine();

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calcutate()}");
        }

    }
}
