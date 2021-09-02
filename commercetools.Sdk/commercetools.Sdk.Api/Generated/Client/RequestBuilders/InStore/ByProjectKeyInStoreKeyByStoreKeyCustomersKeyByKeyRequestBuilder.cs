using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost Post(commercetools.Api.Models.Customers.ICustomerUpdate customerUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, customerUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
