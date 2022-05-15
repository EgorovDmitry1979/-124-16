using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string t; //элемент массива статической последовательности
                int Size = 10; //длина массива
                Console.WriteLine("Введите произвольное количество данных статической последовательности");
                Console.WriteLine("После завершения ввода нажмите 'q'");
            do
            {
                t = Console.ReadLine();
                if (t == "q")
                {
                    Console.WriteLine("TRUE. (Последовательность помещается в массив)");
                    Console.WriteLine("Размер статической последовательности: " + n + ", Размер массива: " + Size);
                    break;
                }
                n++;
            }
                while (n <= Size);
            if (n > Size)
            {
                Console.WriteLine("FALSE. (Последовательность НЕ помещается в массив)");
                Console.WriteLine("Размер статической последовательности: >=" + n + ", Размер массива: " + Size);
            }
        }
    }
}
