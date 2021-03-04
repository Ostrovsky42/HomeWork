using System;

namespace ConsoleApp4
{
    class HwVar
    {
        static void Main(string[] args)
        {

            // Задача 1
                       

            // Задача 2
           

            //Задача 3
            


            //Задача 4
         


            //Задача 5
           
        }



        public static int Task1()
        {
            int a;
            int b;
            Console.Write("№1" + "\n" + "Enter number A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B ");
            b = Convert.ToInt32(Console.ReadLine());
            a = (5 * a + b * b) / (b - a);
            Console.WriteLine("(5 * A + B * B) / (B - A)=" + a);
            return a;
        }

        public static int[] Task2()
        {
            int[] result = new int[2];
            int a;
            int b;
            int temporary;
        Console.Write("№2" + "\n" + "Enter number A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B ");
            b = Convert.ToInt32(Console.ReadLine());

            temporary = a;
            a = b;
            b = temporary;
            Console.WriteLine("A=" + a + " B=" + b);
            result[0] = a;
            result[1] = b;

            return result;
        }

        public static int Task3()
        {
            int a;
            int b;
            int divisionResult;
            int remainderOfDivision;
            Console.Write("№3" + "\n" + "Enter number A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B ");
            b = Convert.ToInt32(Console.ReadLine());
            divisionResult = a / b;
            Console.WriteLine("division result = " + divisionResult);
            remainderOfDivision = a % b;
            Console.WriteLine("remainder of division = " + remainderOfDivision);
            return remainderOfDivision;
        }

        public static double Task4()
        {
            double a;
            double b;
            double c;
            double x;
            Console.Write("№4" + "\n" + "Enter number A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number C ");
            c = Convert.ToInt32(Console.ReadLine());
            x = (c - b) / a;
            Console.WriteLine("X= " + x);
            return x;
        }
     public   static int[] Task5()
        {
            int x1;
            int x2;
            int y1;
            int y2;
            int a;
            int b;
            int[] result = new int[2];
            Console.Write("№5" + "\n" + "Enter x1 ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 ");
            y2 = Convert.ToInt32(Console.ReadLine());
            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;
            Console.Write("y=" + a + "x+" + b);
            result[0] = a;
            result[1]= b;
            return result;
        }

    
    
    
    
    
    
    
    
    
    
    
    }
}