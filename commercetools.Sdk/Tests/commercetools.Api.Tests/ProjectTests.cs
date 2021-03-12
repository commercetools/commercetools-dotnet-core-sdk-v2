using System.IO;
using Xunit;
using commercetools.Api.Models.Projects;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestProjectDeserialization()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            //arrange
            var projectResponse = File.ReadAllText("Resources/project.json");
            var serializerService = p.GetService<ISerializerService>();

            //act
            var project = serializerService.Deserialize<Project>(projectResponse);

            //assert
            Assert.NotNull(project);
            Assert.NotNull(project.ShippingRateInputType);
            Assert.IsType<CartScoreType>(project.ShippingRateInputType);
        }
    }
}
