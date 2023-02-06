using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_4
{
    internal class Program
    {
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии
        // 
        // Примечание
        //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
        //
        static void Main(string[] args)
        {
            Console.WriteLine("Это прогрмамма для сравнения ряда чисел на наличие Арифметической или " +
            "Геометрической прогрессии.");
            int[] Numbers;
            Numbers = ReadNumb();
            bool ArithCheck = true;
            int Arith = Numbers[1] - Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
             int TempValue = Numbers[i] - Numbers[i-1];
             if (Arith != TempValue)
             {
              Console.WriteLine("Последовотельность не является арифметической");
              ArithCheck = false;
              break;
             } 
            }

            if (ArithCheck == false)
            {
                bool Geo = true;
                float Geom = Numbers[1] % Numbers[0];
                for (int i = 1; i < Numbers.Length; i++)
                {
                    float TempValue = Numbers[i] % Numbers[i - 1];
                    if (Geom != TempValue)
                    {
                        Console.WriteLine("Последовотельность не является Геометрической");
                        Geo= false;
                        break;
                    }
                }

                if (Geo == true)
                {
                    Console.WriteLine("Последовотельность является Геометрической");
                } 
            }
            else 
            {
                Console.WriteLine("Последовотельность является арифметической");
            }

           
            Console.ReadLine();
        }
    
        static int[] ReadNumb()
        {
            Console.WriteLine("Сколько чисел вы хотите проверить?");
            int vol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа  ");
            int[] arroy = new int[vol];
            for(int i =0; i<arroy.Length; i++)
            {
                arroy[i] = Convert.ToInt32(Console.ReadLine());
            }                                                      
          return arroy;
        }    // метод принимающий числа
    }

        
}
