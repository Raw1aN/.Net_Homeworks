using System.Net;
using System.Threading.Tasks;
using Giraffe;
using WebAppTests;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData("13", "-", "21", "-8.0")]
        [InlineData("9", "-", "5", "4.0")]
        [InlineData("10", "*", "2", "20.0")]
        [InlineData("10", "/", "5", "2.0")]
        public async Task AllIsGood(string v1, string operation, string v2, string expect)
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync($"https://localhost:5001/calc?v1={v1}&Operation={operation}&v2={v2}");
            var result = response.Content.ReadAsStringAsync().Result;
            Assert.Equal(result, expect);
        }
    }
}