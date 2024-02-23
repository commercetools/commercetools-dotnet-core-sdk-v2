using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Client;
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

        public static async Task<ICategory> CreateCategory(ProjectApiRoot client, CategoryDraft categoryDraft)
        {
            return await client
                .Categories()
                .Post(categoryDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteCategory(ProjectApiRoot client, ICategory category)
        {
            try
            {
                await client
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

        public static async Task WithCategory(ProjectApiRoot client, Func<CategoryDraft, CategoryDraft> draftAction, Action<ICategory> func)
        {
            await With(client, new CategoryDraft(), draftAction, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithCategory(ProjectApiRoot client, Func<CategoryDraft, CategoryDraft> draftAction, Func<ICategory, Task> func)
        {
            await WithAsync(client, new CategoryDraft(), draftAction, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithCategory(ProjectApiRoot client, Func<ICategory, Task> func)
        {
            await WithAsync(client, new CategoryDraft(), DefaultCategoryDraft, func, CreateCategory, DeleteCategory);
        }
        public static async Task WithListOfCategories(ProjectApiRoot client, Func<CategoryDraft, CategoryDraft> draftAction, int count, Func<List<ICategory>, Task> func)
        {
            await WithListAsync(client, new CategoryDraft(), draftAction, func, count, CreateCategory, DeleteCategory);
        }

        public static async Task WithUpdateableCategory(ProjectApiRoot client, Func<ICategory, Task<ICategory>> func)
        {
            await WithUpdateableAsync(client, new CategoryDraft(), DefaultCategoryDraft, func, CreateCategory, DeleteCategory);
        }
        #endregion
    }
}