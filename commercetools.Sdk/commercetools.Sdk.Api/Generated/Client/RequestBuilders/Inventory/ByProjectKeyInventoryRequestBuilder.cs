using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Inventory;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Inventory
{

    public partial class ByProjectKeyInventoryRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyInventoryRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyInventoryGet Get()
        {
            return new ByProjectKeyInventoryGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyInventoryHead Head()
        {
            return new ByProjectKeyInventoryHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyInventoryPost Post(commercetools.Sdk.Api.Models.Inventories.IInventoryEntryDraft inventoryEntryDraft)
        {
            return new ByProjectKeyInventoryPost(ApiHttpClient, SerializerService, ProjectKey, inventoryEntryDraft);
        }


        public ByProjectKeyInventoryByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInventoryByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyInventoryKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInventoryKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
