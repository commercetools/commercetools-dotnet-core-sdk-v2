using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Quotes
{

    public partial class ByProjectKeyQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyQuotesGet Get()
        {
            return new ByProjectKeyQuotesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyQuotesPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteDraft quoteDraft)
        {
            return new ByProjectKeyQuotesPost(ApiHttpClient, SerializerService, ProjectKey, quoteDraft);
        }


        public ByProjectKeyQuotesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyQuotesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyQuotesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyQuotesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
