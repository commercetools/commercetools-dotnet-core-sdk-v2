using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;
using static commercetools.Api.IntegrationTests.ProductTypes.ProductTypesFixture;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.ProductProjectionSearch
{
    [Collection("Integration Tests")]
    public class ProductProjectionSearchIntegrationTests
    {
        public const string KeyPrefix = "EntityForSearch";
        public readonly string KeyProductType = $"{KeyPrefix}_ProductType";
        public readonly string KeyLocalizedProduct = $"{KeyPrefix}_localizedProduct";

        private readonly IClient _client;
        private readonly string _projectKey;
        private readonly ProjectApiRoot _apiRoot;

        public ProductProjectionSearchIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._apiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task SearchByFullLocale()
        {
            //Arrange
            var productType = await CreateOrRetrieveProductType(_client, new ProductTypeDraft
            {
                Key = KeyProductType,
                Name = "SearchProductType",
                Description = "SearchProductType"
            });
            var localizedName = new LocalizedString() { { "en", "apricot" }, { "de", "Aprikose" } };
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
            var product = await CreateOrRetrieveProduct(_client, productDraft);
            Assert.NotNull(product);

            await AssertEventuallyAsync(async () =>
            {
                //Act
                var searchResult = await _client.WithApi()
                    .WithProjectKey(_projectKey)
                    .ProductProjections()
                    .Search()
                    .Get()
                    .WithStaged(true)
                    .AddQueryParam("text.de", localizedName["de"])
                    .WithFilter($"key:\"{KeyLocalizedProduct}\"")
                    .ExecuteAsync();

                //Assert
                Assert.NotNull(searchResult);
                Assert.Single(searchResult.Results);
                Assert.Equal(product.Id, searchResult.Results[0].Id);
                Assert.Equal(localizedName["en"], searchResult.Results[0].Name["en"]);

            });

            var r = _apiRoot.StandalonePrices().Get()
                .WithQuery(q => q.Key().IsInVar("keys"), new Dictionary<string, IEnumerable<string>>()
                {
                    {
                        "keys", new []
                        {
                            "166380","166382","166388","166390"
                        }
                    }
                }).Build();
            Assert.Contains("standalone-prices?where=key%20in%20%3Akeys&var.keys=166380&var.keys=166382&var.keys=166388&var.keys=166390", r.RequestUri.ToString());
        }

        [Fact]
        public Task SearchPost()
        {
            var request = _client.WithApi().WithProjectKey(_projectKey).ProductProjections().Search()
                .Post()
                .AddFormParam("filter", "test")
                .AddFormParam("filter", "test2")
                .Build();
            Assert.Equal("application/x-www-form-urlencoded", request.Content.Headers.GetValues(ApiHttpHeaders.CONTENT_TYPE).First());
            Assert.Equal("filter=test&filter=test2", request.Content.ReadAsStringAsync().Result);
            return Task.CompletedTask;
        }
    }
}