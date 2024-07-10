using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate stagedQuoteUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, stagedQuoteUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
