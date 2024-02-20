using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.ProductDiscounts;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Api.IntegrationTests.ProductDiscount
{
    public class ProductDiscountFixtures
    {
        #region DraftBuilds

        public static ProductDiscountDraft DefaultProductDiscountDraft(ProductDiscountDraft productDiscountDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            productDiscountDraft.Name = new LocalizedString() { { "en", $"Special-Test-Name-{randomInt}" } };
            productDiscountDraft.Predicate = $"product.key=\"randomStr\"";
            productDiscountDraft.IsActive = false;
            productDiscountDraft.SortOrder = "0.65181";
            productDiscountDraft.Value = new ProductDiscountValueRelativeDraft()
            {
                Type = "relative",
                Permyriad = 10
            };
            productDiscountDraft.Description = new LocalizedString()
                { { "en", $"Test-name-productDiscount-{randomStr}" } };


            return productDiscountDraft;
        }

        #endregion

        public static ProductDiscountDraft DefaultProductDiscountDraftWithKey(ProductDiscountDraft draft, string key)
        {
            var productDiscountDraft = DefaultProductDiscountDraft(draft);
            productDiscountDraft.Key = key;

            return productDiscountDraft;
        }

        public static async Task<IProductDiscount> CreateProductDiscount(ProjectApiRoot client,
            ProductDiscountDraft productDiscountDraft)
        {
            try
            {
                return await client
                    .ProductDiscounts()
                    .Post(productDiscountDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteProductDiscount(ProjectApiRoot client, IProductDiscount productDiscount)
        {
            try
            {
                await client
                    .ProductDiscounts()
                    .WithId(productDiscount.Id)
                    .Delete()
                    .WithVersion(productDiscount.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithProductDiscount(ProjectApiRoot client,
            Func<ProductDiscountDraft, ProductDiscountDraft> draftAction,
            Action<IProductDiscount> func)
        {
            await With(client, new ProductDiscountDraft(), draftAction, func, CreateProductDiscount,
                DeleteProductDiscount);
        }

        public static async Task WithProductDiscount(ProjectApiRoot client,
            Func<ProductDiscountDraft, ProductDiscountDraft> draftAction,
            Func<IProductDiscount, Task> func)
        {
            await WithAsync(client, new ProductDiscountDraft(), draftAction, func, CreateProductDiscount,
                DeleteProductDiscount);
        }

        public static async Task WithUpdateableProductDiscount(ProjectApiRoot client,
            Func<IProductDiscount, Task<IProductDiscount>> func)
        {
            await WithUpdateableAsync(client, new ProductDiscountDraft(), DefaultProductDiscountDraft, func,
                CreateProductDiscount,
                DeleteProductDiscount);
        }

        #endregion
    }
}