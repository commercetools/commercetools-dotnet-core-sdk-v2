using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Sdk.Api.Client;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.DiscountCodes
{
    public class DiscountCodesFixtures
    {
        #region DraftBuilds

        public static DiscountCodeDraft DefaultDiscountCodesDraft(DiscountCodeDraft discountCodeDraft)
        {
            discountCodeDraft.Name = new LocalizedString { { "en", "Name" } };
            discountCodeDraft.CartPredicate = "country=\"DE\"";
            discountCodeDraft.IsActive = false;

            return discountCodeDraft;
        }

        public static DiscountCodeDraft DefaultDiscountCodeDraftWithKey(DiscountCodeDraft draft, string key)
        {
            var discountCodeDraft = DefaultDiscountCodesDraft(draft);
            discountCodeDraft.Key = key;

            return discountCodeDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<IDiscountCode> CreateDiscountCodes(ProjectApiRoot client, DiscountCodeDraft discountCodeDraft)
        {
            var resource = await client
                .DiscountCodes()
                .Post(discountCodeDraft)
                .ExecuteAsync();

            return resource;
        }

        public static async Task DeleteDiscountCodes(ProjectApiRoot client, IDiscountCode discountCode)
        {
            try
            {
                await client
                    .DiscountCodes()
                    .WithId(discountCode.Id)
                    .Delete()
                    .WithVersion(discountCode.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion

        #region WithDiscountCodes

        public static async Task WithDiscountCodes(ProjectApiRoot client,
            Func<DiscountCodeDraft, DiscountCodeDraft> draftAction, Action<IDiscountCode> func)
        {
            await With(client, new DiscountCodeDraft(), draftAction, func, CreateDiscountCodes, DeleteDiscountCodes);
        }

        public static async Task WithDiscountCodes(ProjectApiRoot client,
            Func<DiscountCodeDraft, DiscountCodeDraft> draftAction,
            Func<IDiscountCode, Task> func)
        {
            await WithAsync(client, new DiscountCodeDraft(), draftAction, func, CreateDiscountCodes,
                DeleteDiscountCodes);
        }

        public static async Task WithDiscountCodes(ProjectApiRoot client, Func<IDiscountCode, Task> func)
        {
            await WithAsync(client, new DiscountCodeDraft(), DefaultDiscountCodesDraft, func, CreateDiscountCodes,
                DeleteDiscountCodes);
        }

        public static async Task WithUpdateableDiscountCodes(ProjectApiRoot client,
            Func<IDiscountCode, Task<IDiscountCode>> func)
        {
            await WithUpdateableAsync(client, new DiscountCodeDraft(), DefaultDiscountCodesDraft, func,
                CreateDiscountCodes,
                DeleteDiscountCodes);
        }

        public static async Task WithUpdateableDiscountCodes(ProjectApiRoot client, Func<DiscountCodeDraft, DiscountCodeDraft> draftAction,
            Func<IDiscountCode, Task<IDiscountCode>> func)
        {
            await WithUpdateableAsync(client, new DiscountCodeDraft(), draftAction, func,
                CreateDiscountCodes,
                DeleteDiscountCodes);
        }

        #endregion
    }
}