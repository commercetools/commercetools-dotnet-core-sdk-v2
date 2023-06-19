using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeOrdersGet Get()
        {
            return new ByProjectKeyMeOrdersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeOrdersPost Post(commercetools.Sdk.Api.Models.Me.IMyOrderFromCartDraft myOrderFromCartDraft)
        {
            return new ByProjectKeyMeOrdersPost(ApiHttpClient, SerializerService, ProjectKey, myOrderFromCartDraft);
        }


        public ByProjectKeyMeOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeOrdersQuotesRequestBuilder Quotes()
        {
            return new ByProjectKeyMeOrdersQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
