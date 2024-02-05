using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductDiscounts;
using Xunit;
using static commercetools.Api.IntegrationTests.ProductDiscount.ProductDiscountFixtures;

namespace commercetools.Api.IntegrationTests.ProductDiscount
{
    [Collection("Integration Tests")]
    public class ProductDiscountIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public ProductDiscountIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateProductDiscount()
        {
            var key = $"CreateProductDiscount-{TestingUtility.RandomString()}";
            await WithProductDiscount(
                _client, productDiscountDraft => DefaultProductDiscountDraftWithKey(productDiscountDraft, key),
                productDiscount => { Assert.Equal(key, productDiscount.Key); }
            );
        }

        [Fact]
        public async Task GetProductDiscountById()
        {
            var key = $"GetProductDiscountById-{TestingUtility.RandomString()}";
            await WithProductDiscount(
                _client,
                productDiscountDraft => DefaultProductDiscountDraftWithKey(productDiscountDraft, key),
                async productDiscount =>
                {
                    Assert.NotNull(productDiscount);
                    var retrievedProductDiscount = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .ProductDiscounts()
                        .WithId(productDiscount.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedProductDiscount);
                    Assert.Equal(key, retrievedProductDiscount.Key);
                }
            );
        }

        [Fact]
        public async Task QueryProductDiscount()
        {
            var key = $"QueryProductDiscounts-{TestingUtility.RandomString()}";
            await WithProductDiscount(
                _client,
                productDiscountDraft => DefaultProductDiscountDraftWithKey(productDiscountDraft, key),
                async productDiscount =>
                {
                    Assert.NotNull(productDiscount);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .ProductDiscounts()
                        .Get()
                        .WithQuery(q => q.Key().Is(productDiscount.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateProductDiscountByIdChangeDescription()
        {
            await WithUpdateableProductDiscount(
                _client,
                async productDiscount =>
                {
                    Assert.NotNull(productDiscount);
                    var name = $"{TestingUtility.RandomString()}";
                    var action = new ProductDiscountSetDescriptionAction()
                    {
                        Action = "setDescription",
                        Description = new LocalizedString() { { "en", name } }
                    };

                    var update = new ProductDiscountUpdate()
                    {
                        Version = productDiscount.Version,
                        Actions = new List<IProductDiscountUpdateAction>() { action }
                    };

                    var updatedProductDiscount = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .ProductDiscounts()
                        .WithId(productDiscount.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedProductDiscount.Description, new LocalizedString() { { "en", name } });
                    return updatedProductDiscount;
                }
            );
        }
    }
}