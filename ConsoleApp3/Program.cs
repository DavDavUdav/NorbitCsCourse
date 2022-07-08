using System;
using System.Collections.Generic;
using ClassLibraryFrequencyOfWords;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку(знаки препинания точка и пробел)");
            var dict = Class1.CountingFrequencyWords( Console.ReadLine());

            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine($"Слово {pair.Key} встречается {pair.Value} раз.");
            }
            Console.ReadKey();
        }
    }
}
