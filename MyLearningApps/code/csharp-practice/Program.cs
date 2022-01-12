using System;

namespace csharp_practice
{
    class Program
    {
        static void Main1(string[] args)
        {
            TestTryCatch();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }


        public static void TestTryCatch()
        {
            int a = 0;
            try
            {
                int x = 4;
                int y;
                try
                {
                    y = x / a;
                }
                catch (Exception e)
                {
                    Console.WriteLine("inner ex");
                    //throw;   // Line 1
                    throw e;   // Line 2
                    //throw new Exception("divide by 0");  // Line 3
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("outer ex");
                throw ex;
            }
        }
    }
}
