using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab8
{
    internal class Function
    {
        public static string function(double a, double b, double otv,int i)
        {
            double s1 = Math.Log(b, 5);
            double s2 = Math.Sqrt(Math.Cos(2 * a));
            double result = Math.Pow(Math.Sin(s1 / s2), 2);
            string read = "";
            if (otv == Math.Round(result))
            {
                read = "Ответ верный.";
            }
            else if (i == 2)
            {
                read = "Ответ неверный.\n  Вы израсходовали все попытки!\n Ответ: " + Math.Round(result);

            }
            else
            {
                read = "Ответ неверный.";
            }
            return read;
        }

    }
}
