using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class nachalno_kolichestvo
    {
        static void SortPartsByQuantity()
        {
            if (parts.Count > 0)
            {
                parts.Sort((part1, part2) => part2.Quantity.CompareTo(part1.Quantity));

                Console.WriteLine("Резервни части, сортирани по налично количество:");
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
}
