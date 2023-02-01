using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_3
{
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
    internal class Program
    {
        static char[] NotRepeat (string text)   // метод удаления дублей знаков в словах
        {
            char[] chars = text.ToCharArray ();     // переводим стринг в массив чаров
            int k = 0; // счетчик не повторяемых символов
                char[] temp = new char[chars.Length]; // времееный массив для сортировки не повторяемых символов
            for (int i = 0; i < chars.Length; i++) // цикл проверки символов
            {
                for (int j = i + 1;j<chars.Length;)   // цикл открывающий следующий символ
                {
                    if (chars[i] == chars[j])  // сравнение символа со следующим за ним
                    {
                        break;    // если одинковые возвращаемся к первому циклу
                    }
                    else                // если разные то текущий символ записываем во врмееный массив
                    {
                        temp[k] = chars[i];
                        k++;
                        break;           //возврат к первому циклу
                    }
                }
                temp[k] = chars[i];       // записываем последний символ во временный массив
            }
            char[]result = new char[k+1];        // создаем массив для возвращения в программу
            for (int i = 0;i < result.Length;i++)
            {
                result[i] = temp[i];
            }
            return (result);
        }
        static void Main(string[] args)
        {
            string sentence; // переменая для предложения
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();
            char[] result = NotRepeat(sentence);
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
