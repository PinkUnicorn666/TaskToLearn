using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
         * Суть задачи: по введенному номеру дня недели вывести его название, 
         * используя оператор множественного выбора.Нумерация дней недели 
         * начинается с 1 – понедельник, 2 — вторник и т.д.
         */
        Agn:
            Console.WriteLine($"1. Понедельник \n2. Вторник \n3. Средa \n4. Четверг  \n5. Пятница \n6. Суббота \n7. Воскресенье \n \nВведите номер дня недели: ");

            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Средa");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    {
                        Console.WriteLine("Вы ввели неправильное числo.");
                        break;
                    }
            }
            Console.WriteLine($"\nХотите попробовать еще раз? \n1. Да\n2. Выйти");
            int again = Convert.ToInt32(Console.ReadLine());
            if (again == 1)
                goto Agn;
        }
    }
}
