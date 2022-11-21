using Xunit;

namespace CountryAPI.Test
{
    public class ClientTest
    {
        [Fact]
        public async Task GetCountryAsync_ExistingCode()
        {
            string code = "md";

            var result = await Client.GetCountryAsync(code);
            Xunit.Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCountryAsync_NonExistentCode()
        {
            string code = "aaa";

            var result = await Client.GetCountryAsync(code);
            Xunit.Assert.Null(result);
        }
    }
}
