using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteDraft stagedQuoteDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, stagedQuoteDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
