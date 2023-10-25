using System;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                FunctionCache<string, int> cache = new FunctionCache<string, int>(ExpensiveFunction);

                // Example 1: Calling with the same key within the expiration time
                string key1 = "key1";
                int result1 = cache.GetResult(key1, TimeSpan.FromMinutes(5));
                int result2 = cache.GetResult(key1, TimeSpan.FromMinutes(5));

                Console.WriteLine("Result 1: " + result1); // This will call the function
                Console.WriteLine("Result 2: " + result2); // This will use the cached result

                // Example 2: Calling with a different key
                string key2 = "key2";
                int result3 = cache.GetResult(key2, TimeSpan.FromMinutes(5));

                Console.WriteLine("Result 3: " + result3); // This will call the function

                // Example 3: Calling with the same key after cache expiration
                System.Threading.Thread.Sleep(300000); // Sleep for 5 minutes
                int result4 = cache.GetResult(key1, TimeSpan.FromMinutes(5));

                Console.WriteLine("Result 4: " + result4); // This will call the function again
            }

            static int ExpensiveFunction(string key)
            {
                Console.WriteLine($"Executing expensive function for key: {key}");
                return key.GetHashCode();
            }
        }
    }
}