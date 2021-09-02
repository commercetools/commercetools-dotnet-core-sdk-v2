using System.IO;
using System.Threading.Tasks;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.HttpApi;
using commercetools.Sdk.Serialization;
using commercetools.Sdk.V2Compat;
using Xunit;
using IClient = commercetools.Sdk.Client.IClient;

namespace commercetools.Sdk.BCTest
{
    [Collection("Integration Tests")]
    public class BcTest
    {
        private readonly IClient client;
        private readonly IClientConfiguration clientConfiguration;
        private readonly ISerializerService _serializerService;

        public BcTest(ServiceProviderFixture serviceProviderFixture)
        {
            this.client = serviceProviderFixture.GetService<IClient>();
            this._serializerService = serviceProviderFixture.GetService<ISerializerService>();
            this.clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
        }

        [Fact]
        public async Task TestBc()
        {
            var projectKey = this.clientConfiguration.ProjectKey;
            var categories = await ApiFactory
                .CreateForProject(new CtpV2CompatClient(client), projectKey)
                .Categories()
                .Get()
                .ExecuteAsync();
            Assert.NotNull(categories);
        }

        [Fact]
        public void TestEnumDeserialization()
        {
            var json = "{\"typeId\" : \"category\"}";
            var refTypeId = _serializerService.Deserialize<IReferenceTypeId>(json);
            Assert.NotNull(refTypeId);
        }

        [Fact]
        public void TestEnumDeserialization2()
        {
            var json = "{\"typeId\" : \"category\", \"id\": \"6b0aae40-29dc-4236-8065-80abab12f959\"}";
            var icategoryRef = _serializerService.Deserialize<ICategoryReference>(json);
            Assert.NotNull(icategoryRef);
        }

        [Fact]
        public void TestCategoryDeseralization()
        {
            var json = File.ReadAllText("Resources/category.json");
            var category = _serializerService.Deserialize<ICategory>(json);
            Assert.NotNull(category);
        }
    }
}