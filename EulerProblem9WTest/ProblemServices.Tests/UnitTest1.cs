using System;
using System.Linq;
using Xunit;
using EulerProblem9WTest.ProblemService;

namespace EulerProblems.ProblemServies.Tests
{
    public class ProblemServices_Problem9Services
    {
        private readonly Problem9Service _problem9;

        public ProblemServices_Problem9Services()
        {
            _problem9 = new Problem9Service();
        }

        [Fact]
        public void testFindC()
        {
            int a = 3;
            int b = 4;
            int c = _problem9.FindC(a, b);
            Assert.Equal(25, c);
        }
    }
}
