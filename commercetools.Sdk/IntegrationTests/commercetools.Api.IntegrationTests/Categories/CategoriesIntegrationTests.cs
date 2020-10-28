using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Base.Client;
using Xunit;
using static commercetools.Api.IntegrationTests.Categories.CategoriesFixture;

namespace commercetools.Api.IntegrationTests.Categories
{
    [Collection("Integration Tests")]
    public class CategoriesIntegrationTests
    {
        private readonly IClient client;
        private readonly ServiceProviderFixture serviceProviderFixture;
        private readonly string projectKey;

        public CategoriesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this.serviceProviderFixture = serviceProviderFixture;
            this.client = serviceProviderFixture.GetService<IClient>();
            var clientConfiguration = this.serviceProviderFixture.GetClientConfiguration("Client");
            this.projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCategory()
        {
            var key = $"CreateCategory-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                category =>
                {
                    Assert.Equal(key, category.Key);
                });
        }

        [Fact]
        public async Task GetCategoryById()
        {
            var key = $"GetCategoryById-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var retrievedCategory = await client.ApiRoot().WithProjectKey(projectKey)
                        .Categories()
                        .WithId(category.Id)
                        .Get()
                        .ExecuteAsync();
                    
                    Assert.NotNull(retrievedCategory);
                    Assert.Equal(key, retrievedCategory.Key);
                });
        }

        [Fact]
        public async Task GetCategoryByKey()
        {
            var key = $"GetCategoryByKey-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var retrievedCategory = await client.ApiRoot().WithProjectKey(projectKey)
                        .Categories()
                        .WithKey(category.Key)
                        .Get()
                        .ExecuteAsync();
                    
                    Assert.NotNull(retrievedCategory);
                    Assert.Equal(key, retrievedCategory.Key);
                });
        }
        
        [Fact]
        public async Task QueryCategories()
        {
            var key = $"QueryCategories-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var returnedSet = await client.ApiRoot().WithProjectKey(projectKey)
                        .Categories()
                        .Get()
                        .WithWhere($"key = \"{category.Key}\"")
                        .ExecuteAsync();
                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }
        
        [Fact]
        public async Task QueryCategoryByParentAndExpandIt()
        {
            await WithCategory(client, async parentCategory =>
            {
                await WithCategory(
                    client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory),
                    async category =>
                    {
                        Assert.NotNull(category);
                        
                        var returnedSet = await client.ApiRoot().WithProjectKey(projectKey)
                            .Categories()
                            .Get()
                            .WithWhere($"key = \"{category.Key}\"")
                            .WithExpand("parent")
                            .ExecuteAsync();
                        
                        Assert.Single(returnedSet.Results);
                        var retrievedCategory = returnedSet.Results[0];
                        Assert.Equal(category.Key, retrievedCategory.Key);
                        Assert.NotNull(retrievedCategory.Parent);
                        Assert.Equal(parentCategory.Id, retrievedCategory.Parent.Id);
                    });
            });
        }
        
        [Fact]
        public async Task QueryCategoriesByParentAndSort()
        {
            var count = 3;
            await WithCategory(client, async parentCategory =>
            {
                await WithListOfCategories(
                    client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        Assert.Equal(count, categoriesList.Count);
                        var orderedCategoriesNames =
                            categoriesList.OrderBy(c => c.Name["en"]).Select(c => c.Name["en"]).ToList();
                        
                        var returnedSet = await client.ApiRoot().WithProjectKey(projectKey)
                            .Categories()
                            .Get()
                            .WithWhere($"parent(id = \"{parentCategory.Id}\")")
                            .WithExpand("parent")
                            .WithSort("name.en asc")
                            .ExecuteAsync();
                        
                        var categoriesResult = returnedSet.Results;
                        Assert.Equal(count, categoriesResult.Count);
                        Assert.NotNull(categoriesList[0].Parent);
                        Assert.Equal(parentCategory.Id, categoriesResult[0].Parent.Id);
                        var returnedCategoriesNames = categoriesResult.Select(c => c.Name["en"]).ToList();
                        Assert.True(returnedCategoriesNames.SequenceEqual(orderedCategoriesNames));
                    });
            });
        }
        
        [Fact]
        public async Task QueryCategoriesByParentAndSortDescending()
        {
            var count = 3;
            await WithCategory(client, async parentCategory =>
            {
                await WithListOfCategories(
                    client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        Assert.Equal(count, categoriesList.Count);
                        var orderedCategoriesNames =
                            categoriesList.OrderByDescending(c => c.Name["en"]).Select(c => c.Name["en"]).ToList();
                        
                        var returnedSet = await client.ApiRoot().WithProjectKey(projectKey)
                            .Categories()
                            .Get()
                            .WithWhere($"parent(id = \"{parentCategory.Id}\")")
                            .WithExpand("parent")
                            .WithSort("name.en desc")
                            .ExecuteAsync();
                        
                        var categoriesResult = returnedSet.Results;
                        Assert.Equal(count, categoriesResult.Count);
                        Assert.NotNull(categoriesList[0].Parent);
                        Assert.Equal(parentCategory.Id, categoriesResult[0].Parent.Id);
                        var returnedCategoriesNames = categoriesResult.Select(c => c.Name["en"]).ToList();
                        Assert.True(returnedCategoriesNames.SequenceEqual(orderedCategoriesNames));
                    });
            });
        }
        
        [Fact]
        public async Task QueryCategoriesByParentAndLimit()
        {
            var count = 3;
            await WithCategory(client, async parentCategory =>
            {
                await WithListOfCategories(
                    client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        var limit = count - 1;
                        Assert.Equal(count, categoriesList.Count);
                        
                        var returnedSet = await client.ApiRoot().WithProjectKey(projectKey)
                            .Categories()
                            .Get()
                            .WithWhere($"parent(id = \"{parentCategory.Id}\")")
                            .WithExpand("parent")
                            .WithLimit(limit)
                            .WithWithTotal(true)
                            .ExecuteAsync();
                        
                        Assert.Equal(limit, returnedSet.Count);
                        Assert.Equal(limit, returnedSet.Limit);
                        Assert.Equal(count, returnedSet.Total);

                        var categoriesResult = returnedSet.Results;
                        Assert.NotNull(categoriesList[0].Parent);
                        Assert.Equal(parentCategory.Id, categoriesResult[0].Parent.Id);
                    });
            });
        }
        
        [Fact]
        public async Task DeleteCategoryById()
        {
            var key = $"DeleteCategoryById-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);

                    await client.ApiRoot().WithProjectKey(projectKey)
                        .Categories()
                        .WithId(category.Id)
                        .Delete()
                        .WithVersion(category.Version)
                        .ExecuteAsync();
                    
                    await Assert.ThrowsAsync<Exception>(
                        () => client.ApiRoot().WithProjectKey(projectKey).Categories().WithId(category.Id).Get().ExecuteAsync());
                });
        }
        
        [Fact]
        public async Task DeleteCategoryByKey()
        {
            var key = $"DeleteCategoryByKey-{TestingUtility.RandomString()}";
            await WithCategory(
                client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);

                    await client.ApiRoot().WithProjectKey(projectKey)
                        .Categories()
                        .WithKey(category.Key)
                        .Delete()
                        .WithVersion(category.Version)
                        .ExecuteAsync();
                    
                    await Assert.ThrowsAsync<Exception>(
                        () => client.ApiRoot().WithProjectKey(projectKey).Categories().WithId(category.Id).Get().ExecuteAsync());
                });
        }
        
        #region UpdateActions

        [Fact]
        public async Task UpdateCategoryByKeyChangeName()
        {
            await WithUpdateableCategory(client, async category =>
            {
                Assert.NotNull(category);
                
                var name = TestingUtility.RandomString();
                var action = new CategoryChangeNameAction
                {
                    Name = new LocalizedString {{"en", name}}
                };
                var update = new CategoryUpdate
                {
                    Version = category.Version,
                    Actions = new List<ICategoryUpdateAction> {action}
                };

                var updatedCategory = await client.ApiRoot().WithProjectKey(projectKey)
                    .Categories()
                    .WithKey(category.Key)
                    .Post(update)
                    .ExecuteAsync();
                    

                Assert.Equal(name, updatedCategory.Name["en"]);
                return updatedCategory;
            });
        }
        #endregion
    }
}