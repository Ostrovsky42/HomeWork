using System;

namespace ConsoleApp1
{
    class HwVar
    {

        public static void Main()
        {
           
        }


        public static int Task1(int a, int b)
        { //1 Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/(B-A)
            if (b - a == 0)
            {
                throw new Exception("Деление на ноль");
            }
                      
            a = (5 * a + b * b) / (b - a);         
            
            return a;
        }

        public static int[] Task2(int a,  int b)
        { // 2 Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
            int[] result = new int[2];
            
            int temporary = a;            
            a = b;
            b = temporary;
            Console.WriteLine("A=" + a + " B=" + b);
            result[0] = a;
            result[1] = b;

            return result;
        }

        public static int[] Task3(int a, int b)
        {
            // 3 Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
            if (b == 0)
            {
                throw new Exception("Деление на ноль");
            }
            int[] division = new int[2];
            division[0] = a / b;
            Console.WriteLine("division result = " + division[0]);
            division[1] = a % b;
            Console.WriteLine("remainder of division = " + division[1]);
            return division;
        }

        public static double Task4(int a, int b, int c)
        {            // 4 Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
            if (a == 0)
            {
                throw new Exception("Деление на ноль");
            }
            double x;           
            x = (c - b) / a;
            Console.WriteLine("X= " + x);
            return x;
        }
     public   static int[] Task5(int x1, int x2,  int y1, int y2)
        {           // 5 Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
            int a;
            int b;
            int[] result = new int[2];
            if (x1 - x2 == 0)
            {
                throw new Exception("Деление на ноль");
            }
            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;
            Console.Write("y=" + a + "x+" + b);
            result[0] = a;
            result[1]= b;
            return result;
        }
        


        }

    
    
    
    
    
    
    
    
    
    
    
    }
