using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Зохиров
            Console.WriteLine("Введите размерность массивов:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Ошибка! Размерность массива должна быть больше единицы");
                return;
            }

            int[] Answer1 = new int[n];
            int[] Answer2 = new int[n];

            Console.WriteLine("Введите значенние массива Answer1:");
            for (int i = 0; i < n; i++)
            {
                Answer1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите значенние массива Answer2:");
            for (int i = 0; i < n; i++)
            {
                Answer2[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
    }
}
