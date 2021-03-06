﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task01_c
{
    class Program
    {
        /*Ввести значение х и вывести значение полинамо F=12x^4+9x^3-3x^2+2x-4*/
        // добавим метод который выводит значение полинома
        static double Method(double x)
        {
            // минимальное кол-во операций умножения - 4
            double r = (x * (x * (x * (12 * x + 9) - 3) + 2) - 4);
            return r;
        }
        static void Main(string[] args)
        {
            try
            {
                double a;
                string str, rep;
                // можно использовать if{}...else{}
                
                    do
                    {
                        Console.WriteLine("Введите значение x: ");
                        str = Console.ReadLine();
                    } while (!double.TryParse(str, out a));

                    // выводим а, вызываем метод
                    Console.WriteLine($"Ответ: {Method(a)}");

                    
                    rep = Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}