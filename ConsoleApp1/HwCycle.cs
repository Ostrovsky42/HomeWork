using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class HwCycle
    {


        public static string Task1()
        {
            //1 Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            int a;
            int aDef;
            int b;
            int i;
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            aDef = a;
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < b; i++)
            {
                a = a * aDef;
            }
            string result = ($"{aDef}^{b}= {a}");
            return result;
        }

        public static int[] Task2() {

            // 2 Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            int a;
            int i;
            int div;
            int[] result = new int[1000];
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"divisible by {a}: ");
            for (i = 1; i <= 1000; i++)
            {
                div = i % a;
                if (i != 0 && div == 0)
                {
                    result[i] = i;
                }
            }
            return result;
        }

        public static int Task3() {

            // 3 Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, квадрат которых меньше A.

            int a;

            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; (i * i) < a; i++) { }
            return a;
        }

        public static int Task4() {
            // 4 Пользователь вводит 1 число(A).Вывести наибольший делитель(кроме самого A) числа A.

            int a;
            int test;
            int div = 0;
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < a; i++)
            {
                test = a % i;
                if (test == 0)
                    div = i;
            }
            return div;
        }

        public static int Task5() {
            // 5 Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).


            int a;
            int b;
            int sum = 0;
            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                for (; a < b; a++)
                {
                    if ((a % 7) == 0)
                        sum = sum + a;
                }
            }
            else
            {
                for (; a > b; a--)
                {
                    if ((a % 7) == 0)
                        sum = sum + a;
                }
            }
            return sum;
        }

        public static int Task6() {

            // 6 Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.


            int n;
            double fib = 0;
            Console.Write("Enter A ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                fib = (Math.Pow(((1 + Math.Sqrt(5)) / 2), i)) / Math.Sqrt(5);
                fib = Math.Round(fib, MidpointRounding.ToEven);
            }
            return (int)fib;


        }




        public static int Task7() {

            // 7  Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.


            int a;
            int b;

            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            a += b;
            return a;
        }

        public static int Task8() {

            // 8 Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
            int x;

            Console.Write("Enter x ");
            x = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = x;
            int midle = x / 2;
            while (x != midle * midle * midle)
            {
                if (x < midle * midle * midle)
                    right = midle;
                else left = midle;
                midle = (left + right) / 2;
            }
            return midle; }




        public static int Task9() {


            // 9 Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
              int n;
            string numStr = "";
            int num;
            int i = 0;
            Console.Write("Enter N ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                numStr = numStr + (n % 10);
                num = Convert.ToInt32(numStr);
                if (num % 2 != 0)
                {
                    i++;
                }
                n = n / 10;
            }
            return i;
        }

        public static int Task10() {
            // 10 Пользователь вводит 1 число.Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

            int n;
            int numInt;
            string numStr = "";
            Console.Write("Enter N ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                numStr = numStr + (n % 10);
                n = n / 10;
            }
            numInt = Convert.ToInt32(numStr);
            return numInt;
        }



        public static int Task11() {
            //11Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 


             int n;
            int k = 0;
            int odd = 0;
            int even = 0;
            Console.Write("Enter N ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {

                int j = i;
                while (j > 0)
                {
                    k = j % 10;
                    if (k % 2 != 0)
                        odd = odd + k;
                    else
                        even = even + k;

                    j = j / 10;

                }
                if (even > odd)
                    Console.WriteLine(i);
                odd = 0;
                even = 0;
            }
        }

        public static string Task12()
        {

            //12 Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

            int a;
            int b;
            int aNum;
            int bNum;
            int boole = 0;

            Console.Write("Enter A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B ");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                aNum = a % 10;
                while (b > 0)
                {
                    bNum = b % 10;
                    if (aNum == bNum)
                    {
                        boole = 1;
                    }
                    b = b / 10;
                }
                a = a / a;
            }
            if (boole == 0)
                return"НЕТ";
            else
                return"ДА";
        }

        }
    }






