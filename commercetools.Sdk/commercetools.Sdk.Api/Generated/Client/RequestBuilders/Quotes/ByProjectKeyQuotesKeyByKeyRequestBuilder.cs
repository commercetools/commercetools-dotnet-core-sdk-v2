using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Quotes
{

    public partial class ByProjectKeyQuotesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyQuotesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyQuotesKeyByKeyGet Get()
        {
            return new ByProjectKeyQuotesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyQuotesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate quoteUpdate)
        {
            return new ByProjectKeyQuotesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, quoteUpdate);
        }

        public ByProjectKeyQuotesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyQuotesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
