using System;

namespace WaysImproveMemoryUsage.SetNull
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProduct = new Product()
            {
                Id = 1
            };

            myProduct.DoSomeWork();
            myProduct = null;

            //more work

        }
    }


    internal class Product
    {
        public int Id { get; init; }

        public void DoSomeWork()
        {
            //do some work
        }
    }
}
