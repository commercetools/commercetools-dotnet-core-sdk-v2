using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Inventories;
using static commercetools.Api.IntegrationTests.Channel.ChannelFixtures;
using static commercetools.Api.IntegrationTests.Inventory.InventoryFixtures;
using Xunit;

namespace commercetools.Api.IntegrationTests.Inventory
{
    [Collection("Integration Tests")]
    public class InventoryIntegrationTests
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public InventoryIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateInventory()
        {
            // create Channel
            var key = $"Create-Channel-{TestingUtility.RandomString()}";
            var inventoryKey = $"Test-Inventory-Key-{TestingUtility.RandomString()}";

            await WithChannel(
                _projectApiRoot,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.Equal(key, channel.Key);
                    // create Inventory
                    await WithInventory(
                        _projectApiRoot,
                        inventoryDraft =>
                        {
                            inventoryDraft.Key = inventoryKey;
                            inventoryDraft.SupplyChannel = new ChannelResourceIdentifier()
                            {
                                Id = channel.Id,
                                TypeId = IReferenceTypeId.Channel
                            };

                            return DefaultInventoryEntryDraft(inventoryDraft);
                        },
                        inventory =>
                        {
                            Assert.NotNull(inventory);
                            Assert.Equal(inventoryKey, inventory.Key);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task GetInventoryById()
        {
            var key = $"Create-Channel-{TestingUtility.RandomString()}";
            var inventoryKey = $"Test-Inventory-Key-{TestingUtility.RandomString()}";

            // create channel
            await WithChannel(
                _projectApiRoot,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.Equal(key, channel.Key);
                    // create Inventory
                    await WithInventory(
                        _projectApiRoot,
                        inventoryDraft =>
                        {
                            inventoryDraft.Key = inventoryKey;
                            inventoryDraft.SupplyChannel = new ChannelResourceIdentifier()
                            {
                                Id = channel.Id,
                                TypeId = IReferenceTypeId.Channel
                            };

                            return DefaultInventoryEntryDraft(inventoryDraft);
                        },
                        async inventory =>
                        {
                            Assert.NotNull(inventory);
                            var retrievedDiscountCode = await _projectApiRoot
                                .Inventory()
                                .WithId(inventory.Id)
                                .Get()
                                .ExecuteAsync();

                            Assert.NotNull(retrievedDiscountCode);
                            Assert.Equal(inventoryKey, retrievedDiscountCode.Key);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task QueryInventoryById()
        {
            // create Channel
            var key = $"Create-Channel-{TestingUtility.RandomString()}";
            var inventoryKey = $"Test-Inventory-Key-{TestingUtility.RandomString()}";

            await WithChannel(
                _projectApiRoot,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.Equal(key, channel.Key);
                    // create DiscountCodes
                    await WithInventory(
                        _projectApiRoot,
                        inventoryEntryDraft =>
                        {
                            inventoryEntryDraft.Key = inventoryKey;
                            inventoryEntryDraft.SupplyChannel = new ChannelResourceIdentifier()
                            {
                                TypeId = IReferenceTypeId.Channel,
                                Id = channel.Id
                            };

                            return DefaultInventoryEntryDraftWithKey(inventoryEntryDraft, inventoryKey);
                        },
                        async inventory =>
                        {
                            Assert.NotNull(inventory);
                            var retrievedDiscountCode = await _projectApiRoot
                                .Inventory()
                                .Get()
                                .WithQuery(d => d.Id().Is(inventory.Id))
                                .ExecuteAsync();

                            Assert.NotNull(retrievedDiscountCode);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task UpdateInventoryByIdSetKey()
        {
            var key = $"Create-Channel-{TestingUtility.RandomString()}";
            var inventoryKey = $"Test-Inventory-Key-{TestingUtility.RandomString()}";

            // create channel
            await WithChannel(
                _projectApiRoot,
                channelDraft => DefaultChannelDraftWithKey(channelDraft, key),
                async channel =>
                {
                    Assert.Equal(key, channel.Key);
                    // update Inventory
                    await WithUpdateableInventory(
                        _projectApiRoot,
                        inventoryEntryDraft =>
                        {
                            inventoryEntryDraft.Key = inventoryKey;
                            inventoryEntryDraft.SupplyChannel = new ChannelResourceIdentifier()
                            {
                                TypeId = IReferenceTypeId.Channel,
                                Id = channel.Id
                            };

                            return DefaultInventoryEntryDraftWithKey(inventoryEntryDraft, inventoryKey);
                        },
                        async inventoryEntry =>
                        {
                            Assert.NotNull(inventoryEntry);
                            var action = new InventoryEntrySetRestockableInDaysAction()
                            {
                                Action = "setRestockableInDays",
                                RestockableInDays = 8
                            };

                            var update = new InventoryEntryUpdate()
                            {
                                Version = inventoryEntry.Version,
                                Actions = new List<IInventoryEntryUpdateAction>() { action }
                            };

                            var updatedInventory = await _projectApiRoot
                                .Inventory()
                                .WithId(inventoryEntry.Id)
                                .Post(update)
                                .ExecuteAsync();

                            Assert.NotNull(updatedInventory);
                            Assert.NotEqual(inventoryEntry.Version, updatedInventory.Version);

                            return updatedInventory;
                        }
                    );
                }
            );
        }
    }
}