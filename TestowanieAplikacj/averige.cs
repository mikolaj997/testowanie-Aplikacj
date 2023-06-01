using System;
namespace TestowanieAplikacj
{
    public class averige
    {
        public double averigeScore(double num1, double num2, double num3, double num4)
        {
            double result = (num1 + num2+ num3+ num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            num1, num2, num3, num4, result);
            return result;
            
        }
    }
}

