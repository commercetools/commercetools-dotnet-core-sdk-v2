﻿using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Base.Client;
using Xunit;

namespace commercetools.Api.IntegrationTests.Categories
{
    [Collection("Integration Tests")]
    public class CategoriesIntegrationTests
    {
        private readonly IClient client;
        private readonly ServiceProviderFixture serviceProviderFixture;

        public CategoriesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this.serviceProviderFixture = serviceProviderFixture;
            this.client = serviceProviderFixture.GetService<IClient>();
        }

        [Fact]
        public async Task GetCategoryById()
        {
            // Arrange
            var projectKey = serviceProviderFixture.GetClientConfiguration("Client").ProjectKey;
            //var categoryId = "4cabe415-74c3-4a3f-88c7-32bb0133ea08";
            var categoryId = "02ed9a7d-7c1f-40da-b2b7-4cca6752bf29";

            //Act
            var category = await client.ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .WithId(categoryId)
                            .Get()
                            .ExecuteAsync();
            //Assert
            Assert.NotNull(category);
            Assert.Equal(categoryId, category.Id);
        }
        
        [Fact]
        public async Task GetCategoryById2()
        {
            // Arrange
            var projectKey = serviceProviderFixture.GetClientConfiguration("Client").ProjectKey;
            var categoryId = "02ed9a7d-7c1f-40da-b2b7-4cca6752bf29";

            //Act
            var category = await client.ApiRoot()
                .WithProjectKey(projectKey)
                .Categories()
                .WithId(categoryId)
                .Get()
                .ExecuteAsync();
            //Assert
            Assert.NotNull(category);
            Assert.Equal(categoryId, category.Id);
        }
    }
}
