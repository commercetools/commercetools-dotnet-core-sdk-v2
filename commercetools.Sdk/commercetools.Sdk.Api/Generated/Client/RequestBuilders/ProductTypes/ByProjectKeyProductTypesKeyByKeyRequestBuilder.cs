using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductTypesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductTypesKeyByKeyGet Get()
        {
            return new ByProjectKeyProductTypesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductTypesKeyByKeyHead Head()
        {
            return new ByProjectKeyProductTypesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductTypesKeyByKeyPost Post(commercetools.Sdk.Api.Models.ProductTypes.IProductTypeUpdate productTypeUpdate)
        {
            return new ByProjectKeyProductTypesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productTypeUpdate);
        }

        public ByProjectKeyProductTypesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyProductTypesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
