using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public class ByProjectKeyBusinessUnitsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyBusinessUnitsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyBusinessUnitsGet Get()
        {
            return new ByProjectKeyBusinessUnitsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyBusinessUnitsPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitDraft businessUnitDraft)
        {
            return new ByProjectKeyBusinessUnitsPost(ApiHttpClient, SerializerService, ProjectKey, businessUnitDraft);
        }


        public ByProjectKeyBusinessUnitsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyBusinessUnitsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyBusinessUnitsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
