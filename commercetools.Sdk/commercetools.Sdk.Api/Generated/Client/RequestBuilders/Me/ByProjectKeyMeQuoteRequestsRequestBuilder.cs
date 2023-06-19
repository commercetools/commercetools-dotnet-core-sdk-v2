using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuoteRequestsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeQuoteRequestsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeQuoteRequestsGet Get()
        {
            return new ByProjectKeyMeQuoteRequestsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeQuoteRequestsPost Post(commercetools.Sdk.Api.Models.Me.IMyQuoteRequestDraft myQuoteRequestDraft)
        {
            return new ByProjectKeyMeQuoteRequestsPost(ApiHttpClient, SerializerService, ProjectKey, myQuoteRequestDraft);
        }


        public ByProjectKeyMeQuoteRequestsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeQuoteRequestsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMeQuoteRequestsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
