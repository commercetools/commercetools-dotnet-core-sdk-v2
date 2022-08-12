using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public class ByProjectKeyOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyOrdersGet Get()
        {
            return new ByProjectKeyOrdersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyOrdersPost Post(commercetools.Sdk.Api.Models.Orders.IOrderFromCartDraft orderFromCartDraft)
        {
            return new ByProjectKeyOrdersPost(ApiHttpClient, SerializerService, ProjectKey, orderFromCartDraft);
        }


        public ByProjectKeyOrdersImportRequestBuilder ImportOrder()
        {
            return new ByProjectKeyOrdersImportRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersQuotesRequestBuilder OrderQuote()
        {
            return new ByProjectKeyOrdersQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder WithOrderNumber(string orderNumber)
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, orderNumber);
        }

        public ByProjectKeyOrdersEditsRequestBuilder Edits()
        {
            return new ByProjectKeyOrdersEditsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyOrdersSearchRequestBuilder Search()
        {
            return new ByProjectKeyOrdersSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
