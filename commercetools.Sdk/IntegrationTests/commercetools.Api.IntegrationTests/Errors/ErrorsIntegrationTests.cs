using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using static commercetools.Api.IntegrationTests.Categories.CategoriesFixture;

namespace commercetools.Api.IntegrationTests.Errors
{
    [Collection("Integration Tests")]
    public class ErrorsIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public ErrorsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CheckConcurrentModificationException()
        {
            await WithUpdateableCategory(_client, async category =>
            {
                Assert.NotNull(category);

                var name = TestingUtility.RandomString();
                var action = new CategoryChangeNameAction
                {
                    Name = new LocalizedString { { "en", name } }
                };
                var update = new CategoryUpdate
                {
                    Version = category.Version,
                    Actions = new List<ICategoryUpdateAction> { action }
                };

                var updatedCategory = await _client.WithApi(_projectKey)
                    .Categories()
                    .WithKey(category.Key)
                    .Post(update)
                    .ExecuteAsync();


                Assert.Equal(name, updatedCategory.Name["en"]);

                try
                {
                    //do the same update again with the same version
                    await _client.WithApi(_projectKey)
                        .Categories()
                        .WithKey(category.Key)
                        .Post(update)
                        .ExecuteAsync();
                }
                catch (ConcurrentModificationException ex)
                {
                    var errorResponse = ex.AsErrorResponse();
                    Assert.NotNull(errorResponse);
                    Assert.Single(errorResponse.Errors);
                    var error = errorResponse.Errors.FirstOrDefault() as ConcurrentModificationError;
                    Assert.NotNull(error);
                    Assert.Equal(2, error.CurrentVersion);
                }
                return updatedCategory;
            });
        }
    }
}