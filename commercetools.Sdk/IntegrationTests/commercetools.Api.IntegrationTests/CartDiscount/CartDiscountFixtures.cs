using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CartDiscounts;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.CartDiscount
{
    public class CartDiscountFixtures
    {
        #region DraftBuilds

        public static CartDiscountDraft DefaultCartDiscountDraft(CartDiscountDraft cartDiscountDraft)
        {
            var randomString = TestingUtility.RandomString();

            cartDiscountDraft.Name = new LocalizedString { { "en", $"$Name-{randomString}" } };
            cartDiscountDraft.CartPredicate = $"country=\"DE\"";
            cartDiscountDraft.Value = new CartDiscountValueRelativeDraft() { Type = "relative", Permyriad = 10 };
            cartDiscountDraft.Target = new CartDiscountShippingCostTarget() { Type = "shipping" };
            cartDiscountDraft.SortOrder = TestingUtility.RandomSortOrder();
            cartDiscountDraft.RequiresDiscountCode = true;
            cartDiscountDraft.IsActive = false;

            return cartDiscountDraft;
        }

        public static CartDiscountDraft DefaultCartDiscountDraftWithKey(CartDiscountDraft draft, string key)
        {
            var cartDiscountDraft = DefaultCartDiscountDraft(draft);
            cartDiscountDraft.Key = key;

            return cartDiscountDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<ICartDiscount> CreateCartDiscount(ProjectApiRoot client, CartDiscountDraft cartDiscountDraft)
        {
            try
            {
                var resource = await client
                    .CartDiscounts()
                    .Post(cartDiscountDraft)
                    .ExecuteAsync();

                return resource;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteCartDiscount(ProjectApiRoot client, ICartDiscount cartDiscount)
        {
            try
            {
                await client
                    .CartDiscounts()
                    .WithId(cartDiscount.Id)
                    .Delete()
                    .WithVersion(cartDiscount.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion

        #region WithDiscountCodes

        public static async Task WithCartDiscount(ProjectApiRoot client,
            Func<CartDiscountDraft, CartDiscountDraft> draftAction, Action<ICartDiscount> func)
        {
            await With(client, new CartDiscountDraft(), draftAction, func, CreateCartDiscount, DeleteCartDiscount);
        }

        public static async Task WithCartDiscount(ProjectApiRoot client,
            Func<CartDiscountDraft, CartDiscountDraft> draftAction,
            Func<ICartDiscount, Task> func)
        {
            await WithAsync(client, new CartDiscountDraft(), draftAction, func, CreateCartDiscount,
                DeleteCartDiscount);
        }

        public static async Task WithCartDiscount(ProjectApiRoot client, Func<ICartDiscount, Task> func)
        {
            await WithAsync(client, new CartDiscountDraft(), DefaultCartDiscountDraft, func, CreateCartDiscount,
                DeleteCartDiscount);
        }

        public static async Task WithUpdateableCartDiscount(ProjectApiRoot client,
            Func<ICartDiscount, Task<ICartDiscount>> func)
        {
            await WithUpdateableAsync(client, new CartDiscountDraft(), DefaultCartDiscountDraft, func,
                CreateCartDiscount, DeleteCartDiscount);
        }

        #endregion
    }
}