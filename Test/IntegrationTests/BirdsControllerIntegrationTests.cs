using Domain.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Test.IntegrationTests
{
    public class BirdsControllerIntegrationTests : WebApplicationFactory<Program>
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            return base.CreateHostBuilder()
                       .UseEnvironment("Testing")
                       .ConfigureAppConfiguration((context, config) =>
                       {

                       });
        }

        [Fact]
        public async Task GetAllBirds_ReturnsSuccessStatusCode()
        {
            // Arrange
            var client = CreateClient();

            // Act
            var response = await client.GetAsync("/getAllBirds");

            // Assert
            response.EnsureSuccessStatusCode();
            Xunit.Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetAllBirds_ReturnsCorrectContent()
        {
            // Arrange
            var client = CreateClient();

            // Act
            var response = await client.GetAsync("/getAllBirds");

            // Assert
            response.EnsureSuccessStatusCode();

            // Read the response content
            var content = await response.Content.ReadAsStringAsync();

            // Deserialize the content to a list of Bird objects
            var birds = JsonConvert.DeserializeObject<List<Bird>>(content);

            // Assert
            Xunit.Assert.NotNull(birds);
        }
    }
}
