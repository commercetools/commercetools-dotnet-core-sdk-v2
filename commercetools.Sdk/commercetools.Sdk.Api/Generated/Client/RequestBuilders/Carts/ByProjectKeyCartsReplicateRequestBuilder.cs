using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsReplicateRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCartsReplicateRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCartsReplicatePost Post(commercetools.Sdk.Api.Models.Carts.IReplicaCartDraft replicaCartDraft)
        {
            return new ByProjectKeyCartsReplicatePost(ApiHttpClient, SerializerService, ProjectKey, replicaCartDraft);
        }

    }
}
