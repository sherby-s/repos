using System;
using ClassLibrary;

namespace HW_5._1

{
    class Program
    {
        static void Main(string[] args)
        {
           int[] myArray = new int [] { 1, 20, 30, 0, 5, 69 };

            ArrayWorker worker = new ArrayWorker();

            int[] invertArray = new int[myArray.Length];

            invertArray = worker.Invert(myArray);

            Console.WriteLine(string.Join(";", myArray));
            Console.WriteLine(string.Join(";", invertArray));
        }
    }
}
