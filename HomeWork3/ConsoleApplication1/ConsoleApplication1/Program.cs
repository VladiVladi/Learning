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
            double a = 56.9, b = 0;
             
            Console.WriteLine("Введите количество долларов");
            string c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            Console.WriteLine("{0} долларов равно {1} рублей", d, b = a * d);

            Console.ReadKey();
        }
    }
}
