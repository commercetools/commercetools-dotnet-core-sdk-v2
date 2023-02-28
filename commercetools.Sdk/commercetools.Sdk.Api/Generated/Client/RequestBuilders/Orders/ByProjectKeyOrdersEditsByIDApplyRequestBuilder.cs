using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsByIDApplyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyOrdersEditsByIDApplyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyOrdersEditsByIDApplyPost Post(commercetools.Sdk.Api.Models.OrderEdits.IOrderEditApply orderEditApply)
        {
            return new ByProjectKeyOrdersEditsByIDApplyPost(ApiHttpClient, SerializerService, ProjectKey, ID, orderEditApply);
        }

    }
}
