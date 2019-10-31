using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Написать программу, которая запрашивает число элементов массива, после
            чего создает массив, заполняет его случайными целыми числами в
            диапазоне от -30 до 45 и выводит на экран строками по 10 элементов.
            Программа должна после этого вывести элементы массива в обратном
            направлении, начиная с последнего, игнорируя отрицательные элементы.
            */

            /*
            Console.Write("Enter the number of array elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[n];
            Random rand = new Random();
            int limit = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-30, 45);
                if (limit > 10)
                {
                    Console.Write("\n\n");
                    limit = 1;
                }
                limit++;
                Console.Write("{0, 3}  ", array[i]);
            }
            Console.WriteLine("\n\n");
            Array.Reverse(array);
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                    continue;
                if (limit > 10)
                {
                    Console.Write("\n\n");
                    limit = 1;
                }
                limit++;
                Console.Write("{0, 3}  ", array[i]);
            }
            Console.ReadKey();
            */


            /*
            2. Написать программу поворота двумерного массива размерности 7х7 на 90
            градусов вправо (без использования дополнительных массивов).
            */

            /*
            int limit = 1;
            int[,] array = new int[7,7];
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = rand.Next(100);
                    if (limit > 7)
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}  ", array[i, j]);
                }
            }
            Console.Write("\n\n");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                
                    if (limit > 7)
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}  ", array[6-j, i]);
                }
            }
            Console.ReadKey();
            */


            /*
            3. Написать программу циклического сдвига массива на k позиций влево.
            */

            /*
            Console.Write("Enter the number of moves: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[10];
            Random rand = new Random();
            Console.Write("\n");
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(100);
                Console.Write("{0, 3}  ", array[i]);
            }
            Console.Write("\n\n");
            if (k > 10)
                k = k % 10;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("{0, 3}  ", array[i + k]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.Write("{0, 3}  ", array[i - 10 + k]);
                }
            }
            Console.ReadKey();
            */


            /*
            4.Написать функции для поэлементного сложения и вычитания двумерных
            массивов 3х3. Функции должны принимать массивы в качестве параметров
            и выдавать результирующий массив в качестве возвращаемого значения. В
            третьем параметре функции необходимо вернуть среднее значение всех
            элементов входных массивов.
            */

            int limit = 1;
            int[,] array = new int[3, 3];
            int[,] array2 = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rand.Next(100);
                    if (limit > 3)
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array[i, j]);
                }
            }
            Console.Write("\n\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = rand.Next(100);
                    if (limit > 3)
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array2[i, j]);
                }
            }
            Console.Write("\n\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (limit > 3)
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, -4}", array[i, j]+array2[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
