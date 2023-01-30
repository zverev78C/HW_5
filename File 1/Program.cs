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
        static int [,] matrixMultiFactor (int factor, int[,] arroy)
        {
            for (int i = 0; i <arroy.GetLength(0); i++)
            {
                for (int j = 0; j < arroy.GetLength(1); j++)
                {
                    arroy[i, j] = arroy[i,j] * factor;
                }
            }

            //Console.WriteLine("Итоговая матрица: ");
            //for (inti = 0; i
            //{
            //    for (intj = 0; j
            //    {
            //        matrix[i, j] = matrix[i, j] * factor;
            //        Console.Write($"{matrix[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //foreach (int item in arroy)
            //{
            //   => * factor;
            //}

            return arroy;
        }

        // Метод умножающий две матрицы
        //static int multiMatrix (int [,] matrix, int [,] matrix2) 
        //{
        //    return matrixRes;
        //}


        // метод производящий сложение двух матриц

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
            int count = 0;
            foreach (int item in matrix2)
            {

                Console.Write($"{random.Next(1, 101)}\t");
                count++;
                if (count % col == 0)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Итоговая матрица от умножения на число: ");
            int [,] MatrixRes1;
            MatrixRes1 =  matrixMultiFactor(factor, matrix);
            Console.WriteLine();

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

            Console.ReadKey();



        }
    }
}
