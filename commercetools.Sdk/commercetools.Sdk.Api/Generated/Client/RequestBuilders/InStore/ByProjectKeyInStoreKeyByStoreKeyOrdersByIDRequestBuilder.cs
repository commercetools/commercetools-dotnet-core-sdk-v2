using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyOrdersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyOrdersByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost Post(commercetools.Api.Models.Orders.IOrderUpdate orderUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, orderUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
