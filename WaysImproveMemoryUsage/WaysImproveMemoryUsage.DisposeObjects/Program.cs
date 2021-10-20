using System;
using System.Data.SqlClient;

namespace WaysImproveMemoryUsage.DisposeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            CallDisposeDirectly();

            UsingStatement();            
        }

        private static void CallDisposeDirectly()
        {
            var myDatabaseConnection = new SqlConnection();
            myDatabaseConnection.Dispose();
            
        }

        private static void UsingStatement()
        {
            using (var myDatabaseConnection = new SqlConnection())
            {
                //do something with connection
            }
        }
    }
}
