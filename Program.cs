using System;

namespace lab_1_lera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя на русском пожалуйста.");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
        }
    }
}
