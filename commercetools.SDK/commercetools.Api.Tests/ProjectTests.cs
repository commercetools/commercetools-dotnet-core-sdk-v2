using System.IO;
using System.Text.Json;
using Xunit;
using commercetools.Api.Models.Projects;
using commercetools.Api.Registration;
using commercetools.Api.Serialization;

namespace commercetools.Api.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestProjectDeserialization()
        {
            //arrange
            var projectResponse = File.ReadAllText("Resources/project.json");
            var serializerService = new SerializerService(new TypeRetriever());

            //act
            var project = serializerService.Deserialize<Project>(projectResponse);

            //assert
            Assert.NotNull(project);
            Assert.NotNull(project.ShippingRateInputType);
            Assert.IsType<CartScoreType>(project.ShippingRateInputType);
        }
    }
}
