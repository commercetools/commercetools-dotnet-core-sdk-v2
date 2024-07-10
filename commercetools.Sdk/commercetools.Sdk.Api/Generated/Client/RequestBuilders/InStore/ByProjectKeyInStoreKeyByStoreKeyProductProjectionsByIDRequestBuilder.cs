using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductProjectionsByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
