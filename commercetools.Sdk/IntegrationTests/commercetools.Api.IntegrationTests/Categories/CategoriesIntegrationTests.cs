using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using static commercetools.Api.IntegrationTests.Categories.CategoriesFixture;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Categories
{
    [Collection("Integration Tests")]
    public class CategoriesIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CategoriesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCategory()
        {
            var key = $"CreateCategory-{TestingUtility.RandomString()}";
            await WithCategory(
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
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
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var retrievedCategory = await _client.WithApi().WithProjectKey(_projectKey)
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
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var retrievedCategory = await _client.WithApi(_projectKey)
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
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
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
            await WithCategory(_client, async parentCategory =>
            {
                await WithCategory(
                    _client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory),
                    async category =>
                    {
                        Assert.NotNull(category);

                        var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
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
                        Assert.Equal(IReferenceTypeId.Category, retrievedCategory.Parent.TypeId);
                        Assert.NotNull(retrievedCategory.Parent.TypeId.Value);
                        Assert.Equal(ReferenceTypeId.Category, retrievedCategory.Parent.TypeId.Value);
                    });
            });
        }

        [Fact]
        public async Task QueryCategoriesByParentAndSort()
        {
            var count = 3;
            await WithCategory(_client, async parentCategory =>
            {
                await WithListOfCategories(
                    _client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        Assert.Equal(count, categoriesList.Count);
                        var orderedCategoriesNames =
                            categoriesList.OrderBy(c => c.Name["en"]).Select(c => c.Name["en"]).ToList();

                        var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
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
            await WithCategory(_client, async parentCategory =>
            {
                await WithListOfCategories(
                    _client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        Assert.Equal(count, categoriesList.Count);
                        var orderedCategoriesNames =
                            categoriesList.OrderByDescending(c => c.Name["en"]).Select(c => c.Name["en"]).ToList();

                        var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
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
            await WithCategory(_client, async parentCategory =>
            {
                await WithListOfCategories(
                    _client, categoryDraft => DefaultCategoryDraftWithParent(categoryDraft, parentCategory), count,
                    async categoriesList =>
                    {
                        var limit = count - 1;
                        Assert.Equal(count, categoriesList.Count);

                        await AssertEventuallyAsync(async () =>
                        {
                            var returnedSet = await _client.WithApi().WithProjectKey(_projectKey)
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
            });
        }

        [Fact]
        public async Task DeleteCategoryById()
        {
            var key = $"DeleteCategoryById-{TestingUtility.RandomString()}";
            await WithCategory(
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);

                    await _client.WithApi().WithProjectKey(_projectKey)
                        .Categories()
                        .WithId(category.Id)
                        .Delete()
                        .WithVersion(category.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client.WithApi().WithProjectKey(_projectKey).Categories().WithId(category.Id).Get().ExecuteAsync());
                });
        }

        [Fact]
        public async Task DeleteCategoryByKey()
        {
            var key = $"DeleteCategoryByKey-{TestingUtility.RandomString()}";
            await WithCategory(
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);

                    await _client.WithApi().WithProjectKey(_projectKey)
                        .Categories()
                        .WithKey(category.Key)
                        .Delete()
                        .WithVersion(category.Version)
                        .ExecuteAsync();

                    await Assert.ThrowsAsync<NotFoundException>(
                        () => _client.WithApi().WithProjectKey(_projectKey).Categories().WithId(category.Id).Get().ExecuteAsync());
                });
        }

        [Fact]
        public async Task ValidateMemoryLogging()
        {
            var key = $"ValidateMemoryLogging-{TestingUtility.RandomString()}";
            await WithCategory(
                _client, categoryDraft => DefaultCategoryDraftWithKey(categoryDraft, key),
                async category =>
                {
                    Assert.NotNull(category);
                    var retrievedCategory = await _client.WithApi().WithProjectKey(_projectKey)
                        .Categories()
                        .WithId(category.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCategory);

                    var log = InMemoryLogger.GetLogMessages();
                    Assert.NotEmpty(log);
                });
        }

        #region UpdateActions

        [Fact]
        public async Task UpdateCategoryByKeyChangeName()
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

                var updatedCategory = await _client.WithApi().WithProjectKey(_projectKey)
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