using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    internal class zd3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение K:");
            int K = int.Parse(Console.ReadLine());

            int count = 0;
            int number = 2;

            while (count < K)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                    if (count % 10 == 0)
                    {
                        Console.WriteLine(); // Перенос строки после каждых 10 чисел
                    }
                }
                number++;
            }
        }

        // Метод для проверки, является ли число простым
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
