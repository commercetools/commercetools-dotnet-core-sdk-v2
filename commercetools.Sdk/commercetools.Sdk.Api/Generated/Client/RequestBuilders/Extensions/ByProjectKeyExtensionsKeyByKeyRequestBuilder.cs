using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Extensions
{

    public class ByProjectKeyExtensionsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyExtensionsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyExtensionsKeyByKeyGet Get()
        {
            return new ByProjectKeyExtensionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyExtensionsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Extensions.IExtensionUpdate extensionUpdate)
        {
            return new ByProjectKeyExtensionsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, extensionUpdate);
        }

        public ByProjectKeyExtensionsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyExtensionsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
