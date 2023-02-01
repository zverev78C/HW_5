using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from_page_2
{
            #region
            //Задание 2.Перестановка слов в предложении


            //Что нужно сделать
            //Пользователь вводит в программе длинное предложение.
            //Каждое слово раздельно одним пробелом.
            //После ввода пользователь нажимает клавишу Enter.
            //Необходимо создать два метода:

            //первый метод разделяет слова в предложении;
            //второй метод меняет эти слова местами(в обратной последовательности). 
            //При этом важно учесть, что один метод вызывается внутри другого метода,
            //то есть в методе main вызывается метод cо следующей сигнатурой — ReversWords(string inputPhrase).
            //Внутри этого метода вызывается метод по разделению входной фразы на слова.



            //Советы и рекомендации
            //Для сложения строк можно использовать конкатенацию строк.
            //Выражение вида ResultString += NewString + “ ” добавит к текущей строке,
            //которая представлена переменной ResultString, новую строку из переменной NewString
            //и также добавит пробел к концу строки. 
            //Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из задания 1.


            //Что оценивается
            //Вызов метода по разделению на слова происходит внутри метода,
            //который отвечает непосредственно за инвертирование слов в предложении.
            #endregion
    internal class Program
    {
        // метод разделения предложения в массив слов
        static string[] SeparatesWords(string Text)
        {
            string[] words = Text.Split(' ');
            return words;
        }

        // метод меняющий слова местами
        static void ReversWords(string inputPhrase)
        {
            string[] arroy = SeparatesWords(inputPhrase);
            
            Array.Reverse(arroy);
            Console.WriteLine();

            // вывод в консоль итогового предложения
            foreach (string word in arroy)
            {
                Console.Write($"{word} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            ReversWords(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
