using System;
using ClassLibrary;


namespace HW_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 298,96,56,74,68,30};

            ArrayWorker worker = new ArrayWorker();

            int[] result = new int[source.Length + 1];

            result = worker.Insert(source, 4, 90);

            Console.WriteLine(string.Join(",",source));
            Console.WriteLine(string.Join(",", result));

        }
    }
}
