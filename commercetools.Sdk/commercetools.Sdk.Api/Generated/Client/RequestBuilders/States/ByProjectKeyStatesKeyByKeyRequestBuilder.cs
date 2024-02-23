using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.States
{

    public partial class ByProjectKeyStatesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyStatesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyStatesKeyByKeyGet Get()
        {
            return new ByProjectKeyStatesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStatesKeyByKeyHead Head()
        {
            return new ByProjectKeyStatesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStatesKeyByKeyPost Post(commercetools.Sdk.Api.Models.States.IStateUpdate stateUpdate)
        {
            return new ByProjectKeyStatesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, stateUpdate);
        }

        public ByProjectKeyStatesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyStatesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
