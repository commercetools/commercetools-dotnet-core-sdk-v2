using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Inventories;
using commercetools.Sdk.Api.Client;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Inventory
{
    public class InventoryFixtures
    {
        #region DraftBuilds

        public static InventoryEntryDraft DefaultInventoryEntryDraft(InventoryEntryDraft inventoryDraft)
        {
            inventoryDraft.Sku = $"Test-Inventory-Sku-{TestingUtility.RandomString()}";
            inventoryDraft.QuantityOnStock = 8;
            return inventoryDraft;
        }

        public static InventoryEntryDraft DefaultInventoryEntryDraftWithKey(InventoryEntryDraft draft, string key)
        {
            var inventoryDraft = DefaultInventoryEntryDraft(draft);
            inventoryDraft.Key = key;

            return inventoryDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<IInventoryEntry> CreateInventory(ProjectApiRoot client, InventoryEntryDraft inventoryDraft)
        {
            var resource = await client
                .Inventory()
                .Post(inventoryDraft)
                .ExecuteAsync();

            return resource;
        }

        public static async Task DeleteInventory(ProjectApiRoot client, IInventoryEntry inventory)
        {
            try
            {
                await client
                    .Inventory()
                    .WithId(inventory.Id)
                    .Delete()
                    .WithVersion(inventory.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion

        #region WithInventoryEntrys

        public static async Task WithInventory(ProjectApiRoot client,
            Func<InventoryEntryDraft, InventoryEntryDraft> draftAction, Action<IInventoryEntry> func)
        {
            await With(client, new InventoryEntryDraft(), draftAction, func, CreateInventory, DeleteInventory);
        }

        public static async Task WithInventory(ProjectApiRoot client,
            Func<InventoryEntryDraft, InventoryEntryDraft> draftAction,
            Func<IInventoryEntry, Task> func)
        {
            await WithAsync(client, new InventoryEntryDraft(), draftAction, func, CreateInventory,
                DeleteInventory);
        }

        public static async Task WithInventory(ProjectApiRoot client, Func<IInventoryEntry, Task> func)
        {
            await WithAsync(client, new InventoryEntryDraft(), DefaultInventoryEntryDraft, func, CreateInventory,
                DeleteInventory);
        }

        public static async Task WithUpdateableInventory(ProjectApiRoot client,
            Func<IInventoryEntry, Task<IInventoryEntry>> func)
        {
            await WithUpdateableAsync(client, new InventoryEntryDraft(), DefaultInventoryEntryDraft, func,
                CreateInventory,
                DeleteInventory);
        }

        public static async Task WithUpdateableInventory(ProjectApiRoot client, Func<InventoryEntryDraft, InventoryEntryDraft> draftAction,
            Func<IInventoryEntry, Task<IInventoryEntry>> func)
        {
            await WithUpdateableAsync(client, new InventoryEntryDraft(), draftAction, func,
                CreateInventory,
                DeleteInventory);
        }

        #endregion
    }
}