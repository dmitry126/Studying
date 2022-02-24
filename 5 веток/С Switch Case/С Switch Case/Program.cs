using System;

namespace С_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("Привет, уважаемый, эта прога расскажет тебе о данной машине. Выбери какая характеристика тебе нужна:\n 1 - Изготовитель,\n 2 - Марка,\n 3 - Год выпуска,\n 4 - Количество колёс,\n 5 - Количество движков,\n 6 - Наличие битости,\n 7 - Наличие перекрашивания,\n 8 - Гарантия,\n 9 - Количество хозяе,\n 10 - Бак,\n 11 - Расход,\n 12 - Максималка,\n 13 - Разгон до 100,\n 14 - Чехлы на сидениях,\n 15 - Цвет,\n 16  - Диски,\n 17 - Зимняя резина,\n 18 - Чехол на руле,\n 19 - Комплектация,\n 20 - Машина класса.");
            y = Convert.ToInt32(Console.ReadLine());
            string[] massive = {"Лада", "Приора", "2003", "4 колеса", "1 движок", "не бита", "не крашена", "15 лет", "2 хозяина", "150 литров", "10 литров", "200 км/ч", "20 секунд", "есть", "черная", "литые", "есть", "есть", "спорт", "бизнес-класс" };
            switch (y)
            {
                case 1:
                    Console.WriteLine($"Изготовитель - {massive[0]}");
                    break;
                case 2:
                    Console.WriteLine($"Марка - {massive[1]}");
                    break;
                case 3:
                    Console.WriteLine($"Год выпуска - {massive[2]}");
                    break;
                case 4:
                    Console.WriteLine($"Количество колёс - {massive[3]}");
                    break;
                case 5:
                    Console.WriteLine($"Количество движков - {massive[4]}");
                    break;
                case 6:
                    Console.WriteLine($"Наличие битости - {massive[5]}");
                    break;
                case 7:
                    Console.WriteLine($"Наличие перекрашивания - {massive[6]}");
                    break;
                case 8:
                    Console.WriteLine($"Гарантия - {massive[7]}");
                    break;
                case 9:
                    Console.WriteLine($"Количество хозяев - {massive[8]}");
                    break;
                case 10:
                    Console.WriteLine($"Бак - {massive[9]}");
                    break;
                case 11:
                    Console.WriteLine($"Расход - {massive[10]}");
                    break;
                case 12:
                    Console.WriteLine($"Максималка - {massive[11]}");
                    break;
                case 13:
                    Console.WriteLine($"Разгон до 100 - {massive[12]}");
                    break;
                case 14:
                    Console.WriteLine($"Чехлы на сидениях - {massive[13]}");
                    break;
                case 15:
                    Console.WriteLine($"Цвет - {massive[14]}");
                    break;
                case 16:
                    Console.WriteLine($"Диски - {massive[15]}");
                    break;
                case 17:
                    Console.WriteLine($"Зимняя резина - {massive[16]}");
                    break;
                case 18:
                    Console.WriteLine($"Чехол на руле - {massive[17]}");
                    break;
                case 19:
                    Console.WriteLine($"Комплектация - {massive[18]}");
                    break;
                case 20:
                    Console.WriteLine($"Машина класса - {massive[19]}");
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
            Console.ReadLine();
        }
    }
}
