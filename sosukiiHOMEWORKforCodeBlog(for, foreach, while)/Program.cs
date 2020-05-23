using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace sosukiiHOMEWORKforCodeBlog_for__foreach__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oppai = new List<int>();

            int result;
            for (int i = 0; i <= 14; i++) /* 14 - потому, что индексация с нулевого (всего будет 15 элементов). */
            {
                Console.WriteLine("sweetie, enter int num please ");
                while (!Int32.TryParse(Console.ReadLine(), out result)) /* Верни парсенное значение в виде переменной резалт. */
                    Console.WriteLine("wrong");                         /* Если введено что-то КРОМЕ целого числа или не удается парсить - напиши ВРОНГ. */
                oppai.Add(result); /* Добавь значение в СПИСОК. */
            }

            Console.WriteLine("You'r number: ");
            oppai.ForEach(Console.WriteLine); /* Выводит все элементы столбом. */

            Console.WriteLine("count: " + oppai.Count); /* Общее число элементов. */
            Console.WriteLine("max value: " +oppai.Max()); /* Максимальное значение. */
            Console.WriteLine("min value: " + oppai.Min()); /* Минимальное. */
            Console.WriteLine("sum: " + oppai.Sum()); /* Сумма всех элементов. */
           
            int popMINUS =0;
            for (int i = 0; i < oppai.Count; i++) /* Цикл спец-но для разности. */
            {
                var pops = oppai[i];
                popMINUS -= pops;
            }

            int x=0; /* Переменная - как счетчик. */
            int popUMNOZIT=1; /* Переменная для вывода результата умножения элементов списка. */
            do
            {
                popUMNOZIT = popUMNOZIT * oppai[x];
                x++;
            }
            while (x < oppai.Count);

            Console.WriteLine("Разность элементов списка: " + popMINUS);
            Console.WriteLine("Умножение элементов списка: " + popUMNOZIT);

            Console.WriteLine("Yay~ <3 ");

        }
    }
}
