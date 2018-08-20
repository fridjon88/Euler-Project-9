using System;

namespace EulerProblem9WTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemService.Problem9Service problem9 = new ProblemService.Problem9Service();

            Console.WriteLine(problem9.FindAnswereForEuler9(1000));
            Console.ReadKey();
        }
    }
}
