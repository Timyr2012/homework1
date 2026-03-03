using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вітаємо на регестрації, впишіть своє ім'я");
            string name = Console.ReadLine();
            Console.WriteLine("впишіть свій вік");
            string age = Console.ReadLine();
            Console.WriteLine("Придумайте пароль");
            string password = Console.ReadLine();
                      
            Console.WriteLine($"Вітаємо {name} в нашому клубі, ми раді що ви в свої {age} приєдналися до нас. та нікоми не кажіть що пароль {password}");


        }
    }
}
