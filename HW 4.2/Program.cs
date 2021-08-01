using System;

namespace HW_4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Найти все числа, большее 200 и меньше 500, которое нацело делится на 17.
                Реализовать через цикл While().На выходе мы должны получить строку, где числа разделены ‘,’ */


            
            

            
            
            int var = 201;
            int limit = 500;
            

            while (var < limit)
            {
                if (var % 17 == 0)

                 
                Console.Write(var + ", ");

                   var++;
            
            }


           
        }
    }
}
