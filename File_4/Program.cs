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
            int Vol = 1;
            int[] Numders = new int[Vol];
            Console.WriteLine("Введите числовой ряд по возростающей не менее трех чисел.");
            Console.ReadLine();



            Console.ReadLine();
        }
        static void Check(int[]Numbers)
            {
            bool Check = false;
            // Первый цикл проверяет последовательность на Арифм. Прогрессию
            if (Check == true)
            {
                Console.WriteLine("Эта последовательность является Арифмитической прогрессией");
            }
            // если первый цикл не подверждается то второй цикл проверяет последовательность на Геометр. Прогрессию
            else if (Check == true)
            {
                Console.WriteLine("Эта последовательность является геометрической прогрессией");
            }
            // если оба цикла дали отрицательный ответ то выводится сообщение об отсутсвии прогрессии 
            else
            {
                Console.WriteLine("В последовательности нет искомой прогрессии");

            }

            }
       
        }
}
