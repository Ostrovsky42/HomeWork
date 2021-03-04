using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HwArray1
    {


     public static int[] CreateRandomArray()
        {
            int[] array = new int[2];
            Random random = new Random();

             for (int i=0; i<array.Length; i++)
             {
                 array[i] = random.Next(100);
                 Console.WriteLine(array);

             }
            Console.WriteLine(array);
            return array;


            int[] array1 = new int[42];
            Random rand = new Random();
            for (int i = 0; i < array1.Length; i++)
                array1[i] = rand.Next();

            return array;


        }

        //int lenght;
        // int[] array = new int [lenght];
        








            /* Console.WriteLine("2 Найти максимальный элемент массива");
            Console.WriteLine("3 Найти индекс минимального элемента массива");
            Console.WriteLine("4 Найти индекс максимального элемента массива");
            Console.WriteLine("5 Посчитать сумму элементов массива с нечетными индексами");
            Console.WriteLine("6 Сделать реверс массива(массив в обратном направлении)");
            Console.WriteLine("7 Посчитать количество нечетных элементов массива");
            Console.WriteLine("8 Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.");
            Console.WriteLine("9 Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) ");
            Console.WriteLine("10 Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))");*/












            //Console.WriteLine("");
        }





  /*      static void Task1()
        {
            Console.WriteLine("1 Найти минимальный элемент массива");
            int lenght = 2;
            int[] array = new int[lenght];
            CreateRandomArray();
            Console.WriteLine(array);

    */




        }
    

