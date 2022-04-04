using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public class ByProjectKeyProductSelectionsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductSelectionsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductSelectionsKeyByKeyGet Get()
        {
            return new ByProjectKeyProductSelectionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductSelectionsKeyByKeyPost Post(commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionUpdate productSelectionUpdate)
        {
            return new ByProjectKeyProductSelectionsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productSelectionUpdate);
        }

        public ByProjectKeyProductSelectionsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyProductSelectionsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }


        public ByProjectKeyProductSelectionsKeyByKeyProductsRequestBuilder Products()
        {
            return new ByProjectKeyProductSelectionsKeyByKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, Key);
        }
    }
}
