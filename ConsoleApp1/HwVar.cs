using System;

namespace ConsoleApp4
{
    class HwVar
    {
      



        public static int Task1(int a, int b)
        {                  
            a = (5 * a + b * b) / (b - a);          
            return a;
        }

        public static int[] Task2(int a,  int b)
        {
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

            int[] division = new int[2];
            division[0] = a / b;
            Console.WriteLine("division result = " + division[0]);
            division[1] = a % b;
            Console.WriteLine("remainder of division = " + division[1]);
            return division;
        }

        public static double Task4(int a, int b, int c)
        {            
            double x;           
            x = (c - b) / a;
            Console.WriteLine("X= " + x);
            return x;
        }
     public   static int[] Task5(int x1, int x2,  int y1, int y2)
        {           
            int a;
            int b;
            int[] result = new int[2];
            
            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;
            Console.Write("y=" + a + "x+" + b);
            result[0] = a;
            result[1]= b;
            return result;
        }

    
    
    
    
    
    
    
    
    
    
    
    }
}