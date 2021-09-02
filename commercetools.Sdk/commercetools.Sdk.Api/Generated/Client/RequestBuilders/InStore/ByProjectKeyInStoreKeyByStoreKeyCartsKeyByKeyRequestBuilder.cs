using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyRequestBuilder
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

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyPost Post(commercetools.Api.Models.Carts.ICartUpdate cartUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, cartUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
