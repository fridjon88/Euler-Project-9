using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProblem9WTest.ProblemService
{
    public class Problem9Service
    {

        public int FindAnswereForEuler9(int expectedSumOfTriplets)
        {
            for (int a = 1; a <= expectedSumOfTriplets / 3; a++)
            {
                for (int b = a+1; b <= expectedSumOfTriplets / 2; b++)
                {
                    double cDouble = FindC(a, b);
                    if (cDouble % 1.0 != 0.0)
                    {
                        continue;
                    }
                    int c = Convert.ToInt32(cDouble);

                    int tripletSum = TripletSum(a, b, c);
                    if (tripletSum == expectedSumOfTriplets)
                    {
                        return ProductOfTriplet(a, b, c);
                    }
                    else if (tripletSum > expectedSumOfTriplets)
                    {
                        break;
                    }
                }
            }
            throw new NotImplementedException();
        }

         private double FindC(int a, int b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        private int TripletSum(int a, int b, int c)
        {
            return a + b + c;
        }

        private int ProductOfTriplet(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
