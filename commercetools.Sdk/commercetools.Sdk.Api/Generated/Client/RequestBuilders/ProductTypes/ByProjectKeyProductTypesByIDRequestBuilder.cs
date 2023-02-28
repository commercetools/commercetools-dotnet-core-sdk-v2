using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyProductTypesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyProductTypesByIDGet Get()
        {
            return new ByProjectKeyProductTypesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductTypesByIDHead Head()
        {
            return new ByProjectKeyProductTypesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductTypesByIDPost Post(commercetools.Sdk.Api.Models.ProductTypes.IProductTypeUpdate productTypeUpdate)
        {
            return new ByProjectKeyProductTypesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productTypeUpdate);
        }

        public ByProjectKeyProductTypesByIDDelete Delete()
        {
            return new ByProjectKeyProductTypesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
