using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Classwork_26._10._21;
using Xunit;

public class UnitTest1
{
    public class HostBuilder : WebApplicationFactory<Startup>
    {
        protected override IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(x => x.UseStartup<Startup>().UseTestServer());
    }
    
    public class IntegrationTests8 : IClassFixture<HostBuilder>
    {
        private readonly HttpClient _client;
        public IntegrationTests8(HostBuilder server)
        {
            _client = server.CreateClient();
        }
        
        [Theory]
        [InlineData("10", "5", "/", "2")]
        [InlineData("10", "5", "-",  "5")]
        [InlineData("10", "5", "/", "2")]
        [InlineData("10", "5", "*", "50")]
        public async Task Calculate_CorrectArguments_CorrectResultReturned(string val1, string val2, string operation, string expected)
        {
            var response = await _client.GetAsync($"https://localhost:5001/calc/calculate?val1={val1}&operation={operation}&val2={val2}");
            var actual = await response.Content.ReadAsStringAsync();
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("10", "5", "%", "Wrong operation")]
        [InlineData("10", "0", "/",  "Divide by zero")]
        [InlineData("10", "/", "%", "Wrong arguments")]
        [InlineData("%", "/", "5", "Wrong arguments")]
        public async Task Calculate_IncorrectArguments_ExceptionStringReturned(string val1, string val2, string operation, string expected)
        {
            var response = await _client.GetAsync($"https://localhost:5001/calc/calculate?val1={val1}&operation={operation}&val2={val2}");
            var actual = await response.Content.ReadAsStringAsync();
            Assert.Equal(expected, actual);
        }
    }
}