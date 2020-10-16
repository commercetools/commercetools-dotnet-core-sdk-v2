using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Base.Client;
using commercetools.Sdk.V2Compat;
using Xunit;
using IClient = commercetools.Sdk.Client.IClient;

namespace commercetools.Sdk.BCTest
{
    [Collection("Integration Tests")]
    public class BcTest
    {
        private readonly IClient client;
        private readonly ApiRoot root;

        public BcTest(ServiceProviderFixture serviceProviderFixture)
        {
            this.client = serviceProviderFixture.GetService<IClient>();
        }
        
        [Fact]
        public async Task TestBc()
        {
            var categories = await ApiFactory.CreateForProject(new CtpV2CompatClient(client),"test-php-dev-integration-1").Categories().Get().ExecuteAsync();
            Assert.NotNull(categories);
        }
    }
}