using System;

namespace Homework_3
{
    public class Test
    {
        public static bool operator >(Test A, Test B)
        {
            return A.Test_1 > B.Test_1;
        }
        public static bool operator <(Test A, Test B)
        {
            return A.Test_1 < B.Test_1;
        }

        public Test()
        {
            _test_1 = 13;
        }

        public Test(int A)
        {
            _test_1 = A;
        }

        int _test_1;
        public int Test_1
        {
            get { return _test_1; }
            set
            {
                    if (value >= 0)
                    {
                    _test_1 = value;
                    }
                    else
                    {
                        _test_1 = 0;
                    }
            } 
        }
        
        virtual public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
    }

    public class Test1 : Test
    {

        int[] arr = new int[10];
        public Test1()
        { for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i*12;
            }
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        override public void SayHi()
        {
            Console.WriteLine("Hello!");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test A = new Test();

            A.Test_1 = 9;                   //get;set;
            Console.WriteLine(A.Test_1);
            A.Test_1 = -4;
            Console.WriteLine(A.Test_1);

            Test B = new Test(19);          //method overload
            Console.WriteLine(B.Test_1);

            B.SayHi();                      //virtual, override

            Test1 C = new Test1();
            C.SayHi();

            Console.WriteLine(C[6]);        //indexer

            Console.WriteLine(A > B);       //compairing classes
            
            Console.ReadKey();
        }
    }
}
