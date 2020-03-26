﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.NoLiskov
{
    public class EvenNumbersSumCalculatorNoLiskov: SumCalculatorNoLiskov
    {
        public EvenNumbersSumCalculatorNoLiskov(int[] numbers) :base(numbers) { }

        public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
