using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeBusinessUnitsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMeBusinessUnitsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMeBusinessUnitsKeyByKeyGet Get()
        {
            return new ByProjectKeyMeBusinessUnitsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeBusinessUnitsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyBusinessUnitUpdate myBusinessUnitUpdate)
        {
            return new ByProjectKeyMeBusinessUnitsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myBusinessUnitUpdate);
        }

        public ByProjectKeyMeBusinessUnitsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyMeBusinessUnitsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
