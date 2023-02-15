using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public class ByProjectKeyAsAssociateRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAsAssociateRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyAsAssociateByAssociateIdRequestBuilder WithAssociateIdValue(string associateId)
        {
            return new ByProjectKeyAsAssociateByAssociateIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, associateId);
        }
    }
}
