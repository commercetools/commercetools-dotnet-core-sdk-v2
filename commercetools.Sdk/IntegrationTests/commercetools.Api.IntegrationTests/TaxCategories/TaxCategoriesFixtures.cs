using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.TaxCategories;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.TaxCategories
{
    public class TaxCategoriesFixtures
    {
        #region DraftBuilds

        public static TaxCategoryDraft DefaultTaxCategoryDraft(TaxCategoryDraft taxCategoryDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            taxCategoryDraft.Key = $"Test-Key-{randomInt}";
            taxCategoryDraft.Name = $"Test-Name-{randomStr}";
            taxCategoryDraft.Rates = new List<ITaxRateDraft>()
            {
                new TaxRateDraft()
                {
                    Name = $"Test-Tax-Rate-{randomStr}",
                    Country = "DE",
                    IncludedInPrice = true,
                    State = "Berlin",
                    Key = $"Test-Tax-Key-{randomInt}",
                    Amount = 1
                }
            };

            return taxCategoryDraft;
        }

        #endregion

        public static TaxCategoryDraft DefaultTaxCategoriesDraftWithKey(TaxCategoryDraft draft, string key)
        {
            var taxCategoryDraft = DefaultTaxCategoryDraft(draft);
            taxCategoryDraft.Key = key;

            return taxCategoryDraft;
        }

        public static async Task<ITaxCategory> CreateTaxCategories(ProjectApiRoot client,
            TaxCategoryDraft taxCategoriesDraft)
        {
            try
            {
                return await client
                    .TaxCategories()
                    .Post(taxCategoriesDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteTaxCategories(ProjectApiRoot client, ITaxCategory taxCategories)
        {
            try
            {
                await client
                    .TaxCategories()
                    .WithId(taxCategories.Id)
                    .Delete()
                    .WithVersion(taxCategories.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithTaxCategory(ProjectApiRoot client,
            Func<TaxCategoryDraft, TaxCategoryDraft> draftAction,
            Action<ITaxCategory> func)
        {
            await With(client, new TaxCategoryDraft(), draftAction, func, CreateTaxCategories,
                DeleteTaxCategories);
        }

        public static async Task WithTaxCategory(ProjectApiRoot client,
            Func<TaxCategoryDraft, TaxCategoryDraft> draftAction,
            Func<ITaxCategory, Task> func)
        {
            await WithAsync(client, new TaxCategoryDraft(), draftAction, func, CreateTaxCategories,
                DeleteTaxCategories);
        }

        public static async Task WithUpdateableTaxCategory(ProjectApiRoot client,
            Func<ITaxCategory, Task<ITaxCategory>> func)
        {
            await WithUpdateableAsync(client, new TaxCategoryDraft(), DefaultTaxCategoryDraft, func,
                CreateTaxCategories,
                DeleteTaxCategories);
        }

        #endregion
    }
}