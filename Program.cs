using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 15. Даны натуральные числа m и n. Получить все натуральные числа, 
    меньшие n, квадрат суммы цифр которых равен m */

namespace Lab_3_2_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 9;
            int n = 123;
            for (int i = 0; i < n; i++)
            {
                char[] digit = Convert.ToString(i).ToCharArray();
                int sum = 0;
                for (int j = 0; j < digit.Length; j++)
                {
                    sum += int.Parse(digit[j].ToString());
                }
                if (sum*sum == m)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
