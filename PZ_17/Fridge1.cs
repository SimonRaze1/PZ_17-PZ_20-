using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZ_17
{
    public class Fridge1 : ICloneable, IComparable
    {
        // Поля класса
        public string manufacturer;
        public string model;
        public int yearOfRelease;
        public string malfunction;
        public string owner;

        // Метод для расчета стоимости ремонта
        public double RepairCost()
        {
            // Пример расчета стоимости ремонта, 
            // в реальной ситуации логика расчета может быть сложнее
            double cost = 0;
            if (malfunction == "Неисправен компрессор")
            {
                cost = 5000;
            }
            else if (malfunction == "Повреждена дверца")
            {
                cost = 2000;
            }
            else if (malfunction == "Не работает подсветка")
            {
                cost = 1000;
            }
            return cost;
        }

        // Метод для вывода информации о холодильнике
        public void PrintInfo()
        {
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Год выпуска: {yearOfRelease}");
            Console.WriteLine($"Неисправность: {malfunction}");
            Console.WriteLine($"Владелец: {owner}");
            Console.WriteLine($"Стоимость ремонта: {RepairCost():C}");
        }
        public object Clone()
        {
            Fridge1 newFridge = new Fridge1();
            newFridge.manufacturer = manufacturer;
            newFridge.model = model;
            newFridge.yearOfRelease = yearOfRelease;
            newFridge.malfunction = malfunction;
            newFridge.owner = owner;
            return newFridge;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Fridge1 otherFridge = obj as Fridge1;
            if (otherFridge != null)
            {
                // Сравнение по году выпуска
                return yearOfRelease.CompareTo(otherFridge.yearOfRelease);
            }
            else
            {
                throw new ArgumentException("Объект не является Fridge.");
            }
        }
    }
}