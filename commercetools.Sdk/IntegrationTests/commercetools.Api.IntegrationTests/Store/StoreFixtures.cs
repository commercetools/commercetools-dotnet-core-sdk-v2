using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models.Stores;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Api.IntegrationTests.Store
{
    public class StoreFixtures
    {
        #region DraftBuilds

        public static StoreDraft DefaultStoreDraft(StoreDraft storeDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            storeDraft.Key = $"Test-Key-{randomInt}";

            return storeDraft;
        }

        #endregion

        public static StoreDraft DefaultStoreDraftWithKey(StoreDraft draft, string key)
        {
            var storeDraft = DefaultStoreDraft(draft);
            storeDraft.Key = key;

            return storeDraft;
        }

        public static async Task<IStore> CreateStore(IClient client,
            StoreDraft storeDraft)
        {
            try
            {
                return await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Stores()
                    .Post(storeDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteStore(IClient client, IStore store)
        {
            try
            {
                await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Stores()
                    .WithId(store.Id)
                    .Delete()
                    .WithVersion(store.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithStore(IClient client,
            Func<StoreDraft, StoreDraft> draftAction,
            Action<IStore> func)
        {
            await With(client, new StoreDraft(), draftAction, func, CreateStore,
                DeleteStore);
        }

        public static async Task WithStore(IClient client,
            Func<StoreDraft, StoreDraft> draftAction,
            Func<IStore, Task> func)
        {
            await WithAsync(client, new StoreDraft(), draftAction, func, CreateStore,
                DeleteStore);
        }

        public static async Task WithUpdateableStore(IClient client,
            Func<IStore, Task<IStore>> func)
        {
            await WithUpdateableAsync(client, new StoreDraft(), DefaultStoreDraft, func,
                CreateStore,
                DeleteStore);
        }

        #endregion
    }
}