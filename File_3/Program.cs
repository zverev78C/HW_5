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
        static void Main(string[] args)
        {
            string sentence; // переменая для предложения
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine(); // Заполняем переменный предложением.

            Console.ReadKey();
        }
    }
}
