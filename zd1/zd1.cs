using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1
{
    public class zd1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива N:");
            int N = int.Parse(Console.ReadLine());

            double[] array = new double[N];

            Console.WriteLine("Введите значения элементов массива:");
            for (int i = 0; i < N; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            // Находим максимальный по модулю элемент
            double maxElement = Math.Abs(array[0]);
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > maxElement)
                {
                    maxElement = Math.Abs(array[i]);
                }
            }

            // Нормирация элементов массива
            for (int i = 0; i < N; i++)
            {
                array[i] /= maxElement;
            }

            Console.WriteLine("Нормированный массив:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
