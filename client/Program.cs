using client.localhost;
using System;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceLemonway obj = new WebServiceLemonway();
            Console.WriteLine("Enter number:");
            long value1 = Convert.ToInt64(Console.ReadLine());
            var result = obj.Fibonacci(value1);
            Console.WriteLine("Fibonacci number is:"+result);
            Console.WriteLine("Enter XML:");
            string value2 = Console.ReadLine();
            string result2 = obj.XmlToJson(value2);
            Console.WriteLine("The Jason format is:" + result2);
            Console.ReadKey();
        }
    }
}
