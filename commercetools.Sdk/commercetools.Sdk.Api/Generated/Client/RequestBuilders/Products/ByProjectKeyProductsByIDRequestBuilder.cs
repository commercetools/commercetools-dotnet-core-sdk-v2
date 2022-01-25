using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Products
{

    public class ByProjectKeyProductsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyProductsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyProductsByIDGet Get()
        {
            return new ByProjectKeyProductsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductsByIDHead Head()
        {
            return new ByProjectKeyProductsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductsByIDPost Post(commercetools.Api.Models.Products.IProductUpdate productUpdate)
        {
            return new ByProjectKeyProductsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productUpdate);
        }

        public ByProjectKeyProductsByIDDelete Delete()
        {
            return new ByProjectKeyProductsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }


        public ByProjectKeyProductsByIDImagesRequestBuilder Images()
        {
            return new ByProjectKeyProductsByIDImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyProductsByIDProductSelectionsRequestBuilder ProductSelections()
        {
            return new ByProjectKeyProductsByIDProductSelectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
