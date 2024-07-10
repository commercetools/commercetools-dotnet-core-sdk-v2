using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.InStore;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductKey = productKey;
        }



        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringRequestBuilder ProductTailoring()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductKey);
        }
    }
}
