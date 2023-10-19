using System;
using System.Net.Sockets;

namespace Lab5_02
{
    class Program
    {

        static void Main(string[] args)
        {

            MathOperations math = new MathOperations();

            int resultInt = math.Add(5, 3);
            double resultDouble = math.Add(2.5, 1.5);

            int[] arrayResult = math.Add(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
            double[] doubleArrayResult = math.Add(new double[] { 1.1, 2.2, 3.3 }, new double[] { 4.4, 5.5, 6.6 });

            int[,] matrixResult = math.Add(new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 5, 6 }, { 7, 8 } });
            double[,] doubleMatrixResult = math.Add(new double[,] { { 1.1, 2.2 }, { 3.3, 4.4 } },
                new double[,] { { 5.5, 6.6 }, { 7.7, 8.8 } });

            Console.WriteLine("Int Addition: " + resultInt);
            Console.WriteLine("Double Addition: " + resultDouble);

            Console.WriteLine("Array Addition: " + string.Join(", ", arrayResult));
            Console.WriteLine("Double Array Addition: " + string.Join(", ", doubleArrayResult));

            Console.WriteLine("Matrix Addition:");
            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    Console.Write(matrixResult[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Double Matrix Addition:");
            for (int i = 0; i < doubleMatrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < doubleMatrixResult.GetLength(1); j++)
                {
                    Console.Write(doubleMatrixResult[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}