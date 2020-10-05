using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            const int N = 5;
            const int M = 6;
            int k = 0;
            bool isExist = false;

            int[] array1 = new int[N] { 1, 14, 2, 6, 7 };
            int[] array2 = new int[M] { 2, 7, 2, 10, 1, 1 };
            int[] array3 = new int[6];

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        for (int l = 0; l < array3.Length; l++)
                        {
                            if (array3[l] == array1[i])
                            {
                                isExist = true;
                            }
                        }

                        if (isExist == true)
                        {
                            isExist = false;
                            break;
                        }
                        else
                        {
                            array3[k] = array1[i];
                            k++;
                        }
                    }
                }
            }

            Console.Write("Array1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();

            Console.Write("Array2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();

            Console.Write("The same elements in two arrays: ");
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] == 0)
                    break;
                Console.Write($"{array3[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Task 2
            string line;

            Console.Write("Enter some line: ");
            line = Console.ReadLine();

            char[] arr = line.ToCharArray();
            Array.Reverse(arr);
            string revText = new string(arr);

            if (line == revText)
                Console.WriteLine("This line is a palidrom");
            else
                Console.WriteLine("This line is not a palidrom");
            Console.WriteLine();
            Console.WriteLine();


            //Task 3
            string line2;

            Console.Write("Enter some line: ");
            line2 = Console.ReadLine();

            string[] textArray;
            textArray = line2.Split(' ');
            Console.WriteLine($"Number of words in line: {textArray.Length}");
            Console.WriteLine();
            Console.WriteLine();

            //Task 4
            int[,] array = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();

            }

            int min = array[0, 0];
            int max = array[0, 0];
            int maxIndex_i=0, minIndex_i=0;
            int maxIndex_j=0, minIndex_j=0;
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex_i = i;
                        maxIndex_j = j;

                    }

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex_i = i;
                        minIndex_j = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Min element of the array: " + min + " with index [{0},{1}]", minIndex_i, minIndex_j);
            Console.WriteLine("Max element of the array: " + max + " with iundex [{0},{1}]", maxIndex_i, maxIndex_j);

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (array[i, j] == min || array[i, j] == max)
                    {
                        count++;
                    }
                    else if (count == 1)
                    {
                        sum += array[i, j];
                    }
                    if (count == 2)
                        break;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Sum of elements between min and max elements: " + sum);
        }
    }
}
