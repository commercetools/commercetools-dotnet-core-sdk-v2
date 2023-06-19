using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests
{

    public partial class ByProjectKeyQuoteRequestsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyQuoteRequestsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyQuoteRequestsByIDGet Get()
        {
            return new ByProjectKeyQuoteRequestsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyQuoteRequestsByIDPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            return new ByProjectKeyQuoteRequestsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, quoteRequestUpdate);
        }

        public ByProjectKeyQuoteRequestsByIDDelete Delete()
        {
            return new ByProjectKeyQuoteRequestsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
