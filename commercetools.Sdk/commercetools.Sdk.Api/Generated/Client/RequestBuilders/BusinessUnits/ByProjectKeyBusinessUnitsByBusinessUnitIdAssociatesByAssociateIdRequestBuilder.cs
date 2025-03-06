using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string BusinessUnitId { get; }

        private string AssociateId { get; }

        public ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string businessUnitId, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitId = businessUnitId;
            this.AssociateId = associateId;
        }

        public ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet Get()
        {
            return new ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet(ApiHttpClient, ProjectKey, BusinessUnitId, AssociateId);
        }

    }
}
