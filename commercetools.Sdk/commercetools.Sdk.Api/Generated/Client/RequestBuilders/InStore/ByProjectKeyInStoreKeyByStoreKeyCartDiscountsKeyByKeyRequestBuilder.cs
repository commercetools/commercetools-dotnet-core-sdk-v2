using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyPost Post(commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, cartDiscountUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
