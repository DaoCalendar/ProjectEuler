using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Collections;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Add all the natural numbers below one thousand that are multiples of 3 or 5.
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. 
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class EulerProblem001 : IEulerProblem
    {
        private Range _range;

        public EulerProblem001(int low, int high)
        {
            _range = new Range(low, high);
        }

        public string Solve()
        {
            return _range.Where(n => (n % 3 == 0) || (n % 5 == 0)).Sum().ToString();
        }
    }
}
