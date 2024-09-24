using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd6
{
    internal class zd6
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            Random random = new Random();

            // Заполнение массива случайными числами в диапазоне [-10, 10)
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 20 - 10;
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            // Формирование массива индексов, отсортированных по возрастанию значений массива
            int[] indices = new int[array.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                indices[i] = i;
            }

            Array.Sort(indices, (i, j) => array[i].CompareTo(array[j]));

            Console.WriteLine("Массив индексов в порядке возрастания значений элементов:");
            Console.WriteLine(string.Join(", ", indices));
        }
    }
}
