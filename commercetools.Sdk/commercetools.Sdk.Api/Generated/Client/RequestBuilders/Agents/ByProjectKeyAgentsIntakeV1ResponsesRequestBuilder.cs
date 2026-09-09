using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Agents
{

    public partial class ByProjectKeyAgentsIntakeV1ResponsesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAgentsIntakeV1ResponsesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyAgentsIntakeV1ResponsesPost Post(commercetools.Sdk.Api.Models.Agents.IAgentResponsesRequest agentResponsesRequest)
        {
            return new ByProjectKeyAgentsIntakeV1ResponsesPost(ApiHttpClient, SerializerService, ProjectKey, agentResponsesRequest);
        }

    }
}
