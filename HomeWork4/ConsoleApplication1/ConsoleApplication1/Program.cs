using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HomeWork4";

            decimal a = 56.9M, b = 0;

            Console.WriteLine("Введите количество долларов");
            string c = Console.ReadLine();
            decimal d = Convert.ToDecimal(c);

            if (d < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число, пожалуйста, введите заново");
            }
            else
            {
                Console.WriteLine("За {0} долларов Вы получите {1} рублей", d, b = (a * d));
            }

            Console.ReadKey();
        }
    }
}
