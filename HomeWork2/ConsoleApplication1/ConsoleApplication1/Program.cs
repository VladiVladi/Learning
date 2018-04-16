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
            Console.Title = "HomeWork2";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================================================");
            Console.ResetColor();

            Console.WriteLine("\tПривет, я долларовый калькулятор!");
            Console.Write("\tНа сегодня курс доллара");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 56.9 руб.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================================================");
            Console.ResetColor();


            Console.ReadKey();
        }
    }
}
