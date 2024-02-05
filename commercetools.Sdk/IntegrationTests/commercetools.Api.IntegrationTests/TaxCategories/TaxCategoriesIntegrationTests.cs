using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.TaxCategories;
using Xunit;
using static commercetools.Api.IntegrationTests.TaxCategories.TaxCategoriesFixtures;

namespace commercetools.Api.IntegrationTests.TaxCategories
{
    [Collection("Integration Tests")]
    public class TaxCategoriesIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public TaxCategoriesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateTaxCategories()
        {
            var key = $"CreateTaxCategories-{TestingUtility.RandomString()}";
            await WithTaxCategory(
                _client, taxCategoryDraft => DefaultTaxCategoriesDraftWithKey(taxCategoryDraft, key),
                taxCategory => { Assert.Equal(key, taxCategory.Key); }
            );
        }

        [Fact]
        public async Task GetTaxCategoriesById()
        {
            var key = $"GetTaxCategoriesById-{TestingUtility.RandomString()}";
            await WithTaxCategory(
                _client,
                taxCategoryDraft => DefaultTaxCategoriesDraftWithKey(taxCategoryDraft, key),
                async taxCategory =>
                {
                    Assert.NotNull(taxCategory);
                    var retrievedTaxCategories = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .TaxCategories()
                        .WithId(taxCategory.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedTaxCategories);
                    Assert.Equal(key, retrievedTaxCategories.Key);
                }
            );
        }

        [Fact]
        public async Task QueryTaxCategories()
        {
            var key = $"QueryTaxCategory-{TestingUtility.RandomString()}";
            await WithTaxCategory(
                _client,
                taxCategoryDraft => DefaultTaxCategoriesDraftWithKey(taxCategoryDraft, key),
                async taxCategory =>
                {
                    Assert.NotNull(taxCategory);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .TaxCategories()
                        .Get()
                        .WithQuery(q => q.Key().Is(taxCategory.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateTaxCategoriesByIdChangeDescription()
        {
            await WithUpdateableTaxCategory(
                _client,
                async taxCategory =>
                {
                    Assert.NotNull(taxCategory);
                    var name = $"Test-Desc-{TestingUtility.RandomString()}";
                    var action = new TaxCategorySetDescriptionAction()
                    {
                        Action = "setDescription",
                        Description = name,
                    };

                    var update = new TaxCategoryUpdate()
                    {
                        Version = taxCategory.Version,
                        Actions = new List<ITaxCategoryUpdateAction>() { action }
                    };

                    var updatedTaxCategory = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .TaxCategories()
                        .WithId(taxCategory.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedTaxCategory.Description, name);
                    return updatedTaxCategory;
                }
            );
        }
    }
}