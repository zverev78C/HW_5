﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace from_page__1
{
    internal class Program
    {
        



        static void Main(string[] args)
        {

            /// <summary>
            /// метод разделения предложения в массив слов
            /// </summary>
            /// <returns>массив слов</returns>
            //static string SeparatesWords (string Text)
            //{
            //    string[] words = Text.Split(' ');
            //    return words;
            //}

            ///// <summary>
            ///// метод вывода слов в отдельных строках
            ///// </summary>
            //static void Print(string[] words)
            //{
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        Console.Write($"{words[i]}" + "\n");
            //    }
            //}
            #region
            //Задание 1.Метод разделения строки на слова
            //Что нужно сделать
            //Пользователь вводит в консольном приложении длинное предложение.
            //Каждое слово в этом предложении отделено одним пробелом.
            //Необходимо создать метод, который в качестве входного параметра принимает строковую переменную,
            //а в качестве возвращаемого значения — массив слов.
            //После вызова данного метода программа вызывает второй метод,
            //который выводит каждое слово в отдельной строке.   



            //Советы и рекомендации
            //Для реализации данной программы можно написать алгоритм разделения на слова самостоятельно,
            //используя цикл.Также можете использовать метод string.Split(‘ ’);
            //Прочитайте об этом методе подробнее на странице документации Microsoft.

            //Для названия методов используйте CamelCase, когда каждое следующее слово начинается с заглавной буквы.
            //Например, метод с именем GetPositiveRandomInt возвращает положительное целое случайное число.
            //По такому же принципу следует называть и свои методы.


            //Что оценивается
            //В программе, помимо основного метода main, присутствует два других метода, которые вызываются в теле метода main.
            //Названием методов соответствуют тому, что они делают(разделяют или выводят данные).
            #endregion

            string sentence; // переменая для предложения
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine(); // Заполняем переменный предложением.
            
            //string [] arr = SeparatesWords (sentence); // переменная массив для возвращения первого метода
            //Print(arr); // вызов второго метода для вывода на экран консоли

            Console.ReadKey();
        }
    }
}
