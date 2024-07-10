using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Inventory
{

    public partial class ByProjectKeyInventoryKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyInventoryKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyInventoryKeyByKeyGet Get()
        {
            return new ByProjectKeyInventoryKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyInventoryKeyByKeyHead Head()
        {
            return new ByProjectKeyInventoryKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyInventoryKeyByKeyPost Post(commercetools.Sdk.Api.Models.Inventories.IInventoryEntryUpdate inventoryEntryUpdate)
        {
            return new ByProjectKeyInventoryKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, inventoryEntryUpdate);
        }

        public ByProjectKeyInventoryKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInventoryKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
