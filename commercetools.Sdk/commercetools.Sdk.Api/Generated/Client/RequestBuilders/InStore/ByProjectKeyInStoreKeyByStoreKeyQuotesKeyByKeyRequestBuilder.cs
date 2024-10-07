using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate quoteUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, quoteUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
