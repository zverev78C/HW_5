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
            bool NewCheck = true;
            int Arith = Numbers[1] - Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
             int TempValue = Numbers[i] - Numbers[i-1];
             if (Arith != TempValue)
             {
              Console.WriteLine("Последовотельность не является арифметической");
              NewCheck = false;
              break;
             } 
            }

            if (NewCheck == false)
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
        static void Check(int[]Numbers)
        {
            bool Check = false;
               if (Check == true)   // Первый цикл проверяет последовательность на Арифм. Прогрессию
               {
                Console.WriteLine("Эта последовательность является Арифмитической прогрессией");
               }
               else if (Check == true) // если первый цикл не подверждается то второй цикл проверяет последовательность на Геометр. прогрессию
               {
                Console.WriteLine("Эта последовательность является геометрической прогрессией");
               }
               else     // если оба цикла дали отрицательный ответ то выводится сообщение об отсутсвии прогрессии 
               {
                Console.WriteLine("В последовательности нет искомой прогрессии");
               }
        }  // #2 проверкак последовательностей
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
