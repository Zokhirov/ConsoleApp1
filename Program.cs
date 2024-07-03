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
            double sumDifferenceSquard = 0;
            for (int i = 0; i < n; i++)
            {
                sumDifferenceSquard += Math.Pow(Answer1[i] - Answer2[i], 2);
            }
            double Rs = 1 - (6 * sumDifferenceSquard) / (n * (Math.Pow(n, 2) - 1));
            Console.WriteLine($"Коэффицент ранговой корреляции Rs = {Rs}");
            Console.WriteLine("Характер взаимосвязи по шкале Чеддока:");
            if (Rs >= 0 && Rs < 0.2)
            {
                Console.WriteLine("Связь пректически отсутствует");
            }
            else if (Rs >= 0.2 && Rs < 0.5)
            {
                Console.WriteLine("Связь слабая");
            }
            else if (Rs >= 0.5 && Rs < 0.7)
            {
                Console.WriteLine("Связь средняя");
            }
            else if (Rs >= 0.7 && Rs < 0.95)
            {
                Console.WriteLine("Связь сильная");
            }
            else if (Rs >= 0.95 && Rs < 1)
            {
                Console.WriteLine("Практически функциональная завипсимость");
            }
            Console.WriteLine("Работу выполнил студент: Зохиров Абдурахмон Ахмаджонович");
            Console.WriteLine("Группа: 34 ИС");
        }
    }
}
