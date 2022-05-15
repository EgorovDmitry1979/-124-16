using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Случайные_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] { 0, 1, 1, 1, 0, 1, 0, 1, 1, 1 };
            //Это массив знаний в голове у студента. Если 0, то знаний нет.

            {
                int i = 1; //номер первой попытки
                int z = 3; //можно задать количества попыток для присвоения переменной i
                int n;
                do
                {
                    Console.WriteLine(" "); // Это для отображения пробела на экране
                    Console.WriteLine("Это попытка N" + i);
                    Console.WriteLine("- Вы готовы? Тяните билет!");
                    Console.ReadLine();
                    Random Num = new Random();
                    int NT = Num.Next(10);
                    if (NT <= 1)
                    {
                        n = 1;  //Если вдруг номер билета выпадет 0 или -1
                    }
                    else
                    {
                        n = NT;
                    }
                    Console.WriteLine("- Билет N" + n);
                    var a = A[n - 1]; //Содержание билета. Ключ массива
                    if (a > 0)
                    {
                        Console.WriteLine("- Билет знаю, попытаюсь ответить");
                        //знания есть, если ячейка массива отлична от 0
                        Console.WriteLine(" "); // Это для отображения пробела на экране
                    }
                    else
                    {
                        Console.WriteLine("- Билет не знаю. Приду на пересдачу.");
                        //знаний нет, если ячейка массива равна 0
                        i++;
                        continue;
                    }
                        Random Grade = new Random();
                        var y = Grade.Next(6);
                    if (y <= 2) //чтобы оценка не была "0" и "1"
                    {
                        Console.WriteLine("- Очень плохо, оценка: " + 2);
                        Console.WriteLine("- Придёте на пересдачу...");
                        i++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("- Оценка за экзамен: " + y);
                        if (y <= 3)
                        {
                            Console.WriteLine("- Повезло, что сдал...");
                            return;
                        }
                        else if (y <= 4)
                        {
                            Console.WriteLine("- Могло быть и лучше.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("- Ура!");
                            return;
                        }
                    }
                }
                while (i <= z);
                if (i <= z)
                {

                }
                else
                {
                    Console.WriteLine("- Сожалею, но количество попыток исчерпано.");
                    Console.WriteLine("- Вы отчислены!");
                }
            }
        }
    }
}