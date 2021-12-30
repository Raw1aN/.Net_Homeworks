using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace HW12
{
    public class HostBuilderFSharp : WebApplicationFactory<Giraffe.App.Startup>
    {
        protected override IHostBuilder CreateHostBuilder()
            => Host
                .CreateDefaultBuilder()
                .ConfigureWebHostDefaults(a => a
                    .UseStartup<Giraffe.App.Startup>()
                    .UseTestServer());
    }

    public class HostBuilderCSharp : WebApplicationFactory<Classwork_26._10._21.Startup>
    {
        protected override IHostBuilder CreateHostBuilder()
            => Host
                .CreateDefaultBuilder()
                .ConfigureWebHostDefaults(a => a
                    .UseStartup<Classwork_26._10._21.Startup>()
                    .UseTestServer());
    }

    [MinColumn]
    [MaxColumn]
    [MedianColumn]
    public class Benchmark
    {
        private HttpClient CSharpClient;
        private HttpClient FSharpClient;

        [GlobalSetup]
        public void GlobalSetUp()
        {
            CSharpClient = new HostBuilderCSharp().CreateClient();
            FSharpClient = new HostBuilderFSharp().CreateClient();
        }

        [Benchmark]
        public async Task AddInCSharp()
        {
            await SendRequestCSharp("5", "+", "8");
        }

        [Benchmark]
        public async Task AddInFSharp()
        {
            await SendRequestFSharp("5", "+", "8");
        }

        [Benchmark]
        public async Task MinInCSharp()
        {
            await SendRequestCSharp("5", "-", "8");
        }

        [Benchmark]
        public async Task MinInFSharp()
        {
            await SendRequestFSharp("10", "-", "1");
        }

        [Benchmark]
        public async Task MulInCSharp()
        {
            await SendRequestCSharp("5", "*", "8");
        }

        [Benchmark]
        public async Task MultiplyInFSharp()
        {
            await SendRequestFSharp("5", "*", "8");
        }

        private async Task SendRequestFSharp(string v1, string operation, string v2)
        {
            await FSharpClient.GetAsync($"https://localhost:5000/calc?v1={v1}&operation={operation}&v2={v2}");
        }

        private async Task SendRequestCSharp(string v1, string operation, string v2)
        {
            await CSharpClient.GetAsync($"https://localhost:5001/calc/calculate?val1={v1}&operation={operation}&val2={v2}");
            //https://localhost:5001/calc/calculate?val1=1&operation=/&val2=2
        }
    }
}