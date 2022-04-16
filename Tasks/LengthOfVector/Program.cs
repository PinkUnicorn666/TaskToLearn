using System;

namespace LengthOfVector
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишите программу, которая позволяет пользователю ввести в консоль 
            три координаты вектора x, y, и z, с основанием у начала координат. 
            Вычислите длину этого вектора и выведите её обратно в консоль. 
            */
            Console.Write($"Введите координаты вектора с основанием у начала координат. \nВведите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double VectorLength = Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2) + Math.Pow(z,2));
            Console.WriteLine("Длина вектора равна "+ VectorLength);

        }
    }
}
