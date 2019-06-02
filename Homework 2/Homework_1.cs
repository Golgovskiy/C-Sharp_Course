using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Homework_1
    {
        static void Main(string[] args)
        {
            // 1.Обьявить переменные всех примитивных типов значений.
            sbyte a = 1;
            byte b = 1;
            short c = 1;
            ushort d = 1;
            int e = 1;
            uint f = 1;
            long g = 1;
            ulong q = 1;
            float w = 1.0f;
            double r = 1.0;
            decimal t = 1.1M;
            bool y = true;
            char z = 'e';
            //2.Операции над ними.
            e = a = 3;
            e = b * 2;
            e = c + 8;
            e = d - 5;
            r = w / 5;
            c++;
            d--;
            y = a < f;
            y = a > f;
            y = a == 2;
            y = a <= 5;
            y = a >= 7;
            r = r % 5.3;

            e = e * 45573456; //Переполнение.
        }
    }
}
