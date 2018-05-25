using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HomeWork6";

        Label1:
            Console.WriteLine("Введите количество долларов:");
            double dollars = Convert.ToDouble(Console.ReadLine());
            int summ;

            if (dollars <= 0)
            {
                Console.WriteLine("Не корректно введенное число. \nПожалуйста, повторите ввод!");
                goto Label1;
            }

            else
            {
                summ = (int)(56.9 * dollars);
                Console.WriteLine("Сумма для выдачи: {0} рублей", summ);
            }

            Calculator instance = new Calculator(summ);
            instance.Cash();

            Console.ReadKey();
        }
    }
}
