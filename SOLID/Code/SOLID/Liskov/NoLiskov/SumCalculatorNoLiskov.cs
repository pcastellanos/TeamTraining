using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.NoLiskov
{
    public class SumCalculatorNoLiskov
    {
        protected readonly int[] _numbers;

        public SumCalculatorNoLiskov(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }
}
