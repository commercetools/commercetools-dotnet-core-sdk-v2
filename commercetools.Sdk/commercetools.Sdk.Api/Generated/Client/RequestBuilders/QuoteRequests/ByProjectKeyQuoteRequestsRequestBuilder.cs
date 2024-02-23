using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests
{

    public partial class ByProjectKeyQuoteRequestsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyQuoteRequestsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyQuoteRequestsGet Get()
        {
            return new ByProjectKeyQuoteRequestsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyQuoteRequestsHead Head()
        {
            return new ByProjectKeyQuoteRequestsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyQuoteRequestsPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestDraft quoteRequestDraft)
        {
            return new ByProjectKeyQuoteRequestsPost(ApiHttpClient, SerializerService, ProjectKey, quoteRequestDraft);
        }


        public ByProjectKeyQuoteRequestsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyQuoteRequestsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyQuoteRequestsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyQuoteRequestsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
