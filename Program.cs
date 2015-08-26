using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int MyART(int a, int b)
        {
            return a*b/2;
        }

        static void Main(string[] args)
        {

            try
            {
                int a, b;

                Console.WriteLine("Введите значение первого катета треугольника");
                string input = Console.ReadLine();
                a = Convert.ToInt32(input);

                Console.WriteLine("Введите значение второго катета треугольника");
                input = Console.ReadLine();
                b = Convert.ToInt32(input);

                a = MyART(a, b);

                Console.Write("Площадь треугольника с указанными сторонами: " + a.ToString());
                Console.ReadKey();
            }

            // Обрабатываем исключение при неккоректном вводе числа в консоль
            catch (FormatException)
            {
                Console.WriteLine("Ввелите число.");
                Console.ReadKey();
            }

        }
    }
}
