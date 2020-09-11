using System.IO;
using System.Text.Json;
using Xunit;
using commercetools.Api.Models.Projects;

namespace commercetools.Api.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestProjectDeserialization()
        {
            //arrange
            var projectResponse = File.ReadAllText("Resources/project.json");

            //act
            var project = JsonSerializer.Deserialize<Project>(projectResponse);

            //assert
            Assert.NotNull(project);
            Assert.NotNull(project.ShippingRateInputType);
            Assert.IsType<CartScoreType>(project.ShippingRateInputType);
        }
    }
}
