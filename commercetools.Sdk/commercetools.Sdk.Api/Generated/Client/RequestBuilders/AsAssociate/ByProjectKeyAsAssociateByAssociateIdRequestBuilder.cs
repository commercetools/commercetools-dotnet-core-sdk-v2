using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public class ByProjectKeyAsAssociateByAssociateIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        public ByProjectKeyAsAssociateByAssociateIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
        }



        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsRequestBuilder BusinessUnits()
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId);
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyRequestBuilder InBusinessUnitKeyWithBusinessUnitKeyValue(string businessUnitKey)
        {
            return new ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, businessUnitKey);
        }
    }
}
