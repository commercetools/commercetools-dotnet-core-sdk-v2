using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public class ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string ID { get; }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.ID = id;
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDGet(ApiHttpClient, ProjectKey, AssociateId, ID);
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, ID, businessUnitUpdate);
        }

    }
}
