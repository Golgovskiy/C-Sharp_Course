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
            double a, b, h;
            int counter = 0;
            while (true)
                {
                while (true) //check
                {
                    try
                    {
                        Console.WriteLine("Please enter A:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter B:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter H:");
                        h = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch     //so warning
                    {
                        Console.WriteLine("Wrong data type!");
                    }
                }
                Console.WriteLine("Result:");
                // time start
                var sw = System.Diagnostics.Stopwatch.StartNew();
                //math
                if (a < b && h > 0)              //check A < B
                {
                    for (double i = a; i <= b; i += h)
                    {
                        counter++;
                        if ((i <= 2) && (i != -2) && (i != 0))  //check
                        {
                            double x = Math.Sqrt(2 - i) + 1.2;
                            x = x / (2 + i);
                            x = x + Math.Pow((2 / i), (1 / 3));
                            if (x > 0)
                            {
                                x = Math.Log(x);
                                Console.WriteLine(counter + ". " + "X = " + i + ", " + "Y = " + x);
                            }
                            else
                            {
                                Console.WriteLine(counter + ". " + "X = " + i + ", " + "Y = Error");
                            }

                        }
                        else        //so warning
                        {
                            Console.WriteLine(counter + ". " + "X = " + i + ", " + "Y = Error");
                        }
                    }
                }
                else                    //so warning
                {
                    Console.WriteLine("Wrong input");
                }
                sw.Stop();
                Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds); //time output
                Console.WriteLine("-------------");
            }
        }
    }
}