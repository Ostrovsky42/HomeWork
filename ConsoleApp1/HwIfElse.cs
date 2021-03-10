using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class HwIfElse

    {
        

        public static int Task1(int a, int b)
        {
            // 1 Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

            int res;
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


        public static string Task2(int x, int y)
        {
            // 2 Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            if (x == 0 || y == 0)
            {
                throw new Exception("Точка лежит в начале коорднат");
            }
            if(x == 0 && y == 0)
            {
                throw new Exception("Точка лежит на оси коорднат");
            }

            if (x > 0)
            {
                if (y > 0)
                    return ("I");
                else
                    return ("IV");
            }
            else if (y > 0)
                return ("II");
            else
                return ("III");

        }

        public static string Task3(int a, int b, int c)
        {
            // 3 Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

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
            else
                return ($"{a} {b} {c}");
        }



        public static double[] Task4(double a, double b, double c)
        {
            // 4 Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0.

            double d;
            double x1;
            double x2;
            int i = 1;
            double[] result=new double[i]; 

            if (a == 0)
            {
                throw new Exception("Нет корней, на ноль делить нельзя");
            }

            if (a != 0)
            {
                d = b * b - (4 * a * c);
                if (d < 0)
                {
                    throw new Exception("Нет корней");
                }                  
                else if (d == 0)
                {
                    
                    x1 = -b / (2 * a);
                    result[0] = Math.Round(x1, 2);
                   
                }
                else
                {
                    i++;
                    result = new double[i];
                    x1 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                    x2 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                    result[0] = Math.Round(x1, 2);
                    result[1] = Math.Round(x2, 2);
                }

            }
            return result;
        }



        public static string Task5(int num)

        {     //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

            string answer;
            string[] stringToTen = new string[10] { "", " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" };
            string[] stringAfterTen = new string[10] { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] stringTenToTwenty = new string[10] { "", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестьнадцать", "семьнадцать", "восемнадцать", "девятнадцать" };

            if (num / 10 == 1 && num < 20)
            {
                switch (num % 10)
                {
                    case 0:
                        return stringTenToTwenty[0];
                    case 1:
                        return stringTenToTwenty[1];
                    case 2:
                        return stringTenToTwenty[2];
                    case 3:
                        return stringTenToTwenty[3];
                    case 4:
                        return stringTenToTwenty[4];
                    case 5:
                        return stringTenToTwenty[5];
                    case 6:
                        return stringTenToTwenty[6];
                    case 7:
                        return stringTenToTwenty[7];
                    case 8:
                        return stringTenToTwenty[8];
                    case 9:
                        return stringTenToTwenty[9];
                        //нечестно вышло
                }
            }
            answer = stringAfterTen[num / 10] + stringToTen[num % 10];
            return answer;

        }





    }



}
    
