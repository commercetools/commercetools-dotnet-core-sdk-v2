using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdBusinessUnitsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsGet(ApiHttpClient, ProjectKey, AssociateId);
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitDraft businessUnitDraft)
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, businessUnitDraft);
        }


        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, key);
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, AssociateId, ID);
        }
    }
}
