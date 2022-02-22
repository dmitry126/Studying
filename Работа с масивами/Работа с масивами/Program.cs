using System;
namespace Работа_с_масивами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum = 0;
            int[] A = new int[9];
            Console.WriteLine("Привет, прога считает среднее арифметическое между 9 введенными числами которые больше 12 и меньше 25 ");
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine($"Введите число #{i+1}:") ;
                int y = Convert.ToInt32(Console.ReadLine());
                A[i] = y;
            }
            foreach (int element in A) {
                if (element > 12 && element < 25) {
                    sum += element;
                    counter++;
                }
            }
            Console.WriteLine($"Cреднее арифметическое между 9 введенными числами которые больше 12 и меньше 25 = {(double)sum/counter}");
            Console.ReadLine();
        }
    }
}
 