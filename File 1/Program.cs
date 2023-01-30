using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_1
{
    internal class Program
    {
        // Задание 1.
        // Воспользовавшись решением задания 3 четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение

        // метод умножающий матрицу на число
        static int[,] matrixMultiFactor(int factor, int[,] arroy)
        {
            int[,] arroyFactor = new int [ arroy.GetLength(0), arroy.GetLength(1)];
            for (int i = 0; i < arroy.GetLength(0); i++)
            {
                for (int j = 0; j < arroy.GetLength(1); j++)
                {
                    arroyFactor [i, j] = arroy[i, j] * factor;
                }
            }
            return arroyFactor;
        }

        // Метод умножающий две матрицы
        static int [,] multiMatrix(int[,] arroy1, int[,] arroy2)
        {
            int[,] arroy3 = new int[arroy1.GetLength(0), arroy1.GetLength(1)];

            for (int i = 0; i < arroy3.GetLength(0); i++)
            {
                for (int j = 0; j < arroy3.GetLength(1); j++)
                {
                    arroy3[i,j] = arroy1 [i,j] * arroy2 [i,j];
                }
            }
            return arroy3;
        }

        // метод производящий сложение двух матриц
        static int[,] SumMatrix(int [,] arroy1 ,int [,] arroy2)
        {
            int[,] arroy3 = new int[arroy1.GetLength(0), arroy1.GetLength(1)];

            for (int i = 0; i < arroy3.GetLength(0); i++)
            {
                for (int j = 0; j < arroy3.GetLength(1); j++)
                {
                    arroy3[i, j] = arroy1[i, j] + arroy2[i, j];
                }
            }
            return arroy3;
        }
        static void Main(string[] args)
        {
            Console.Write("введите количество строк матрицы:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Введите множитель: ");
            int factor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[row, col];
            int[,] matrix2 = new int[row, col];
            Random random = new Random();

            Console.WriteLine("Исходная матрица один:");
            // заполнение случайными числами первой матрицы
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(1, 101);
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Исходная матрица два:");
            // заполнение второй матрицы
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = random.Next(1, 101);
                    Console.Write($"{matrix2[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Итоговая матрица от умножения на число: ");
            int[,] MatrixRes1;
            MatrixRes1 = matrixMultiFactor(factor, matrix);
            int count = 0;
            foreach (int item in MatrixRes1)
            {
                Console.Write($"{item}\t");
                count++;
                if (count % col == 0)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Итоговая матрица от умножения двух матриц: ");
            int[,] MatrixRes2;
            MatrixRes2 = multiMatrix(matrix, matrix2);
            foreach (int item in MatrixRes2)
            {
                Console.Write($"{item}\t");
                count++;
                if (count % MatrixRes2.GetLength(0) == 0)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Итоговая матрица от сложения двух матриц: ");
            int[,] MatrixRes3;
            MatrixRes3 = SumMatrix(matrix, matrix2);
            foreach (int item in MatrixRes3)
            {
                Console.Write($"{item}\t");
                count++;
                if (count % MatrixRes3.GetLength(0) == 0)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
