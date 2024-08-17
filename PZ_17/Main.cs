using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZ_17
{
    public class MainKlass
    {
        public static void Main(string[] args)
        {
            // Создание объектов класса Fridge
            Fridge1 fridge1 = new Fridge1
            {
                manufacturer = "Samsung",
                model = "RB38T776FSR",
                yearOfRelease = 2022,
                malfunction = "Неисправен компрессор",
                owner = "Иван Иванов"
            };

            Fridge1 fridge2 = new Fridge1
            {
                manufacturer = "LG",
                model = "GN-L205BL",
                yearOfRelease = 2019,
                malfunction = "Повреждена дверца",
                owner = "Петр Петров"
            };

            Fridge1 fridge3 = new Fridge1
            {
                manufacturer = "Bosch",
                model = "KGN39VL30",
                yearOfRelease = 2020,
                malfunction = "Не работает подсветка",
                owner = "Мария Сидорова"
            };

            // Сортировка холодильников по году выпуска
            Fridge1[] fridges = { fridge1, fridge2, fridge3 };
            Array.Sort(fridges);

            // Вывод информации о холодильниках
            Console.WriteLine("Отсортированные холодильники:");
            foreach (Fridge1 fridge in fridges)
            {
                fridge.PrintInfo();
                Console.WriteLine("----------------------");
            }
        }
    }
}