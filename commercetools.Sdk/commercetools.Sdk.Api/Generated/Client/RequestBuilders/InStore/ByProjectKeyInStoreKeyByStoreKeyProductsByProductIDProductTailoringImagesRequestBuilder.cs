using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductID = productId;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesPost Post(Stream stream)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductID, stream);
        }

    }
}
