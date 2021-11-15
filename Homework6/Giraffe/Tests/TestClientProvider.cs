using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Giraffe;

namespace WebAppTests
{
    public class TestClientProvider
    {
        public TestClientProvider()
        {
            var er = new WebApplicationFactory<App.Startup>();
            Client = er.CreateClient();
        }

        public HttpClient Client { get; }
    }
}