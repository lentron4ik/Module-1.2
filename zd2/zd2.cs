using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class zd2
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            // Инициализация массива случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Числа от 1 до 100
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("Введите целое число для замены максимального элемента:");
            int inputNumber = int.Parse(Console.ReadLine());

            // Находждение индекса максимального элемента
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Замена максимального элемента
            array[maxIndex] = inputNumber;

            Console.WriteLine("Массив после замены максимального элемента:");
            Console.WriteLine(string.Join(", ", array));
            Console.ReadKey();
        }
    }
}

