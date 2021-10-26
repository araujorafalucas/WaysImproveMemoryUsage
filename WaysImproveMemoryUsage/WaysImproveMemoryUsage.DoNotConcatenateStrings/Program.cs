using System;
using System.Diagnostics;
using System.Text;

namespace WaysImproveMemoryUsage.DoNotConcatenateStrings
{
    class Program
    {
        const int TimesToConcatenate = 10_000;        

        static void Main(string[] args)
        {
            //run one by one 

            //RegularConcatenation();

            ConcatenationWithStrinBuilder();           

            Console.ReadKey();
        }        

        private static void RegularConcatenation()
        {

            string someText = string.Empty;
            for (int i = 0; i < 10_000; i++)
            {
                someText += "sometexttoconcatenate";
            }

            Console.WriteLine($"After RegularConcatenation: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }

        private static void ConcatenationWithStrinBuilder()
        {           

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10_000; i++)
            {
                stringBuilder.Append("sometexttoconcatenate");
            }

            Console.WriteLine($"After ConcatenationWithStrinbBuilder: {GC.GetTotalMemory(false) / 1000m / 1000m}mb");
        }

        


    }
}
