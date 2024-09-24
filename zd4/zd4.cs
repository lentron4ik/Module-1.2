using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    internal class zd4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива K:");
            int K = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите диапазон значений A и B (A включительно, B не включительно):");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int[] array = new int[K];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < K; i++)
            {
                array[i] = random.Next(A, B);
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            // Нахождение индексов минимального и максимального элементов
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < K; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            Console.WriteLine("Элементы между минимальным и максимальным индексами (включительно):");
            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
