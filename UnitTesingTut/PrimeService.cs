using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesingTut
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            if(num < 2) return false;

            for(var divisor=2;divisor<=Math.Sqrt(num); divisor++)
            {
                if(num % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
