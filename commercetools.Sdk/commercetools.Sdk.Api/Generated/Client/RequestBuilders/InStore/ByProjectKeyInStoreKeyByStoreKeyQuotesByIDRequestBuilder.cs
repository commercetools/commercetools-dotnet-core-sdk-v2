using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuotesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate quoteUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, quoteUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
