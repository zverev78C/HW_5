﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_2
{
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence; // переменая для предложения
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine(); // Заполняем переменный предложением.

            Console.ReadKey();
        }
    }
}
