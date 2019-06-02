using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, h;
            Console.WriteLine("Please enter A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter H:");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:");
            if (a < b)
              {
                  for (int i = a; i <= b; i += h)
                  {
                    try
                    {
                        double x = Math.Log((Math.Sqrt(2 - i) + 1.2) / (2 + i) + Math.Pow((2 / i), (1 / 3)));
                        Console.WriteLine(i + ". " + "X =" + x);
                    }
                    catch
                    {
                        Console.WriteLine("Impossible to compute");
                    }
                  }
                  Console.ReadKey();
              }
              else
              {
                  Console.WriteLine("B < A");
              }
              
        }
    }
}
