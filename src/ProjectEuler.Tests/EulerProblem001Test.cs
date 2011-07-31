using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    public class EulerProblem001Test
    {
        [Fact]
        public void When_we_list_all_the_natural_numbers_below_10_that_are_multiples_of_3_or_5_the_sum_must_be_23()
        {
            string expected = "23";
            IEulerProblem problem = new EulerProblem001(1, 10);
            string result = problem.Solve();            
            Assert.Same(expected, result);
        }

        [Fact]
        public void When_we_list_all_the_natural_numbers_below_1000_that_are_multiples_of_3_or_5_the_sum_must_be_233168()
        {
            string expected = "233168";
            IEulerProblem problem = new EulerProblem001(1, 1000);
            string result = problem.Solve();
            Assert.Same(expected, result);
        }
    }
}
