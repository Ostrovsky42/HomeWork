using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class HwArray1
    {

        public static void Main()
        {
            int[] ann = new int[] {12,1,4,7,2,8 };
            int[] arr =  Task10(ann);
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{ann[i]},{ arr[i]}");
            }

            
        }


        public static int Task1(int[] array)
            {
                Console.WriteLine("1 Найти минимальный элемент массива");

                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (min > array[i])
                        min = array[i];
                }
                return min;

            }

            public static int Task2(int[] array)
            {
                Console.WriteLine("2 Найти максимальный элемент массива");

                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (max < array[i])
                        max = array[i];
                }
                return max;
            }
            public static int Task3(int[] array)
            {
                Console.WriteLine("3 Найти индекс минимального элемента массива");

                int min = array[0];
                int iMin = 0;

                for (int i = 1; i < array.Length; i++)
                {
                if (min > array[i])
                {
                    min = array[i];
                    iMin = i;
                }
                }
                return iMin;
            }



            public static int Task4(int[] array)
            {
                Console.WriteLine("4 Найти индекс максимального элемента массива");

                int max = array[0];
                int iMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i]) { 
                max = array[i];
                iMax = i; }
                }
                return iMax;
            }

            public static int Task5(int[] array)
            {
                Console.WriteLine("5 Посчитать сумму элементов массива с нечетными индексами");

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                        sum += array[i];
                }

                return sum;
            }

            public static int[] Task6(int[] array)
            {
                Console.WriteLine("6 Сделать реверс массива(массив в обратном направлении)");

                int temp = 0;
                int temp1 = 0;

            for (int i = 0; i < array.Length/2; i++)
                {
                temp = array[i];
                temp1 = array[(array.Length -1) - i];
                array[(array.Length-1) - i] = temp;
                array[i] = temp1;
                }
            return array;
            }

            public static int Task7(int[] array)
            {
                Console.WriteLine("7 Посчитать количество нечетных элементов массива");

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                    count++;
                    }
                }
                return count;

            }

            public static int[] Task8(int[] array)
            {
                Console.WriteLine("8 Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.");

                int temp;
                int j = (array.Length / 2) - 1;
                for (int i = 1; i < ((array.Length / 2) + 1); i++)
                {
                    temp = array[array.Length - i];
                    array[array.Length - i] = array[j];
                    array[j] = temp;
                    j--;
                }
                return array;

            }



            public static int[] Task9(int[] array)
            {
                Console.WriteLine("9 Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select)! или вставками(Insert)) ");

                int temp;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[min])
                            min = j;
                    }
                    temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
                return array;
            }




            public static int[] Task10(int[] array)
            {
                Console.WriteLine("10 Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  пузырьком(Bubble)!, выбором(Select) или вставками(Insert))");

                int temp;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }

                    }
                }

                return array;
            }

            private static int[] CreateRandomArray()
            {
                Console.WriteLine("Введите длину массива");
                int lenght = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[lenght];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = random.Next(10, 100);
                return array;
            }

            private static void WriteArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
                Console.WriteLine();

            }

        }




    }




