﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class HwIfElse

    {
        public static int Task1()
        {
            // 1 Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            int a;
            int b;
            int res;
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                res = a + b;
                Console.WriteLine("A>B" + "\n" + "A+B=" + res);
            }
            else if (a < b)
            {
                res = a - b;
                Console.WriteLine("A<B" + "\n" + "A-B=" + res);
            }
            else
            {
                res = a * b;
                Console.WriteLine("A=B" + "\n" + "A*B=" + res);
            }
            return res;
        }


        public static string Task2()
        {

            // 2 Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

            int x;
            int y;
            Console.Write("Enter X ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                    return (" I");
                else
                    return (" IV");
            }
            else if (y > 0)
                return (" II");
            else
                return (" III");

        }

        public static string Task3()
        {
            // 3 Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

            int a;
            int b;
            int c;
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                    return ($"{c} {b} {a}");
                else
                    return ($"{b} {c} {a}");
            }
            else if (b > c && b > a)
            {
                if (c > a)
                    return ($"{a} {c} {b}");
                else
                    return ($"{c} {a} {b}");
            }
            else if (a > b)
                return ($"{b} {a} {c}");
        }



        public static double[] Task4()
        {
            // 4 Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0.

            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;
            double[] result = new double[2];
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                d = b * b - (4 * a * c);
                if (d < 0)
                    Console.WriteLine("no roots");
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"d=0  X={Math.Round(x1, 2)} ");
                }
                else
                {
                    x1 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                    x2 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                    result[0] = Math.Round(x1, 2);
                    result[1] = Math.Round(x2, 2);
                }

            }
            return result;
        }








    }
}
            


    