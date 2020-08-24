using System;
using System.Threading.Tasks;
using System.Dynamic;

namespace HelloWorld
{
    namespace Tools
    {
        public class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Sub(double a, double b)
            {
                return (a - b) - 10;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[2];
            a[1] = new int[4];
            a[2] = new int[3];
            Console.WriteLine(a[0][1]);
            Console.WriteLine(a);
            double result = Tools.Calculator.Sub(1111111111.1111111, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }


}
