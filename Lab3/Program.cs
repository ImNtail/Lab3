using System;

namespace Lab3
{
    class Program
    {
        static int[,] sum(int[,] array, int[,] array2, out decimal AverageValue)
        {
            //Сумма матриц
            AverageValue = 0;
            int n = 3;
            int[,] arrayOutput = new int[n, n];
            for (int i = 0; i < arrayOutput.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOutput.GetLength(1); j++)
                {
                	AverageValue += array[i, j];
                    arrayOutput[i, j] = array[i, j] + array2[i, j];
                }
            }
            AverageValue = AverageValue / array.Length;
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
        static int sumIterative(int[] array)
        {
            int sumIter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumIter += array[i];
            }
            return sumIter;
        }
        static int sumRecursive(int[] array, int sumRec, int element)
        {
            if (element >= array.Length)
            {
                return sumRec;
            }
            else
            {
            	sumRec += array[element];  	
            	element++;
            }
            return sumRecursive(array, sumRec, element);
        }
        static int minIterative(int[] array)
        {
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
        static int minRecursive(int[] array, int minRec, int element)
        {
			if (element < array.Length)
			{
				 if (array[element] < minRec) 
				 { 
				 	minRec = array[element];
				 }
				 return minRecursive(array, minRec, ++element);
			}
			return minRec;
        }
        static int Fibonacci(int NumOfElement)
		{
		    if (NumOfElement == 0)
		    {
		        return 0;
		    }
		    else if (NumOfElement == 1)
		    {
		        return 1;
		    }
		    else
		    {
		        return Fibonacci(NumOfElement - 1) + Fibonacci(NumOfElement - 2);
		    }
		}
        static int Determinant(int[,] array, int length)
        {
            int det = 0;
            if (length == 2)
            {
                det = (array[0, 0] * array[1, 1]) - (array[1, 0] * array[0, 1]);
                Console.WriteLine("Determinant of the second order matrix = " + det + "\n\n");
                return det;
            }
            if (length != 2)
            {
				int i = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (i + j % 2 == 0)
                    {
                        det += array[i, j] * Minor(array, i, j, length);
                        Console.WriteLine("Determinant = Previous_det + {0} * Determinant_of_the_second_order_matrix = {1} \n\n", array[i, j], det);
                    }
                    else
                    {
                        det -= array[i, j] * Minor(array, i, j, length);
                        Console.WriteLine("Determinant = Previous_det - {0} * Determinant_of_the_second_order_matrix = {1} \n\n", array[i, j], det);
                    }
                }
        	}
            Console.WriteLine();
        	return det;
        }
        static int Minor(int[,] array, int n, int m, int length)
        {
            length -= 1;
            int[,] MinorArray = new int[length, length];
            for (int i = 0, q = 0; q < MinorArray.GetLength(0); i++, q++)
            {
                for (int j = 0, w = 0; w < MinorArray.GetLength(1); j++, w++)
                {
                    if (i == n) i++;
                    if (j == m) j++;
                    MinorArray[q, w] = array[i, j];
                    Console.Write("{0, 3} ", MinorArray[q, w]);
                }
                Console.WriteLine("\n");
            }
            return Determinant(MinorArray, length);
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
            int length = 7;
            int[,] array = new int[length, length];
			Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write("{0, 3}  ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                	array[i, j] = array[length - 1 - j, i];
                    Console.Write("{0, 3} ", array[i, j]);
                }
                Console.WriteLine();
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
            if (k > array.Length)
            	k = k % 10;
            for (int i = k; i < array.Length; i++)
            {
                Console.Write("{0, 3}  ", array[i]);
            }
            for (int i = 0; i < k; i++)
            {
            	Console.Write("{0, 3}  ", array[i]);
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
            int n = 3;
            int[,] array = new int[n, n];
            int[,] array2 = new int[n, n];
            decimal AverageValue = 0;
            Random rand = new Random();
            Console.WriteLine("The first array: ");
            Console.Write("\n\n");
			for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write("{0, 3}", array[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.Write("\n\n");
            Console.WriteLine("The second array: \n");
			for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(100);
                    Console.Write("{0, 3}", array2[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.Write("\n\n");
            Console.WriteLine("Output sum array is: \n");
            int[,] a = sum(array, array2, out AverageValue);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0, 3} ", a[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Output diff array is: \n");
            int[,] b = diff(array, array2);
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("{0, 3} ", b[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.Write("\n\n");
            Console.WriteLine("Average value is {0}", AverageValue);
            Console.ReadKey();
        }


        /*
        5. Написать программу перемножения двух матриц 5х5.
        */
        static void fifth()
        {
            int n = 5;
            int[,] array = new int[n, n];
            int[,] array2 = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("The first array: \n");
			for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    Console.Write("{0, 3}", array[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.Write("\n\n");
            Console.WriteLine("The second array: \n");
			for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(10);
                    Console.Write("{0, 3}", array2[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.Write("\n\n\n");
            Console.WriteLine("Output product array is: \n");
            int[,] a = product(array, array2);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, 4} ", a[i, j]);
                }
                Console.Write("\n\n\n");
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
            int element = 0;
            int sumRec = 0;
            int minRec = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write("{0, 3} ", array[i]);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Iterative amount = {0}", sumIterative(array));
            Console.WriteLine("\n\n");
            Console.WriteLine("Recursive amount = {0}", sumRecursive(array, sumRec, element));
            Console.WriteLine("\n\n");
            Console.WriteLine("Minimal element (iterative) = {0}", minIterative(array));
            Console.WriteLine("\n\n");
            Console.WriteLine("Minimal element (recursive) = {0}", minRecursive(array, minRec, element));
            Console.ReadKey();
        }
        
        
        /*
        7. Написать рекурсивную функцию для нахождения n-ого члена ряда
		Фибоначчи по формулам, приведенным в лабораторной работе №2.
        */
        static void seventh()
        {
        	Console.Write("Enter the number that you need: ");
       		int NumOfElement = int.Parse(Console.ReadLine());
        	Console.WriteLine();
        	Console.WriteLine(Fibonacci(NumOfElement));
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
            int[,] array = new int[length, length];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    Console.Write("{0, 2}  ", array[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.WriteLine();
            Console.WriteLine("Answer: determinant of the matrix is {0}", Determinant(array, length));
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
			int length = 9;
            int[,] array = new int[length, length];
            Random rand = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write("{0, 4} ", array[i, j]);
                }
                Console.Write("\n\n");
            }
			Console.Write("\n\n\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0, 3} ", array[i, length - 1 - j]);
                    }
                    
                    if (i != j && i + j == length - 1)
                    {
                    	Console.Write("{0, 3} ", array[i, i]);
                    }
                    else if (i != j)
                    	Console.Write("{0, 3} ", array[i, j]);
                }
                Console.Write("\n\n");
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
