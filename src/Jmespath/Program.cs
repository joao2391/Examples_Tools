using System;
using System.Net.Http;
using DevLab.JmesPath;


namespace Jmespath
{
    class Program
    {
        static void Main(string[] args)
        {            
            HttpClient client = new HttpClient();
            var result = client.GetAsync("https://jsonplaceholder.typicode.com/todos/1")
                        .Result.Content.ReadAsStringAsync().Result;
            
            const string expression = "@.title";

            var jmes = new JmesPath();            
            var resultJson = jmes.Transform(result, expression);

            Console.WriteLine(resultJson);
            Console.ReadKey();
        }
    }
}
