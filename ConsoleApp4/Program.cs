using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Батарейка> батарейки = new List<Батарейка>
        {
            new Батарейка { Тип = "АА", Ёмкость = 2500 },
            new Батарейка { Тип = "ААА", Ёмкость = 1200 },
            new Батарейка { Тип = "АА", Ёмкость = 2700 },
            new Батарейка { Тип = "ААА", Ёмкость = 1100 },
            new Батарейка { Тип = "АА", Ёмкость = 2600 }
        };

            var упорядоченныеБатарейкиАА = батарейки
                .Where(b => b.Тип == "АА")
                .OrderBy(b => b.Ёмкость)
                .ToList();

            Console.WriteLine("Батарейки типа АА, упорядоченные по ёмкости:");
            foreach (var батарейка in упорядоченныеБатарейкиАА)
            {
                Console.WriteLine($"Тип: {батарейка.Тип}, Ёмкость: {батарейка.Ёмкость} Вт/час");
            }
        }
    }
}
