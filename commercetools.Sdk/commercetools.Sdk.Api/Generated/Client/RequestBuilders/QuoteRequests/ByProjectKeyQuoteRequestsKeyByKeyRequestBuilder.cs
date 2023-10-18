using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests
{

    public partial class ByProjectKeyQuoteRequestsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyQuoteRequestsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyQuoteRequestsKeyByKeyGet Get()
        {
            return new ByProjectKeyQuoteRequestsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyQuoteRequestsKeyByKeyHead Head()
        {
            return new ByProjectKeyQuoteRequestsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyQuoteRequestsKeyByKeyPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            return new ByProjectKeyQuoteRequestsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, quoteRequestUpdate);
        }

        public ByProjectKeyQuoteRequestsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyQuoteRequestsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
