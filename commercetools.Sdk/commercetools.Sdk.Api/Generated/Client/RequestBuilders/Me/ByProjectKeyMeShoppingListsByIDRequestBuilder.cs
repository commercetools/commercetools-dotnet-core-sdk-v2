using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeShoppingListsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMeShoppingListsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMeShoppingListsByIDGet Get()
        {
            return new ByProjectKeyMeShoppingListsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeShoppingListsByIDHead Head()
        {
            return new ByProjectKeyMeShoppingListsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeShoppingListsByIDPost Post(commercetools.Sdk.Api.Models.Me.IMyShoppingListUpdate myShoppingListUpdate)
        {
            return new ByProjectKeyMeShoppingListsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myShoppingListUpdate);
        }

        public ByProjectKeyMeShoppingListsByIDDelete Delete()
        {
            return new ByProjectKeyMeShoppingListsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
