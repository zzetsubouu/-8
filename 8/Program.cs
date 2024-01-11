using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompPract8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание #1
            //Console.Write("Введите название города: ");
            //string city = Console.ReadLine();
            //if (city.Length % 2 == 0)
            //{
            //    Console.WriteLine("Четно");
            //}
            //else
            //{
            //    Console.WriteLine("Нечетно");
            //}

            // Задание #2
            //Console.Write("Введите первую фамилию: ");
            //string surname1 = Console.ReadLine();
            //Console.Write("Введите вторую фамилию: ");
            //string surname2 = Console.ReadLine();
            //if (surname1.Length > surname2.Length)
            //{
            //    Console.WriteLine($"{surname1} - длиннее");
            //}
            //else
            //{
            //    Console.WriteLine($"{surname2} - длиннее");
            //}    

            // Задание #3 - Определить, является или нет текущий год високосным? Год ввести с клавиатуры.
            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());
            //if (year%4 == 0)
            //{
            //    Console.WriteLine("Год является високосным.");
            //}
            //else
            //{
            //    Console.WriteLine("Год не является високосным.");
            //}

            // Задание №4 - Определить, входит и цена выбранного ноутбука в диапазон от 20 до 30 тыс. р
            //Console.Write("Введите цену вашего ноутбука: ");
            //int price = int.Parse(Console.ReadLine());
            //if (price > 20000 && price < 30000)
            //{
            //    Console.WriteLine("Ваш ноутбук входит в диапазон.");
            //}
            //else
            //{
            //    Console.WriteLine("Ваш ноутбук не входит в диапазон.");
            //}

            // Задание №5
            //Console.Write("X = ");
            //int x = int.Parse(Console.ReadLine());
            //double y = 0;
            //if (x>=0)
            //{
            //    y = 2 * x + Math.Sqrt(x);
            //}
            //else
            //{
            //    y = Math.Abs(x) + Math.Pow(x, 2);
            //}
            //Console.WriteLine($"Результат: {y}");
            //2-ой способ тернарной операцией.
            //y = x < 0 ? Math.Abs(x) + Math.Pow(x, 2) : 2 * x + Math.Sqrt(x);
            //Console.Write($"{y}");

            // Задание #6
            //Console.Write("X = ");
            //double x = double.Parse(Console.ReadLine());
            //double y = 0;
            //if (x <= -5)
            //{
            //    y = Math.Sqrt(13 - x);
            //}
            //if (x>-5&&x<5)
            //{
            //    y = Math.Abs(4 * x - 5);
            //}
            //if (x>=5)
            //{
            //    y = Math.Pow(3*x, 2)-5*x;
            //}
            //Console.Write($"{y}");
            Console.Read();

        }
    }
}