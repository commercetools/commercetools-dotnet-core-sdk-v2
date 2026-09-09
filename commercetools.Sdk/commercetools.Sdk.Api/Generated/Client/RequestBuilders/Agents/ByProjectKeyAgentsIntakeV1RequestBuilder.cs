using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Agents
{

    public partial class ByProjectKeyAgentsIntakeV1RequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAgentsIntakeV1RequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyAgentsIntakeV1ResponsesRequestBuilder Responses()
        {
            return new ByProjectKeyAgentsIntakeV1ResponsesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
