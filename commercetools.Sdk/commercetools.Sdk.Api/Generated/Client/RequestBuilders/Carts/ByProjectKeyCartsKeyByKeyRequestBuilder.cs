using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Carts
{

    public class ByProjectKeyCartsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyCartsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyCartsKeyByKeyGet Get()
        {
            return new ByProjectKeyCartsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCartsKeyByKeyPost Post(commercetools.Api.Models.Carts.ICartUpdate cartUpdate)
        {
            return new ByProjectKeyCartsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, cartUpdate);
        }

        public ByProjectKeyCartsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCartsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
