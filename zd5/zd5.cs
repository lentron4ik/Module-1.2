using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    internal class zd5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива K:");
            int K = int.Parse(Console.ReadLine());

            char[] array = new char[K];
            char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            Random random = new Random();

            // Генерация массива случайных букв
            for (int i = 0; i < K; i++)
            {
                array[i] = (char)random.Next('а', 'я' + 1); // Буквы от 'а' до 'я'
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            // Создание нового массива с согласными буквами
            char[] consonantArray = Array.FindAll(array, c => Array.IndexOf(consonants, c) >= 0);

            Console.WriteLine("Массив согласных букв:");
            Console.WriteLine(string.Join(", ", consonantArray));
        }
    }
}
