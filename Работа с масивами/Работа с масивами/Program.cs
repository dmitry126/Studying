using System;
namespace Работа_с_масивами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; //счетчик
            int sum = 0;    //сумма
            int[] A = new int[9];//создаем массив
            Console.WriteLine("Привет, прога считает среднее арифметическое между 9 введенными числами которые больше 12 и меньше 25 ");//приветствие
            for (int i = 0; i <= 8; i++){ //создаем цикл для ввода массива
                Console.WriteLine($"Введите число #{i+1}:");//запрос на ввод числа
                int y = Convert.ToInt32(Console.ReadLine());//ввод числа
                A[i] = y;//присваиваем элементу массива введенное число
            }
            foreach (int element in A) {//цикл по всем элементам массива
                if (element > 12 && element < 25){//условие
                    sum += element;//суммирование
                    counter++;//счетчик
                }
            }
            Console.WriteLine($"Cреднее арифметическое между 9 введенными числами которые больше 12 и меньше 25 = {(double)sum/counter}");//вывод результата с приведением к типу double
            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
 