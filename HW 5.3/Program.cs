using System;
using ClassLibrary;

namespace HW_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone fugure = new Cone(5.33M,3.098M);

            Console.WriteLine("Площадь основания: " + fugure.SquareBase() + "метров кв.");
            Console.WriteLine($"Площад конуса: {fugure.SquareCone()} метров кв.");
        }
    }
}
