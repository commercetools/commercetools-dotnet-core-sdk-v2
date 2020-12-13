using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Base.Client;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;
using static commercetools.Api.IntegrationTests.Products.ProductTypesFixture;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.ProductProjectionSearch
{
    [Collection("Integration Tests")]
    public class ProductProjectionSearchIntegrationTests
    {
        public const string KeyPrefix = "EntityForSearch";
        public readonly string KeyProductType = $"{KeyPrefix}_ProductType";
        public readonly string KeyLocalizedProduct = $"{KeyPrefix}_localizedProduct";
        
        private readonly IClient client;
        private readonly ServiceProviderFixture serviceProviderFixture;
        private readonly string projectKey;

        public ProductProjectionSearchIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this.serviceProviderFixture = serviceProviderFixture;
            this.client = serviceProviderFixture.GetService<IClient>();
            var clientConfiguration = this.serviceProviderFixture.GetClientConfiguration("Client");
            this.projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task SearchByFullLocale()
        {
            //Arrange
            var productType = await CreateOrRetrieveProductType(client, new ProductTypeDraft
            {
                Key = KeyProductType,
                Name = "SearchProductType",
                Description = "SearchProductType"
            });
            var localizedName = new LocalizedString() {{"en", "apricot"}, {"de", "Aprikose"}};
            var productDraft = new ProductDraft
            {
                Key = KeyLocalizedProduct,
                Name = localizedName,
                ProductType = new ProductTypeResourceIdentifier { Key = productType.Key },
                Slug = new LocalizedString
                {
                    {"en", $"Slug_{KeyLocalizedProduct}"},
                    {"de", $"Slug_de_{KeyLocalizedProduct}"}
                }
            };
            var product = await CreateOrRetrieveProduct(client, productDraft);
            Assert.NotNull(product);

            await AssertEventuallyAsync(async () =>
            {
                //Act
                var searchResult = await client.ApiRoot()
                    .WithProjectKey(projectKey)
                    .ProductProjections()
                    .Search()
                    .Get()
                    .WithStaged(true)
                    .AddQueryParam("text.de", localizedName["de"])
                    .WithFilterQuery($"id:\"{product.Id}\"")
                    .ExecuteAsync();
            
                //Assert
                Assert.NotNull(searchResult);
                Assert.Single(searchResult.Results);
                Assert.Equal(product.Id, searchResult.Results[0].Id);
                Assert.Equal(localizedName["en"], searchResult.Results[0].Name["en"]);
 
            });
        }
    }
}