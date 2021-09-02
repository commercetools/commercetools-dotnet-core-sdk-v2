using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Carts
{

    public class ByProjectKeyCartsReplicateRequestBuilder
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

        public ByProjectKeyCartsReplicatePost Post(commercetools.Api.Models.Carts.IReplicaCartDraft replicaCartDraft)
        {
            return new ByProjectKeyCartsReplicatePost(ApiHttpClient, SerializerService, ProjectKey, replicaCartDraft);
        }

    }
}
