using System;

namespace Lab3
{
    class Program
    {
        static int[,] sum(int[,] array, int[,] array2)
        {
            //Сумма матриц
            int n = 3;
            int[,] arrayOutput = new int[n, n];
            for (int i = 0; i < arrayOutput.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOutput.GetLength(1); j++)
                {
                    arrayOutput[i, j] = array[i, j] + array2[i, j];
                }
            }
            return arrayOutput;
        }
        static int[,] diff(int[,] array, int[,] array2)
        {
            //Разность матриц
            int n = 3;
            int[,] arrayOutput = new int[n, n];
            for (int i = 0; i < arrayOutput.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOutput.GetLength(1); j++)
                {
                    arrayOutput[i, j] = array[i, j] - array2[i, j];
                }
            }
            return arrayOutput;
        }
        static int[,] product(int[,] array, int[,] array2)
        {
            //Перемножение двух матриц
            int n = 5;
            int[,] arrayOutput = new int[n, n];
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    arrayOutput[i, j] = 0;
                    for (int k = 0; k <= n - 1; k++)
                    {
                        arrayOutput[i, j] += array[i, k] * array2[k, j];
                    }
                }
            }
            return arrayOutput;
        }
        static int sumIterative(int[] array, int length)
        {
            //Сумма элементов массива (итерационно)
            int sumIter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumIter += array[i];
            }
            return sumIter;
        }
        static int sumRecursive(int[] array, int length)
        {
            //Сумма элементов массива (рекурсивно)
            if (length == 0)
            {
                return 0;
            }
            if (length == 1)
            {
                return array[1];
            }
            //что-то не так здесь
            return array[length - 1] + sumRecursive(array, length - 1);
        }
        static int minIterative(int[] array)
        {
        	//Минимальный элемент массива (итерационно)
        	int minIter = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                    if (minIter > array[i])
                    {
                        minIter = array[i];
                    }
            }
            return minIter;
        }
        static int minRecursive(int[] array, int length)
        {
        	//Минимальный элемент массива (рекурсивно)
        	int minRec = array[0];
        	if (length < 1)
        	{
        		return 0;
        	}
        	if (minRec > array[length-1])
        	{
        		minRec = array[length-1];
        	}
        	minRecursive(array, length-1);
        	return minRec;
        	//что-то не так
        }
        static int Fibonacci(int NumOfNums)
		{
		    if (NumOfNums == 0)
		    {
		        return 0;
		    }
		    else if (NumOfNums == 1)
		    {
		        return 1;
		    }
		    else
		    {
		        return Fibonacci(NumOfNums - 1) + Fibonacci(NumOfNums - 2);
		    }
		}

        static void Main(string[] args)
        {
            int select;
            Console.Write("Choose the task from 1 to 10: ");
            select = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (select)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("The first task: \n");
                    first();
                    break;
                case 2:
                    Console.WriteLine("The second task: \n");
                    second();
                    break;
                case 3:
                    Console.WriteLine("The third task: \n");
                    third();
                    break;
                case 4:
                    Console.WriteLine("The fourth task: \n");
                    fourth();
                    break;
                case 5:
                    Console.WriteLine("The fifth task: \n");
                    fifth();
                    break;
                case 6:
                    Console.WriteLine("The sixth task: \n");
                    sixth();
                    break;
                case 7:
                    Console.WriteLine("The seventh task: \n");
                    seventh();
                    break;
                case 8:
                    Console.WriteLine("The eighth task: \n");
                    eighth();
                    break;
                case 9:
                    Console.WriteLine("The first individual task: \n");
                    ninth();
                    break;
 				case 10:
                    Console.WriteLine("The second individual task: \n");
                    tenth();
                    break;                    
                default:
                    break;
            }
        }

        /*
        1. Написать программу, которая запрашивает число элементов массива, после
        чего создает массив, заполняет его случайными целыми числами в
        диапазоне от -30 до 45 и выводит на экран строками по 10 элементов.
        Программа должна после этого вывести элементы массива в обратном
        направлении, начиная с последнего, игнорируя отрицательные элементы.
        */
        static void first()
        {
            Console.Write("Enter the number of array elements: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[length];
            Random rand = new Random();
            int limit = 1;
            for (int i = 0; i < length; i++)
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
            for (int i = 0; i < length; i++)
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
        }


        /*
        2. Написать программу поворота двумерного массива размерности 7х7 на 90
        градусов вправо (без использования дополнительных массивов).
        */
        static void second()
        {
            int limit = 1, n = 7;
            int[,] array = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}  ", array[i, j]);
                }
            }
            Console.Write("\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}  ", array[6 - j, i]);
                }
            }
            Console.ReadKey();
        }


        /*
        3. Написать программу циклического сдвига массива на k позиций влево.
        */

        static void third()
        {
            Console.Write("Enter the number of moves: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int length = 10;
            int[] array = new int[length];
            Random rand = new Random();
            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                Console.Write("{0, 3}  ", array[i]);
            }
            Console.Write("\n\n");
            if (k > 10)
                k = k % 10;
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    Console.Write("{0, 3}  ", array[i + k]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Write("{0, 3}  ", array[i - 10 + k]);
                }
            }
            Console.ReadKey();
        }


        /*
        4.Написать функции для поэлементного сложения и вычитания двумерных
        массивов 3х3. Функции должны принимать массивы в качестве параметров
        и выдавать результирующий массив в качестве возвращаемого значения. В
        третьем параметре функции необходимо вернуть среднее значение всех
        элементов входных массивов.
        */
        static void fourth()
        {
            int limit = 1, n = 3;
            int[,] array = new int[n, n];
            int[,] array2 = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("The first array: ");
            Console.Write("\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array[i, j]);
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("The second array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(100);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array2[i, j]);
                }
            }
            Console.Write("\n\n\n");
            Console.WriteLine("Output sum array is: \n");
            int[,] a = sum(array, array2);
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
                    Console.Write("{0, 4} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Output diff array is: \n");
            int[,] b = diff(array, array2);
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (limit > b.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 4} ", b[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        /*
        5. Написать программу перемножения двух матриц 5х5.
        */
        static void fifth()
        {
            int limit = 1, n = 5;
            int[,] array = new int[n, n];
            int[,] array2 = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("The first array: ");
            Console.Write("\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array[i, j]);
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("The second array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(10);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}", array2[i, j]);
                }
            }
            Console.Write("\n\n\n");
            Console.WriteLine("Output product array is: \n");
            int[,] a = product(array, array2);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (limit > a.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 4} ", a[i, j]);
                }
            }
            Console.ReadKey();
        }

        /*
        6. Написать и продемонстрировать работу следующих функций:
        sumIterative - итерационно вычисляет сумму элементов массива;
        sumRecursive - рекурсивно вычисляет сумму элементов массива;
        minIterative - итерационно вычисляет минимальный элемент в массиве;
        minRecursive - рекурсивно вычисляет минимальный элемент в массиве.
        */

        static void sixth()
        {
            Console.Write("Enter the number of array elements: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write("{0, 3} ", array[i]);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Iterative amount = {0}", sumIterative(array, length));
            Console.WriteLine("\n\n");
            Console.WriteLine("Recursive amount = {0}", sumRecursive(array, length));
            Console.WriteLine("\n\n");
            Console.WriteLine("Minimal element (iterative) = {0}", minIterative(array));
            Console.WriteLine("\n\n");
            Console.WriteLine("Minimal element (recursive) = {0}", minRecursive(array, length));
            Console.ReadKey();
        }
        
        
        /*
        7. Написать рекурсивную функцию для нахождения n-ого члена ряда
		Фибоначчи по формулам, приведенным в лабораторной работе №2.
        */
        static void seventh()
        {
        	Console.Write("Enter the number what you need: ");
       		int NumOfNums = int.Parse(Console.ReadLine());
        	Console.WriteLine();
        	Console.WriteLine(Fibonacci(NumOfNums));
        	Console.ReadKey();
        }
       
       
        /*
        8. Написать программу, позволяющую рекурсивно вычислить определитель
	    матрицы NxN по формуле: ...... , где M ij – это дополнительный минор (определитель матрицы, получаемой из
	    исходной вычеркиванием i-й строки и j-го столбца).
        */
        static void eighth()
        {
        	Console.Write("Enter the length of NxN array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
      	    int limit = 1;
            int[,] array = new int[length, length];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 3}  ", array[i, j]);
                }
            }
			//рекурсивно посчитать M ij --> A ij --> detA
            Console.ReadKey();
        }
        
        
        //Индивидуальные
        /*
        1. Написать программу, заполняющую и отображающую на экране двумерный
		массив 9х9, в соответствии с вариантом (приложение А).
		Заполнить матрицу случайными числами. Отобразить
		главную и побочную диагонали симметрично относительно
		вертикальной оси.
		*/
		static void ninth()
		{
			int limit = 1, length = 9;
            int[,] array = new int[length, length];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-99, 99);
                    if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n\n");
                        limit = 1;
                    }
                    limit++;
                    Console.Write("{0, 4} ", array[i, j]);
                }
            }
            Console.Write("\n\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                	if (limit > array.GetLength(0))
                    {
                        Console.Write("\n\n\n");
                        limit = 1;
                    }
                    limit++;
                    if (i == j)
                    {
                        Console.Write("{0, 4} ", array[i, 8 - j]);
                    }
                    
                    if (i != j && i + j == length - 1)
                    {
                    	Console.Write("{0, 4} ", array[i, i]);
                    }
                    else if (i != j)
                    	Console.Write("{0, 4} ", array[i, j]);
                }
            }
            Console.ReadKey();
		}
		
		
		/*
		2. Написать программу, работающую с одномерным массивом, в соответствии с вариантом.
		Программа сначала должна запрашивать у пользователя некоторое четное число элементов массива, а затем и сами элементы массива.
		Написать программу, которая выводит на экран TRUE, если элементы массива представляют собой возрастающую последовательность, иначе – FALSE.
		*/
		static void tenth()
		{
			Console.Write("Enter the even number of array elements: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (length % 2 != 0)
            {
            	Console.Write("The even number of array elements must be even. Please try again: ");
            	length = int.Parse(Console.ReadLine());
            	Console.WriteLine();
            }
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
				Console.Write("Enter the element of array: ");
				array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            bool check = false;
            for (int i = 1; i < array.Length; i++)
            {
            	if (array[i] < array[i - 1])
            	{
            		check = false;
            		break;
            	}
            	else
            		check = true;
            }
            Console.WriteLine(check);
            Console.ReadKey();
		}
    }
}
