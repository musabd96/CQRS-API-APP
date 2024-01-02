using Domain.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System.Net;
using Xunit;

namespace Test.IntegrationTests
{
    public class BirdsControllerIntegrationTests : WebApplicationFactory<Program>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public BirdsControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
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
            var content = await response.Content.ReadAsStringAsync();
            var birds = JsonConvert.DeserializeObject<List<Bird>>(content);

            // Assert
            response.EnsureSuccessStatusCode();
            Xunit.Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Xunit.Assert.NotNull(birds);
        }
    }
}
