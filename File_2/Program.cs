using System;
using System.Dynamic;

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
            sentence = Console.ReadLine(); // Заполняем переменную предложением.
            string[] words = SeparatesWords(sentence);
            string MinWord = WordWithMinChar(words);
            Console.WriteLine($"Самое маленькое слово: {MinWord}");
            string [] MaxWord = WordWithMaxChar(words);
            int D = words.Length;
            if (words.Length > 1)
                {
                Console.Write($"Самые большые слова: ");
                }
            else
                {
                 Console.Write($"Самое большое слово: ");
                }
            // D > 1 ? Console.Write($"Самые большые слова: ") :  Console.Write($"Самое большое слово: ") ;

            foreach (string word in MaxWord)
            {
                Console.Write(word +" ");
            }
            Console.ReadKey();
        }
        static string[] SeparatesWords(string Text)
        {
            string[] words1 = Text.Split(' ','.',',') ;  // разбиение строки на массив
            string[] temp = new string[words1.Length];           // временный массив для поиска пробелов
            int count = 0;                                       // счетчик количества пробелов                                
            for (int i=0; i <words1.Length;i++) 
                {
                  if (words1[i] != "")
                  {
                    temp[i- count] = words1[i];    
                  }
                  else
                  {
                    count++;
                  }
                }           // цикл для выявления пробела в ячейках
            string[] words = new string[words1.Length - count];
            for (int i = 0; i < words.Length; i++)
                {
                words[i] = temp[i];
                }              // цикл для создания массива без пробелов
            return words;
        }     // метод преобразующий текст в массив
        static string WordWithMinChar (string[] text)
        {
            string word = text[0];
            foreach (string t in text)
            {
                if (word.Length > t.Length)
                    word = t;
            }
            return word;
        }   // метод минимум букв
        static string[] WordWithMaxChar(string[] text)
        {
            string word = text[0];
            int count = 0;
            foreach (string t in text)
            {
                if (word.Length < t.Length)
                    word = t;
                else if (word.Length == t.Length)
                    count++;
            } // выявляем самое большое слово и количество этих слов
            string [] word2 = new string [count];
            int j=-0;
            foreach (string t in text) 
            {
                if (word.Length == t.Length)
                {
                    word2[j] = t;
                    j++;
                }
            }
            return word2;
        }  // метод максимум букв
    }
}
