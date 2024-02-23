using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeCartsReplicateRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeCartsReplicateRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeCartsReplicatePost Post(commercetools.Sdk.Api.Models.Me.IReplicaMyCartDraft replicaMyCartDraft)
        {
            return new ByProjectKeyMeCartsReplicatePost(ApiHttpClient, SerializerService, ProjectKey, replicaMyCartDraft);
        }

    }
}
