using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyBusinessUnitsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyBusinessUnitsKeyByKeyGet Get()
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyBusinessUnitsKeyByKeyHead Head()
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyBusinessUnitsKeyByKeyPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, businessUnitUpdate);
        }

        public ByProjectKeyBusinessUnitsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyBusinessUnitsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
