using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestDraft quoteRequestDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, quoteRequestDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
