using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate stagedQuoteUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, stagedQuoteUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
