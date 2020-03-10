using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesingTut
{
    public class CalculatorService
    {
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Devide(decimal x, decimal y)
        {
            return x / y;
        }
    }
}
