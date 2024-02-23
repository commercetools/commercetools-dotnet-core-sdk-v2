using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Quotes
{

    public partial class ByProjectKeyQuotesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyQuotesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyQuotesByIDGet Get()
        {
            return new ByProjectKeyQuotesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyQuotesByIDHead Head()
        {
            return new ByProjectKeyQuotesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyQuotesByIDPost Post(commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate quoteUpdate)
        {
            return new ByProjectKeyQuotesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, quoteUpdate);
        }

        public ByProjectKeyQuotesByIDDelete Delete()
        {
            return new ByProjectKeyQuotesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
