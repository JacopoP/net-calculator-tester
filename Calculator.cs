using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float a, float b) {  return a + b; }
        public static float Subtract(float a, float b) { return a - b; }
        public static float Multiply(float a, float b) { return a * b; }
        public static float Divide(float a, float b) 
        {
            if (b == 0)
                return float.NaN;
            return a / b; 
        }
        public static double Exponential(int a, int b)
        {
            double result = 1;
            if (b == 0)
                return 1;
            if (a == 0)
                return 0;
            if (b > 0)
            {
                for(int i = 0; i < b; i++)
                    result *= a;
                return result;
            }
            for (int i = 0; i < -b; i++)
                result /= a;
            return result;
        }
    }
}
