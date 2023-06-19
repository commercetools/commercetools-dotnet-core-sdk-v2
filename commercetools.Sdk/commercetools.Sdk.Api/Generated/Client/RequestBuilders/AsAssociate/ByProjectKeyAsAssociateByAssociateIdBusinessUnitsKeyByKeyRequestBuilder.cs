using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string Key { get; }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.Key = key;
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyGet Get()
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyGet(ApiHttpClient, ProjectKey, AssociateId, Key);
        }

        public ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyAsAssociateByAssociateIdBusinessUnitsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, AssociateId, Key, businessUnitUpdate);
        }

    }
}
