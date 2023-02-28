using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersEditsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyOrdersEditsGet Get()
        {
            return new ByProjectKeyOrdersEditsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyOrdersEditsPost Post(commercetools.Sdk.Api.Models.OrderEdits.IOrderEditDraft orderEditDraft)
        {
            return new ByProjectKeyOrdersEditsPost(ApiHttpClient, SerializerService, ProjectKey, orderEditDraft);
        }


        public ByProjectKeyOrdersEditsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyOrdersEditsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyOrdersEditsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyOrdersEditsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
