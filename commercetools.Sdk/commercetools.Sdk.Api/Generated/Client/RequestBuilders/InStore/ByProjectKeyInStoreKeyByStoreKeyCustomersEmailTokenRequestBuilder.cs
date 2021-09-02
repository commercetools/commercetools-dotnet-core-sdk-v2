using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenPost Post(commercetools.Api.Models.Customers.ICustomerCreateEmailToken customerCreateEmailToken)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerCreateEmailToken);
        }

    }
}
