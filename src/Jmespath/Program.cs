using System;

namespace Jmespath
{
    class Program
    {
        static void Main(string[] args)
        {   
            string resultJson = BasicExpressions.Transform();

            Console.WriteLine(resultJson);

            Console.ReadKey();
        }
    }
}
