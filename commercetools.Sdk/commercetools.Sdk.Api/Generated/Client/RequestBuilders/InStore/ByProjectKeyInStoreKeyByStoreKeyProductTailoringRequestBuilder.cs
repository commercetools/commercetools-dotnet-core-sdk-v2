using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductTailoringRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductTailoringRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductTailoringGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductTailoringGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductTailoringPost Post(commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoringInStoreDraft productTailoringInStoreDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductTailoringPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, productTailoringInStoreDraft);
        }

    }
}
