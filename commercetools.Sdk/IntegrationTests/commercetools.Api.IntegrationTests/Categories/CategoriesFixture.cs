using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Categories
{
    public class CategoriesFixture
    {
        #region DraftBuilds

        public static CategoryDraft DefaultCategoryDraft(CategoryDraft categoryDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            categoryDraft.Name = new LocalizedString { { "en", $"Name{randomInt}" } };
            categoryDraft.Slug = new LocalizedString { { "en", $"Slug{randomInt}" } };
            categoryDraft.Key = $"Key{randomInt}";
            categoryDraft.OrderHint = TestingUtility.RandomSortOrder();
            return categoryDraft;
        }

        public static CategoryDraft DefaultCategoryDraftWithKey(CategoryDraft draft, string key)
        {
            var categoryDraft = DefaultCategoryDraft(draft);
            categoryDraft.Key = key;
            return categoryDraft;
        }

        public static CategoryDraft DefaultCategoryDraftWithParent(CategoryDraft draft, ICategory parent)
        {
            var categoryDraft = DefaultCategoryDraft(draft);
            categoryDraft.Parent = new CategoryResourceIdentifier
            {
                Id = parent.Id
            };
            return categoryDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<ICategory> CreateCategory(IClient client, CategoryDraft categoryDraft)
        {
            return await client.WithApi().WithProjectKey(DefaultProjectKey)
                .Categories()
                .Post(categoryDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteCategory(IClient client, ICategory category)
        {
            try
            {
                await client.WithApi().WithProjectKey(DefaultProjectKey)
                    .Categories()
                    .WithId(category.Id)
                    .Delete()
                    .WithVersion(category.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion

        #region WithCategory

        public static async Task WithCategory(IClient client, Func<CategoryDraft, CategoryDraft> draftAction, Action<ICategory> func)
        {
            await With(client, new CategoryDraft(), draftAction, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithCategory(IClient client, Func<CategoryDraft, CategoryDraft> draftAction, Func<ICategory, Task> func)
        {
            await WithAsync(client, new CategoryDraft(), draftAction, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithCategory(IClient client, Func<ICategory, Task> func)
        {
            await WithAsync(client, new CategoryDraft(), DefaultCategoryDraft, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithListOfCategories(IClient client, Func<CategoryDraft, CategoryDraft> draftAction, int count, Func<List<ICategory>, Task> func)
        {
            await WithListAsync(client, new CategoryDraft(), draftAction, func, count, CreateCategory, DeleteCategory);
        }

        public static async Task WithUpdateableCategory(IClient client, Func<ICategory, Task<ICategory>> func)
        {
            await WithUpdateableAsync(client, new CategoryDraft(), DefaultCategoryDraft, func, CreateCategory, DeleteCategory);
        }
        #endregion
    }
}