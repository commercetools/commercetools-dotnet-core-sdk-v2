using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Products
{

    public class ByProjectKeyProductsKeyByKeyProductSelectionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductsKeyByKeyProductSelectionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet Get()
        {
            return new ByProjectKeyProductsKeyByKeyProductSelectionsGet(ApiHttpClient, ProjectKey, Key);
        }

    }
}
