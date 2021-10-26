using System;
using System.Net.Http;
using System.Threading.Tasks;

        static async Task DoRequest()
        {
            var httpClient = new HttpClient();

            var response = await httpClient
                .GetAsync("http://localhost:5000/add?v1=1&v2=2");
            var str = await response.Content
                .ReadAsStringAsync();

            Console.WriteLine(str);
        }
        
        await DoRequest();