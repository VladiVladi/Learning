using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_new
{
    class Calculator
    {
        double summ;
        int temp;

        public Calculator(double summ)
        {
            this.summ = summ;
        }

        public void Cash()
        {
            double[] money = new double[] { 5000, 2000, 1000, 500, 200, 100, 50, 10, 5, 2, 1 };

            for (int i = 0; i < money.Length; i++)
            {
                if (summ >= money[i])
                {
                    temp = (int)(summ / money[i]);
                    summ = summ - (money[i] * temp);
                    Console.WriteLine("Вам будут выданы купюры/монеты номиналом {0} рублей в количестве {1} штук", money[i], temp);
                }
                else if (summ == 0)
                {
                    break;
                }
            }
        }
    }
}


