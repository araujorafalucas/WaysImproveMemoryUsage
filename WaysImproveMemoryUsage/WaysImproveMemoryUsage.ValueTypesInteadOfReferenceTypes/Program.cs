using System;

namespace WaysImproveMemoryUsage.ValueTypesInteadOfReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            TestWithObject();

            //TestWithInt();

            Console.ReadKey();

        }

        static void TestWithObject()
        {
            for (int i = 0; i < 10_000; i++)
            {
                DoSomethingWithObject(i);
            }

            Console.WriteLine($"TestWithObject : {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }

        static void DoSomethingWithObject(object param)
        {
            int paramAsInt = (int)param;

            //do some work...
        }

        static void TestWithInt()
        {
            for (int i = 0; i < 10_000; i++)
            {
                DoSomethingWithInt(i);
            }

            Console.WriteLine($"TestWithInt : {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }


        static void DoSomethingWithInt(int param)
        {            
            //do some work...
        }
    }
}
