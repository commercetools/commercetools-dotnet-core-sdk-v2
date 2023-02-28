using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeCartsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMeCartsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMeCartsKeyByKeyGet Get()
        {
            return new ByProjectKeyMeCartsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeCartsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyCartUpdate myCartUpdate)
        {
            return new ByProjectKeyMeCartsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myCartUpdate);
        }

        public ByProjectKeyMeCartsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyMeCartsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
