using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;


namespace commercetools.Api.IntegrationTests.Cart
{
    public class CartFixture
    {
        #region DraftBuilds

        public static CartDraft DefaultCartDraft(CartDraft cartDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            cartDraft.Country = "DE";
            cartDraft.Currency = "EUR";
            cartDraft.ItemShippingAddresses = new List<IBaseAddress>()
            {
                new BaseAddress() { Country = "DE", Key = $"Key{randomInt}" }
            };

            return cartDraft;
        }

        public static CartDraft DefaultCartDraftWithKey(CartDraft draft, string key)
        {
            var cartDraft = DefaultCartDraft(draft);
            cartDraft.Key = key;

            return cartDraft;
        }

        #endregion

        public static async Task<ICart> CreateCart(ProjectApiRoot client, CartDraft cartDraft)
        {
            return await client
                .Carts()
                .Post(cartDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteCart(ProjectApiRoot client, ICart cart)
        {
            try
            {
                await client
                    .Carts()
                    .WithKey(cart.Key)
                    .Delete()
                    .WithVersion(cart.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region WithCart

        public static async Task WithCart(ProjectApiRoot client, Func<CartDraft, CartDraft> draftAction, Action<ICart> func)
        {
            await With(client, new CartDraft(), draftAction, func, CreateCart, DeleteCart);
        }

        public static async Task WithCart(ProjectApiRoot client, Func<CartDraft, CartDraft> draftAction,
            Func<ICart, Task> func)
        {
            await WithAsync(client, new CartDraft(), draftAction, func, CreateCart, DeleteCart);
        }

        public static async Task WithCart(ProjectApiRoot client, Func<ICart, Task> func)
        {
            await WithAsync(client, new CartDraft(), DefaultCartDraft, func, CreateCart, DeleteCart);
        }

        public static async Task WithUpdateableCart(ProjectApiRoot client, Func<ICart, Task<ICart>> func)
        {
            await WithUpdateableAsync(client, new CartDraft(), DefaultCartDraft, func, CreateCart, DeleteCart);
        }

        #endregion
    }
}