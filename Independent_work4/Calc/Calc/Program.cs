using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 5, operand2 = 3;

            Console.WriteLine("Даны числа 5 и 3. Выберите знак арифметической операции: +, -, *, / ");

            String sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0}+{1}={2}", operand1, operand2, operand1+operand2);
                    break;

                case "-":
                    Console.WriteLine("{0}-{1}={2}", operand1, operand2, operand1-operand2);
                    break;

                case "*":
                    Console.WriteLine("{0}*{1}={2}", operand1, operand2, operand1*operand2);
                    break;

                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("{0}/{1}={2}", operand1, operand2, operand1/operand2);
                        Console.WriteLine("остаток от деления {0}%{1}={2}", operand1, operand2, operand1%operand2);
                    }
                                        
                    else 
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    break;

                default:
                    Console.WriteLine("Вы не ввели знак арифметической операции !");
                    break; 
            }

             Console.ReadKey();
             
        }

    }
}
