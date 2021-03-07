using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public static class HwArray2
    {
        

       
       
        public static int[,] Task1(int[,] array)
        {//1 Найти минимальный элемент массива
          
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                }
            }

            return array;
        }

        public static int[,] Task2(int[,] array)
        {

            // 2 Найти максимальный элемент массива
            
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
            }
            return array;

        }

        public static int[,] Task3(int[,] array)
        {
            // 3 Найти индекс минимального элемента массива
          
            int min = array[0, 0];
            int[] indexMin=new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                    indexMin[0] = i;
                    indexMin[1] = j;
                }

            }
            return array;
        }
        public static int[,] Task4(int[,] array)
        {
            // 4 Найти индекс максимального элемента массива
            
            int max = array[0, 0];
            int[] indexMax = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                    indexMax[0] = i;
                    indexMax[1] = j;
                }

            }
            return array;
        }

        public static int  Task5(int[,] array)
        { // 5 Найти количество элементов массива, которые больше всех своих соседей одновременно
            
            
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0&& (array[i, j] > (array[i + 1, j] + array[i + 1, j + 1] + array[i, j + 1]))) //верхний левый угол
                    {
                            count++;                        
                    }
                    else if ((i == array.GetLength(0) - 1) && j == 0&&(array[i, j] > array[i - 1, j] + array[i - 1, j + 1] + array[i, j + 1])) //нижний левый угол
                    {                        
                            count++;
                    }
                    else if(i==0&&(j==array.GetLength(1) - 1)&& (array[i, j] > array[i + 1, j] + array[i + 1, j - 1] + array[i, j - 1])) //верхний правый угол 
                    {
                            count++;
                    }
                    else if(i== array.GetLength(0) - 1&&j== array.GetLength(1) - 1&& (array[i, j] > array[i - 1, j] + array[i - 1, j - 1] + array[i, j - 1])) // нижний правый угол
                    {                       
                            count++;
                    }else if (i != 0 && i!=array.GetLength(0) - 1 && j == 0&& (array[i, j] > array[i + 1, j] + array[i - 1, j] + array[i + 1, j + 1] + array[i - 1, j + 1] + array[i, j + 1])) //левый край
                    {                    
                            count++;
                    }else if (i == 0 && j != 0&&j!= array.GetLength(1) - 1&& (array[i, j] > array[i, j + 1] + array[i, j - 1] + array[i + 1, j + 1] + array[i + 1, j - 1] + array[i + 1, j])) // верхний край
                    {                        
                            count++;
                    }else if(i== array.GetLength(0) - 1 && j != 0&&j!= array.GetLength(1) - 1&& (array[i, j] > array[i, j + 1] + array[i, j - 1] + array[i - 1, j + 1] + array[i - 1, j - 1] + array[i - 1, j])) //нижний край
                    {
                            count++;
                    }else if(i!=0&&i!= array.GetLength(0) - 1&&j== array.GetLength(1) - 1&& (array[i, j] > array[i + 1, j] + array[i - 1, j] + array[i - 1, j - 1] + array[i, j - 1] + array[i + 1, j - 1])) //правый край
                    {
                            count++;
                    } else
                    {
                        if (array[i, j] > array[i - 1, j - 1] + array[i - 1, j] + array[i - 1, j + 1] + array[i, j + 1] + array[i + 1, j + 1] + array[i + 1, j] + array[i + 1, j - 1] + array[i, j - 1])
                            count++;
                    }
                }
            }
            return count;
        }

        public static int[,] Task6 (int[,] array)
        {
            // 6 Отразите массив относительно его главной диагонали
          
            int[,] newArray = new int[array.GetLength(1),array.GetLength(0)];
            WriteArray(array);
            for(int i=0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[j, i] = array[i, j];
                }
            }
            return newArray;

        }
















        private static int[,] CreateRandomArray2(int war = 8)
        {
            Console.WriteLine("Введите длину массива");
            int len = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[len, war];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = random.Next(0,3 );
            }
            return array;
        }

        private static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


        }





        private static int[,] CreateArray2(int war = 4)
        {
            Console.WriteLine("Введите длину массива");
            int len = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[len, war];
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++) {
                    array[i, j] = k;
                    k++;
                }
            }
            return array;
        }
    } 
}



