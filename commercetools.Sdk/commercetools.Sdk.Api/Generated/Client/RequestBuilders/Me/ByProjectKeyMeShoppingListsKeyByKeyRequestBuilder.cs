using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMeShoppingListsKeyByKeyGet Get()
        {
            return new ByProjectKeyMeShoppingListsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeShoppingListsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyShoppingListUpdate myShoppingListUpdate)
        {
            return new ByProjectKeyMeShoppingListsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myShoppingListUpdate);
        }

        public ByProjectKeyMeShoppingListsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyMeShoppingListsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
