using System;

namespace NoPowFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Вычислить, не используя функцию pow, значения функции z(x, m) = x^m * (sin(xm))^m, для значений аргументов:
            x от -1.1 до 0.3 с шагом 0.2;
            m от 1 до 5 с шагом 1.
            */
            double x = -1.1;
            double m = 1;
            double result;
           
            do
            {
                do
                {
                    result = 1;
                    for (int i = 1; i <= m; i++)
                        result *= x * Math.Sin(x*m);
                    Console.WriteLine("Значение функции равно "+result+", m = "+m);
                    m++;
                }
                while (m <= 5);
                Console.WriteLine("Вычислено при x = " + Math.Round(x,1));
                m = 1;
                x += 0.2;
            }
            while (x <= 0.3);
        }
    }
}
