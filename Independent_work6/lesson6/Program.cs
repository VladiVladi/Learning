using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            int resualt = 0;

            for (++x; x < y; x++)
            {
                resualt += x;
            }

            Console.WriteLine("Сумма чисел равна {0}", resualt);
            Console.ReadKey();
        }
    }
}
