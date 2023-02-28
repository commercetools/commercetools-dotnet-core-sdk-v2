using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyZonesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyZonesGet Get()
        {
            return new ByProjectKeyZonesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyZonesPost Post(commercetools.Sdk.Api.Models.Zones.IZoneDraft zoneDraft)
        {
            return new ByProjectKeyZonesPost(ApiHttpClient, SerializerService, ProjectKey, zoneDraft);
        }


        public ByProjectKeyZonesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyZonesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyZonesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyZonesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
