using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Carts.ICartUpdate cartUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, cartUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
