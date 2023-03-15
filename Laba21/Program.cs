using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Б");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действие, которое хотите сделать:");
            Console.WriteLine("|1: + | |2: - | |3: * | |4: / |");
            while (!false)
            {
                double sum = 0;
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        sum = A + B;
                        Console.WriteLine(A + " + " + B + " = " + sum);
                        break;
                    case 2:
                        sum = A - B;
                        Console.WriteLine(A + " - " + B + " = " + sum);
                        break;
                    case 3:
                        sum = A * B;
                        Console.WriteLine(A + " * " + B + " = " + sum);
                        break;
                    case 4:
                        sum = A / B;
                        Console.WriteLine(A + " / " + B + " = " + sum);
                        break;
                }

            }
            Console.WriteLine("Это Дмитрий Новик Т-096");
        }
    }
}
