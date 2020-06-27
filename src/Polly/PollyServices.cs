using Polly;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Polly_Ex
{
    public class PollyServices
    {

        public void Teste()
        {
            HttpClient client = new HttpClient();
            string url = "https://www.google.com.br/";

            HttpResponseMessage response = client.GetAsync(url).Result;
            



            var x = Policy.Handle<HttpRequestException>();
            
        }
    }
}
