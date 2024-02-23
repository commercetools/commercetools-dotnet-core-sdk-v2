using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeBusinessUnitsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeBusinessUnitsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeBusinessUnitsGet Get()
        {
            return new ByProjectKeyMeBusinessUnitsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeBusinessUnitsHead Head()
        {
            return new ByProjectKeyMeBusinessUnitsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeBusinessUnitsPost Post(commercetools.Sdk.Api.Models.Me.IMyBusinessUnitDraft myBusinessUnitDraft)
        {
            return new ByProjectKeyMeBusinessUnitsPost(ApiHttpClient, SerializerService, ProjectKey, myBusinessUnitDraft);
        }


        public ByProjectKeyMeBusinessUnitsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeBusinessUnitsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeBusinessUnitsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMeBusinessUnitsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
