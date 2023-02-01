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
            int k = 1;
            char[] chars = text.ToCharArray ();     // переводим стринг в массив чаров
            //for (int i = 0; i < chars.Length; i++)               // цикл проходит по массиву
            //{
            //    for (int j = 0; j < chars.Length; j++)      // цикл проходит по массиву второй раз что бы сравнить 1 и второй символ
            //    {
            //        char[] NewChar = new char[k+1];             // новый массив для записи не парных символов
            //        if (chars[i] != chars[j])                 // проверка апрности
            //        {
            //            NewChar[k] = chars[i];
            //            k++;
            //            break;
            //        }
            //        break;
            //    }
            //}

            for (int i = 0; i < chars.Length; i++)
            {
                char[] temp = new char[k];
                switch (true)
                {
                    case (i == 0):
                    temp[0]= chars[i];
                        break;
                    case (chars[i] == chars[i + 1]):
                        break;
                    default:
                        temp[k-1] = chars[i];
                        k++;
                        break;
                }

                Console.WriteLine(temp[k-1]);
            }
               // temp[k-1] = chars[i];
          
            return (chars);
        }
        static void Main(string[] args)
        {
            string sentence; // переменая для предложения
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();
            char[] result = NotRepeat(sentence);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
