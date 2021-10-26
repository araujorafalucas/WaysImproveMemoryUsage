using System;
using System.Collections.Generic;

namespace WaysImproveMemoryUsage.SetListCapacity
{
    class Program
    {
        const int ListCapacity = 10_000;
        static void Main(string[] args)
        {
            GenerateListWithoutCapacity();

            //GenerateListWithCapacity();

            Console.ReadKey();

        }

        private static void GenerateListWithoutCapacity()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < ListCapacity; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"After GenerateListWithoutCapacity: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }

        private static void GenerateListWithCapacity()
        {
            List<int> list = new List<int>(ListCapacity);

            for (int i = 0; i < ListCapacity; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"After GenerateListWithCapacity: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }        
    }
}
