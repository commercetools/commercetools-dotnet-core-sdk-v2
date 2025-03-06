using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        private string AssociateId { get; }

        public ByProjectKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.AssociateId = associateId;
        }

        public ByProjectKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet Get()
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet(ApiHttpClient, ProjectKey, Key, AssociateId);
        }

    }
}
