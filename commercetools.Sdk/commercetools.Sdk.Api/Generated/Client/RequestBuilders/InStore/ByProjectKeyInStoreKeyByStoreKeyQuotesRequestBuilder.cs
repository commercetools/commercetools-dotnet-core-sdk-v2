using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteDraft quoteDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, quoteDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
