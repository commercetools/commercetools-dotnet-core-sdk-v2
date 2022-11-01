using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public class ByProjectKeyBusinessUnitsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyBusinessUnitsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyBusinessUnitsByIDGet Get()
        {
            return new ByProjectKeyBusinessUnitsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyBusinessUnitsByIDPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyBusinessUnitsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, businessUnitUpdate);
        }

        public ByProjectKeyBusinessUnitsByIDDelete Delete()
        {
            return new ByProjectKeyBusinessUnitsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
