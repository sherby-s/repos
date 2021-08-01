using System;

namespace HW_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. 	Содайте Console Application(Core или .Net5) в Visual Studio.
            Дано: у вас есть 3 промежутка чисел: от 0 до 30, от 31 до 60 и от 61 до 100.
            Входной параметр: пользователь вводит число.
            Что мы делаем: нужно понять в какой промежуток попало число.
            Выводим на консоль: в каком промежутке число. Если не попало, пишем “Я такого числа не знаю.”
                */



            while (true)
            {

                Console.WriteLine("Введите целое число:");
                string input = Console.ReadLine();

                int number;
                if (int.TryParse(input, out number))

                    if (number > 100 || number < 0)

                        Console.WriteLine("Я такого числа не знаю.");

                    else if (number >= 0 && number <= 30)

                        Console.WriteLine("Число " + number + " в диапазоне от 0 до 30");

                    else if (number > 30 && number < 60)

                        Console.WriteLine("Число " + number + " в диапазоне от 31 до 60");
                    else

                        Console.WriteLine("Число " + number + " в диапазоне от 61 до 100");

                else
                    Console.WriteLine("Это не число");

            }

            
        }
    }
}
