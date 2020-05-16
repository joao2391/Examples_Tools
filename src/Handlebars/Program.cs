using System;

namespace Handlebars_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string basic = BasicUsage.Result();
            string partial = Partials.Result();
            string helpers = Helpers.Result();
            string blockHelper = BlockHelpers.Result();

            Console.WriteLine(basic);
            Console.WriteLine();
            Console.WriteLine(partial);
            Console.WriteLine();
            Console.WriteLine(helpers);
            Console.WriteLine();
            Console.WriteLine(blockHelper);

            Console.ReadKey();

        }
    }
}
