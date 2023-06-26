using System;
using System.Collections.Generic;

namespace ConsoleApp3;

    class CarPart
    {
      public string Name { get; set; }
      public string Manufacturer { get; set; }
      public string CarBrand { get; set; }
      public decimal Price { get; set; }
      public int Quantity { get; set; }
    }

    class Programing
    {
       static List<CarPart> parts = new List<CarPart>();

      static void Main()
      {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добави нова част");
            Console.WriteLine("2. Изтрий част");
            Console.WriteLine("3. Прегледай части");
            Console.WriteLine("4. Изход");
            Console.WriteLine();
            Console.Write("Изберете опция: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddPart();
                    break;
                case "2":
                    DeletePart();
                    break;
                case "3":
                    DisplayParts();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Невалиден избор.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddPart()
    {
        Console.Write("Име на частта: ");
        string name = Console.ReadLine();
        Console.Write("Производител: ");
        string manufacturer = Console.ReadLine();
        Console.Write("Марка на колата: ");
        string carBrand = Console.ReadLine();
        Console.Write("Цена: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Количество: ");
        int quantity = int.Parse(Console.ReadLine());

        CarPart part = new CarPart()
        {
            Name = name,
            Manufacturer = manufacturer,
            CarBrand = carBrand,
            Price = price,
            Quantity = quantity
        };

        parts.Add(part);

        Console.WriteLine("Частта е добавена успешно.");
    }

    static void DeletePart()
    {
        Console.Write("Име на частта, която искате да изтриете: ");
        string name = Console.ReadLine();

        CarPart part = parts.Find(p => p.Name == name);

        if (part != null)
        {
            parts.Remove(part);
            Console.WriteLine("Частта е изтрита успешно.");
        }
        else
        {
            Console.WriteLine("Частта не е намерена.");
        }
    }

    static void DisplayParts()
    {
        Console.WriteLine("Всички части в магазина:");

        if (parts.Count > 0)
        {
            foreach (CarPart part in parts)
            {
                Console.WriteLine("Име: " + part.Name);
                Console.WriteLine("Производител: " + part.Manufacturer);
                Console.WriteLine("Марка на колата: " + part.CarBrand);
                Console.WriteLine("Цена: " + part.Price);
                Console.WriteLine("Количество: " + part.Quantity);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Няма налични части.");
        }
    }
}
