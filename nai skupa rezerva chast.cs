using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class nai_skupa_rezerva_chast
    {
        static void DisplayMostExpensivePart()
        {
            if (parts.Count > 0)
            {
                CarPart mostExpensivePart = parts[0];

                foreach (CarPart part in parts)
                {
                    if (part.Price > mostExpensivePart.Price)
                    {
                        mostExpensivePart = part;
                    }
                }

                Console.WriteLine("Най-скъпата резервна част:");
                Console.WriteLine("Име: " + mostExpensivePart.Name);
                Console.WriteLine("Производител: " + mostExpensivePart.Manufacturer);
                Console.WriteLine("Марка на колата: " + mostExpensivePart.CarBrand);
                Console.WriteLine("Цена: " + mostExpensivePart.Price);
                Console.WriteLine("Количество: " + mostExpensivePart.Quantity);
            }
            else
            {
                Console.WriteLine("Няма налични части.");
            }
        }

    }
}
