using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://www.receitaws.com.br/v1/cnpj/27865757000102");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("application/json").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(response.Content);
                Console.ReadLine();
            }

        }
    }
}
