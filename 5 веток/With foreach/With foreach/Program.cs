﻿using System;

namespace With_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("Привет, уважаемый, эта прога расскажет тебе о данной машине. Выбери какая характеристика тебе нужна:\n 1 - Изготовитель,\n 2 - Марка,\n 3 - Год выпуска,\n 4 - Количество колёс,\n 5 - Количество движков,\n 6 - Наличие битости,\n 7 - Наличие перекрашивания,\n 8 - Гарантия,\n 9 - Количество хозяе,\n 10 - Бак,\n 11 - Расход,\n 12 - Максималка,\n 13 - Разгон до 100,\n 14 - Чехлы на сидениях,\n 15 - Цвет,\n 16  - Диски,\n 17 - Зимняя резина,\n 18 - Чехол на руле,\n 19 - Комплектация,\n 20 - Машина класса.");
            try {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                y = -1;
            }
            if (y < 1 || y > 20)
            {
                Console.WriteLine("Введено неправильное число, будем демилитаризировать ;-)");
                Console.ReadLine();
                return;
            }
            string[] massive = { "Лада", "Приора", "2003", "4 колеса", "1 движок", "не бита", "не крашена", "15 лет", "2 хозяина", "150 литров", "10 литров", "200 км/ч", "20 секунд", "есть", "черная", "литые", "есть", "есть", "спорт", "бизнес-класс" };
            foreach (string element in massive) {
                if (element == massive[y-1]) {
                    Console.WriteLine(massive[y-1]);
                }
            }
            Console.ReadLine();
        }
    }
}
