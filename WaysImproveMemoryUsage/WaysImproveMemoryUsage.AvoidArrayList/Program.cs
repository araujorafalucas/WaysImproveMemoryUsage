using System;
using System.Collections;
using System.Collections.Generic;

namespace WaysImproveMemoryUsage.AvoidArrayList
{
    class Program
    {
        const int HowManyItensToAdd = 10_000;

        static void Main(string[] args)
        {
            CreateArrayList();

            //CreateList();

            Console.ReadKey();
        }

        private static void CreateArrayList()
        {

            ArrayList arrayList = new ArrayList();
            
            for (int i = 0; i < HowManyItensToAdd; i++)
            {
                arrayList.Add(i);
            }

            Console.WriteLine($"After CreateArrayList: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }

        private static void CreateList()
        {

            List<int> list = new List<int>();

            for (int i = 0; i < HowManyItensToAdd; i++)
            {
                list.Add(i);
            }

            Console.WriteLine($"After CreateList: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }
    }
}
