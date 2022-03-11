using System;
using ClassLibraryWrite;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadUser();
        }

        public static void ReadUser()
        {
            Console.WriteLine("Введите целое положительное число");

            int n = Convert.ToInt32(Console.ReadLine());
            int []arrNumbers = WriteStrings.WriteNum(n);
            for (int i = 0; i<=arrNumbers.Length;i++)
            {
                if (i == n)
                {
                    Console.Write(i + ".");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("Введите целое нечетное положительное число");
            n = Convert.ToInt32(Console.ReadLine());
            char [,]starSquade = WriteStrings.WriteStars(n);

            for (int i = 0; i<starSquade.GetLength(0);i++)
            {
                for (int j=0;j<starSquade.GetLength(1);j++)
                {
                    Console.Write(starSquade[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
