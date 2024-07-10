using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, quoteRequestUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
