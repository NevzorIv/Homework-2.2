using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №2.");
            Console.WriteLine();
            double itog;
            itog = GetNum();
            GetAnswer(itog);
            Console.ReadKey();
        }
        static double GetNum()
        {
            double y = 0;
            while ((y % 11 != 0) || (y % 11 == 0 && y == 0))
            {
                Console.WriteLine($"Начальное значение y = {y}");
                Console.Write("1. Добавить 2 к результату\n" +
                "2. Вычесть 3 из результата\n" +
                "3. Удвоить результат\n" +
                "4. Разделить результат на 5\n" +
                "5. Вычесть результат из 100\n" +
                "6. Вывести результат и выйти из программы\n" +
                "Введите номер необходимой операции: ");
                double.TryParse(Console.ReadLine(), out double numOperation);
                Console.WriteLine("");
                if (numOperation == 1)
                    y += 2;
                if (numOperation == 2)
                    y -= 3;
                if (numOperation == 3)
                    y *= 2;
                if (numOperation == 4)
                    y /= 5;
                if (numOperation == 5)
                    y = 100 - y;
                if (numOperation == 6)
                    return y;
                if (numOperation < 1 || numOperation > 6)
                {
                    Console.WriteLine("!!! Введен не верный номер операции !!!");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("!!! Значение (y) кратно 11 !!!");
            y = 0;
            return y;
        }
        static void GetAnswer(double itog)
        {
            Console.WriteLine($"Итоговое значение y = {itog}");
        }
    }
}
